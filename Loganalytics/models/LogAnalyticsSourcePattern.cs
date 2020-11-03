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
    /// LogAnalyticsSourcePattern
    /// </summary>
    public class LogAnalyticsSourcePattern 
    {
        
        /// <value>
        /// converted text
        /// </value>
        [JsonProperty(PropertyName = "convertedText")]
        public string ConvertedText { get; set; }
        
        /// <value>
        /// parser Id
        /// </value>
        [JsonProperty(PropertyName = "dbParserId")]
        public System.Nullable<long> DbParserId { get; set; }
        
        /// <value>
        /// date time columns
        /// </value>
        [JsonProperty(PropertyName = "dbPatternDateTimeColumns")]
        public string DbPatternDateTimeColumns { get; set; }
        
        /// <value>
        /// date time field
        /// </value>
        [JsonProperty(PropertyName = "dbPatternDateTimeField")]
        public string DbPatternDateTimeField { get; set; }
        
        /// <value>
        /// sequence column
        /// </value>
        [JsonProperty(PropertyName = "dbPatternSequenceColumn")]
        public string DbPatternSequenceColumn { get; set; }
        
        /// <value>
        /// field list
        /// </value>
        [JsonProperty(PropertyName = "fields")]
        public System.Collections.Generic.List<LogAnalyticsParserField> Fields { get; set; }
        
        /// <value>
        /// is include flag
        /// </value>
        [JsonProperty(PropertyName = "isInclude")]
        public System.Nullable<bool> IsInclude { get; set; }
        
        /// <value>
        /// is default flag
        /// </value>
        [JsonProperty(PropertyName = "isDefault")]
        public System.Nullable<bool> IsDefault { get; set; }
        
        [JsonProperty(PropertyName = "patternFilter")]
        public LogAnalyticsPatternFilter PatternFilter { get; set; }
        
        /// <value>
        /// alias
        /// </value>
        [JsonProperty(PropertyName = "alias")]
        public string Alias { get; set; }
        
        /// <value>
        /// description
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// is enabled flag
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// pattern Id
        /// </value>
        [JsonProperty(PropertyName = "patternId")]
        public System.Nullable<long> PatternId { get; set; }
        
        /// <value>
        /// is system flag
        /// </value>
        [JsonProperty(PropertyName = "isSystem")]
        public System.Nullable<bool> IsSystem { get; set; }
        
        /// <value>
        /// source Id
        /// </value>
        [JsonProperty(PropertyName = "sourceId")]
        public System.Nullable<long> SourceId { get; set; }
        
        /// <value>
        /// suppress agent warning
        /// </value>
        [JsonProperty(PropertyName = "isAgentWarningSuppressed")]
        public System.Nullable<bool> IsAgentWarningSuppressed { get; set; }
        
        /// <value>
        /// pattern text
        /// </value>
        [JsonProperty(PropertyName = "patternText")]
        public string PatternText { get; set; }
        
        /// <value>
        /// pattern type
        /// </value>
        [JsonProperty(PropertyName = "patternType")]
        public System.Nullable<long> PatternType { get; set; }
        
        /// <value>
        /// source entity types
        /// </value>
        [JsonProperty(PropertyName = "entityType")]
        public System.Collections.Generic.List<string> EntityType { get; set; }
        
    }
}
