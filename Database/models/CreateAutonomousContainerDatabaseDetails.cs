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
    /// Describes the required parameters for the creation of an Autonomous Container Database.
    /// 
    /// </summary>
    public class CreateAutonomousContainerDatabaseDetails 
    {
        
        /// <value>
        /// The display name for the Autonomous Container Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The `DB_UNIQUE_NAME` of the Oracle Database being backed up.
        /// </value>
        [JsonProperty(PropertyName = "dbUniqueName")]
        public string DbUniqueName { get; set; }
                ///
        /// <value>
        /// The service level agreement type of the Autonomous Container Database. The default is STANDARD. For an autonomous dataguard Autonomous Container Database, the specified Autonomous Exadata Infrastructure must be associated with a remote Autonomous Exadata Infrastructure.
        /// </value>
        ///
        public enum ServiceLevelAgreementTypeEnum {
            [EnumMember(Value = "STANDARD")]
            Standard,
            [EnumMember(Value = "AUTONOMOUS_DATAGUARD")]
            AutonomousDataguard
        };

        /// <value>
        /// The service level agreement type of the Autonomous Container Database. The default is STANDARD. For an autonomous dataguard Autonomous Container Database, the specified Autonomous Exadata Infrastructure must be associated with a remote Autonomous Exadata Infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "serviceLevelAgreementType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ServiceLevelAgreementTypeEnum> ServiceLevelAgreementType { get; set; }
        
        /// <value>
        /// The OCID of the Autonomous Exadata Infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "autonomousExadataInfrastructureId")]
        public string AutonomousExadataInfrastructureId { get; set; }
        
        /// <value>
        /// The OCID of the peer Autonomous Exadata Infrastructure for Autonomous Data Guard.
        /// </value>
        [JsonProperty(PropertyName = "peerAutonomousExadataInfrastructureId")]
        public string PeerAutonomousExadataInfrastructureId { get; set; }
        
        /// <value>
        /// The display name for the peer Autonomous Container Database.
        /// </value>
        [JsonProperty(PropertyName = "peerAutonomousContainerDatabaseDisplayName")]
        public string PeerAutonomousContainerDatabaseDisplayName { get; set; }
                ///
        /// <value>
        /// The protection mode of this Autonomous Data Guard association. For more information, see
        /// [Oracle Data Guard Protection Modes](http://docs.oracle.com/database/122/SBYDB/oracle-data-guard-protection-modes.htm#SBYDB02000)
        /// in the Oracle Data Guard documentation.
        /// 
        /// </value>
        ///
        public enum ProtectionModeEnum {
            [EnumMember(Value = "MAXIMUM_AVAILABILITY")]
            MaximumAvailability,
            [EnumMember(Value = "MAXIMUM_PERFORMANCE")]
            MaximumPerformance
        };

        /// <value>
        /// The protection mode of this Autonomous Data Guard association. For more information, see
        /// [Oracle Data Guard Protection Modes](http://docs.oracle.com/database/122/SBYDB/oracle-data-guard-protection-modes.htm#SBYDB02000)
        /// in the Oracle Data Guard documentation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "protectionMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ProtectionModeEnum> ProtectionMode { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the peer Autonomous VM cluster for Autonomous Data Guard. Required to enable Data Guard.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "peerAutonomousVmClusterId")]
        public string PeerAutonomousVmClusterId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment where the standby Autonomous Container Database
        /// will be created.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "peerAutonomousContainerDatabaseCompartmentId")]
        public string PeerAutonomousContainerDatabaseCompartmentId { get; set; }
        
        [JsonProperty(PropertyName = "peerAutonomousContainerDatabaseBackupConfig")]
        public PeerAutonomousContainerDatabaseBackupConfig PeerAutonomousContainerDatabaseBackupConfig { get; set; }
        
        /// <value>
        /// The OCID of the Autonomous VM Cluster.
        /// </value>
        [JsonProperty(PropertyName = "autonomousVmClusterId")]
        public string AutonomousVmClusterId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment containing the Autonomous Container Database.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
                ///
        /// <value>
        /// Database Patch model preference.
        /// </value>
        ///
        public enum PatchModelEnum {
            [EnumMember(Value = "RELEASE_UPDATES")]
            ReleaseUpdates,
            [EnumMember(Value = "RELEASE_UPDATE_REVISIONS")]
            ReleaseUpdateRevisions
        };

        /// <value>
        /// Database Patch model preference.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PatchModel is required.")]
        [JsonProperty(PropertyName = "patchModel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PatchModelEnum> PatchModel { get; set; }
        
        [JsonProperty(PropertyName = "maintenanceWindowDetails")]
        public MaintenanceWindow MaintenanceWindowDetails { get; set; }
        
        /// <value>
        /// The scheduling detail for the quarterly maintenance window of the standby Autonomous Container Database.
        /// This value represents the number of days before scheduled maintenance of the primary database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "standbyMaintenanceBufferInDays")]
        public System.Nullable<int> StandbyMaintenanceBufferInDays { get; set; }
        
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
        
        [JsonProperty(PropertyName = "backupConfig")]
        public AutonomousContainerDatabaseBackupConfig BackupConfig { get; set; }
        
        /// <value>
        /// The OCID of the key container that is used as the master encryption key in database transparent data encryption (TDE) operations.
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
        
        /// <value>
        /// The OCID of the key container version that is used in database transparent data encryption (TDE) operations KMS Key can have multiple key versions. If none is specified, the current key version (latest) of the Key Id is used for the operation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyVersionId")]
        public string KmsKeyVersionId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Oracle Cloud Infrastructure [vault](https://docs.cloud.oracle.com/Content/KeyManagement/Concepts/keyoverview.htm#concepts).
        /// </value>
        [JsonProperty(PropertyName = "vaultId")]
        public string VaultId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the key store.
        /// </value>
        [JsonProperty(PropertyName = "keyStoreId")]
        public string KeyStoreId { get; set; }
        
    }
}
