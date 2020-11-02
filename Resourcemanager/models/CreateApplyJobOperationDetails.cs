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


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// Job details that are specific to apply operations.
    /// 
    /// </summary>
    public class CreateApplyJobOperationDetails : CreateJobOperationDetails
    {
        
        /// <value>
        /// Specifies the source of the execution plan to apply.
        /// Use `AUTO_APPROVED` to run the job without an execution plan.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "executionPlanStrategy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ApplyJobOperationDetails.ExecutionPlanStrategyEnum> ExecutionPlanStrategy { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of a plan job, for use when specifying `FROM_PLAN_JOB_ID` as the `executionPlanStrategy`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "executionPlanJobId")]
        public string ExecutionPlanJobId { get; set; }
        
        [JsonProperty(PropertyName = "operation")]
        private readonly string operation = "APPLY";
    }
}
