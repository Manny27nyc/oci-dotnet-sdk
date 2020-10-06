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
    /// Details to create and download an Oracle Autonomous Database wallet.
    /// 
    /// </summary>
    public class GenerateAutonomousDatabaseWalletDetails 
    {
                ///
        /// <value>
        /// The type of wallet to generate.
        /// <br/>
        /// **Shared Exadata infrastructure usage:**
        /// * `SINGLE` - used to generate a wallet for a single database
        /// * `ALL` - used to generate wallet for all databases in the region
        /// <br/>
        /// **Dedicated Exadata infrastructure usage:** Value must be `NULL` if attribute is used.
        /// 
        /// </value>
        ///
        public enum GenerateTypeEnum {
            [EnumMember(Value = "ALL")]
            All,
            [EnumMember(Value = "SINGLE")]
            Single
        };

        /// <value>
        /// The type of wallet to generate.
        /// <br/>
        /// **Shared Exadata infrastructure usage:**
        /// * `SINGLE` - used to generate a wallet for a single database
        /// * `ALL` - used to generate wallet for all databases in the region
        /// <br/>
        /// **Dedicated Exadata infrastructure usage:** Value must be `NULL` if attribute is used.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "generateType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<GenerateTypeEnum> GenerateType { get; set; }

        /// <value>
        /// The password to encrypt the keys inside the wallet. The password must be at least 8 characters long and must include at least 1 letter and either 1 numeric character or 1 special character.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Password is required.")]
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
    }
}
