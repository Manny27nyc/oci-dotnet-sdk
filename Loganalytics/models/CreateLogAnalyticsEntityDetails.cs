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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Details for new log analytics entity to be added.
    /// 
    /// </summary>
    public class CreateLogAnalyticsEntityDetails 
    {
        
        /// <value>
        /// Log analytics entity name. The name must be unique, within the tenancy, and cannot be changed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Compartment Identifier [OCID] (https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Log analytics entity type name.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EntityTypeName is required.")]
        [JsonProperty(PropertyName = "entityTypeName")]
        public string EntityTypeName { get; set; }
        
        /// <value>
        /// The OCID of the Management Agent.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "managementAgentId")]
        public string ManagementAgentId { get; set; }
        
        /// <value>
        /// The OCID of the Cloud resource which this entity is a representation of. This may be blank when the entity
        /// represents a non-cloud resource that the customer may have on their premises.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "cloudResourceId")]
        public string CloudResourceId { get; set; }
        
        /// <value>
        /// The timezone region of the log analytics entity.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timezoneRegion")]
        public string TimezoneRegion { get; set; }
        
        /// <value>
        /// The hostname where the entity represented here is actually present. This would be the output one would get if
        /// they run `echo $HOSTNAME` on Linux or an equivalent OS command. This may be different from
        /// management agents host since logs may be collected remotely.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }
        
        /// <value>
        /// This indicates the type of source. It is primarily for Enterprise Manager Repository ID.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceId")]
        public string SourceId { get; set; }
        
        /// <value>
        /// The name/value pairs for parameter values to be used in file patterns specified in log sources.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.Dictionary<string, string> Properties { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
