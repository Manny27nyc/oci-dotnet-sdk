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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// List of problem ids to be passed in to update the Problem status.
    /// </summary>
    public class UpdateBulkProblemStatusDetails 
    {
        
        /// <value>
        /// Action taken by user
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ProblemLifecycleDetail> Status { get; set; }
        
        /// <value>
        /// List of ProblemIds to be passed in to update the Problem status.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProblemIds is required.")]
        [JsonProperty(PropertyName = "problemIds")]
        public System.Collections.Generic.List<string> ProblemIds { get; set; }
        
    }
}
