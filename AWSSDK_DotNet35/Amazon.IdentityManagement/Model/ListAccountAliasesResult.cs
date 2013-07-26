/*
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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// <para>Contains the result of a successful invocation of the ListAccountAliases action.</para>
    /// </summary>
    public partial class ListAccountAliasesResult : AmazonWebServiceResponse
    {
        
        private List<string> accountAliases = new List<string>();
        private bool? isTruncated;
        private string marker;

        /// <summary>
        /// A list of aliases associated with the account.
        ///  
        /// </summary>
        public List<string> AccountAliases
        {
            get { return this.accountAliases; }
            set { this.accountAliases = value; }
        }

        // Check to see if AccountAliases property is set
        internal bool IsSetAccountAliases()
        {
            return this.accountAliases.Count > 0;
        }

        /// <summary>
        /// A flag that indicates whether there are more account aliases to list. If your results were truncated, you can make a subsequent pagination
        /// request using the <c>Marker</c> request parameter to retrieve more account aliases in the list.
        ///  
        /// </summary>
        public bool IsTruncated
        {
            get { return this.isTruncated ?? default(bool); }
            set { this.isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this.isTruncated.HasValue;
        }

        /// <summary>
        /// Use this only when paginating results, and only in a subsequent request after you've received a response where the results are truncated.
        /// Set it to the value of the <c>Marker</c> element in the response you just received.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 320</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\u00FF]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }
    }
}
