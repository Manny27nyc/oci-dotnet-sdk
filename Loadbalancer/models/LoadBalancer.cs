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


namespace Oci.LoadbalancerService.Models
{
    /// <summary>
    /// The properties that define a load balancer. For more information, see
    /// [Managing a Load Balancer](https://docs.cloud.oracle.com/Content/Balance/Tasks/managingloadbalancer.htm).
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized,
    /// talk to an administrator. If you're an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// <br/>
    /// For information about endpoints and signing API requests, see
    /// [About the API](https://docs.cloud.oracle.com/Content/API/Concepts/usingapi.htm). For information about available SDKs and tools, see
    /// [SDKS and Other Tools](https://docs.cloud.oracle.com/Content/API/Concepts/sdks.htm).
    /// 
    /// </summary>
    public class LoadBalancer 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the load balancer.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment containing the load balancer.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A user-friendly name. It does not have to be unique, and it is changeable.
        /// <br/>
        /// Example: example_load_balancer
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
                ///
        /// <value>
        /// The current state of the load balancer.
        /// 
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <value>
        /// The current state of the load balancer.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the load balancer was created, in the format defined by RFC3339.
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
        /// An array of IP addresses.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ipAddresses")]
        public System.Collections.Generic.List<IpAddress> IpAddresses { get; set; }
        
        /// <value>
        /// A template that determines the total pre-provisioned bandwidth (ingress plus egress).
        /// To get a list of available shapes, use the {@link #listShapes(ListShapesRequest) listShapes}
        /// operation.
        /// <br/>
        /// Example: 100Mbps
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShapeName is required.")]
        [JsonProperty(PropertyName = "shapeName")]
        public string ShapeName { get; set; }
        
        /// <value>
        /// Whether the load balancer has a VCN-local (private) IP address.
        /// <br/>
        /// If \"true\", the service assigns a private IP address to the load balancer.
        /// <br/>
        /// If \"false\", the service assigns a public IP address to the load balancer.
        /// <br/>
        /// A public load balancer is accessible from the internet, depending on your VCN's
        /// [security list rules](https://docs.cloud.oracle.com/Content/Network/Concepts/securitylists.htm). For more information about public and
        /// private load balancers, see [How Load Balancing Works](https://docs.cloud.oracle.com/Content/Balance/Concepts/balanceoverview.htm#how-load-balancing-works).
        /// <br/>
        /// Example: true
        /// </value>
        [JsonProperty(PropertyName = "isPrivate")]
        public System.Nullable<bool> IsPrivate { get; set; }
        
        /// <value>
        /// An array of subnet [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        [JsonProperty(PropertyName = "subnetIds")]
        public System.Collections.Generic.List<string> SubnetIds { get; set; }
        
        /// <value>
        /// An array of NSG [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) associated with the load
        /// balancer.
        /// <br/>
        /// During the load balancer's creation, the service adds the new load balancer to the specified NSGs.
        /// <br/>
        /// The benefits of associating the load balancer with NSGs include:
        /// <br/>
        /// *  NSGs define network security rules to govern ingress and egress traffic for the load balancer.
        /// <br/>
        /// *  The network security rules of other resources can reference the NSGs associated with the load balancer
        ///    to ensure access.
        /// <br/>
        /// Example: [&quot;ocid1.nsg.oc1.phx.unique_ID&quot;]
        /// </value>
        [JsonProperty(PropertyName = "networkSecurityGroupIds")]
        public System.Collections.Generic.List<string> NetworkSecurityGroupIds { get; set; }
        
        [JsonProperty(PropertyName = "listeners")]
        public System.Collections.Generic.Dictionary<string, Listener> Listeners { get; set; }
        
        [JsonProperty(PropertyName = "hostnames")]
        public System.Collections.Generic.Dictionary<string, Hostname> Hostnames { get; set; }
        
        [JsonProperty(PropertyName = "sslCipherSuites")]
        public System.Collections.Generic.Dictionary<string, SSLCipherSuite> SslCipherSuites { get; set; }
        
        [JsonProperty(PropertyName = "certificates")]
        public System.Collections.Generic.Dictionary<string, Certificate> Certificates { get; set; }
        
        [JsonProperty(PropertyName = "backendSets")]
        public System.Collections.Generic.Dictionary<string, BackendSet> BackendSets { get; set; }
        
        [JsonProperty(PropertyName = "pathRouteSets")]
        public System.Collections.Generic.Dictionary<string, PathRouteSet> PathRouteSets { get; set; }
        
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
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// System tags can be viewed by users, but can only be created by the system.
        /// <br/>
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
        [JsonProperty(PropertyName = "ruleSets")]
        public System.Collections.Generic.Dictionary<string, RuleSet> RuleSets { get; set; }
        
    }
}
