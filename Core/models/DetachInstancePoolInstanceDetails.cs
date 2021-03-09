/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
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
    /// Detach an instance from the pool.
    /// 
    /// </summary>
    public class DetachInstancePoolInstanceDetails 
    {
        
        /// <value>
        /// The instance ocid to detach.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceId is required.")]
        [JsonProperty(PropertyName = "instanceId")]
        public string InstanceId { get; set; }
        
        /// <value>
        /// Decrement the size of the instance pool during detachment.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDecrementSize")]
        public System.Nullable<bool> IsDecrementSize { get; set; }
        
        /// <value>
        /// Terminate the instance after it has been detached.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAutoTerminate")]
        public System.Nullable<bool> IsAutoTerminate { get; set; }
        
    }
}