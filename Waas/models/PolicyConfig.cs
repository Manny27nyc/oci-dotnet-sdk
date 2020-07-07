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


namespace Oci.WaasService.Models
{
    /// <summary>
    /// The configuration details for the WAAS policy.
    /// </summary>
    public class PolicyConfig 
    {
        
        /// <value>
        /// The OCID of the SSL certificate to use if HTTPS is supported.
        /// </value>
        [JsonProperty(PropertyName = "certificateId")]
        public string CertificateId { get; set; }

        /// <value>
        /// Enable or disable HTTPS support. If true, a `certificateId` is required. If unspecified, defaults to `false`.
        /// </value>
        [JsonProperty(PropertyName = "isHttpsEnabled")]
        public System.Nullable<bool> IsHttpsEnabled { get; set; }

        /// <value>
        /// Force HTTP to HTTPS redirection. If unspecified, defaults to `false`.
        /// </value>
        [JsonProperty(PropertyName = "isHttpsForced")]
        public System.Nullable<bool> IsHttpsForced { get; set; }
        ///
        ///
        public enum TlsProtocolsEnum {
            [EnumMember(Value = "TLS_V1")]
            TlsV1,
            [EnumMember(Value = "TLS_V1_1")]
            TlsV11,
            [EnumMember(Value = "TLS_V1_2")]
            TlsV12,
            [EnumMember(Value = "TLS_V1_3")]
            TlsV13
        };

        /// <value>
        /// A list of allowed TLS protocols. Only applicable when HTTPS support is enabled.
        /// The TLS protocol is negotiated while the request is connecting and the most recent protocol supported by both the edge node and client browser will be selected. If no such version exists, the connection will be aborted.
        /// - **TLS_V1:** corresponds to TLS 1.0 specification.
        /// <br/>
        /// - **TLS_V1_1:** corresponds to TLS 1.1 specification.
        /// <br/>
        /// - **TLS_V1_2:** corresponds to TLS 1.2 specification.
        /// <br/>
        /// - **TLS_V1_3:** corresponds to TLS 1.3 specification.
        /// <br/>
        /// Enabled TLS protocols must go in a row. For example if `TLS_v1_1` and `TLS_V1_3` are enabled, `TLS_V1_2` must be enabled too.
        /// </value>
        [JsonProperty(PropertyName = "tlsProtocols", ItemConverterType = typeof(StringEnumConverter))]
        public System.Collections.Generic.List<TlsProtocolsEnum> TlsProtocols { get; set; }

        /// <value>
        /// Enable or disable GZIP compression of origin responses. If enabled, the header `Accept-Encoding: gzip` is sent to origin, otherwise, the empty `Accept-Encoding:` header is used.
        /// </value>
        [JsonProperty(PropertyName = "isOriginCompressionEnabled")]
        public System.Nullable<bool> IsOriginCompressionEnabled { get; set; }

        /// <value>
        /// Enabling `isBehindCdn` allows for the collection of IP addresses from client requests if the WAF is connected to a CDN.
        /// </value>
        [JsonProperty(PropertyName = "isBehindCdn")]
        public System.Nullable<bool> IsBehindCdn { get; set; }
        ///
        /// <value>
        /// Specifies an HTTP header name which is treated as the connecting client's IP address. Applicable only if `isBehindCdn` is enabled.
        /// <br/>
        /// The edge node reads this header and its value and sets the client IP address as specified. It does not create the header if the header is not present in the request. If the header is not present, the connecting IP address will be used as the client's true IP address. It uses the last IP address in the header's value as the true IP address.
        /// <br/>
        /// Example: X-Client-Ip: 11.1.1.1, 13.3.3.3In the case of multiple headers with the same name, only the first header will be used. It is assumed that CDN sets the correct client IP address to prevent spoofing.- **X_FORWARDED_FOR:** Corresponds to X-Forwarded-For header name.- **X_CLIENT_IP:** Corresponds to X-Client-Ip header name.- **X_REAL_IP:** Corresponds to X-Real-Ip header name.- **CLIENT_IP:** Corresponds to Client-Ip header name.- **TRUE_CLIENT_IP:** Corresponds to True-Client-Ip header name.
        /// </value>
        ///
        public enum ClientAddressHeaderEnum {
            [EnumMember(Value = "X_FORWARDED_FOR")]
            XForwardedFor,
            [EnumMember(Value = "X_CLIENT_IP")]
            XClientIp,
            [EnumMember(Value = "X_REAL_IP")]
            XRealIp,
            [EnumMember(Value = "CLIENT_IP")]
            ClientIp,
            [EnumMember(Value = "TRUE_CLIENT_IP")]
            TrueClientIp
        };

        /// <value>
        /// Specifies an HTTP header name which is treated as the connecting client's IP address. Applicable only if `isBehindCdn` is enabled.
        /// <br/>
        /// The edge node reads this header and its value and sets the client IP address as specified. It does not create the header if the header is not present in the request. If the header is not present, the connecting IP address will be used as the client's true IP address. It uses the last IP address in the header's value as the true IP address.
        /// <br/>
        /// Example: X-Client-Ip: 11.1.1.1, 13.3.3.3In the case of multiple headers with the same name, only the first header will be used. It is assumed that CDN sets the correct client IP address to prevent spoofing.- **X_FORWARDED_FOR:** Corresponds to X-Forwarded-For header name.- **X_CLIENT_IP:** Corresponds to X-Client-Ip header name.- **X_REAL_IP:** Corresponds to X-Real-Ip header name.- **CLIENT_IP:** Corresponds to Client-Ip header name.- **TRUE_CLIENT_IP:** Corresponds to True-Client-Ip header name.
        /// </value>
        [JsonProperty(PropertyName = "clientAddressHeader")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ClientAddressHeaderEnum> ClientAddressHeader { get; set; }

        /// <value>
        /// Enable or disable automatic content caching based on the response `cache-control` header. This feature enables the origin to act as a proxy cache. Caching is usually defined using `cache-control` header. For example `cache-control: max-age=120` means that the returned resource is valid for 120 seconds. Caching rules will overwrite this setting.
        /// </value>
        [JsonProperty(PropertyName = "isCacheControlRespected")]
        public System.Nullable<bool> IsCacheControlRespected { get; set; }

        /// <value>
        /// Enable or disable buffering of responses from the origin. Buffering improves overall stability in case of network issues, but slightly increases Time To First Byte.
        /// </value>
        [JsonProperty(PropertyName = "isResponseBufferingEnabled")]
        public System.Nullable<bool> IsResponseBufferingEnabled { get; set; }
        ///
        /// <value>
        /// The set cipher group for the configured TLS protocol. This sets the configuration for the TLS connections between clients and edge nodes only.
        /// - **DEFAULT:** Cipher group supports TLS 1.0, TLS 1.1, TLS 1.2, TLS 1.3 protocols. It has the following ciphers enabled: `ECDHE-RSA-AES128-GCM-SHA256:ECDHE-ECDSA-AES128-GCM-SHA256:ECDHE-RSA-AES256-GCM-SHA384:ECDHE-ECDSA-AES256-GCM-SHA384:DHE-RSA-AES128-GCM-SHA256:DHE-DSS-AES128-GCM-SHA256:kEDH+AESGCM:ECDHE-RSA-AES128-SHA256:ECDHE-ECDSA-AES128-SHA256:ECDHE-RSA-AES128-SHA:ECDHE-ECDSA-AES128-SHA:ECDHE-RSA-AES256-SHA384:ECDHE-ECDSA-AES256-SHA384:ECDHE-RSA-AES256-SHA:ECDHE-ECDSA-AES256-SHA:DHE-RSA-AES128-SHA256:DHE-RSA-AES128-SHA:DHE-DSS-AES128-SHA256:DHE-RSA-AES256-SHA256:DHE-DSS-AES256-SHA:DHE-RSA-AES256-SHA:AES128-GCM-SHA256:AES256-GCM-SHA384:AES128-SHA256:AES256-SHA256:AES128-SHA:AES256-SHA:AES:CAMELLIA:!DES-CBC3-SHA:!aNULL:!eNULL:!EXPORT:!DES:!RC4:!MD5:!PSK:!aECDH:!EDH-DSS-DES-CBC3-SHA:!EDH-RSA-DES-CBC3-SHA:!KRB5-DES-CBC3-SHA`
        /// </value>
        ///
        public enum CipherGroupEnum {
            [EnumMember(Value = "DEFAULT")]
            Default
        };

        /// <value>
        /// The set cipher group for the configured TLS protocol. This sets the configuration for the TLS connections between clients and edge nodes only.
        /// - **DEFAULT:** Cipher group supports TLS 1.0, TLS 1.1, TLS 1.2, TLS 1.3 protocols. It has the following ciphers enabled: `ECDHE-RSA-AES128-GCM-SHA256:ECDHE-ECDSA-AES128-GCM-SHA256:ECDHE-RSA-AES256-GCM-SHA384:ECDHE-ECDSA-AES256-GCM-SHA384:DHE-RSA-AES128-GCM-SHA256:DHE-DSS-AES128-GCM-SHA256:kEDH+AESGCM:ECDHE-RSA-AES128-SHA256:ECDHE-ECDSA-AES128-SHA256:ECDHE-RSA-AES128-SHA:ECDHE-ECDSA-AES128-SHA:ECDHE-RSA-AES256-SHA384:ECDHE-ECDSA-AES256-SHA384:ECDHE-RSA-AES256-SHA:ECDHE-ECDSA-AES256-SHA:DHE-RSA-AES128-SHA256:DHE-RSA-AES128-SHA:DHE-DSS-AES128-SHA256:DHE-RSA-AES256-SHA256:DHE-DSS-AES256-SHA:DHE-RSA-AES256-SHA:AES128-GCM-SHA256:AES256-GCM-SHA384:AES128-SHA256:AES256-SHA256:AES128-SHA:AES256-SHA:AES:CAMELLIA:!DES-CBC3-SHA:!aNULL:!eNULL:!EXPORT:!DES:!RC4:!MD5:!PSK:!aECDH:!EDH-DSS-DES-CBC3-SHA:!EDH-RSA-DES-CBC3-SHA:!KRB5-DES-CBC3-SHA`
        /// </value>
        [JsonProperty(PropertyName = "cipherGroup")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<CipherGroupEnum> CipherGroup { get; set; }

        /// <value>
        /// An object that represents a load balancing method and its properties.
        /// </value>
        [JsonProperty(PropertyName = "loadBalancingMethod")]
        public LoadBalancingMethod LoadBalancingMethod { get; set; }

        /// <value>
        /// ModSecurity is not capable to inspect WebSockets. Therefore paths specified here have WAF disabled if Connection request header from the client has the value Upgrade (case insensitive matching) and Upgrade request header has the value websocket (case insensitive matching). Paths matches if the concatenation of request URL path and query starts with the contents of the one of `websocketPathPrefixes` array value. In All other cases challenges, like JSC, HIC and etc., remain active.
        /// </value>
        [JsonProperty(PropertyName = "websocketPathPrefixes")]
        public System.Collections.Generic.List<string> WebsocketPathPrefixes { get; set; }

        /// <value>
        /// SNI stands for Server Name Indication and is an extension of the TLS protocol. It indicates which hostname is being contacted by the browser at the beginning of the 'handshake'-process. This allows a server to connect multiple SSL Certificates to one IP address and port.
        /// </value>
        [JsonProperty(PropertyName = "isSniEnabled")]
        public System.Nullable<bool> IsSniEnabled { get; set; }

        [JsonProperty(PropertyName = "healthChecks")]
        public HealthCheck HealthChecks { get; set; }
    }
}