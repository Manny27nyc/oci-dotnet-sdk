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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Partial information about the database which includes id, name, type.
    /// </summary>
    public class DatabaseDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseId is required.")]
        [JsonProperty(PropertyName = "databaseId")]
        public string DatabaseId { get; set; }
        
        /// <value>
        /// The database name. The database name is unique within the tenancy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseName is required.")]
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }
        
        /// <value>
        /// The user-friendly name for the database. The name does not have to be unique.
        /// </value>
        [JsonProperty(PropertyName = "databaseDisplayName")]
        public string DatabaseDisplayName { get; set; }
        
        /// <value>
        /// Operations Insights internal representation of the database type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseType is required.")]
        [JsonProperty(PropertyName = "databaseType")]
        public string DatabaseType { get; set; }
        
        /// <value>
        /// The version of the database.
        /// </value>
        [JsonProperty(PropertyName = "databaseVersion")]
        public string DatabaseVersion { get; set; }
        
    }
}
