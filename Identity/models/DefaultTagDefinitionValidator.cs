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
    /// <summary>
    /// Use this validator to clear any existing validator on the tag key definition with the UpdateTag
    /// operation. Using this `validatorType` is the same as not setting any value on the validator field.
    /// The resultant value for `validatorType` returned in the response body is `null`.
    /// 
    /// </summary>
    public class DefaultTagDefinitionValidator : BaseTagDefinitionValidator
    {
        
        [JsonProperty(PropertyName = "validatorType")]
        private readonly string validatorType = "DEFAULT";
    }
}
