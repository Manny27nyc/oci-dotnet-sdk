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
    /// AbstractParserTestResultLogEntry
    /// </summary>
    public class AbstractParserTestResultLogEntry 
    {
        
        /// <value>
        /// extra info attributes
        /// </value>
        [JsonProperty(PropertyName = "extraInfoAttributes")]
        public System.Collections.Generic.Dictionary<string, string> ExtraInfoAttributes { get; set; }
        
        /// <value>
        /// field name value map
        /// </value>
        [JsonProperty(PropertyName = "fieldNameValueMap")]
        public System.Collections.Generic.Dictionary<string, string> FieldNameValueMap { get; set; }
        
        /// <value>
        /// field position value map
        /// </value>
        [JsonProperty(PropertyName = "fieldPositionValueMap")]
        public System.Collections.Generic.Dictionary<string, string> FieldPositionValueMap { get; set; }
        
        /// <value>
        /// fields
        /// </value>
        [JsonProperty(PropertyName = "fields")]
        public System.Collections.Generic.Dictionary<string, string> Fields { get; set; }
        
        /// <value>
        /// log entry
        /// </value>
        [JsonProperty(PropertyName = "logEntry")]
        public string LogEntry { get; set; }
        
        /// <value>
        /// match status
        /// </value>
        [JsonProperty(PropertyName = "matchStatus")]
        public string MatchStatus { get; set; }
        
        /// <value>
        /// match status description
        /// </value>
        [JsonProperty(PropertyName = "matchStatusDescription")]
        public string MatchStatusDescription { get; set; }
        
    }
}
