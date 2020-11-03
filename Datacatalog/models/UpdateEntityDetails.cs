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
    /// Properties used in entity update operations.
    /// </summary>
    public class UpdateEntityDetails 
    {
        
        /// <value>
        /// A user-friendly display name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Detailed description of a data entity.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Last modified timestamp of the object in the external system.
        /// </value>
        [JsonProperty(PropertyName = "timeExternal")]
        public System.Nullable<System.DateTime> TimeExternal { get; set; }
        
        /// <value>
        /// Property to indicate if the object is a physical materialized object or virtual. For example, View.
        /// </value>
        [JsonProperty(PropertyName = "isLogical")]
        public System.Nullable<bool> IsLogical { get; set; }
        
        /// <value>
        /// Property to indicate if the object is a sub object of a parent physical object.
        /// </value>
        [JsonProperty(PropertyName = "isPartition")]
        public System.Nullable<bool> IsPartition { get; set; }
        
        /// <value>
        /// Key of the associated folder.
        /// </value>
        [JsonProperty(PropertyName = "folderKey")]
        public string FolderKey { get; set; }
        
        /// <value>
        /// Key of the associated pattern if this is a logical entity.
        /// </value>
        [JsonProperty(PropertyName = "patternKey")]
        public string PatternKey { get; set; }
        
        /// <value>
        /// The expression realized after resolving qualifiers . Used in deriving this logical entity
        /// </value>
        [JsonProperty(PropertyName = "realizedExpression")]
        public string RealizedExpression { get; set; }
        
        /// <value>
        /// Status of the object as updated by the harvest process. When an entity object is created, it's harvest status
        /// will indicate if the entity's metadata has been fully harvested or not. The harvest process can perform
        /// shallow harvesting to allow users to browse the metadata and can on-demand deep harvest on any object
        /// This requires a harvest status indicator for catalog objects.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "harvestStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<HarvestStatus> HarvestStatus { get; set; }
        
        /// <value>
        /// Key of the last harvest process to update this object.
        /// </value>
        [JsonProperty(PropertyName = "lastJobKey")]
        public string LastJobKey { get; set; }
        
        /// <value>
        /// The list of customized properties along with the values for this object
        /// </value>
        [JsonProperty(PropertyName = "customPropertyMembers")]
        public System.Collections.Generic.List<CustomPropertySetUsage> CustomPropertyMembers { get; set; }
        
        /// <value>
        /// A map of maps that contains the properties which are specific to the entity type. Each entity type
        /// definition defines it's set of required and optional properties. The map keys are category names and the
        /// values are maps of property name to property value. Every property is contained inside of a category. Most
        /// entities have required properties within the \"default\" category. To determine the set of required and
        /// optional properties for an entity type, a query can be done on '/types?type=dataEntity' that returns a
        /// collection of all entity types. The appropriate entity type, which includes definitions of all of
        /// it's properties, can be identified from this collection.
        /// Example: {&quot;properties&quot;: { &quot;default&quot;: { &quot;key1&quot;: &quot;value1&quot;}}}
        /// </value>
        [JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> Properties { get; set; }
        
    }
}
