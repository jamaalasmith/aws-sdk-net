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
    /// Container for the parameters to the RestoreDBInstanceFromDBSnapshot operation.
    /// <para> Creates a new DB Instance from a DB snapshot. The target database is created from the source database restore point with the same
    /// configuration as the original source database, except that the new RDS instance is created with the default security group. </para>
    /// </summary>
    public partial class RestoreDBInstanceFromDBSnapshotRequest : AmazonWebServiceRequest
    {
        private string dBInstanceIdentifier;
        private string dBSnapshotIdentifier;
        private string dBInstanceClass;
        private int? port;
        private string availabilityZone;
        private string dBSubnetGroupName;
        private bool? multiAZ;
        private bool? publiclyAccessible;
        private bool? autoMinorVersionUpgrade;
        private string licenseModel;
        private string dBName;
        private string engine;
        private int? iops;
        private string optionGroupName;

        /// <summary>
        /// The identifier for the DB Snapshot to restore from. Constraints: <ul> <li>Must contain from 1 to 63 alphanumeric characters or hyphens</li>
        /// <li>First character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li> </ul>
        ///  
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this.dBInstanceIdentifier; }
            set { this.dBInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this.dBInstanceIdentifier != null;
        }

        /// <summary>
        /// Name of the DB Instance to create from the DB Snapshot. This parameter isn't case sensitive. Constraints: <ul> <li>Must contain from 1 to
        /// 255 alphanumeric characters or hyphens</li> <li>First character must be a letter</li> <li>Cannot end with a hyphen or contain two
        /// consecutive hyphens</li> </ul> Example: <c>my-snapshot-id</c>
        ///  
        /// </summary>
        public string DBSnapshotIdentifier
        {
            get { return this.dBSnapshotIdentifier; }
            set { this.dBSnapshotIdentifier = value; }
        }

        // Check to see if DBSnapshotIdentifier property is set
        internal bool IsSetDBSnapshotIdentifier()
        {
            return this.dBSnapshotIdentifier != null;
        }

        /// <summary>
        /// The compute and memory capacity of the Amazon RDS DB instance. Valid Values: <c>db.t1.micro | db.m1.small | db.m1.medium | db.m1.large |
        /// db.m1.xlarge | db.m2.2xlarge | db.m2.4xlarge</c>
        ///  
        /// </summary>
        public string DBInstanceClass
        {
            get { return this.dBInstanceClass; }
            set { this.dBInstanceClass = value; }
        }

        // Check to see if DBInstanceClass property is set
        internal bool IsSetDBInstanceClass()
        {
            return this.dBInstanceClass != null;
        }

        /// <summary>
        /// The port number on which the database accepts connections. Default: The same port as the original DB Instance Constraints: Value must be
        /// <c>1150-65535</c>
        ///  
        /// </summary>
        public int Port
        {
            get { return this.port ?? default(int); }
            set { this.port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this.port.HasValue;
        }

        /// <summary>
        /// The EC2 Availability Zone that the database instance will be created in. Default: A random, system-chosen Availability Zone. Constraint: You
        /// cannot specify the AvailabilityZone parameter if the MultiAZ parameter is set to <c>true</c>. Example: <c>us-east-1a</c>
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// The DB Subnet Group name to use for the new instance.
        ///  
        /// </summary>
        public string DBSubnetGroupName
        {
            get { return this.dBSubnetGroupName; }
            set { this.dBSubnetGroupName = value; }
        }

        // Check to see if DBSubnetGroupName property is set
        internal bool IsSetDBSubnetGroupName()
        {
            return this.dBSubnetGroupName != null;
        }

        /// <summary>
        /// Specifies if the DB Instance is a Multi-AZ deployment. Constraint: You cannot specify the AvailabilityZone parameter if the MultiAZ
        /// parameter is set to <c>true</c>.
        ///  
        /// </summary>
        public bool MultiAZ
        {
            get { return this.multiAZ ?? default(bool); }
            set { this.multiAZ = value; }
        }

        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this.multiAZ.HasValue;
        }

        /// <summary>
        /// Specifies the accessibility options for the DB Instance. A value of true specifies an Internet-facing instance with a publicly resolvable
        /// DNS name, which resolves to a public IP address. A value of false specifies an internal instance with a DNS name that resolves to a private
        /// IP address. Default: The default behavior varies depending on whether a VPC has been requested or not. The following list shows the default
        /// behavior in each case. <ul> <li><b>Default VPC:</b>true</li> <li><b>VPC:</b>false</li> </ul> If no DB subnet group has been specified as
        /// part of the request and the PubliclyAccessible value has not been set, the DB instance will be publicly accessible. If a specific DB subnet
        /// group has been specified as part of the request and the PubliclyAccessible value has not been set, the DB instance will be private.
        ///  
        /// </summary>
        public bool PubliclyAccessible
        {
            get { return this.publiclyAccessible ?? default(bool); }
            set { this.publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this.publiclyAccessible.HasValue;
        }

        /// <summary>
        /// Indicates that minor version upgrades will be applied automatically to the DB Instance during the maintenance window.
        ///  
        /// </summary>
        public bool AutoMinorVersionUpgrade
        {
            get { return this.autoMinorVersionUpgrade ?? default(bool); }
            set { this.autoMinorVersionUpgrade = value; }
        }

        // Check to see if AutoMinorVersionUpgrade property is set
        internal bool IsSetAutoMinorVersionUpgrade()
        {
            return this.autoMinorVersionUpgrade.HasValue;
        }

        /// <summary>
        /// License model information for the restored DB Instance. Default: Same as source. Valid values: <c>license-included</c> |
        /// <c>bring-your-own-license</c> | <c>general-public-license</c>
        ///  
        /// </summary>
        public string LicenseModel
        {
            get { return this.licenseModel; }
            set { this.licenseModel = value; }
        }

        // Check to see if LicenseModel property is set
        internal bool IsSetLicenseModel()
        {
            return this.licenseModel != null;
        }

        /// <summary>
        /// The database name for the restored DB Instance. <note> This parameter doesn't apply to the MySQL engine. </note>
        ///  
        /// </summary>
        public string DBName
        {
            get { return this.dBName; }
            set { this.dBName = value; }
        }

        // Check to see if DBName property is set
        internal bool IsSetDBName()
        {
            return this.dBName != null;
        }

        /// <summary>
        /// The database engine to use for the new instance. Default: The same as source Constraint: Must be compatible with the engine of the source
        /// Example: <c>oracle-ee</c>
        ///  
        /// </summary>
        public string Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this.engine != null;
        }

        /// <summary>
        /// Specifies the amount of provisioned IOPS for the DB Instance, expressed in I/O operations per second. If this parameter is not specified,
        /// the IOPS value will be taken from the backup. If this parameter is set to 0, the new instance will be converted to a non-PIOPS instance,
        /// which will take additional time, though your DB instance will be available for connections before the conversion starts. Constraints: Must
        /// be an integer greater than 1000.
        ///  
        /// </summary>
        public int Iops
        {
            get { return this.iops ?? default(int); }
            set { this.iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this.iops.HasValue;
        }

        /// <summary>
        /// The name of the option group to be used for the restored DB instance. <!-- Note that persistent options, such as the TDE_SQLServer option
        /// for Microsoft SQL Server, cannot be removed from an option group while DB instances are associated with the option group. --> Permanent
        /// options, such as the TDE option for Oracle Advanced Security TDE, cannot be removed from an option group, and that option group cannot be
        /// removed from a DB instance once it is associated with a DB instance
        ///  
        /// </summary>
        public string OptionGroupName
        {
            get { return this.optionGroupName; }
            set { this.optionGroupName = value; }
        }

        // Check to see if OptionGroupName property is set
        internal bool IsSetOptionGroupName()
        {
            return this.optionGroupName != null;
        }

    }
}
    
