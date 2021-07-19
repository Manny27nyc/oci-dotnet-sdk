/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
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
    /// The configuration details for updating a Data Guard association for a database.
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class UpdateDataGuardAssociationDetails 
    {
        
        /// <value>
        /// A strong password for the 'SYS', 'SYSTEM', and 'PDB Admin' users to apply during standby creation.
        /// <br/>
        /// The password must contain no fewer than nine characters and include:
        /// <br/>
        /// * At least two uppercase characters.
        /// <br/>
        /// * At least two lowercase characters.
        /// <br/>
        /// * At least two numeric characters.
        /// <br/>
        /// * At least two special characters. Valid special characters include \"_\", \"#\", and \"-\" only.
        /// <br/>
        /// **The password MUST be the same as the primary admin password.**
        /// 
        /// </value>
        [JsonProperty(PropertyName = "databaseAdminPassword")]
        public string DatabaseAdminPassword { get; set; }
                ///
        /// <value>
        /// The protection mode for the Data Guard association's primary and standby database. For more information, see
        /// [Oracle Data Guard Protection Modes](http://docs.oracle.com/database/122/SBYDB/oracle-data-guard-protection-modes.htm#SBYDB02000)
        /// in the Oracle Data Guard documentation.
        /// 
        /// </value>
        ///
        public enum ProtectionModeEnum {
            [EnumMember(Value = "MAXIMUM_AVAILABILITY")]
            MaximumAvailability,
            [EnumMember(Value = "MAXIMUM_PERFORMANCE")]
            MaximumPerformance,
            [EnumMember(Value = "MAXIMUM_PROTECTION")]
            MaximumProtection
        };

        /// <value>
        /// The protection mode for the Data Guard association's primary and standby database. For more information, see
        /// [Oracle Data Guard Protection Modes](http://docs.oracle.com/database/122/SBYDB/oracle-data-guard-protection-modes.htm#SBYDB02000)
        /// in the Oracle Data Guard documentation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "protectionMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ProtectionModeEnum> ProtectionMode { get; set; }
                ///
        /// <value>
        /// The redo transport type to use for this Data Guard association.  Valid values depend on the specified 'protectionMode':
        /// * MAXIMUM_AVAILABILITY - Use SYNC or FASTSYNC
        /// * MAXIMUM_PERFORMANCE - Use ASYNC
        /// * MAXIMUM_PROTECTION - Use SYNC
        /// <br/>
        /// For more information, see
        /// [Redo Transport Services](http://docs.oracle.com/database/122/SBYDB/oracle-data-guard-redo-transport-services.htm#SBYDB00400)
        /// in the Oracle Data Guard documentation.
        /// 
        /// </value>
        ///
        public enum TransportTypeEnum {
            [EnumMember(Value = "SYNC")]
            Sync,
            [EnumMember(Value = "ASYNC")]
            Async,
            [EnumMember(Value = "FASTSYNC")]
            Fastsync
        };

        /// <value>
        /// The redo transport type to use for this Data Guard association.  Valid values depend on the specified 'protectionMode':
        /// * MAXIMUM_AVAILABILITY - Use SYNC or FASTSYNC
        /// * MAXIMUM_PERFORMANCE - Use ASYNC
        /// * MAXIMUM_PROTECTION - Use SYNC
        /// <br/>
        /// For more information, see
        /// [Redo Transport Services](http://docs.oracle.com/database/122/SBYDB/oracle-data-guard-redo-transport-services.htm#SBYDB00400)
        /// in the Oracle Data Guard documentation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "transportType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TransportTypeEnum> TransportType { get; set; }
        
    }
}
