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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The shape field object.
    /// </summary>
    public class ShapeField : TypedObject
    {
        
        /// <value>
        /// The reference to the type.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        public System.Object Type { get; set; }
        
        /// <value>
        /// Labels are keywords or labels that you can add to data assets, dataflows etc. You can define your own labels and use them to categorize content.
        /// </value>
        [JsonProperty(PropertyName = "labels")]
        public System.Collections.Generic.List<string> Labels { get; set; }
        
        [JsonProperty(PropertyName = "nativeShapeField")]
        public NativeShapeField NativeShapeField { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "SHAPE_FIELD";
    }
}
