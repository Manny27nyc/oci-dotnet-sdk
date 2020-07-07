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


namespace Oci.ApplicationmigrationService.Models
{
    /// <summary>
    /// An application running in the source environment that is available for export.
    /// 
    /// </summary>
    public class SourceApplication 
    {
        
        /// <value>
        /// The name of the application
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// The type of application
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MigrationTypes> Type { get; set; }

        /// <value>
        /// Unique identifier (OCID) for the Source to which the application belongs
        /// </value>
        [JsonProperty(PropertyName = "sourceId")]
        public string SourceId { get; set; }

        /// <value>
        /// The version of the application server
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <value>
        /// The current application running state
        /// </value>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }
    }
}