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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para> A Cache Cluster is made up of one or more Cache Nodes. Each Cache Node is an separate endpoint servicing the memcached protocol.
    /// </para>
    /// </summary>
    public class CacheNode
    {
        
        private string cacheNodeId;
        private string cacheNodeStatus;
        private DateTime? cacheNodeCreateTime;
        private Endpoint endpoint;
        private string parameterGroupStatus;

        /// <summary>
        /// Specifies a Cache Node identifier. This is the unique key that identifies a Cache Node per Customer (AWS account).
        ///  
        /// </summary>
        public string CacheNodeId
        {
            get { return this.cacheNodeId; }
            set { this.cacheNodeId = value; }
        }

        // Check to see if CacheNodeId property is set
        internal bool IsSetCacheNodeId()
        {
            return this.cacheNodeId != null;
        }

        /// <summary>
        /// Specifies the current state of this Cache Node.
        ///  
        /// </summary>
        public string CacheNodeStatus
        {
            get { return this.cacheNodeStatus; }
            set { this.cacheNodeStatus = value; }
        }

        // Check to see if CacheNodeStatus property is set
        internal bool IsSetCacheNodeStatus()
        {
            return this.cacheNodeStatus != null;
        }

        /// <summary>
        /// Provides the date and time the Cache Node was created.
        ///  
        /// </summary>
        public DateTime CacheNodeCreateTime
        {
            get { return this.cacheNodeCreateTime ?? default(DateTime); }
            set { this.cacheNodeCreateTime = value; }
        }

        // Check to see if CacheNodeCreateTime property is set
        internal bool IsSetCacheNodeCreateTime()
        {
            return this.cacheNodeCreateTime.HasValue;
        }

        /// <summary>
        /// Specifies the endpoint details for a Cache Node.
        ///  
        /// </summary>
        public Endpoint Endpoint
        {
            get { return this.endpoint; }
            set { this.endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this.endpoint != null;
        }

        /// <summary>
        /// Specifies the status of the parameter group applied to this Cache Node.
        ///  
        /// </summary>
        public string ParameterGroupStatus
        {
            get { return this.parameterGroupStatus; }
            set { this.parameterGroupStatus = value; }
        }

        // Check to see if ParameterGroupStatus property is set
        internal bool IsSetParameterGroupStatus()
        {
            return this.parameterGroupStatus != null;
        }
    }
}
