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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Top level response object.
    /// 
    /// </summary>
    public class SummarizeDatabaseInsightResourceUsageTrendAggregationCollection 
    {
        
        /// <value>
        /// The start timestamp that was passed into the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeIntervalStart is required.")]
        [JsonProperty(PropertyName = "timeIntervalStart")]
        public System.Nullable<System.DateTime> TimeIntervalStart { get; set; }
        
        /// <value>
        /// The end timestamp that was passed into the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeIntervalEnd is required.")]
        [JsonProperty(PropertyName = "timeIntervalEnd")]
        public System.Nullable<System.DateTime> TimeIntervalEnd { get; set; }
                ///
        /// <value>
        /// Defines the type of resource metric (CPU, STORAGE)
        /// 
        /// </value>
        ///
        public enum ResourceMetricEnum {
            [EnumMember(Value = "CPU")]
            Cpu,
            [EnumMember(Value = "STORAGE")]
            Storage
        };

        /// <value>
        /// Defines the type of resource metric (CPU, STORAGE)
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceMetric is required.")]
        [JsonProperty(PropertyName = "resourceMetric")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ResourceMetricEnum> ResourceMetric { get; set; }
        
        /// <value>
        /// Displays usage unit ( CORES, GB)
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UsageUnit is required.")]
        [JsonProperty(PropertyName = "usageUnit")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<UsageUnit> UsageUnit { get; set; }
        
        /// <value>
        /// Time duration in milliseconds between data points (one hour or one day).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ItemDurationInMs is required.")]
        [JsonProperty(PropertyName = "itemDurationInMs")]
        public System.Nullable<long> ItemDurationInMs { get; set; }
        
        /// <value>
        /// Usage Data with time stamps
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UsageData is required.")]
        [JsonProperty(PropertyName = "usageData")]
        public System.Collections.Generic.List<ResourceUsageTrendAggregation> UsageData { get; set; }
        
    }
}
