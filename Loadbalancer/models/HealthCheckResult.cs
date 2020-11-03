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


namespace Oci.LoadbalancerService.Models
{
    /// <summary>
    /// Information about a single backend server health check result reported by a load balancer.
    /// 
    /// </summary>
    public class HealthCheckResult 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the subnet hosting the load balancer that reported this health check status.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// The IP address of the health check status report provider. This identifier helps you differentiate same-subnet
        /// load balancers that report health check status.
        /// <br/>
        /// Example: 10.0.0.7
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceIpAddress is required.")]
        [JsonProperty(PropertyName = "sourceIpAddress")]
        public string SourceIpAddress { get; set; }
        
        /// <value>
        /// The date and time the data was retrieved, in the format defined by RFC3339.
        /// <br/>
        /// Example: 2017-06-02T18:28:11+00:00
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Timestamp is required.")]
        [JsonProperty(PropertyName = "timestamp")]
        public System.Nullable<System.DateTime> Timestamp { get; set; }
                ///
        /// <value>
        /// The result of the most recent health check.
        /// 
        /// </value>
        ///
        public enum HealthCheckStatusEnum {
            [EnumMember(Value = "OK")]
            Ok,
            [EnumMember(Value = "INVALID_STATUS_CODE")]
            InvalidStatusCode,
            [EnumMember(Value = "TIMED_OUT")]
            TimedOut,
            [EnumMember(Value = "REGEX_MISMATCH")]
            RegexMismatch,
            [EnumMember(Value = "CONNECT_FAILED")]
            ConnectFailed,
            [EnumMember(Value = "IO_ERROR")]
            IoError,
            [EnumMember(Value = "OFFLINE")]
            Offline,
            [EnumMember(Value = "UNKNOWN")]
            Unknown
        };

        /// <value>
        /// The result of the most recent health check.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HealthCheckStatus is required.")]
        [JsonProperty(PropertyName = "healthCheckStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<HealthCheckStatusEnum> HealthCheckStatus { get; set; }
        
    }
}
