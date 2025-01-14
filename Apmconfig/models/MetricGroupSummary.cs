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


namespace Oci.ApmconfigService.Models
{
    /// <summary>
    /// A Metric Group.
    /// 
    /// </summary>
    public class MetricGroupSummary : ConfigSummary
    {
        
        /// <value>
        /// The name of this metric group
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of a Span Filter. The filterId is mandatory for the creation
        /// of MetricGroups. A filterId will be generated when a Span Filter is created.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "filterId")]
        public string FilterId { get; set; }
        
        /// <value>
        /// The namespace to write the metrics to
        /// </value>
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// A list of dimensions for this metric
        /// </value>
        [JsonProperty(PropertyName = "dimensions")]
        public System.Collections.Generic.List<Dimension> Dimensions { get; set; }
        
        [JsonProperty(PropertyName = "metrics")]
        public System.Collections.Generic.List<Metric> Metrics { get; set; }
        
        [JsonProperty(PropertyName = "configType")]
        private readonly string configType = "METRIC_GROUP";
    }
}
