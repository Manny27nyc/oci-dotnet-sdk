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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// For use with Oracle Cloud Infrastructure FastConnect. Each
    /// {@link VirtualCircuit} runs on one or
    /// more cross-connects or cross-connect groups. A `CrossConnectMapping`
    /// contains the properties for an individual cross-connect or cross-connect group
    /// associated with a given virtual circuit.
    /// <br/>
    /// The mapping includes information about the cross-connect or
    /// cross-connect group, the VLAN, and the BGP peering session.
    /// <br/>
    /// If you're a customer who is colocated with Oracle, that means you own both
    /// the virtual circuit and the physical connection it runs on (cross-connect or
    /// cross-connect group), so you specify all the information in the mapping. There's
    /// one exception: for a public virtual circuit, Oracle specifies the BGP IPv4
    /// addresses.
    /// <br/>
    /// If you're a provider, then you own the physical connection that the customer's
    /// virtual circuit runs on, so you contribute information about the cross-connect
    /// or cross-connect group and VLAN.
    /// <br/>
    /// Who specifies the BGP peering information in the case of customer connection via
    /// provider? If the BGP session goes from Oracle to the provider's edge router, then
    /// the provider also specifies the BGP peering information. If the BGP session instead
    /// goes from Oracle to the customer's edge router, then the customer specifies the BGP
    /// peering information. There's one exception: for a public virtual circuit, Oracle
    /// specifies the BGP IPv4 addresses.
    /// <br/>
    /// Every `CrossConnectMapping` must have BGP IPv4 peering addresses. BGP IPv6 peering
    /// addresses are optional. If BGP IPv6 addresses are provided, the customer can
    /// exchange IPv6 routes with Oracle.
    /// 
    /// </summary>
    public class CrossConnectMapping 
    {
        
        /// <value>
        /// The key for BGP MD5 authentication. Only applicable if your system
        /// requires MD5 authentication. If empty or not set (null), that
        /// means you don't use BGP MD5 authentication.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "bgpMd5AuthKey")]
        public string BgpMd5AuthKey { get; set; }
        
        /// <value>
        /// The OCID of the cross-connect or cross-connect group for this mapping.
        /// Specified by the owner of the cross-connect or cross-connect group (the
        /// customer if the customer is colocated with Oracle, or the provider if the
        /// customer is connecting via provider).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "crossConnectOrCrossConnectGroupId")]
        public string CrossConnectOrCrossConnectGroupId { get; set; }
        
        /// <value>
        /// The BGP IPv4 address for the router on the other end of the BGP session from
        /// Oracle. Specified by the owner of that router. If the session goes from Oracle
        /// to a customer, this is the BGP IPv4 address of the customer's edge router. If the
        /// session goes from Oracle to a provider, this is the BGP IPv4 address of the
        /// provider's edge router. Must use a /30 or /31 subnet mask.
        /// <br/>
        /// There's one exception: for a public virtual circuit, Oracle specifies the BGP IPv4 addresses.
        /// <br/>
        /// Example: 10.0.0.18/31
        /// </value>
        [JsonProperty(PropertyName = "customerBgpPeeringIp")]
        public string CustomerBgpPeeringIp { get; set; }
        
        /// <value>
        /// The IPv4 address for Oracle's end of the BGP session. Must use a /30 or /31
        /// subnet mask. If the session goes from Oracle to a customer's edge router,
        /// the customer specifies this information. If the session goes from Oracle to
        /// a provider's edge router, the provider specifies this.
        /// <br/>
        /// There's one exception: for a public virtual circuit, Oracle specifies the BGP IPv4 addresses.
        /// <br/>
        /// Example: 10.0.0.19/31
        /// </value>
        [JsonProperty(PropertyName = "oracleBgpPeeringIp")]
        public string OracleBgpPeeringIp { get; set; }
        
        /// <value>
        /// The BGP IPv6 address for the router on the other end of the BGP session from
        /// Oracle. Specified by the owner of that router. If the session goes from Oracle
        /// to a customer, this is the BGP IPv6 address of the customer's edge router. If the
        /// session goes from Oracle to a provider, this is the BGP IPv6 address of the
        /// provider's edge router. Only subnet masks from /64 up to /127 are allowed.
        /// <br/>
        /// There's one exception: for a public virtual circuit, Oracle specifies the BGP IPv6 addresses.
        /// <br/>
        /// Note that IPv6 addressing is currently supported only in certain regions. See
        /// [IPv6 Addresses](https://docs.cloud.oracle.com/Content/Network/Concepts/ipv6.htm).
        /// <br/>
        /// Example: 2001:db8::1/64
        /// </value>
        [JsonProperty(PropertyName = "customerBgpPeeringIpv6")]
        public string CustomerBgpPeeringIpv6 { get; set; }
        
        /// <value>
        /// The IPv6 address for Oracle's end of the BGP session.  Only subnet masks from /64 up to /127 are allowed.
        /// If the session goes from Oracle to a customer's edge router,
        /// the customer specifies this information. If the session goes from Oracle to
        /// a provider's edge router, the provider specifies this.
        /// <br/>
        /// There's one exception: for a public virtual circuit, Oracle specifies the BGP IPv6 addresses.
        /// <br/>
        /// Note that IPv6 addressing is currently supported only in certain regions. See
        /// [IPv6 Addresses](https://docs.cloud.oracle.com/Content/Network/Concepts/ipv6.htm).
        /// <br/>
        /// Example: 2001:db8::2/64
        /// </value>
        [JsonProperty(PropertyName = "oracleBgpPeeringIpv6")]
        public string OracleBgpPeeringIpv6 { get; set; }
        
        /// <value>
        /// The number of the specific VLAN (on the cross-connect or cross-connect group)
        /// that is assigned to this virtual circuit. Specified by the owner of the cross-connect
        /// or cross-connect group (the customer if the customer is colocated with Oracle, or
        /// the provider if the customer is connecting via provider).
        /// <br/>
        /// Example: 200
        /// </value>
        [JsonProperty(PropertyName = "vlan")]
        public System.Nullable<int> Vlan { get; set; }
        
    }
}
