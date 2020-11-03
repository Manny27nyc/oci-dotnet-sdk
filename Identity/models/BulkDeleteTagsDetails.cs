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


namespace Oci.IdentityService.Models
{
    /// <summary>
    /// Properties for deleting tags in bulk
    /// </summary>
    public class BulkDeleteTagsDetails 
    {
        
        /// <value>
        /// The OCIDs of the tag definitions to delete
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TagDefinitionIds is required.")]
        [JsonProperty(PropertyName = "tagDefinitionIds")]
        public System.Collections.Generic.List<string> TagDefinitionIds { get; set; }
        
    }
}
