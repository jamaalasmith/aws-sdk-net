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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>A JSON object containing the following fields:</para>
    /// <ul>
    /// <li> DescribeCacheOutput$CacheAllocatedInBytes </li>
    /// <li> DescribeCacheOutput$CacheDirtyPercentage </li>
    /// <li> DescribeCacheOutput$CacheHitPercentage </li>
    /// <li> DescribeCacheOutput$CacheMissPercentage </li>
    /// <li> DescribeCacheOutput$CacheUsedPercentage </li>
    /// <li> DescribeCacheOutput$DiskIds </li>
    /// <li> DescribeCacheOutput$GatewayARN </li>
    /// 
    /// </ul>
    /// </summary>
    public partial class DescribeCacheResult : AmazonWebServiceResponse
    {
        
        private string gatewayARN;
        private List<string> diskIds = new List<string>();
        private long? cacheAllocatedInBytes;
        private double? cacheUsedPercentage;
        private double? cacheDirtyPercentage;
        private double? cacheHitPercentage;
        private double? cacheMissPercentage;

        /// <summary>
        /// In response, AWS Storage Gateway returns the ARN of the activated gateway. If you don't remember the ARN of a gateway, you can use the List
        /// Gateways operations to return a list of gateways for your account and region.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 500</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GatewayARN
        {
            get { return this.gatewayARN; }
            set { this.gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this.gatewayARN != null;
        }

        /// <summary>
        /// An array of the gateway's local disk IDs that are configured as cache. Each local disk ID is specified as a string (minimum length of 1 and
        /// maximum length of 300). If no local disks are configured as cache, then the <c>DiskIds</c> array is empty.
        ///  
        /// </summary>
        public List<string> DiskIds
        {
            get { return this.diskIds; }
            set { this.diskIds = value; }
        }

        // Check to see if DiskIds property is set
        internal bool IsSetDiskIds()
        {
            return this.diskIds.Count > 0;
        }

        /// <summary>
        /// The size allocated, in bytes, for the cache. If no cache is defined for the gateway, this field returns 0.
        ///  
        /// </summary>
        public long CacheAllocatedInBytes
        {
            get { return this.cacheAllocatedInBytes ?? default(long); }
            set { this.cacheAllocatedInBytes = value; }
        }

        // Check to see if CacheAllocatedInBytes property is set
        internal bool IsSetCacheAllocatedInBytes()
        {
            return this.cacheAllocatedInBytes.HasValue;
        }

        /// <summary>
        /// The percentage (0 to 100) of the cache storage in use. If no cached is defined for the gateway, this field returns 0.
        ///  
        /// </summary>
        public double CacheUsedPercentage
        {
            get { return this.cacheUsedPercentage ?? default(double); }
            set { this.cacheUsedPercentage = value; }
        }

        // Check to see if CacheUsedPercentage property is set
        internal bool IsSetCacheUsedPercentage()
        {
            return this.cacheUsedPercentage.HasValue;
        }

        /// <summary>
        /// The percentage of the cache that contains data that has not yet been persisted to Amazon S3. If no cached is defined for the gateway, this
        /// field returns 0.
        ///  
        /// </summary>
        public double CacheDirtyPercentage
        {
            get { return this.cacheDirtyPercentage ?? default(double); }
            set { this.cacheDirtyPercentage = value; }
        }

        // Check to see if CacheDirtyPercentage property is set
        internal bool IsSetCacheDirtyPercentage()
        {
            return this.cacheDirtyPercentage.HasValue;
        }

        /// <summary>
        /// The percentage (0 to 100) of data read from the storage volume that was read from cache. If no cached is defined for the gateway, this field
        /// returns 0.
        ///  
        /// </summary>
        public double CacheHitPercentage
        {
            get { return this.cacheHitPercentage ?? default(double); }
            set { this.cacheHitPercentage = value; }
        }

        // Check to see if CacheHitPercentage property is set
        internal bool IsSetCacheHitPercentage()
        {
            return this.cacheHitPercentage.HasValue;
        }

        /// <summary>
        /// TThe percentage (0 to 100) of data read from the storage volume that was not read from the cache, but was read from Amazon S3. If no cached
        /// is defined for the gateway, this field returns 0.
        ///  
        /// </summary>
        public double CacheMissPercentage
        {
            get { return this.cacheMissPercentage ?? default(double); }
            set { this.cacheMissPercentage = value; }
        }

        // Check to see if CacheMissPercentage property is set
        internal bool IsSetCacheMissPercentage()
        {
            return this.cacheMissPercentage.HasValue;
        }
    }
}
