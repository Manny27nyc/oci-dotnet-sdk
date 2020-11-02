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
    /// Properties used in data asset create operations.
    /// </summary>
    public class CreateDataAssetDetails 
    {
        
        /// <value>
        /// A user-friendly display name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Detailed description of the data asset.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The key of the data asset type. This can be obtained via the '/types' endpoint.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TypeKey is required.")]
        [JsonProperty(PropertyName = "typeKey")]
        public string TypeKey { get; set; }
        
        /// <value>
        /// The list of customized properties along with the values for this object
        /// </value>
        [JsonProperty(PropertyName = "customPropertyMembers")]
        public System.Collections.Generic.List<CustomPropertySetUsage> CustomPropertyMembers { get; set; }
        
        /// <value>
        /// A map of maps that contains the properties which are specific to the data asset type. Each data asset type
        /// definition defines it's set of required and optional properties. The map keys are category names and the
        /// values are maps of property name to property value. Every property is contained inside of a category. Most
        /// data assets have required properties within the \"default\" category. To determine the set of optional and
        /// required properties for a data asset type, a query can be done on '/types?type=dataAsset' that returns a
        /// collection of all data asset types. The appropriate data asset type, which includes definitions of all of
        /// it's properties, can be identified from this collection.
        /// Example: {&quot;properties&quot;: { &quot;default&quot;: { &quot;host&quot;: &quot;host1&quot;, &quot;port&quot;: &quot;1521&quot;, &quot;database&quot;: &quot;orcl&quot;}}}
        /// </value>
        [JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> Properties { get; set; }
        
    }
}
