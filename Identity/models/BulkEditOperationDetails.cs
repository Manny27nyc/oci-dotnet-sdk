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


namespace Oci.IdentityService.Models
{
    
    public class BulkEditOperationDetails 
    {
                ///
        /// <value>
        /// An enum-like description of the type of operation.
        /// <br/>
        /// * `ADD_WHERE_ABSENT` adds a defined tag only if the tag does not already exist on the resource.
        /// * `SET_WHERE_PRESENT` updates the value for a defined tag only if the tag is present on the resource.
        /// * `ADD_OR_SET` combines the first two operations to add a defined tag if it does not already exist on the resource 
        /// or update the value for a defined tag only if the tag is present on the resource.
        /// * `REMOVE` removes the defined tag from the resource. The tag is removed from the resource regardless of the tag value.
        /// 
        /// </value>
        ///
        public enum OperationTypeEnum {
            [EnumMember(Value = "ADD_WHERE_ABSENT")]
            AddWhereAbsent,
            [EnumMember(Value = "SET_WHERE_PRESENT")]
            SetWherePresent,
            [EnumMember(Value = "ADD_OR_SET")]
            AddOrSet,
            [EnumMember(Value = "REMOVE")]
            Remove
        };

        /// <value>
        /// An enum-like description of the type of operation.
        /// <br/>
        /// * `ADD_WHERE_ABSENT` adds a defined tag only if the tag does not already exist on the resource.
        /// * `SET_WHERE_PRESENT` updates the value for a defined tag only if the tag is present on the resource.
        /// * `ADD_OR_SET` combines the first two operations to add a defined tag if it does not already exist on the resource 
        /// or update the value for a defined tag only if the tag is present on the resource.
        /// * `REMOVE` removes the defined tag from the resource. The tag is removed from the resource regardless of the tag value.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperationType is required.")]
        [JsonProperty(PropertyName = "operationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OperationTypeEnum> OperationType { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefinedTags is required.")]
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
