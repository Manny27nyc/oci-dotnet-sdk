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


namespace Oci.WaasService.Models
{
    /// <summary>
    /// An object that represents the action of removing from a response all occurrences of header fields
    /// with a specified name.
    /// 
    /// </summary>
    public class RemoveHttpResponseHeaderAction : HeaderManipulationAction
    {
        
        /// <value>
        /// A header field name that conforms to RFC 7230.
        /// <br/>
        /// Example: example_header_name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Header is required.")]
        [JsonProperty(PropertyName = "header")]
        public string Header { get; set; }
        
        [JsonProperty(PropertyName = "action")]
        private readonly string action = "REMOVE_HTTP_RESPONSE_HEADER";
    }
}
