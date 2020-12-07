/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.AuditService.Models;

namespace Oci.AuditService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/8.1.0/audit/ListEvents.cs.html">here</a> to see an example of how to use ListEvents request.
    /// </example>
    public class ListEventsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Returns events that were processed at or after this start date and time, expressed in
        /// [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// <br/>
        /// For example, a start value of `2017-01-15T11:30:00Z` will retrieve a list of all events processed
        /// since 30 minutes after the 11th hour of January 15, 2017, in Coordinated Universal Time (UTC).
        /// You can specify a value with granularity to the minute. Seconds (and milliseconds, if included) must
        /// be set to `0`.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StartTime is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "startTime")]
        public System.Nullable<System.DateTime> StartTime { get; set; }
        
        /// <value>
        /// Returns events that were processed before this end date and time, expressed in
        /// [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// <br/>
        /// For example, a start value of `2017-01-01T00:00:00Z` and an end value of `2017-01-02T00:00:00Z`
        /// will retrieve a list of all events processed on January 1, 2017. Similarly, a start value of
        /// `2017-01-01T00:00:00Z` and an end value of `2017-02-01T00:00:00Z` will result in a list of all
        /// events processed between January 1, 2017 and January 31, 2017. You can specify a value with
        /// granularity to the minute. Seconds (and milliseconds, if included) must be set to `0`.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EndTime is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "endTime")]
        public System.Nullable<System.DateTime> EndTime { get; set; }
        
        /// <value>
        /// For list pagination. The value of the `opc-next-page` response header from the previous \"List\" call.
        /// For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a
        /// particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
