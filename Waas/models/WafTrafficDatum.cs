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
    /// A time series of traffic data for the  Web Application Firewall configured for a policy.
    /// </summary>
    public class WafTrafficDatum 
    {
        
        /// <value>
        /// The date and time the traffic was observed, rounded down to the start of the range, and expressed in RFC 3339 timestamp format.
        /// </value>
        [JsonProperty(PropertyName = "timeObserved")]
        public System.Nullable<System.DateTime> TimeObserved { get; set; }
        
        /// <value>
        /// The number of seconds this data covers.
        /// </value>
        [JsonProperty(PropertyName = "timeRangeInSeconds")]
        public System.Nullable<int> TimeRangeInSeconds { get; set; }
        
        /// <value>
        /// The tenancy OCID of the data.
        /// </value>
        [JsonProperty(PropertyName = "tenancyId")]
        public string TenancyId { get; set; }
        
        /// <value>
        /// The compartment OCID of the data.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The policy OCID of the data.
        /// </value>
        [JsonProperty(PropertyName = "waasPolicyId")]
        public string WaasPolicyId { get; set; }
        
        /// <value>
        /// Traffic in bytes.
        /// </value>
        [JsonProperty(PropertyName = "trafficInBytes")]
        public System.Nullable<int> TrafficInBytes { get; set; }
        
    }
}
