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
    /// Contains resource statistics with usage unit
    /// </summary>
    public class ResourceStatistics 
    {
        
        /// <value>
        /// Total amount used of the resource metric type (CPU, STORAGE).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Usage is required.")]
        [JsonProperty(PropertyName = "usage")]
        public System.Double Usage { get; set; }
        
        /// <value>
        /// The maximum allocated amount of the resource metric type  (CPU, STORAGE).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Capacity is required.")]
        [JsonProperty(PropertyName = "capacity")]
        public System.Double Capacity { get; set; }
        
        /// <value>
        /// The base allocated amount of the resource metric type  (CPU, STORAGE).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "baseCapacity")]
        public System.Double BaseCapacity { get; set; }
        
        /// <value>
        /// Indicates if auto scaling feature is enabled or disabled on a database. It will be false for all metrics other than CPU.
        /// </value>
        [JsonProperty(PropertyName = "isAutoScalingEnabled")]
        public System.Nullable<bool> IsAutoScalingEnabled { get; set; }
        
        /// <value>
        /// Resource utilization in percentage
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UtilizationPercent is required.")]
        [JsonProperty(PropertyName = "utilizationPercent")]
        public System.Double UtilizationPercent { get; set; }
        
        /// <value>
        /// Change in resource utilization in percentage
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UsageChangePercent is required.")]
        [JsonProperty(PropertyName = "usageChangePercent")]
        public System.Double UsageChangePercent { get; set; }
        
    }
}
