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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Details of scheduled operation.
    /// 
    /// </summary>
    public class ScheduledOperationDetails 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DayOfWeek is required.")]
        [JsonProperty(PropertyName = "dayOfWeek")]
        public DayOfWeek DayOfWeek { get; set; }
        
        /// <value>
        /// auto start time. value must be of ISO-8601 format \"HH:mm\"
        /// </value>
        [JsonProperty(PropertyName = "scheduledStartTime")]
        public string ScheduledStartTime { get; set; }
        
        /// <value>
        /// auto stop time. value must be of ISO-8601 format \"HH:mm\"
        /// </value>
        [JsonProperty(PropertyName = "scheduledStopTime")]
        public string ScheduledStopTime { get; set; }
        
    }
}