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


namespace Oci.VaultService.Models
{
    /// <summary>
    /// A rule that disallows reuse of previously used secret content by the specified secret.
    /// 
    /// </summary>
    public class SecretReuseRule : SecretRule
    {
        
        /// <value>
        /// A property indicating whether the rule is applied even if the secret version with the content you are trying to reuse was deleted.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isEnforcedOnDeletedSecretVersions")]
        public System.Nullable<bool> IsEnforcedOnDeletedSecretVersions { get; set; }
        
        [JsonProperty(PropertyName = "ruleType")]
        private readonly string ruleType = "SECRET_REUSE_RULE";
    }
}
