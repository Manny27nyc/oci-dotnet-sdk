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


namespace Oci.LoggingService.Models
{
    /// <summary>
    /// Summary of services that are integrated with public logging.
    /// </summary>
    public class ServiceSummary 
    {
        
        /// <value>
        /// Tenant OCID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TenantId is required.")]
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }
        
        /// <value>
        /// Apollo project namespace, if any.
        /// </value>
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// Service ID as set in Service Principal.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServicePrincipalName is required.")]
        [JsonProperty(PropertyName = "servicePrincipalName")]
        public string ServicePrincipalName { get; set; }
        
        /// <value>
        /// Service endpoint.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Endpoint is required.")]
        [JsonProperty(PropertyName = "endpoint")]
        public string Endpoint { get; set; }
        
        /// <value>
        /// User-friendly service name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Service ID.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Type of resource that a service provides.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceTypes is required.")]
        [JsonProperty(PropertyName = "resourceTypes")]
        public System.Collections.Generic.List<ResourceType> ResourceTypes { get; set; }
        
    }
}
