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
    /// LogAnalyticsMetaFunction
    /// </summary>
    public class LogAnalyticsMetaFunction 
    {
        
        /// <value>
        /// meta function argument object
        /// </value>
        [JsonProperty(PropertyName = "metaFunctionArgument")]
        public System.Collections.Generic.List<LogAnalyticsMetaFunctionArgument> MetaFunctionArgument { get; set; }
        
        /// <value>
        /// component
        /// </value>
        [JsonProperty(PropertyName = "component")]
        public string Component { get; set; }
        
        /// <value>
        /// description
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// edit version
        /// </value>
        [JsonProperty(PropertyName = "editVersion")]
        public System.Nullable<long> EditVersion { get; set; }
        
        /// <value>
        /// meta function Id
        /// </value>
        [JsonProperty(PropertyName = "metaFunctionId")]
        public System.Nullable<long> MetaFunctionId { get; set; }
        
        /// <value>
        /// java class name
        /// </value>
        [JsonProperty(PropertyName = "javaClassName")]
        public string JavaClassName { get; set; }
        
        /// <value>
        /// meta function name
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
    }
}
