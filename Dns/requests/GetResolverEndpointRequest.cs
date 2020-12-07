/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DnsService.Models;

namespace Oci.DnsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/8.1.0/dns/GetResolverEndpoint.cs.html">here</a> to see an example of how to use GetResolverEndpoint request.
    /// </example>
    public class GetResolverEndpointRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the target resolver.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResolverId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "resolverId")]
        public string ResolverId { get; set; }
        
        /// <value>
        /// The name of the target resolver endpoint.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResolverEndpointName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "resolverEndpointName")]
        public string ResolverEndpointName { get; set; }
        
        /// <value>
        /// The `If-Modified-Since` header field makes a GET or HEAD request method
        /// conditional on the selected representation's modification date being more
        /// recent than the date provided in the field-value.  Transfer of the
        /// selected representation's data is avoided if that data has not changed.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "If-Modified-Since")]
        public string IfModifiedSince { get; set; }
        
        /// <value>
        /// The `If-None-Match` header field makes the request method conditional on
        /// the absence of any current representation of the target resource, when
        /// the field-value is `*`, or having a selected representation with an
        /// entity-tag that does not match any of those listed in the field-value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "If-None-Match")]
        public string IfNoneMatch { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need
        /// to contact Oracle about a particular request, please provide
        /// the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// Specifies to operate only on resources that have a matching DNS scope.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "scope")]
        public System.Nullable<Scope> Scope { get; set; }
    }
}
