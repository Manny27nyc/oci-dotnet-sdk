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


namespace Oci.AnalyticsService.Models
{
    /// <summary>
    /// Input payload to update a Private Access Channel.
    /// 
    /// </summary>
    public class UpdatePrivateAccessChannelDetails 
    {
        
        /// <value>
        /// Display Name of the Private Access Channel.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// OCID of the customer VCN peered with private access channel.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vcnId")]
        public string VcnId { get; set; }
        
        /// <value>
        /// OCID of the customer subnet connected to private access channel.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// List of Private Source DNS zones registered with Private Access Channel,
        /// where datasource hostnames from these dns zones / domains will be resolved in the peered VCN for access from Analytics Instance.
        /// Min of 1 is required and Max of 30 Private Source DNS zones can be registered.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateSourceDnsZones")]
        public System.Collections.Generic.List<PrivateSourceDnsZone> PrivateSourceDnsZones { get; set; }
        
    }
}