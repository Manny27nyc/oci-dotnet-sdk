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
    /// A summary of information about a particular CPE device type. Compare with
    /// {@link CpeDeviceShapeDetail}.
    /// 
    /// </summary>
    public class CpeDeviceShapeSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the CPE device shape.
        /// This value uniquely identifies the type of CPE device.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Basic information about this particular CPE device type.
        /// </value>
        [JsonProperty(PropertyName = "cpeDeviceInfo")]
        public CpeDeviceInfo CpeDeviceInfo { get; set; }
        
    }
}
