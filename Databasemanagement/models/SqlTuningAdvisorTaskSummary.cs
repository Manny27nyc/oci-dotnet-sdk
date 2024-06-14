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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The summary for a SQL Tuning Advisor task.
    /// </summary>
    public class SqlTuningAdvisorTaskSummary 
    {
        
        /// <value>
        /// Unique identifier of the task. It is not the [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlTuningAdvisorTaskId is required.")]
        [JsonProperty(PropertyName = "sqlTuningAdvisorTaskId")]
        public System.Nullable<long> SqlTuningAdvisorTaskId { get; set; }
        
        /// <value>
        /// The instance id of the task. It is not the [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        [JsonProperty(PropertyName = "instanceId")]
        public System.Nullable<int> InstanceId { get; set; }
        
        /// <value>
        /// The name of the task.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The description of the task.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The owner of the task.
        /// </value>
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }
        
        /// <value>
        /// Creation date of the task.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The status of the task.
        /// </value>
        [JsonProperty(PropertyName = "taskStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SqlTuningTaskStatusTypes> TaskStatus { get; set; }
        
        /// <value>
        /// Days to expire the task. If the value equals -1 then the task has no expiration time (UNLIMITED).
        /// </value>
        [JsonProperty(PropertyName = "daysToExpire")]
        public System.Nullable<int> DaysToExpire { get; set; }
        
        /// <value>
        /// Start timestamp of task execution.
        /// </value>
        [JsonProperty(PropertyName = "timeExecutionStarted")]
        public System.Nullable<System.DateTime> TimeExecutionStarted { get; set; }
        
        /// <value>
        /// End timestamp of task execution.
        /// </value>
        [JsonProperty(PropertyName = "timeExecutionEnded")]
        public System.Nullable<System.DateTime> TimeExecutionEnded { get; set; }
        
        /// <value>
        /// The total number of SQL statements related to the SQL tuning advisor task.
        /// </value>
        [JsonProperty(PropertyName = "totalSqlStatements")]
        public System.Nullable<int> TotalSqlStatements { get; set; }
        
        /// <value>
        /// Number of recommendations produced.
        /// </value>
        [JsonProperty(PropertyName = "recommendationCount")]
        public System.Nullable<int> RecommendationCount { get; set; }
        
    }
}