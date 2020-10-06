/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Details for the create cloud VM cluster operation.
    /// 
    /// </summary>
    public class CreateCloudVmClusterDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the subnet associated with the cloud VM cluster.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the backup network subnet associated with the cloud VM cluster.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BackupSubnetId is required.")]
        [JsonProperty(PropertyName = "backupSubnetId")]
        public string BackupSubnetId { get; set; }

        /// <value>
        /// The number of CPU cores to enable for a cloud VM cluster. Valid values depend on the specified shape:
        /// <br/>
        /// - Exadata.Base.48 - Specify a multiple of 2, from 0 to 48.
        /// - Exadata.Quarter1.84 - Specify a multiple of 2, from 22 to 84.
        /// - Exadata.Half1.168 - Specify a multiple of 4, from 44 to 168.
        /// - Exadata.Full1.336 - Specify a multiple of 8, from 88 to 336.
        /// - Exadata.Quarter2.92 - Specify a multiple of 2, from 0 to 92.
        /// - Exadata.Half2.184 - Specify a multiple of 4, from 0 to 184.
        /// - Exadata.Full2.368 - Specify a multiple of 8, from 0 to 368.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CpuCoreCount is required.")]
        [JsonProperty(PropertyName = "cpuCoreCount")]
        public System.Nullable<int> CpuCoreCount { get; set; }

        /// <value>
        /// The cluster name for cloud VM cluster. The cluster name must begin with an alphabetic character, and may contain hyphens (-). Underscores (_) are not permitted. The cluster name can be no longer than 11 characters and is not case sensitive.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "clusterName")]
        public string ClusterName { get; set; }

        /// <value>
        /// The percentage assigned to DATA storage (user data and database files).
        /// The remaining percentage is assigned to RECO storage (database redo logs, archive logs, and recovery manager backups). Accepted values are 35, 40, 60 and 80. The default is 80 percent assigned to DATA storage. See [Storage Configuration](https://docs.cloud.oracle.com/Content/Database/Concepts/exaoverview.htm#Exadata) in the Exadata documentation for details on the impact of the configuration settings on storage.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dataStoragePercentage")]
        public System.Nullable<int> DataStoragePercentage { get; set; }

        /// <value>
        /// The user-friendly name for the cloud VM cluster. The name does not need to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the cloud Exadata infrastructure resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CloudExadataInfrastructureId is required.")]
        [JsonProperty(PropertyName = "cloudExadataInfrastructureId")]
        public string CloudExadataInfrastructureId { get; set; }

        /// <value>
        /// The hostname for the cloud VM cluster. The hostname must begin with an alphabetic character, and
        /// can contain alphanumeric characters and hyphens (-). The maximum length of the hostname is 16 characters for bare metal and virtual machine DB systems, and 12 characters for Exadata systems.
        /// <br/>
        /// The maximum length of the combined hostname and domain is 63 characters.
        /// <br/>
        /// **Note:** The hostname must be unique within the subnet. If it is not unique,
        /// the cloud VM Cluster will fail to provision.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Hostname is required.")]
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }

        /// <value>
        /// A domain name used for the cloud VM cluster. If the Oracle-provided internet and VCN
        /// resolver is enabled for the specified subnet, the domain name for the subnet is used
        /// (do not provide one). Otherwise, provide a valid DNS domain name. Hyphens (-) are not permitted.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        /// <value>
        /// The public key portion of one or more key pairs used for SSH access to the cloud VM cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SshPublicKeys is required.")]
        [JsonProperty(PropertyName = "sshPublicKeys")]
        public System.Collections.Generic.List<string> SshPublicKeys { get; set; }
        ///
        /// <value>
        /// The Oracle license model that applies to the cloud VM cluster. The default is BRING_YOUR_OWN_LICENSE.
        /// 
        /// </value>
        ///
        public enum LicenseModelEnum {
            [EnumMember(Value = "LICENSE_INCLUDED")]
            LicenseIncluded,
            [EnumMember(Value = "BRING_YOUR_OWN_LICENSE")]
            BringYourOwnLicense
        };

        /// <value>
        /// The Oracle license model that applies to the cloud VM cluster. The default is BRING_YOUR_OWN_LICENSE.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "licenseModel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseModelEnum> LicenseModel { get; set; }

        /// <value>
        /// If true, the sparse disk group is configured for the cloud VM cluster. If false, the sparse disk group is not created.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSparseDiskgroupEnabled")]
        public System.Nullable<bool> IsSparseDiskgroupEnabled { get; set; }

        /// <value>
        /// If true, database backup on local Exadata storage is configured for the cloud VM cluster. If false, database backup on local Exadata storage is not available in the cloud VM cluster.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isLocalBackupEnabled")]
        public System.Nullable<bool> IsLocalBackupEnabled { get; set; }

        /// <value>
        /// The time zone to use for the cloud VM cluster. For details, see [Time Zones](https://docs.cloud.oracle.com/Content/Database/References/timezones.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }

        /// <value>
        /// A list of the [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the network security groups (NSGs) that this resource belongs to. Setting this to an empty array after the list is created removes the resource from all NSGs. For more information about NSGs, see [Security Rules](https://docs.cloud.oracle.com/Content/Network/Concepts/securityrules.htm).
        /// **NsgIds restrictions:**
        /// - Autonomous Databases with private access require at least 1 Network Security Group (NSG). The nsgIds array cannot be empty.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }

        /// <value>
        /// A list of the [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the network security groups (NSGs) that the backup network of this DB system belongs to. Setting this to an empty array after the list is created removes the resource from all NSGs. For more information about NSGs, see [Security Rules](https://docs.cloud.oracle.com/Content/Network/Concepts/securityrules.htm). Applicable only to Exadata systems.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "backupNetworkNsgIds")]
        public System.Collections.Generic.List<string> BackupNetworkNsgIds { get; set; }

        /// <value>
        /// A valid Oracle Grid Infrastructure (GI) software version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GiVersion is required.")]
        [JsonProperty(PropertyName = "giVersion")]
        public string GiVersion { get; set; }

        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }

        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
    }
}
