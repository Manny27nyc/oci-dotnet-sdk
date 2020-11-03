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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Details for the MYSQL data asset type.
    /// </summary>
    public class DataAssetFromMySQL : DataAsset
    {
        
        /// <value>
        /// The generic JDBC host name.
        /// </value>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <value>
        /// The generic JDBC port number.
        /// </value>
        [JsonProperty(PropertyName = "port")]
        public string Port { get; set; }
        
        /// <value>
        /// The generic JDBC service name for the database.
        /// </value>
        [JsonProperty(PropertyName = "serviceName")]
        public string ServiceName { get; set; }
        
        [JsonProperty(PropertyName = "defaultConnection")]
        public ConnectionFromMySQLDetails DefaultConnection { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "MYSQL_DATA_ASSET";
    }
}
