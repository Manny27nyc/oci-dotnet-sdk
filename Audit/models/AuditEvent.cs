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


namespace Oci.AuditService.Models
{
    /// <summary>
    /// All the attributes of an audit event. For more information, see [Viewing Audit Log Events](https://docs.cloud.oracle.com/iaas/Content/Audit/Tasks/viewinglogevents.htm).
    /// 
    /// </summary>
    public class AuditEvent 
    {
        
        /// <value>
        /// The type of event that happened. 
        /// <br/>
        /// The service that produces the event can also add, remove, or change the meaning of a field.
        /// A service implementing these type changes would publish a new version of an `eventType` and
        /// revise the `eventTypeVersion` field.
        /// <br/>
        /// Example: com.oraclecloud.ComputeApi.GetInstance
        /// </value>
        [JsonProperty(PropertyName = "eventType")]
        public string EventType { get; set; }
        
        /// <value>
        /// The version of the CloudEvents specification. The structure of the envelope follows the 
        /// [CloudEvents](https://github.com/cloudevents/spec) industry standard format hosted by the
        /// [Cloud Native Computing Foundation ( CNCF)](https://www.cncf.io/).
        /// <br/>
        /// Audit uses version 0.1 specification of the CloudEvents event envelope. 
        /// <br/>
        /// Example: 0.1
        /// </value>
        [JsonProperty(PropertyName = "cloudEventsVersion")]
        public string CloudEventsVersion { get; set; }
        
        /// <value>
        /// The version of the event type. This version applies to the payload of the event, not the envelope.
        /// Use `cloudEventsVersion` to determine the version of the envelope.
        /// <br/>
        /// Example: 2.0
        /// </value>
        [JsonProperty(PropertyName = "eventTypeVersion")]
        public string EventTypeVersion { get; set; }
        
        /// <value>
        /// The source of the event.
        /// <br/>
        /// Example: ComputeApi
        /// </value>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }
        
        /// <value>
        /// The GUID of the event.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "eventId")]
        public string EventId { get; set; }
        
        /// <value>
        /// The time the event occurred, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// <br/>
        /// Example: 2019-09-18T00:10:59.252Z
        /// </value>
        [JsonProperty(PropertyName = "eventTime")]
        public System.Nullable<System.DateTime> EventTime { get; set; }
        
        /// <value>
        /// The content type of the data contained in `data`.
        /// <br/>
        /// Example: application/json
        /// </value>
        [JsonProperty(PropertyName = "contentType")]
        public string ContentType { get; set; }
        
        [JsonProperty(PropertyName = "data")]
        public Data Data { get; set; }
        
    }
}
