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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Contains the parameter configuration values.
    /// </summary>
    public class ConfigParameterValue 
    {
        
        /// <value>
        /// A string value of the parameter.
        /// </value>
        [JsonProperty(PropertyName = "stringValue")]
        public string StringValue { get; set; }
        
        /// <value>
        /// An integer value of the parameter.
        /// </value>
        [JsonProperty(PropertyName = "intValue")]
        public System.Nullable<int> IntValue { get; set; }
        
        /// <value>
        /// The root object reference value.
        /// </value>
        [JsonProperty(PropertyName = "refValue")]
        public System.Object RefValue { get; set; }
        
        /// <value>
        /// Reference to the parameter by its key.
        /// </value>
        [JsonProperty(PropertyName = "parameterValue")]
        public string ParameterValue { get; set; }
        
    }
}
