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
    /// The shape used to launch instances associated with the dedicated VM host.
    /// 
    /// </summary>
    public class DedicatedVmHostInstanceShapeSummary 
    {
        
        /// <value>
        /// The shape's availability domain.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The name of the virtual machine instance shapes that can be launched on a dedicated VM host.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceShapeName is required.")]
        [JsonProperty(PropertyName = "instanceShapeName")]
        public string InstanceShapeName { get; set; }
        
    }
}
