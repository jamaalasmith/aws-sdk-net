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
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStack operation.
    /// <para>Creates a new stack. For more information, see Create a New Stack.</para>
    /// </summary>
    public partial class CreateStackRequest : AmazonWebServiceRequest
    {
        private string name;
        private string region;
        private Dictionary<string,string> attributes = new Dictionary<string,string>();
        private string serviceRoleArn;
        private string defaultInstanceProfileArn;
        private string defaultOs;
        private string hostnameTheme;
        private string defaultAvailabilityZone;
        private string customJson;
        private bool? useCustomCookbooks;
        private Source customCookbooksSource;
        private string defaultSshKeyName;
        private RootDeviceType defaultRootDeviceType;

        /// <summary>
        /// The stack name.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The stack AWS region, such as "us-east-1". For more information about Amazon regions, see <a
        /// href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions and Endpoints</a>.
        ///  
        /// </summary>
        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this.region != null;
        }

        /// <summary>
        /// One or more user-defined key/value pairs to be added to the stack attributes bag.
        ///  
        /// </summary>
        public Dictionary<string,string> Attributes
        {
            get { return this.attributes; }
            set { this.attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this.attributes != null;
        }

        /// <summary>
        /// The stack AWS Identity and Access Management (IAM) role, which allows OpsWorks to work with AWS resources on your behalf. You must set this
        /// parameter to the Amazon Resource Name (ARN) for an existing IAM role. For more information about IAM ARNs, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">Using Identifiers</a>.
        ///  
        /// </summary>
        public string ServiceRoleArn
        {
            get { return this.serviceRoleArn; }
            set { this.serviceRoleArn = value; }
        }

        // Check to see if ServiceRoleArn property is set
        internal bool IsSetServiceRoleArn()
        {
            return this.serviceRoleArn != null;
        }

        /// <summary>
        /// The ARN of an IAM profile that is the default profile for all of the stack's EC2 instances. For more information about IAM ARNs, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">Using Identifiers</a>.
        ///  
        /// </summary>
        public string DefaultInstanceProfileArn
        {
            get { return this.defaultInstanceProfileArn; }
            set { this.defaultInstanceProfileArn = value; }
        }

        // Check to see if DefaultInstanceProfileArn property is set
        internal bool IsSetDefaultInstanceProfileArn()
        {
            return this.defaultInstanceProfileArn != null;
        }

        /// <summary>
        /// The cloned stack default operating system, which must be either "Amazon Linux" or "Ubuntu 12.04 LTS".
        ///  
        /// </summary>
        public string DefaultOs
        {
            get { return this.defaultOs; }
            set { this.defaultOs = value; }
        }

        // Check to see if DefaultOs property is set
        internal bool IsSetDefaultOs()
        {
            return this.defaultOs != null;
        }

        /// <summary>
        /// The stack's host name theme, with spaces are replaced by underscores. The theme is used to generate hostnames for the stack's instances. By
        /// default, <c>HostnameTheme</c> is set to Layer_Dependent, which creates hostnames by appending integers to the layer's shortname. The other
        /// themes are: <ul> <li>Baked_Goods</li> <li>Clouds</li> <li>European_Cities</li> <li>Fruits</li> <li>Greek_Deities</li>
        /// <li>Legendary_Creatures_from_Japan</li> <li>Planets_and_Moons</li> <li>Roman_Deities</li> <li>Scottish_Islands</li> <li>US_Cities</li>
        /// <li>Wild_Cats</li> </ul> To obtain a generated hostname, call <c>GetHostNameSuggestion</c>, which returns a hostname based on the current
        /// theme.
        ///  
        /// </summary>
        public string HostnameTheme
        {
            get { return this.hostnameTheme; }
            set { this.hostnameTheme = value; }
        }

        // Check to see if HostnameTheme property is set
        internal bool IsSetHostnameTheme()
        {
            return this.hostnameTheme != null;
        }

        /// <summary>
        /// The stack default Availability Zone. For more information, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions and
        /// Endpoints</a>.
        ///  
        /// </summary>
        public string DefaultAvailabilityZone
        {
            get { return this.defaultAvailabilityZone; }
            set { this.defaultAvailabilityZone = value; }
        }

        // Check to see if DefaultAvailabilityZone property is set
        internal bool IsSetDefaultAvailabilityZone()
        {
            return this.defaultAvailabilityZone != null;
        }

        /// <summary>
        /// A string that contains user-defined, custom JSON. It is used to override the corresponding default stack configuration JSON values. The
        /// string should be in the following format and must escape characters such as '"'.: <c>"{\"key1\": \"value1\", \"key2\": \"value2\",...}"</c>
        /// For more information on custom JSON, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-json.html"> Use Custom
        /// JSON to Modify the Stack Configuration JSON</a>.
        ///  
        /// </summary>
        public string CustomJson
        {
            get { return this.customJson; }
            set { this.customJson = value; }
        }

        // Check to see if CustomJson property is set
        internal bool IsSetCustomJson()
        {
            return this.customJson != null;
        }

        /// <summary>
        /// Whether the stack uses custom cookbooks.
        ///  
        /// </summary>
        public bool UseCustomCookbooks
        {
            get { return this.useCustomCookbooks ?? default(bool); }
            set { this.useCustomCookbooks = value; }
        }

        // Check to see if UseCustomCookbooks property is set
        internal bool IsSetUseCustomCookbooks()
        {
            return this.useCustomCookbooks.HasValue;
        }

        /// <summary>
        /// Contains the information required to retrieve an app or cookbook from a repository. For more information, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingapps-creating.html">Creating Apps</a> or <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingcookbook-installingcustom.html">Custom Recipes and Cookbooks</a>.
        ///  
        /// </summary>
        public Source CustomCookbooksSource
        {
            get { return this.customCookbooksSource; }
            set { this.customCookbooksSource = value; }
        }

        // Check to see if CustomCookbooksSource property is set
        internal bool IsSetCustomCookbooksSource()
        {
            return this.customCookbooksSource != null;
        }

        /// <summary>
        /// A default SSH key for the stack instances. You can override this value when you create or update an instance.
        ///  
        /// </summary>
        public string DefaultSshKeyName
        {
            get { return this.defaultSshKeyName; }
            set { this.defaultSshKeyName = value; }
        }

        // Check to see if DefaultSshKeyName property is set
        internal bool IsSetDefaultSshKeyName()
        {
            return this.defaultSshKeyName != null;
        }

        /// <summary>
        /// The default root device type. This value is used by default for all instances in the cloned stack, but you can override it when you create
        /// an instance. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ComponentsAMIs.html#storage-for-the-root-device">Storage for the Root Device</a>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ebs, instance-store</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public RootDeviceType DefaultRootDeviceType
        {
            get { return this.defaultRootDeviceType; }
            set { this.defaultRootDeviceType = value; }
        }

        // Check to see if DefaultRootDeviceType property is set
        internal bool IsSetDefaultRootDeviceType()
        {
            return this.defaultRootDeviceType != null;
        }

    }
}
    
