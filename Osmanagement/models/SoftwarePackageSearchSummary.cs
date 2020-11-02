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


namespace Oci.OsmanagementService.Models
{
    /// <summary>
    /// Summary information for a software package
    /// </summary>
    public class SoftwarePackageSearchSummary 
    {
        
        /// <value>
        /// Package name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Unique identifier for the package. NOTE - This is not an OCID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Type of the package
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// Version of the package
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Version is required.")]
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// the architecture for which this software was built
        /// </value>
        [JsonProperty(PropertyName = "architecture")]
        public string Architecture { get; set; }
        
        /// <value>
        /// a summary description of the software package
        /// </value>
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }
        
        /// <value>
        /// Type of the erratum.
        /// </value>
        [JsonProperty(PropertyName = "advisoryType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<UpdateTypes> AdvisoryType { get; set; }
        
        /// <value>
        /// List of errata containing this software package
        /// </value>
        [JsonProperty(PropertyName = "errata")]
        public System.Collections.Generic.List<Id> Errata { get; set; }
        
        /// <value>
        /// list of software sources that provide the software package
        /// </value>
        [JsonProperty(PropertyName = "softwareSources")]
        public System.Collections.Generic.List<SoftwareSourceId> SoftwareSources { get; set; }
        
    }
}
