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


namespace Oci.ComputeinstanceagentService.Models
{
    /// <summary>
    /// The command content.
    /// </summary>
    public class InstanceAgentCommandContentInfo 
    {
        
        /// <value>
        /// The command ocid
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceAgentCommandId is required.")]
        [JsonProperty(PropertyName = "instanceAgentCommandId")]
        public string InstanceAgentCommandId { get; set; }
        
        /// <value>
        /// The OCID of the compartment the command is created in.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// created at time of command.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// updated time of command.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Whether the command has been canceled.
        /// </value>
        [JsonProperty(PropertyName = "isCanceled")]
        public System.Nullable<bool> IsCanceled { get; set; }
        
        /// <value>
        /// The last command time.
        /// </value>
        [JsonProperty(PropertyName = "executionTimeOutInSeconds")]
        public System.Nullable<int> ExecutionTimeOutInSeconds { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Content is required.")]
        [JsonProperty(PropertyName = "content")]
        public InstanceAgentCommandContent Content { get; set; }
        
    }
}
