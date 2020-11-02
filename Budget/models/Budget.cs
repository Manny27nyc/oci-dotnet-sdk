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


namespace Oci.BudgetService.Models
{
    /// <summary>
    /// A budget.
    /// </summary>
    public class Budget 
    {
        
        /// <value>
        /// The OCID of the budget
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// This is DEPRECATED. For backwards compatability, the property will be populated when
        /// targetType is \"COMPARTMENT\" AND targets contains EXACT ONE target compartment ocid.
        /// For all other scenarios, this property will be left empty.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "targetCompartmentId")]
        public string TargetCompartmentId { get; set; }
        
        /// <value>
        /// The display name of the budget.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The description of the budget.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The amount of the budget expressed in the currency of the customer's rate card.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Amount is required.")]
        [JsonProperty(PropertyName = "amount")]
        public System.Nullable<decimal> Amount { get; set; }
        
        /// <value>
        /// The reset period for the budget.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResetPeriod is required.")]
        [JsonProperty(PropertyName = "resetPeriod")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ResetPeriod> ResetPeriod { get; set; }
        
        /// <value>
        /// The type of target on which the budget is applied.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "targetType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TargetType> TargetType { get; set; }
        
        /// <value>
        /// The list of targets on which the budget is applied.
        ///   If targetType is \"COMPARTMENT\", targets contains list of compartment OCIDs.
        ///   If targetType is \"TAG\", targets contains list of cost tracking tag identifiers in the form of \"{tagNamespace}.{tagKey}.{tagValue}\".
        /// 
        /// </value>
        [JsonProperty(PropertyName = "targets")]
        public System.Collections.Generic.List<string> Targets { get; set; }
        
        /// <value>
        /// The current state of the budget.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Total number of alert rules in the budget
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AlertRuleCount is required.")]
        [JsonProperty(PropertyName = "alertRuleCount")]
        public System.Nullable<int> AlertRuleCount { get; set; }
        
        /// <value>
        /// Version of the budget. Starts from 1 and increments by 1.
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public System.Nullable<int> Version { get; set; }
        
        /// <value>
        /// The actual spend in currency for the current budget cycle
        /// </value>
        [JsonProperty(PropertyName = "actualSpend")]
        public System.Nullable<decimal> ActualSpend { get; set; }
        
        /// <value>
        /// The forecasted spend in currency by the end of the current budget cycle
        /// </value>
        [JsonProperty(PropertyName = "forecastedSpend")]
        public System.Nullable<decimal> ForecastedSpend { get; set; }
        
        /// <value>
        /// The time that the budget spend was last computed
        /// </value>
        [JsonProperty(PropertyName = "timeSpendComputed")]
        public System.Nullable<System.DateTime> TimeSpendComputed { get; set; }
        
        /// <value>
        /// Time that budget was created
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Time that budget was updated
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
