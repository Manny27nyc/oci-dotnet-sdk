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


namespace Oci.CimsService.Models
{
    /// <summary>
    /// Reserved for future use.
    /// </summary>
    public class LimitItem : Item
    {
        
        /// <value>
        /// The currently available limit of the resource.
        /// </value>
        [JsonProperty(PropertyName = "currentLimit")]
        public System.Nullable<int> CurrentLimit { get; set; }
        
        /// <value>
        /// The current usage of the resource.
        /// </value>
        [JsonProperty(PropertyName = "currentUsage")]
        public System.Nullable<int> CurrentUsage { get; set; }
        
        /// <value>
        /// The requested limit for the resource.
        /// </value>
        [JsonProperty(PropertyName = "requestedLimit")]
        public System.Nullable<int> RequestedLimit { get; set; }
                ///
        /// <value>
        /// The status of the request.
        /// </value>
        ///
        public enum LimitStatusEnum {
            [EnumMember(Value = "APPROVED")]
            Approved,
            [EnumMember(Value = "PARTIALLY_APPROVED")]
            PartiallyApproved,
            [EnumMember(Value = "NOT_APPROVED")]
            NotApproved
        };

        /// <value>
        /// The status of the request.
        /// </value>
        [JsonProperty(PropertyName = "limitStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LimitStatusEnum> LimitStatus { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "limit";
    }
}
