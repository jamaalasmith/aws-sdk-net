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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the RevokeDBSecurityGroupIngress operation.
    /// <para> Revokes ingress from a DBSecurityGroup for previously authorized IP ranges or EC2 or VPC Security Groups. Required parameters for
    /// this API are one of CIDRIP, EC2SecurityGroupId for VPC, or (EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId).
    /// </para>
    /// </summary>
    public partial class RevokeDBSecurityGroupIngressRequest : AmazonWebServiceRequest
    {
        private string dBSecurityGroupName;
        private string cIDRIP;
        private string eC2SecurityGroupName;
        private string eC2SecurityGroupId;
        private string eC2SecurityGroupOwnerId;

        /// <summary>
        /// The name of the DB Security Group to revoke ingress from.
        ///  
        /// </summary>
        public string DBSecurityGroupName
        {
            get { return this.dBSecurityGroupName; }
            set { this.dBSecurityGroupName = value; }
        }

        // Check to see if DBSecurityGroupName property is set
        internal bool IsSetDBSecurityGroupName()
        {
            return this.dBSecurityGroupName != null;
        }

        /// <summary>
        /// The IP range to revoke access from. Must be a valid CIDR range. If <c>CIDRIP</c> is specified, <c>EC2SecurityGroupName</c>,
        /// <c>EC2SecurityGroupId</c> and <c>EC2SecurityGroupOwnerId</c> cannot be provided.
        ///  
        /// </summary>
        public string CIDRIP
        {
            get { return this.cIDRIP; }
            set { this.cIDRIP = value; }
        }

        // Check to see if CIDRIP property is set
        internal bool IsSetCIDRIP()
        {
            return this.cIDRIP != null;
        }

        /// <summary>
        /// The name of the EC2 Security Group to revoke access from. For VPC DB Security Groups, <c>EC2SecurityGroupId</c> must be provided. Otherwise,
        /// EC2SecurityGroupOwnerId and either <c>EC2SecurityGroupName</c> or <c>EC2SecurityGroupId</c> must be provided.
        ///  
        /// </summary>
        public string EC2SecurityGroupName
        {
            get { return this.eC2SecurityGroupName; }
            set { this.eC2SecurityGroupName = value; }
        }

        // Check to see if EC2SecurityGroupName property is set
        internal bool IsSetEC2SecurityGroupName()
        {
            return this.eC2SecurityGroupName != null;
        }

        /// <summary>
        /// The id of the EC2 Security Group to revoke access from. For VPC DB Security Groups, <c>EC2SecurityGroupId</c> must be provided. Otherwise,
        /// EC2SecurityGroupOwnerId and either <c>EC2SecurityGroupName</c> or <c>EC2SecurityGroupId</c> must be provided.
        ///  
        /// </summary>
        public string EC2SecurityGroupId
        {
            get { return this.eC2SecurityGroupId; }
            set { this.eC2SecurityGroupId = value; }
        }

        // Check to see if EC2SecurityGroupId property is set
        internal bool IsSetEC2SecurityGroupId()
        {
            return this.eC2SecurityGroupId != null;
        }

        /// <summary>
        /// The AWS Account Number of the owner of the EC2 security group specified in the <c>EC2SecurityGroupName</c> parameter. The AWS Access Key ID
        /// is not an acceptable value. For VPC DB Security Groups, <c>EC2SecurityGroupId</c> must be provided. Otherwise, EC2SecurityGroupOwnerId and
        /// either <c>EC2SecurityGroupName</c> or <c>EC2SecurityGroupId</c> must be provided.
        ///  
        /// </summary>
        public string EC2SecurityGroupOwnerId
        {
            get { return this.eC2SecurityGroupOwnerId; }
            set { this.eC2SecurityGroupOwnerId = value; }
        }

        // Check to see if EC2SecurityGroupOwnerId property is set
        internal bool IsSetEC2SecurityGroupOwnerId()
        {
            return this.eC2SecurityGroupOwnerId != null;
        }

    }
}
    
