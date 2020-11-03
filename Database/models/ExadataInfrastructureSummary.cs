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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Details of the Exadata Cloud@Customer infrastructure.
    /// </summary>
    public class ExadataInfrastructureSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Exadata infrastructure.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
                ///
        /// <value>
        /// The current lifecycle state of the Exadata infrastructure.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "REQUIRES_ACTIVATION")]
            RequiresActivation,
            [EnumMember(Value = "ACTIVATING")]
            Activating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "ACTIVATION_FAILED")]
            ActivationFailed,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "DISCONNECTED")]
            Disconnected
        };

        /// <value>
        /// The current lifecycle state of the Exadata infrastructure.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The user-friendly name for the Exadata Cloud@Customer infrastructure. The name does not need to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The shape of the Exadata infrastructure. The shape determines the amount of CPU, storage, and memory resources allocated to the instance.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Shape is required.")]
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        /// <value>
        /// The time zone of the Exadata infrastructure. For details, see [Exadata Infrastructure Time Zones](https://docs.cloud.oracle.com/Content/Database/References/timezones.htm).
        /// </value>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }
        
        /// <value>
        /// The number of enabled CPU cores.
        /// </value>
        [JsonProperty(PropertyName = "cpusEnabled")]
        public System.Nullable<int> CpusEnabled { get; set; }
        
        /// <value>
        /// The total number of CPU cores available.
        /// </value>
        [JsonProperty(PropertyName = "maxCpuCount")]
        public System.Nullable<int> MaxCpuCount { get; set; }
        
        /// <value>
        /// The memory allocated in GBs.
        /// </value>
        [JsonProperty(PropertyName = "memorySizeInGBs")]
        public System.Nullable<int> MemorySizeInGBs { get; set; }
        
        /// <value>
        /// The total memory available in GBs.
        /// </value>
        [JsonProperty(PropertyName = "maxMemoryInGBs")]
        public System.Nullable<int> MaxMemoryInGBs { get; set; }
        
        /// <value>
        /// The local node storage allocated in GBs.
        /// </value>
        [JsonProperty(PropertyName = "dbNodeStorageSizeInGBs")]
        public System.Nullable<int> DbNodeStorageSizeInGBs { get; set; }
        
        /// <value>
        /// The total local node storage available in GBs.
        /// </value>
        [JsonProperty(PropertyName = "maxDbNodeStorageInGBs")]
        public System.Nullable<int> MaxDbNodeStorageInGBs { get; set; }
        
        /// <value>
        /// Size, in terabytes, of the DATA disk group.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dataStorageSizeInTBs")]
        public System.Double DataStorageSizeInTBs { get; set; }
        
        /// <value>
        /// The total available DATA disk group size.
        /// </value>
        [JsonProperty(PropertyName = "maxDataStorageInTBs")]
        public System.Double MaxDataStorageInTBs { get; set; }
        
        /// <value>
        /// The IP address for the first control plane server.
        /// </value>
        [JsonProperty(PropertyName = "cloudControlPlaneServer1")]
        public string CloudControlPlaneServer1 { get; set; }
        
        /// <value>
        /// The IP address for the second control plane server.
        /// </value>
        [JsonProperty(PropertyName = "cloudControlPlaneServer2")]
        public string CloudControlPlaneServer2 { get; set; }
        
        /// <value>
        /// The netmask for the control plane network.
        /// </value>
        [JsonProperty(PropertyName = "netmask")]
        public string Netmask { get; set; }
        
        /// <value>
        /// The gateway for the control plane network.
        /// </value>
        [JsonProperty(PropertyName = "gateway")]
        public string Gateway { get; set; }
        
        /// <value>
        /// The CIDR block for the Exadata administration network.
        /// </value>
        [JsonProperty(PropertyName = "adminNetworkCIDR")]
        public string AdminNetworkCIDR { get; set; }
        
        /// <value>
        /// The CIDR block for the Exadata InfiniBand interconnect.
        /// </value>
        [JsonProperty(PropertyName = "infiniBandNetworkCIDR")]
        public string InfiniBandNetworkCIDR { get; set; }
        
        /// <value>
        /// The corporate network proxy for access to the control plane network.
        /// </value>
        [JsonProperty(PropertyName = "corporateProxy")]
        public string CorporateProxy { get; set; }
        
        /// <value>
        /// The list of DNS server IP addresses. Maximum of 3 allowed.
        /// </value>
        [JsonProperty(PropertyName = "dnsServer")]
        public System.Collections.Generic.List<string> DnsServer { get; set; }
        
        /// <value>
        /// The list of NTP server IP addresses. Maximum of 3 allowed.
        /// </value>
        [JsonProperty(PropertyName = "ntpServer")]
        public System.Collections.Generic.List<string> NtpServer { get; set; }
        
        /// <value>
        /// The date and time the Exadata infrastructure was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The CSI Number of the Exadata infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "csiNumber")]
        public string CsiNumber { get; set; }
        
        /// <value>
        /// The list of contacts for the Exadata infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "contacts")]
        public System.Collections.Generic.List<ExadataInfrastructureContact> Contacts { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
