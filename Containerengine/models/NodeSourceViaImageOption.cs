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


namespace Oci.ContainerengineService.Models
{
    /// <summary>
    /// An image can be specified as the source of nodes when launching a node pool using the `nodeSourceDetails` object.
    /// 
    /// </summary>
    public class NodeSourceViaImageOption : NodeSourceOption
    {
        
        /// <value>
        /// The OCID of the image.
        /// </value>
        [JsonProperty(PropertyName = "imageId")]
        public string ImageId { get; set; }
        
        [JsonProperty(PropertyName = "sourceType")]
        private readonly string sourceType = "IMAGE";
    }
}
