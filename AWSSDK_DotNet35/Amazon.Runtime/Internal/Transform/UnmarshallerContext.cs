﻿/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Text;
using System.Xml;

using ThirdParty.Ionic.Zlib;

namespace Amazon.Runtime.Internal.Transform
{
    /// <summary>
    /// Base class for the UnmarshallerContext objects that are used
    /// to unmarshall a web-service response.
    /// </summary>
    public abstract class UnmarshallerContext
    {
        protected CrcCalculatorStream crcStream;
        protected int crc32Result;
        protected string responseContents;
        protected IWebResponseData webResponseData;

        public string ResponseBody
        {
            get { return responseContents; }
        }

        public IWebResponseData ResponseData
        {
            get { return webResponseData; }
        }

        internal void ValidateCRC32IfAvailable()
        {
            if (this.crcStream != null)
            {
                if (this.crcStream.Crc32 != this.crc32Result)
                {
                    throw new IOException("CRC value returned with response does not match the computed CRC value for the returned response body.");
                }
            }
        }

        protected void SetupCRCStream(IWebResponseData responseData, Stream responseStream, long contentLength)
        {
            this.crcStream = null;

            UInt32 parsed;
            if (UInt32.TryParse(responseData.GetHeaderValue("x-amz-crc32"), out parsed))
            {
                this.crc32Result = (int)parsed;
                this.crcStream = new CrcCalculatorStream(responseStream, contentLength);
            }
        }

        /// <summary>
        ///     Tests the specified expression against the current position in the XML
        ///     document </summary>
        /// <param name="expression">
        ///     The pseudo-XPath expression to test.</param>
        /// <returns>
        ///     True if the expression matches the current position in the document, 
        ///     false otherwise.</returns>
        public bool TestExpression(string expression)
        {
            return TestExpression(expression, CurrentPath);
        }

        /// <summary>
        ///     Tests the specified expression against the current position in the XML
        ///     document being parsed, and restricts the expression to matching at the
        ///     specified stack depth. </summary>
        /// <param name="expression">
        ///     The pseudo-XPath expression to test.</param>
        /// <param name="startingStackDepth">
        ///     The depth in the stack representing where the expression must
        ///     start matching in order for this method to return true. </param>
        /// <returns>
        ///     True if the specified expression matches the current position in
        ///     the XML document, starting from the specified depth. </returns>
        public bool TestExpression(string expression, int startingStackDepth)
        {
            return TestExpression(expression, startingStackDepth, CurrentPath, CurrentDepth);
        }

        private static bool TestExpression(string expression, string currentPath)
        {
            if (expression.Equals("."))
                return true;

            return currentPath.EndsWith(expression, StringComparison.OrdinalIgnoreCase);
        }

        private static bool TestExpression(string expression, int startingStackDepth, string currentPath, int currentDepth)
        {
            if (expression.Equals("."))
                return true;

            int index = -1;
            while ((index = expression.IndexOf("/", index + 1)) > -1)
            {
                // Don't consider attributes a new depth level
                if (expression[0] != '@')
                {
                    startingStackDepth++;
                }
            }
            return (startingStackDepth == currentDepth
                    && currentPath.EndsWith("/" + expression, StringComparison.OrdinalIgnoreCase));
        }

        #region Abstract members

        /// <summary>
        /// The current path that is being unmarshalled.
        /// </summary>
        public abstract string CurrentPath { get; }

        /// <summary>
        /// Returns the element depth of the parser's current position in the
        /// document being parsed.
        /// </summary>
        public abstract int CurrentDepth { get; }

        /// <summary>
        /// Reads to the next node in the document, and updates the context accordingly.
        /// </summary>
        /// <returns>
        /// True if a node was read, false if there are no more elements to read.
        /// </returns>
        public abstract bool Read();

        /// <summary>
        ///     Returns the text contents of the current element being parsed.
        /// </summary>
        /// <returns>
        ///     The text contents of the current element being parsed.
        /// </returns>
        public abstract string ReadText();

        /// <summary>
        /// True if <c>NodeType</c> is <c>Element</c>.
        /// </summary>
        public abstract bool IsStartElement { get; }

        /// <summary>
        /// True if <c>NodeType</c> is <c>EndElement</c>.
        /// </summary>
        public abstract bool IsEndElement { get; }

        /// <summary>
        /// True if the context is at the start of the document.
        /// </summary>
        public abstract bool IsStartOfDocument { get; }

        #endregion

    }

    /// <summary>
    /// Wrap an <c>XmltextReader</c> for simulating an event stream.
    /// 
    /// Each <c>Read()</c> operation goes either to the next element or next attribute within
    /// the current element. <c>TestExpression()</c> is used to match the current event
    /// to an xpath expression. The general pattern looks like this:
    /// <code>
    /// UnmarshallerContext context = new UnmarshallerContext(...);
    /// while (context.Read())
    /// {
    ///     if (context.TestExpresion("path/to/element"))
    ///     {
    ///         myObject.stringMember = stringUnmarshaller.GetInstance().Unmarshall(context);
    ///         continue;
    ///     }
    ///     if (context.TestExpression("path/to/@attribute"))
    ///         myObject.MyComplexTypeMember = MyComplexTypeUnmarshaller.GetInstance().Unmarshall(context);
    /// }
    /// </code>
    /// </summary>
    public class XmlUnmarshallerContext : UnmarshallerContext
    {
        #region Private members

#if BCL && !BCL45
        private static readonly XmlReaderSettings READER_SETTINGS = new XmlReaderSettings() { ProhibitDtd = false, IgnoreWhitespace = true };
#else
        private static readonly XmlReaderSettings READER_SETTINGS = new XmlReaderSettings() { DtdProcessing = DtdProcessing.Ignore, IgnoreWhitespace = true };
#endif

        private StreamReader streamReader;
        private XmlReader _xmlReader;
        private Stack<string> stack = new Stack<string>();
        private string stackString = "";
        private Dictionary<string, string> attributeValues;
        private List<string> attributeNames;
        private IEnumerator<string> attributeEnumerator;
        private XmlNodeType nodeType;
        private string nodeContent = String.Empty;

        internal Stream Stream
        {
            get { return streamReader.BaseStream; }
        }

        private XmlReader XmlReader
        {
            get
            {
                if (_xmlReader == null)
                {
                    _xmlReader = XmlReader.Create(streamReader, READER_SETTINGS);
                }
                return _xmlReader;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Wrap an XmlTextReader with state for event-based parsing of an XML stream.
        /// </summary>
        /// <param name="responseBody">String with the XML from a service response.</param>
        /// <param name="responseData">Response data coming back from the request</param>
        public XmlUnmarshallerContext(string responseBody, IWebResponseData responseData)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(responseBody);
            Stream stream = new MemoryStream(bytes);

            this.streamReader = new StreamReader(stream);
            this.webResponseData = responseData;
            this.responseContents = responseBody;
        }
        
        /// <summary>
        /// Wrap an XmlTextReader with state for event-based parsing of an XML stream.
        /// </summary>
        /// <param name="responseStream"><c>Stream</c> with the XML from a service response.</param>
        /// <param name="responseData">Response data coming back from the request</param>
        public XmlUnmarshallerContext(Stream responseStream, IWebResponseData responseData)
        {
            this.streamReader = new StreamReader(responseStream);
            this.webResponseData = responseData;
            this.responseContents = null;
        }        

        #endregion

        #region Overrides

        /// <summary>
        /// The current XML path that is being unmarshalled.
        /// </summary>
        public override string CurrentPath
        {
            get { return this.stackString; }
        }

        /// <summary>
        ///     Returns the element depth of the parser's current position in the XML
        ///     document being parsed.
        /// </summary>
        public override int CurrentDepth
        {
            get { return stack.Count; }
        }

        /// <summary>
        /// Reads to the next node in the XML document, and updates the context accordingly.
        /// </summary>
        /// <returns>
        /// True if a node was read, false if there are no more elements to read./
        /// </returns>
        public override bool Read()
        {
            if (attributeEnumerator != null && attributeEnumerator.MoveNext())
            {
                this.nodeType = XmlNodeType.Attribute;
                stackString = String.Format("{0}/@{1}", StackToPath(stack), attributeEnumerator.Current);
            }
            else
            {
                if (XmlReader.NodeType == XmlNodeType.None || XmlReader.NodeType == XmlNodeType.XmlDeclaration || XmlReader.NodeType == XmlNodeType.Comment)
                    XmlReader.Read();

                while (XmlReader.IsEmptyElement)
                {
                    XmlReader.Read();
                }

                switch (XmlReader.NodeType)
                {
                    case XmlNodeType.EndElement:
                        this.nodeType = XmlNodeType.EndElement;
                        stack.Pop();
                        stackString = StackToPath(stack);
                        XmlReader.Read();
                        break;
                    case XmlNodeType.Element:
                        nodeType = XmlNodeType.Element;
                        stack.Push(XmlReader.LocalName);
                        stackString = StackToPath(stack);
                        this.ReadElement();
                        break;
                }
            }

            bool result = XmlReader.ReadState != ReadState.EndOfFile;
            return result;
        }

        /// <summary>
        ///     Returns the text contents of the current element being parsed.
        /// </summary>
        /// <returns>
        ///     The text contents of the current element being parsed.
        /// </returns>
        public override string  ReadText()
        {
            if (this.nodeType == XmlNodeType.Attribute)
            {
                return (attributeValues[attributeEnumerator.Current]);
            }
            else
            {
                return nodeContent;
            }
        }

        /// <summary>
        /// True if <c>NodeType</c> is <c>Element</c>.
        /// </summary>
        public override bool IsStartElement
        {
            get { return this.nodeType == XmlNodeType.Element; }
        }

        /// <summary>
        /// True if <c>NodeType</c> is <c>EndElement</c>.
        /// </summary>
        public override bool IsEndElement
        {
            get { return this.nodeType == XmlNodeType.EndElement; }
        }

        /// <summary>
        /// True if the context is at the start of the document.
        /// </summary>
        public override bool IsStartOfDocument
        {
            get { return XmlReader.ReadState == ReadState.Initial; }
        }

        #endregion

        #region Public methods

        /// <summary>
        /// True if <c>NodeType</c> is <c>Attribute</c>.
        /// </summary>
        public bool IsAttribute
        {
            get { return this.nodeType == XmlNodeType.Attribute; }
        }

        #endregion

        #region Private Methods

        private string StackToPath(Stack<string> stack)
        {
            string path = null;
            foreach (string s in stack.ToArray())
            {
                path = null == path ? s : String.Format("{0}/{1}", s, path);
            }
            return "/" + path;
        }

        // Move to the next element, cache the attributes collection
        // and attempt to cache the inner text of the element if applicable.
        private void ReadElement()
        {
            if (XmlReader.HasAttributes)
            {
                attributeValues = new Dictionary<string, string>();
                attributeNames = new List<string>();
                while (XmlReader.MoveToNextAttribute())
                {
                    attributeValues.Add(XmlReader.LocalName, XmlReader.Value);
                    attributeNames.Add(XmlReader.LocalName);
                }
                attributeEnumerator = attributeNames.GetEnumerator();
            }
            XmlReader.MoveToElement();
            XmlReader.Read();

            if (XmlReader.NodeType == XmlNodeType.Text)
                nodeContent = XmlReader.ReadContentAsString();
            else
                nodeContent = String.Empty;
        }

        /// <summary>
        /// The <c>XmlNodeType</c> of the current event. Will be one of
        /// <c>Element</c>, <c>EndElement</c>, or <c>Attribute</c> during parsing,
        /// and <c>None</c> at the start and end.
        /// </summary>
        private XmlNodeType NodeType
        {
            get { return this.nodeType; }
        }

        #endregion
    }

    public class EC2UnmarshallerContext : XmlUnmarshallerContext
    {
        /// <summary>
        /// Wrap an XmlTextReader with state for event-based parsing of an XML stream.
        /// </summary>
        /// <param name="responseBody">String with the XML from a service response.</param>
        /// <param name="responseData">Response data coming back from the request</param>
        public EC2UnmarshallerContext(string responseBody, IWebResponseData responseData)
            : base(responseBody, responseData)
        {
        }
        
        /// <summary>
        /// Wrap an XmlTextReader with state for event-based parsing of an XML stream.
        /// </summary>
        /// <param name="responseStream"><c>Stream</c> with the XML from a service response.</param>
        /// <param name="responseData">Response data coming back from the request</param>
        public EC2UnmarshallerContext(Stream responseStream, IWebResponseData responseData)
            : base(responseStream, responseData)
        {
        }

        /// <summary>
        /// RequestId value, if found in response
        /// </summary>
        public string RequestId { get; private set; }

        /// <summary>
        /// Reads to the next node in the XML document, and updates the context accordingly.
        /// If node is RequestId, reads the contents and stores in RequestId property.
        /// </summary>
        /// <returns>
        /// True if a node was read, false if there are no more elements to read./
        /// </returns>
        public override bool Read()
        {
            bool result = base.Read();
            if (RequestId == null)
            {
                if (IsStartElement && TestExpression("RequestId", 2))
                {
                    RequestId = StringUnmarshaller.GetInstance().Unmarshall(this);
                }
            }
            return result;
        }
    }
}
