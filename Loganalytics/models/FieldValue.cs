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
    /// Field value representing and entry in a list-of-values field.
    /// 
    /// </summary>
    public class FieldValue 
    {
        
        /// <value>
        /// Display representation of the field value.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayValue")]
        public string DisplayValue { get; set; }
        
        /// <value>
        /// Internal representation of the field value.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "internalValue")]
        public System.Object InternalValue { get; set; }
        
        /// <value>
        /// Denotes if this list-of-values value has been marked as deleted.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDeleted")]
        public System.Nullable<bool> IsDeleted { get; set; }
        
    }
}
