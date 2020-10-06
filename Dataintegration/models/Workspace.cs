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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// A workspace is an organizational construct to keep multiple data integration solutions and their resources (data assets, data flows, tasks, and so on) separate from each other, helping you to stay organized. For example, you could have separate workspaces for development, testing, and production.
    /// </summary>
    public class Workspace 
    {
        
        /// <value>
        /// The OCID of the VCN the subnet is in.
        /// </value>
        [JsonProperty(PropertyName = "vcnId")]
        public string VcnId { get; set; }

        /// <value>
        /// The OCID of the subnet for customer connected databases.
        /// </value>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }

        /// <value>
        /// The IP of the custom DNS.
        /// </value>
        [JsonProperty(PropertyName = "dnsServerIp")]
        public string DnsServerIp { get; set; }

        /// <value>
        /// The DNS zone of the custom DNS to use to resolve names.
        /// </value>
        [JsonProperty(PropertyName = "dnsServerZone")]
        public string DnsServerZone { get; set; }

        /// <value>
        /// Specifies whether the private network connection is enabled or disabled.
        /// </value>
        [JsonProperty(PropertyName = "isPrivateNetworkEnabled")]
        public System.Nullable<bool> IsPrivateNetworkEnabled { get; set; }

        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }

        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }

        /// <value>
        /// A detailed description for the workspace.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <value>
        /// A user-friendly display name for the workspace. Does not have to be unique, and can be modified. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// The OCID of the compartment containing the workspace.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// The date and time the workspace was created, in the timestamp format defined by RFC3339.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }

        /// <value>
        /// The date and time the workspace was updated, in the timestamp format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        ///
        /// <value>
        /// Lifecycle states for workspaces in Data Integration Service
        /// CREATING - The resource is being created and may not be usable until the entire metadata is defined
        /// UPDATING - The resource is being updated and may not be usable until all changes are commited
        /// DELETING - The resource is being deleted and might require deep cleanup of children.
        /// ACTIVE   - The resource is valid and available for access
        /// INACTIVE - The resource might be incomplete in its definition or might have been made unavailable for
        ///          administrative reasons
        /// DELETED  - The resource has been deleted and isn't available
        /// FAILED   - The resource is in a failed state due to validation or other errors
        /// STARTING - The resource is being started and may not be usable until becomes ACTIVE again
        /// STOPPING - The resource is in the process of Stopping and may not be usable until it Stops or fails
        /// STOPPED  - The resource is in Stopped state due to stop operation.
        /// 
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "STARTING")]
            Starting,
            [EnumMember(Value = "STOPPING")]
            Stopping,
            [EnumMember(Value = "STOPPED")]
            Stopped
        };

        /// <value>
        /// Lifecycle states for workspaces in Data Integration Service
        /// CREATING - The resource is being created and may not be usable until the entire metadata is defined
        /// UPDATING - The resource is being updated and may not be usable until all changes are commited
        /// DELETING - The resource is being deleted and might require deep cleanup of children.
        /// ACTIVE   - The resource is valid and available for access
        /// INACTIVE - The resource might be incomplete in its definition or might have been made unavailable for
        ///          administrative reasons
        /// DELETED  - The resource has been deleted and isn't available
        /// FAILED   - The resource is in a failed state due to validation or other errors
        /// STARTING - The resource is being started and may not be usable until becomes ACTIVE again
        /// STOPPING - The resource is in the process of Stopping and may not be usable until it Stops or fails
        /// STOPPED  - The resource is in Stopped state due to stop operation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }

        /// <value>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in failed state.
        /// </value>
        [JsonProperty(PropertyName = "stateMessage")]
        public string StateMessage { get; set; }

        /// <value>
        /// A system-generated and immutable identifier assigned to the workspace upon creation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }
}
