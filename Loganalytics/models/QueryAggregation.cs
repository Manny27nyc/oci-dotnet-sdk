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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Query results.
    /// 
    /// </summary>
    public class QueryAggregation 
    {
        
        /// <value>
        /// Number of rows query retrieved. Up to maxTotalCount limit.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "totalCount")]
        public System.Nullable<int> TotalCount { get; set; }
        
        /// <value>
        /// Number of rows matched by query.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "totalMatchedCount")]
        public System.Nullable<long> TotalMatchedCount { get; set; }
        
        /// <value>
        /// True if query did not complete processing all data.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "arePartialResults")]
        public System.Nullable<bool> ArePartialResults { get; set; }
        
        /// <value>
        /// Explanation of why results may be partial. Only set if isPartialResults is true.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "partialResultReason")]
        public string PartialResultReason { get; set; }
        
        /// <value>
        /// Query result columns
        /// 
        /// </value>
        [JsonProperty(PropertyName = "columns")]
        public System.Collections.Generic.List<AbstractColumn> Columns { get; set; }
        
        /// <value>
        /// Query result fields
        /// 
        /// </value>
        [JsonProperty(PropertyName = "fields")]
        public System.Collections.Generic.List<AbstractColumn> Fields { get; set; }
        
        /// <value>
        /// Query result data
        /// 
        /// </value>
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, System.Object>> Items { get; set; }
        
        /// <value>
        /// Time ellapsed executing query in milli-seconds.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "queryExecutionTimeInMs")]
        public System.Nullable<long> QueryExecutionTimeInMs { get; set; }
        
        /// <value>
        /// Percentage progress completion of the query.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PercentComplete is required.")]
        [JsonProperty(PropertyName = "percentComplete")]
        public System.Nullable<int> PercentComplete { get; set; }
        
    }
}
