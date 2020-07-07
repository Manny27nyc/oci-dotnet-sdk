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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// OCPU options for an image and shape.
    /// </summary>
    public class ImageOcpuConstraints 
    {
        
        /// <value>
        /// The minimum number of OCPUs supported for this image and shape.
        /// </value>
        [JsonProperty(PropertyName = "min")]
        public System.Nullable<int> Min { get; set; }

        /// <value>
        /// The maximum number of OCPUs supported for this image and shape.
        /// </value>
        [JsonProperty(PropertyName = "max")]
        public System.Nullable<int> Max { get; set; }
    }
}