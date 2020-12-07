/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.WaasService.Models;

namespace Oci.WaasService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/8.1.0/waas/ListWaasPolicyCustomProtectionRules.cs.html">here</a> to see an example of how to use ListWaasPolicyCustomProtectionRules request.
    /// </example>
    public class ListWaasPolicyCustomProtectionRulesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the WAAS policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WaasPolicyId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "waasPolicyId")]
        public string WaasPolicyId { get; set; }
        
        /// <value>
        /// The unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The maximum number of items to return in a paginated call. If unspecified, defaults to `10`.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The value of the `opc-next-page` response header from the previous paginated call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// Filter rules using a list of ModSecurity rule IDs.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "modSecurityRuleId")]
        public System.Collections.Generic.List<string> ModSecurityRuleId { get; set; }
        
        ///
        /// <value>
        /// Filter rules using a list of actions.
        /// </value>
        ///
        public enum ActionEnum {
            [EnumMember(Value = "DETECT")]
            Detect,
            [EnumMember(Value = "BLOCK")]
            Block
        };

        /// <value>
        /// Filter rules using a list of actions.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "action")]
        public System.Collections.Generic.List<ActionEnum> Action { get; set; }
    }
}
