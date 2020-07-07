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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// Details about Kerberos principals
    /// </summary>
    public class KerberosDetails 
    {
        
        /// <value>
        /// Name of the Kerberos principal
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PrincipalName is required.")]
        [JsonProperty(PropertyName = "principalName")]
        public string PrincipalName { get; set; }

        /// <value>
        /// Location of the keytab file
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KeytabFile is required.")]
        [JsonProperty(PropertyName = "keytabFile")]
        public string KeytabFile { get; set; }
    }
}