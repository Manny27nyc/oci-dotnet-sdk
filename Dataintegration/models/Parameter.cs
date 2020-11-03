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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Parameters are created and assigned values that can be configured for each integration task.
    /// </summary>
    public class Parameter : TypedObject
    {
        
        [JsonProperty(PropertyName = "type")]
        public BaseType Type { get; set; }
        
        /// <value>
        /// The default value of the parameter.
        /// </value>
        [JsonProperty(PropertyName = "defaultValue")]
        public System.Object DefaultValue { get; set; }
        
        /// <value>
        /// The default value of the parameter which can be an object in DIS, such as a data entity.
        /// </value>
        [JsonProperty(PropertyName = "rootObjectDefaultValue")]
        public System.Object RootObjectDefaultValue { get; set; }
        
        /// <value>
        /// Specifies whether the parameter is input value.
        /// </value>
        [JsonProperty(PropertyName = "isInput")]
        public System.Nullable<bool> IsInput { get; set; }
        
        /// <value>
        /// Specifies whether the parameter is output value.
        /// </value>
        [JsonProperty(PropertyName = "isOutput")]
        public System.Nullable<bool> IsOutput { get; set; }
                ///
        /// <value>
        /// The output aggregation type.
        /// </value>
        ///
        public enum OutputAggregationTypeEnum {
            [EnumMember(Value = "MIN")]
            Min,
            [EnumMember(Value = "MAX")]
            Max,
            [EnumMember(Value = "COUNT")]
            Count,
            [EnumMember(Value = "SUM")]
            Sum
        };

        /// <value>
        /// The output aggregation type.
        /// </value>
        [JsonProperty(PropertyName = "outputAggregationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OutputAggregationTypeEnum> OutputAggregationType { get; set; }
        
        /// <value>
        /// The type of value the parameter was created for.
        /// </value>
        [JsonProperty(PropertyName = "typeName")]
        public string TypeName { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "PARAMETER";
    }
}
