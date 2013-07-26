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
    /// Container for the parameters to the DescribeElasticIps operation.
    /// <para>Describes an instance's Elastic IP addresses.</para>
    /// </summary>
    public partial class DescribeElasticIpsRequest : AmazonWebServiceRequest
    {
        private string instanceId;
        private List<string> ips = new List<string>();

        /// <summary>
        /// The instance ID. If you include this parameter, <c>DescribeElasticIps</c> returns a description of the Elastic IP addresses associated with
        /// the specified instance.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// An array of Elastic IP addresses to be described. If you include this parameter, <c>DescribeElasticIps</c> returns a description of the
        /// specified Elastic IP addresses. Otherwise, it returns a description of every Elastic IP address.
        ///  
        /// </summary>
        public List<string> Ips
        {
            get { return this.ips; }
            set { this.ips = value; }
        }

        // Check to see if Ips property is set
        internal bool IsSetIps()
        {
            return this.ips.Count > 0;
        }

    }
}
    
