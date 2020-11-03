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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Properties used in tag create operations.
    /// </summary>
    public class CreateTagDetails 
    {
        
        /// <value>
        /// The name of the tag in the case of a free form tag.
        /// When linking to a glossary term, this field is not specified.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Unique key of the related term or null in the case of a free form tag.
        /// </value>
        [JsonProperty(PropertyName = "termKey")]
        public string TermKey { get; set; }
        
    }
}
