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
    /// Query builder edit request details.
    /// 
    /// </summary>
    public class FilterDetails 
    {
        
        /// <value>
        /// Query to apply edits to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "QueryString is required.")]
        [JsonProperty(PropertyName = "queryString")]
        public string QueryString { get; set; }
        
        /// <value>
        /// Default subsystem to qualify fields with in the queryString if not specified.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubSystem is required.")]
        [JsonProperty(PropertyName = "subSystem")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SubSystemName> SubSystem { get; set; }
        
        /// <value>
        /// List of edit operations to be applied in the specified order to the specified queryString.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "filters")]
        public System.Collections.Generic.List<Filter> Filters { get; set; }
        
    }
}
