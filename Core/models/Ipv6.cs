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
    /// An *IPv6* is a conceptual term that refers to an IPv6 address and related properties.
    /// The `IPv6` object is the API representation of an IPv6.
    /// <br/>
    /// You can create and assign an IPv6 to any VNIC that is in an IPv6-enabled subnet in an
    /// IPv6-enabled VCN.
    /// <br/>
    /// **Note:** IPv6 addressing is currently supported only in certain regions. For important
    /// details about IPv6 addressing in a VCN, see [IPv6 Addresses](https://docs.cloud.oracle.com/Content/Network/Concepts/ipv6.htm).
    /// 
    /// </summary>
    public class Ipv6 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment containing the IPv6.
        /// This is the same as the VNIC's compartment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable. Avoid
        /// entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the IPv6.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The IPv6 address of the `IPv6` object. The address is within the private IPv6 CIDR block
        /// of the VNIC's subnet (see the `ipv6CidrBlock` attribute for the {@link Subnet}
        /// object).
        /// <br/>
        /// Example: 2001:0db8:0123:1111:abcd:ef01:2345:6789
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IpAddress is required.")]
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
        
        /// <value>
        /// Whether the IPv6 can be used for internet communication. Allowed by default for an IPv6 in
        /// a public subnet. Never allowed for an IPv6 in a private subnet. If the value is `true`, the
        /// IPv6 uses its public IP address for internet communication.
        /// <br/>
        /// Example: true
        /// </value>
        [JsonProperty(PropertyName = "isInternetAccessAllowed")]
        public System.Nullable<bool> IsInternetAccessAllowed { get; set; }
                ///
        /// <value>
        /// The IPv6's current state.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated
        };

        /// <value>
        /// The IPv6's current state.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The IPv6 address to be used for internet communication. The address is within the public
        /// IPv6 CIDR block of the VNIC's subnet (see the `ipv6PublicCidrBlock` attribute for the
        /// {@link Subnet} object).
        /// <br/>
        /// If your organization did NOT assign a custom IPv6 CIDR to the VCN for the private address
        /// space, Oracle provides the IPv6 CIDR and uses that same CIDR for the private and public
        /// address space. Therefore the `publicIpAddress` would be the same as the `ipAddress`.
        /// <br/>
        /// If your organization assigned a custom IPv6 CIDR to the VCN for the private address space,
        /// the right 80 bits of the IPv6 public IP (the subnet and address bits) are the same as for
        /// the `ipAddress`. But the left 48 bits are from the public IPv6 CIDR that Oracle assigned
        /// to the VCN.
        /// <br/>
        /// This is null if the IPv6 is created with `isInternetAccessAllowed` set to `false`.
        /// <br/>
        /// Example: 2001:0db8:0123:1111:abcd:ef01:2345:6789
        /// </value>
        [JsonProperty(PropertyName = "publicIpAddress")]
        public string PublicIpAddress { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the subnet the VNIC is in.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// The date and time the IPv6 was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VNIC the IPv6 is assigned to.
        /// The VNIC and IPv6 must be in the same subnet.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VnicId is required.")]
        [JsonProperty(PropertyName = "vnicId")]
        public string VnicId { get; set; }
        
    }
}
