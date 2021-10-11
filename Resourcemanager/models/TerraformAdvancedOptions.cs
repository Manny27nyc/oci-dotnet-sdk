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


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// Specifies advanced options for Terraform commands. These options are not necessary for normal usage of Terraform.
    /// 
    /// </summary>
    public class TerraformAdvancedOptions 
    {
        
        /// <value>
        /// Specifies whether to refresh the state for each resource before running the job (operation).
        /// Refreshing the state can affect performance. Consider setting to `false` if the configuration includes several resources.
        /// Used with the following operations: `PLAN`, `APPLY`, `DESTROY`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isRefreshRequired")]
        public System.Nullable<bool> IsRefreshRequired { get; set; }
        
        /// <value>
        /// Limits the number of concurrent Terraform operations when [walking the graph](https://www.terraform.io/docs/internals/graph.html#walking-the-graph).
        /// Use this parameter to help debug Terraform issues or to accomplish certain special use cases.
        /// A higher value might cause resources to be throttled.
        /// Used with the following operations: `PLAN`, `APPLY`, `DESTROY`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "parallelism")]
        public System.Nullable<int> Parallelism { get; set; }
                ///
        /// <value>
        /// Enables detailed logs at the specified verbosity for running the job (operation).
        /// Used with the following operations: `PLAN`, `APPLY`, `DESTROY`.
        /// 
        /// </value>
        ///
        public enum DetailedLogLevelEnum {
            [EnumMember(Value = "ERROR")]
            Error,
            [EnumMember(Value = "WARN")]
            Warn,
            [EnumMember(Value = "INFO")]
            Info,
            [EnumMember(Value = "DEBUG")]
            Debug,
            [EnumMember(Value = "TRACE")]
            Trace
        };

        /// <value>
        /// Enables detailed logs at the specified verbosity for running the job (operation).
        /// Used with the following operations: `PLAN`, `APPLY`, `DESTROY`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "detailedLogLevel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DetailedLogLevelEnum> DetailedLogLevel { get; set; }
        
    }
}