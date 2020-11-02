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
    /// Details to create an Oracle Autonomous Database by cloning from a backup of an existing Autonomous Database.
    /// 
    /// </summary>
    public class CreateAutonomousDatabaseFromBackupDetails : CreateAutonomousDatabaseBase
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the source Autonomous Database Backup that you will clone to create a new Autonomous Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AutonomousDatabaseBackupId is required.")]
        [JsonProperty(PropertyName = "autonomousDatabaseBackupId")]
        public string AutonomousDatabaseBackupId { get; set; }
                ///
        /// <value>
        /// The Autonomous Database clone type.
        /// </value>
        ///
        public enum CloneTypeEnum {
            [EnumMember(Value = "FULL")]
            Full,
            [EnumMember(Value = "METADATA")]
            Metadata
        };

        /// <value>
        /// The Autonomous Database clone type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CloneType is required.")]
        [JsonProperty(PropertyName = "cloneType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<CloneTypeEnum> CloneType { get; set; }
        
        [JsonProperty(PropertyName = "source")]
        private readonly string source = "BACKUP_FROM_ID";
    }
}
