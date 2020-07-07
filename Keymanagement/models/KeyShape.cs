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


namespace Oci.KeymanagementService.Models
{
    /// <summary>
    /// The cryptographic properties of a key.
    /// </summary>
    public class KeyShape 
    {
                ///
        /// <value>
        /// The algorithm used by a key's key versions to encrypt or decrypt.
        /// </value>
        ///
        public enum AlgorithmEnum {
            [EnumMember(Value = "AES")]
            Aes,
            [EnumMember(Value = "RSA")]
            Rsa
        };

        /// <value>
        /// The algorithm used by a key's key versions to encrypt or decrypt.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Algorithm is required.")]
        [JsonProperty(PropertyName = "algorithm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AlgorithmEnum> Algorithm { get; set; }

        /// <value>
        /// The length of the key, expressed as an integer. Values of 16, 24, or 32 are supported.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Length is required.")]
        [JsonProperty(PropertyName = "length")]
        public System.Nullable<int> Length { get; set; }
    }
}