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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Information about the attaching the private endpoint resource to a catalog
    /// </summary>
    public class AttachCatalogPrivateEndpointDetails 
    {
        
        /// <value>
        /// The identifier of the private endpoint to be attached to the catalog resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CatalogPrivateEndpointId is required.")]
        [JsonProperty(PropertyName = "catalogPrivateEndpointId")]
        public string CatalogPrivateEndpointId { get; set; }
        
    }
}
