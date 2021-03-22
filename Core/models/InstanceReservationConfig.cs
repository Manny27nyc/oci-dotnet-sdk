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
    /// Data that defines the instance reservation configuration.
    /// 
    /// </summary>
    public class InstanceReservationConfig 
    {
        
        /// <value>
        /// The fault domain of this reservation configuration.
        /// If a value is not supplied, this reservation configuration is applicable to all fault domains in the specified availability domain.
        /// For more information, see [Capacity Reservations](https://docs.cloud.oracle.com/iaas/Content/Compute/Tasks/reserve-capacity.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "faultDomain")]
        public string FaultDomain { get; set; }
        
        /// <value>
        /// The shape to use when launching instances using compute capacity reservations. The shape determines the number of CPUs, the amount of memory,
        /// and other resources allocated to the instance.
        /// You can list all available shapes by calling {@link ListComputeCapacityReservationInstanceShapes}.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceShape is required.")]
        [JsonProperty(PropertyName = "instanceShape")]
        public string InstanceShape { get; set; }
        
        [JsonProperty(PropertyName = "instanceShapeConfig")]
        public InstanceReservationShapeConfigDetails InstanceShapeConfig { get; set; }
        
        /// <value>
        /// The amount of capacity reserved in this configuration.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ReservedCount is required.")]
        [JsonProperty(PropertyName = "reservedCount")]
        public System.Nullable<long> ReservedCount { get; set; }
        
        /// <value>
        /// The amount of capacity in use out of the total capacity reserved in this reservation configuration.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UsedCount is required.")]
        [JsonProperty(PropertyName = "usedCount")]
        public System.Nullable<long> UsedCount { get; set; }
        
    }
}