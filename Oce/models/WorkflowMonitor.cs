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


namespace Oci.OceService.Models
{
    /// <summary>
    /// The workflow monitor for this work request.
    /// </summary>
    public class WorkflowMonitor 
    {
        
        /// <value>
        /// workflow name for this work request
        /// </value>
        [JsonProperty(PropertyName = "workflowName")]
        public string WorkflowName { get; set; }
        
        /// <value>
        /// resource name for this work request
        /// </value>
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }
        
        /// <value>
        /// Workflow step of workflow monitor.
        /// </value>
        [JsonProperty(PropertyName = "workflowSteps")]
        public System.Collections.Generic.List<WorkflowStep> WorkflowSteps { get; set; }
        
    }
}
