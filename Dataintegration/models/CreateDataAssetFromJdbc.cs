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
    /// Details for the generic JDBC data asset type.
    /// </summary>
    public class CreateDataAssetFromJdbc : CreateDataAssetDetails
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
        /// The data asset type for the generic JDBC data asset.
        /// </value>
        [JsonProperty(PropertyName = "dataAssetType")]
        public string DataAssetType { get; set; }

        [JsonProperty(PropertyName = "defaultConnection")]
        public CreateConnectionFromJdbc DefaultConnection { get; set; }
    }
}
