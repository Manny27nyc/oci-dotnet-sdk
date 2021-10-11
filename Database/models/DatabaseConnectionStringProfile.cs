/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// The connection string profile to allow clients to group, filter and select connection string values based on structured metadata.
    /// 
    /// </summary>
    public class DatabaseConnectionStringProfile 
    {
        
        /// <value>
        /// A user-friendly name for the connection.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Connection string value.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Value is required.")]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
                ///
        /// <value>
        /// Consumer group used by the connection.
        /// </value>
        ///
        public enum ConsumerGroupEnum {
            [EnumMember(Value = "HIGH")]
            High,
            [EnumMember(Value = "MEDIUM")]
            Medium,
            [EnumMember(Value = "LOW")]
            Low,
            [EnumMember(Value = "TP")]
            Tp,
            [EnumMember(Value = "TPURGENT")]
            Tpurgent
        };

        /// <value>
        /// Consumer group used by the connection.
        /// </value>
        [JsonProperty(PropertyName = "consumerGroup")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ConsumerGroupEnum> ConsumerGroup { get; set; }
                ///
        /// <value>
        /// Protocol used by the connection.
        /// </value>
        ///
        public enum ProtocolEnum {
            [EnumMember(Value = "TCP")]
            Tcp,
            [EnumMember(Value = "TCPS")]
            Tcps
        };

        /// <value>
        /// Protocol used by the connection.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Protocol is required.")]
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ProtocolEnum> Protocol { get; set; }
                ///
        /// <value>
        /// Specifies whether the TLS handshake is using one-way (`SERVER`) or mutual (`MUTUAL`) authentication.
        /// </value>
        ///
        public enum TlsAuthenticationEnum {
            [EnumMember(Value = "SERVER")]
            Server,
            [EnumMember(Value = "MUTUAL")]
            Mutual
        };

        /// <value>
        /// Specifies whether the TLS handshake is using one-way (`SERVER`) or mutual (`MUTUAL`) authentication.
        /// </value>
        [JsonProperty(PropertyName = "tlsAuthentication")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TlsAuthenticationEnum> TlsAuthentication { get; set; }
                ///
        /// <value>
        /// Host format used in connection string.
        /// </value>
        ///
        public enum HostFormatEnum {
            [EnumMember(Value = "FQDN")]
            Fqdn,
            [EnumMember(Value = "IP")]
            Ip
        };

        /// <value>
        /// Host format used in connection string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HostFormat is required.")]
        [JsonProperty(PropertyName = "hostFormat")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<HostFormatEnum> HostFormat { get; set; }
                ///
        /// <value>
        /// Specifies whether the listener performs a direct hand-off of the session, or redirects the session. In RAC deployments where SCAN is used, sessions are redirected to a Node VIP. Use `DIRECT` for direct hand-offs. Use `REDIRECT` to redirect the session.
        /// </value>
        ///
        public enum SessionModeEnum {
            [EnumMember(Value = "DIRECT")]
            Direct,
            [EnumMember(Value = "REDIRECT")]
            Redirect
        };

        /// <value>
        /// Specifies whether the listener performs a direct hand-off of the session, or redirects the session. In RAC deployments where SCAN is used, sessions are redirected to a Node VIP. Use `DIRECT` for direct hand-offs. Use `REDIRECT` to redirect the session.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SessionMode is required.")]
        [JsonProperty(PropertyName = "sessionMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SessionModeEnum> SessionMode { get; set; }
                ///
        /// <value>
        /// Specifies whether the connection string is using the long (`LONG`), Easy Connect (`EZCONNECT`), or Easy Connect Plus (`EZCONNECTPLUS`) format.
        /// Autonomous Databases on shared Exadata infrastructure always use the long format.
        /// 
        /// </value>
        ///
        public enum SyntaxFormatEnum {
            [EnumMember(Value = "LONG")]
            Long,
            [EnumMember(Value = "EZCONNECT")]
            Ezconnect,
            [EnumMember(Value = "EZCONNECTPLUS")]
            Ezconnectplus
        };

        /// <value>
        /// Specifies whether the connection string is using the long (`LONG`), Easy Connect (`EZCONNECT`), or Easy Connect Plus (`EZCONNECTPLUS`) format.
        /// Autonomous Databases on shared Exadata infrastructure always use the long format.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SyntaxFormat is required.")]
        [JsonProperty(PropertyName = "syntaxFormat")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SyntaxFormatEnum> SyntaxFormat { get; set; }
        
    }
}