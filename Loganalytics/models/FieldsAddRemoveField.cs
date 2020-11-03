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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Field denoting a field specified in querylanguage FIELDS command.
    /// 
    /// </summary>
    public class FieldsAddRemoveField : AbstractField
    {
                ///
        /// <value>
        /// Denotes if field entry in FIELDS command is to show / hide field in results.
        /// 
        /// </value>
        ///
        public enum OperationEnum {
            [EnumMember(Value = "ADD")]
            Add,
            [EnumMember(Value = "REMOVE")]
            Remove
        };

        /// <value>
        /// Denotes if field entry in FIELDS command is to show / hide field in results.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "operation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OperationEnum> Operation { get; set; }
        
        [JsonProperty(PropertyName = "name")]
        private readonly string name = "FIELDS";
    }
}
