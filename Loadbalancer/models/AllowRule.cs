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


namespace Oci.LoadbalancerService.Models
{
    /// <summary>
    /// An object that represents the action of configuring an access control rule. Access control rules permit access
    /// to application resources based on user-specified match conditions. This rule applies only to HTTP listeners.
    /// <br/>
    /// **NOTES:**
    /// *  If you do not specify any access control rules, the default rule is to allow all traffic.
    /// *  If you add access control rules, the load balancer denies any traffic that does not match the rules.
    /// *  Maximum of two match conditions can be specified in a rule.
    /// *  You can specify this rule only with the following `RuleCondition` combinations:
    ///     *  `SOURCE_IP_ADDRESS`
    ///     *  `SOURCE_VCN_ID`
    ///     *  `SOURCE_VCN_ID\", \"SOURCE_VCN_IP_ADDRESS`
    /// 
    /// </summary>
    public class AllowRule : Rule
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Conditions is required.")]
        [JsonProperty(PropertyName = "conditions")]
        public System.Collections.Generic.List<RuleCondition> Conditions { get; set; }
        
        /// <value>
        /// A brief description of the access control rule. Avoid entering confidential information.
        /// <br/>
        /// Example: 192.168.0.0/16 and 2001:db8::/32 are trusted clients. Whitelist them.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        [JsonProperty(PropertyName = "action")]
        private readonly string action = "ALLOW";
    }
}
