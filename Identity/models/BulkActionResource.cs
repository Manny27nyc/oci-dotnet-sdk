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


namespace Oci.IdentityService.Models
{
    /// <summary>
    /// The bulk action resource entity.
    /// 
    /// </summary>
    public class BulkActionResource 
    {
        
        /// <value>
        /// The resource OCID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Identifier is required.")]
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        /// <value>
        /// The resource-type. To get the list of supported resource-types use
        /// {@link #listBulkActionResourceTypes(ListBulkActionResourceTypesRequest) listBulkActionResourceTypes}.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EntityType is required.")]
        [JsonProperty(PropertyName = "entityType")]
        public string EntityType { get; set; }
        
        /// <value>
        /// Additional information that helps to identity the resource for bulk action.
        /// <br/>
        /// The APIs to delete and move most resource types only require the resource identifier (ocid).
        /// But some resource-types require additional identifying information.
        /// <br/>
        /// This information is provided in the resource's public API document. It is also
        /// available through the
        /// {@link #listBulkActionResourceTypes(ListBulkActionResourceTypesRequest) listBulkActionResourceTypes}.
        /// <br/>
        /// **Example**:
        /// The APIs to delete or move the `buckets` resource-type require `namespaceName` and `bucketName` to identify the resource, as
        /// shown in the APIs, {@link #deleteBucket(DeleteBucketRequest) deleteBucket} and
        /// {@link #updateBucket(UpdateBucketRequest) updateBucket}.
        /// <br/>
        /// To add a bucket for bulk actions, specify `namespaceName` and `bucketName` in
        /// the metadata property as shown in this example
        /// <br/>
        ///     {
        ///       \"identifier\": \"<OCID_of_bucket>\"
        ///       \"entityType\": \"bucket\",
        ///       \"metadata\":
        ///       {
        ///         \"namespaceName\": \"sampleNamespace\",
        ///         \"bucketName\": \"sampleBucket\"
        ///       }
        ///     }
        /// 
        /// </value>
        [JsonProperty(PropertyName = "metadata")]
        public System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }
        
    }
}
