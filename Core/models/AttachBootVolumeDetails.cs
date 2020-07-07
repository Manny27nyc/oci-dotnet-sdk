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
    
    public class AttachBootVolumeDetails 
    {
        
        /// <value>
        /// The OCID of the  boot volume.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BootVolumeId is required.")]
        [JsonProperty(PropertyName = "bootVolumeId")]
        public string BootVolumeId { get; set; }

        /// <value>
        /// A user-friendly name. Does not have to be unique, and it cannot be changed. Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// The OCID of the instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceId is required.")]
        [JsonProperty(PropertyName = "instanceId")]
        public string InstanceId { get; set; }
    }
}