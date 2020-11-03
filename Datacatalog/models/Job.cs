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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Details of a job. Jobs are scheduled instances of a job definition.
    /// </summary>
    public class Job 
    {
        
        /// <value>
        /// Unique key of the job resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// A user-friendly display name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Detailed description of the job.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The data catalog's OCID.
        /// </value>
        [JsonProperty(PropertyName = "catalogId")]
        public string CatalogId { get; set; }
        
        /// <value>
        /// Lifecycle state for job.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<JobLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the job was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2019-03-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Time that this job was last updated. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Type of the job.
        /// </value>
        [JsonProperty(PropertyName = "jobType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<JobType> JobType { get; set; }
        
        /// <value>
        /// Schedule specified in the cron expression format that has seven fields for second, minute, hour, day-of-month, month, day-of-week, year.
        /// It can also include special characters like * for all and ? for any. There are also pre-defined schedules that can be specified using
        /// special strings. For example, @hourly will run the job every hour.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scheduleCronExpression")]
        public string ScheduleCronExpression { get; set; }
        
        /// <value>
        /// Date that the schedule should be operational. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeScheduleBegin")]
        public System.Nullable<System.DateTime> TimeScheduleBegin { get; set; }
        
        /// <value>
        /// Date that the schedule should end from being operational. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeScheduleEnd")]
        public System.Nullable<System.DateTime> TimeScheduleEnd { get; set; }
        
        /// <value>
        /// Type of job schedule that is inferred from the scheduling properties.
        /// </value>
        [JsonProperty(PropertyName = "scheduleType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<JobScheduleType> ScheduleType { get; set; }
        
        /// <value>
        /// The key of the connection used by the job. This connection will override the default connection specified in
        /// the associated job definition. All executions will use this connection.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "connectionKey")]
        public string ConnectionKey { get; set; }
        
        /// <value>
        /// The unique key of the job definition resource that defined the scope of this job.
        /// </value>
        [JsonProperty(PropertyName = "jobDefinitionKey")]
        public string JobDefinitionKey { get; set; }
        
        /// <value>
        /// Internal version of the job resource.
        /// </value>
        [JsonProperty(PropertyName = "internalVersion")]
        public string InternalVersion { get; set; }
        
        /// <value>
        /// The total number of executions for this job schedule.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "executionCount")]
        public System.Nullable<int> ExecutionCount { get; set; }
        
        /// <value>
        /// The date and time of the most recent execution for this Job, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2019-03-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeOfLatestExecution")]
        public System.Nullable<System.DateTime> TimeOfLatestExecution { get; set; }
        
        /// <value>
        /// OCID of the user who created this job.
        /// </value>
        [JsonProperty(PropertyName = "createdById")]
        public string CreatedById { get; set; }
        
        /// <value>
        /// OCID of the user who updated this job.
        /// </value>
        [JsonProperty(PropertyName = "updatedById")]
        public string UpdatedById { get; set; }
        
        /// <value>
        /// The display name of the job definition resource that defined the scope of this job.
        /// </value>
        [JsonProperty(PropertyName = "jobDefinitionName")]
        public string JobDefinitionName { get; set; }
        
        /// <value>
        /// Error code returned from the latest job execution for this job. Useful when the latest Job execution is in FAILED state.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "errorCode")]
        public string ErrorCode { get; set; }
        
        /// <value>
        /// Error message returned from the latest job execution for this job. Useful when the latest Job Execution is in a FAILED state.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }
        
        /// <value>
        /// URI to the job instance in the API.
        /// </value>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
        
    }
}
