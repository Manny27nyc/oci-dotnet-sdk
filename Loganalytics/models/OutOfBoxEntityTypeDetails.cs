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
    /// A Single Entity Type Definition
    /// </summary>
    public class OutOfBoxEntityTypeDetails 
    {
        
        /// <value>
        /// Log analytics entity type name.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Internal name for the log analytics entity type.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InternalName is required.")]
        [JsonProperty(PropertyName = "internalName")]
        public string InternalName { get; set; }
        
        /// <value>
        /// Log analytics entity type category. Category will be used for grouping and filtering.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Category is required.")]
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
                ///
        /// <value>
        /// Log analytics entity type group. Supported values: ClOUD, NON_CLOUD.
        /// 
        /// </value>
        ///
        public enum CloudTypeEnum {
            [EnumMember(Value = "CLOUD")]
            Cloud,
            [EnumMember(Value = "NON_CLOUD")]
            NonCloud
        };

        /// <value>
        /// Log analytics entity type group. Supported values: ClOUD, NON_CLOUD.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CloudType is required.")]
        [JsonProperty(PropertyName = "cloudType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<CloudTypeEnum> CloudType { get; set; }
        
        /// <value>
        /// A Single Entity Type Property Definition
        /// </value>
        [JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.List<EntityTypeProperty> Properties { get; set; }
        
    }
}
