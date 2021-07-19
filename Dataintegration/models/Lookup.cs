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
    /// The information about the lookup operator. The lookup operator has two input links, a primary input, and a lookup source input. It has an output link, fields of the lookup input are appended to the primary input and projected as the output fields.
    /// </summary>
    public class Lookup : Operator
    {
        
        [JsonProperty(PropertyName = "lookupCondition")]
        public Expression LookupCondition { get; set; }
        
        /// <value>
        /// For the rows for which lookup condition does not satisfy, if set to true - do not return those rows of primary Input source and if set to false - create a row with primary input fields values and lookup field values as NULL.
        /// </value>
        [JsonProperty(PropertyName = "isSkipNoMatch")]
        public System.Nullable<bool> IsSkipNoMatch { get; set; }
                ///
        /// <value>
        /// if there are multiple records found in the lookup input what action should be performed. The default value for this field is RETURN_ANY.
        /// </value>
        ///
        public enum MultiMatchStrategyEnum {
            [EnumMember(Value = "RETURN_ANY")]
            ReturnAny,
            [EnumMember(Value = "RETURN_FIRST")]
            ReturnFirst,
            [EnumMember(Value = "RETURN_LAST")]
            ReturnLast,
            [EnumMember(Value = "RETURN_ALL")]
            ReturnAll,
            [EnumMember(Value = "RETURN_ERROR")]
            ReturnError
        };

        /// <value>
        /// if there are multiple records found in the lookup input what action should be performed. The default value for this field is RETURN_ANY.
        /// </value>
        [JsonProperty(PropertyName = "multiMatchStrategy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MultiMatchStrategyEnum> MultiMatchStrategy { get; set; }
        
        /// <value>
        /// this map is used for replacing NULL values in the record. Key is the column name and value is the NULL replacement.
        /// </value>
        [JsonProperty(PropertyName = "nullFillValues")]
        public System.Collections.Generic.Dictionary<string, System.Object> NullFillValues { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "LOOKUP_OPERATOR";
    }
}
