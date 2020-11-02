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
    /// Create new block volumes or attach to an existing volume. Specify either createDetails or volumeId.
    /// 
    /// </summary>
    public class InstanceConfigurationBlockVolumeDetails 
    {
        
        [JsonProperty(PropertyName = "attachDetails")]
        public InstanceConfigurationAttachVolumeDetails AttachDetails { get; set; }
        
        [JsonProperty(PropertyName = "createDetails")]
        public InstanceConfigurationCreateVolumeDetails CreateDetails { get; set; }
        
        /// <value>
        /// The OCID of the volume.
        /// </value>
        [JsonProperty(PropertyName = "volumeId")]
        public string VolumeId { get; set; }
        
    }
}
