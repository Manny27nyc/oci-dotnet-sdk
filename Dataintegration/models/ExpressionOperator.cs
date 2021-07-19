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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// An operator for expressions
    /// </summary>
    public class ExpressionOperator : Operator
    {
                ///
        /// <value>
        /// The merge condition. The conditions are
        /// ALL_SUCCESS - All the preceeding operators need to be successful.
        /// ALL_FAILED - All the preceeding operators should have failed.
        /// ALL_COMPLETE - All the preceeding operators should have completed. It could have executed successfully or failed.
        /// 
        /// </value>
        ///
        public enum TriggerRuleEnum {
            [EnumMember(Value = "ALL_SUCCESS")]
            AllSuccess,
            [EnumMember(Value = "ALL_FAILED")]
            AllFailed,
            [EnumMember(Value = "ALL_COMPLETE")]
            AllComplete
        };

        /// <value>
        /// The merge condition. The conditions are
        /// ALL_SUCCESS - All the preceeding operators need to be successful.
        /// ALL_FAILED - All the preceeding operators should have failed.
        /// ALL_COMPLETE - All the preceeding operators should have completed. It could have executed successfully or failed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "triggerRule")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TriggerRuleEnum> TriggerRule { get; set; }
        
        [JsonProperty(PropertyName = "configProviderDelegate")]
        public ConfigProvider ConfigProviderDelegate { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "EXPRESSION_OPERATOR";
    }
}
