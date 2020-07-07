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


namespace Oci.OcvpService.Models
{
    /// <summary>
    /// The SDDC information to be updated.
    /// <br/>
    /// **Important:** Only the `displayName`, `freeFormTags`, and `definedTags` attributes
    /// affect the existing SDDC. Changing the other attributes affects the `Sddc` object, but not
    /// the VMware environment currently running on that SDDC. Those other attributes are used
    /// by the Oracle Cloud VMware Solution *only* for new ESXi hosts that you add to this
    /// SDDC in the future with {@link #createEsxiHost(CreateEsxiHostRequest) createEsxiHost}.
    /// 
    /// </summary>
    public class UpdateSddcDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the SDDC.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// The version of bundled VMware software that the Oracle Cloud VMware Solution will
        /// install on any new ESXi hosts that you add to this SDDC in the future.
        /// <br/>
        /// For the list of versions supported by the Oracle Cloud VMware Solution, see
        /// {@link #listSupportedVmwareSoftwareVersions(ListSupportedVmwareSoftwareVersionsRequest) listSupportedVmwareSoftwareVersions}).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vmwareSoftwareVersion")]
        public string VmwareSoftwareVersion { get; set; }

        /// <value>
        /// One or more public SSH keys to be included in the `~/.ssh/authorized_keys` file for
        /// the default user on each ESXi host, only when adding new ESXi hosts to this SDDC.
        /// Use a newline character to separate multiple keys.
        /// The SSH keys must be in the format required for the `authorized_keys` file.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sshAuthorizedKeys")]
        public string SshAuthorizedKeys { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN to use for
        /// the vSphere component of the VMware environment when adding new ESXi hosts to the SDDC.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vsphereVlanId")]
        public string VsphereVlanId { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN to use for
        /// the vMotion component of the VMware environment when adding new ESXi hosts to the SDDC.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vmotionVlanId")]
        public string VmotionVlanId { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN to use for
        /// the vSAN component of the VMware environment when adding new ESXi hosts to the SDDC.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vsanVlanId")]
        public string VsanVlanId { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN to use for
        /// the NSX VTEP component of the VMware environment when adding new ESXi hosts to the SDDC.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsxVTepVlanId")]
        public string NsxVTepVlanId { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN to use for
        /// the NSX Edge VTEP component of the VMware environment when adding new ESXi hosts to the SDDC.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsxEdgeVTepVlanId")]
        public string NsxEdgeVTepVlanId { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN to use for
        /// the NSX Edge Uplink 1 component of the VMware environment when adding new ESXi hosts to the SDDC.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsxEdgeUplink1VlanId")]
        public string NsxEdgeUplink1VlanId { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN to use for
        /// the NSX Edge Uplink 2 component of the VMware environment when adding new ESXi hosts to the SDDC.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsxEdgeUplink2VlanId")]
        public string NsxEdgeUplink2VlanId { get; set; }

        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }

        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
    }
}