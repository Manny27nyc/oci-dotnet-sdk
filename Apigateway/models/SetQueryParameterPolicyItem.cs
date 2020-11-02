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


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// Set will add a new query parameter if it was not in the original request.  If the parameter already exists on the
    /// request, you can choose to override, append, or skip it.
    /// 
    /// </summary>
    public class SetQueryParameterPolicyItem 
    {
        
        /// <value>
        /// The case-sensitive name of the query parameter.  This name must be unique across transformation policies.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// A list of new values.  Each value can be a constant or may include one or more expressions enclosed within
        /// ${} delimiters.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Values is required.")]
        [JsonProperty(PropertyName = "values")]
        public System.Collections.Generic.List<string> Values { get; set; }
                ///
        /// <value>
        /// If a query parameter with the same name already exists in the request, OVERWRITE will overwrite the value,
        /// APPEND will append to the existing value, or SKIP will keep the existing value.
        /// 
        /// </value>
        ///
        public enum IfExistsEnum {
            [EnumMember(Value = "OVERWRITE")]
            Overwrite,
            [EnumMember(Value = "APPEND")]
            Append,
            [EnumMember(Value = "SKIP")]
            Skip
        };

        /// <value>
        /// If a query parameter with the same name already exists in the request, OVERWRITE will overwrite the value,
        /// APPEND will append to the existing value, or SKIP will keep the existing value.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ifExists")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<IfExistsEnum> IfExists { get; set; }
        
    }
}
