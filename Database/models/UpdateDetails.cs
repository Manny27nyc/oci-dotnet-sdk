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
    /// Details specifying which maintenance update to apply to the target and which actions are to be performed by the maintenance update.
    /// 
    /// </summary>
    public class UpdateDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the maintenance update.
        /// </value>
        [JsonProperty(PropertyName = "updateId")]
        public string UpdateId { get; set; }
                ///
        /// <value>
        /// The update action.
        /// </value>
        ///
        public enum UpdateActionEnum {
            [EnumMember(Value = "ROLLING_APPLY")]
            RollingApply,
            [EnumMember(Value = "NON_ROLLING_APPLY")]
            NonRollingApply,
            [EnumMember(Value = "PRECHECK")]
            Precheck
        };

        /// <value>
        /// The update action.
        /// </value>
        [JsonProperty(PropertyName = "updateAction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<UpdateActionEnum> UpdateAction { get; set; }
        
    }
}
