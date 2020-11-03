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


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// Enable CORS (Cross-Origin-Resource-Sharing) request handling.
    /// 
    /// </summary>
    public class CorsPolicy 
    {
        
        /// <value>
        /// The list of allowed origins that the CORS handler will use to respond to CORS requests. The gateway will
        /// send the Access-Control-Allow-Origin header with the best origin match for the circumstances. '*' will match
        /// any origins, and 'null' will match queries from 'file:' origins. All other origins must be qualified with the
        /// scheme, full hostname, and port if necessary.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AllowedOrigins is required.")]
        [JsonProperty(PropertyName = "allowedOrigins")]
        public System.Collections.Generic.List<string> AllowedOrigins { get; set; }
        
        /// <value>
        /// The list of allowed HTTP methods that will be returned for the preflight OPTIONS request in the
        /// Access-Control-Allow-Methods header. '*' will allow all methods.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "allowedMethods")]
        public System.Collections.Generic.List<string> AllowedMethods { get; set; }
        
        /// <value>
        /// The list of headers that will be allowed from the client via the Access-Control-Allow-Headers header.
        /// '*' will allow all headers.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "allowedHeaders")]
        public System.Collections.Generic.List<string> AllowedHeaders { get; set; }
        
        /// <value>
        /// The list of headers that the client will be allowed to see from the response as indicated by the
        /// Access-Control-Expose-Headers header. '*' will expose all headers.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "exposedHeaders")]
        public System.Collections.Generic.List<string> ExposedHeaders { get; set; }
        
        /// <value>
        /// Whether to send the Access-Control-Allow-Credentials header to allow CORS requests with cookies.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAllowCredentialsEnabled")]
        public System.Nullable<bool> IsAllowCredentialsEnabled { get; set; }
        
        /// <value>
        /// The time in seconds for the client to cache preflight responses. This is sent as the Access-Control-Max-Age
        /// if greater than 0.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxAgeInSeconds")]
        public System.Nullable<int> MaxAgeInSeconds { get; set; }
        
    }
}
