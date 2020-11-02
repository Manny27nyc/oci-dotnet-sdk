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


namespace Oci.ContainerengineService.Models
{
    /// <summary>
    /// A Kubernetes cluster. Avoid entering confidential information.
    /// </summary>
    public class Cluster 
    {
        
        /// <value>
        /// The OCID of the cluster.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The name of the cluster.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The OCID of the compartment in which the cluster exists.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The OCID of the virtual cloud network (VCN) in which the cluster exists.
        /// </value>
        [JsonProperty(PropertyName = "vcnId")]
        public string VcnId { get; set; }
        
        /// <value>
        /// The version of Kubernetes running on the cluster masters.
        /// </value>
        [JsonProperty(PropertyName = "kubernetesVersion")]
        public string KubernetesVersion { get; set; }
        
        /// <value>
        /// The OCID of the KMS key to be used as the master encryption key for Kubernetes secret encryption.
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
        
        /// <value>
        /// Optional attributes for the cluster.
        /// </value>
        [JsonProperty(PropertyName = "options")]
        public ClusterCreateOptions Options { get; set; }
        
        /// <value>
        /// Metadata about the cluster.
        /// </value>
        [JsonProperty(PropertyName = "metadata")]
        public ClusterMetadata Metadata { get; set; }
        
        /// <value>
        /// The state of the cluster masters.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ClusterLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Details about the state of the cluster masters.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// Endpoints served up by the cluster masters.
        /// </value>
        [JsonProperty(PropertyName = "endpoints")]
        public ClusterEndpoints Endpoints { get; set; }
        
        /// <value>
        /// Available Kubernetes versions to which the clusters masters may be upgraded.
        /// </value>
        [JsonProperty(PropertyName = "availableKubernetesUpgrades")]
        public System.Collections.Generic.List<string> AvailableKubernetesUpgrades { get; set; }
        
    }
}
