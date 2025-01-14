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
    /// The finding benefits data for the SQL Tuning Advisor summary report.
    /// </summary>
    public class SqlTuningAdvisorTaskSummaryFindingBenefits 
    {
        
        /// <value>
        /// The count of Potential database time before SQL recommendations are implemented.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbTimeBeforeRecommended is required.")]
        [JsonProperty(PropertyName = "dbTimeBeforeRecommended")]
        public System.Nullable<int> DbTimeBeforeRecommended { get; set; }
        
        /// <value>
        /// The count of Potential database time after SQL recommendations are implemented.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbTimeAfterRecommended is required.")]
        [JsonProperty(PropertyName = "dbTimeAfterRecommended")]
        public System.Nullable<int> DbTimeAfterRecommended { get; set; }
        
        /// <value>
        /// The count of database time benefit before SQL recommendations are implemented.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbTimeBeforeImplemented is required.")]
        [JsonProperty(PropertyName = "dbTimeBeforeImplemented")]
        public System.Nullable<int> DbTimeBeforeImplemented { get; set; }
        
        /// <value>
        /// The count of database time benefit after SQL recommendations are implemented.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbTimeAfterImplemented is required.")]
        [JsonProperty(PropertyName = "dbTimeAfterImplemented")]
        public System.Nullable<int> DbTimeAfterImplemented { get; set; }
        
    }
}
