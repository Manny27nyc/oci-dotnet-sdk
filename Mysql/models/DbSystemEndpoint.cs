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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// A particular functional endpoint for access to a DB System, and the properties that apply to it.
    /// 
    /// </summary>
    public class DbSystemEndpoint 
    {
        
        /// <value>
        /// The network address of the DB System.
        /// </value>
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }
        
        /// <value>
        /// The IP address the DB System is configured to listen on.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IpAddress is required.")]
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
        
        /// <value>
        /// The port the MySQL instance listens on.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Port is required.")]
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// The network port where to connect to use this endpoint using the X protocol.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PortX is required.")]
        [JsonProperty(PropertyName = "portX")]
        public System.Nullable<int> PortX { get; set; }
                ///
        ///
        public enum ModesEnum {
            [EnumMember(Value = "READ")]
            Read,
            [EnumMember(Value = "WRITE")]
            Write
        };

        /// <value>
        /// The access modes from the client that this endpoint supports.
        /// </value>
        [JsonProperty(PropertyName = "modes", ItemConverterType = typeof(StringEnumConverter))]
        public System.Collections.Generic.List<ModesEnum> Modes { get; set; }
                ///
        /// <value>
        /// The state of the endpoints, as far as it can seen from the DB System.
        /// There may be some inconsistency with the actual state of the MySQL service.
        /// 
        /// </value>
        ///
        public enum StatusEnum {
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "UPDATING")]
            Updating
        };

        /// <value>
        /// The state of the endpoints, as far as it can seen from the DB System.
        /// There may be some inconsistency with the actual state of the MySQL service.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// Additional information about the current endpoint status.
        /// </value>
        [JsonProperty(PropertyName = "statusDetails")]
        public string StatusDetails { get; set; }
        
    }
}
