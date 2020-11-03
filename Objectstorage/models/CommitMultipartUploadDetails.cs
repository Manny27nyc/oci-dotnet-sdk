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


namespace Oci.ObjectstorageService.Models
{
    /// <summary>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you are not authorized,
    /// talk to an administrator. If you are an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// 
    /// </summary>
    public class CommitMultipartUploadDetails 
    {
        
        /// <value>
        /// The part numbers and entity tags (ETags) for the parts to be committed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PartsToCommit is required.")]
        [JsonProperty(PropertyName = "partsToCommit")]
        public System.Collections.Generic.List<CommitMultipartUploadPartDetails> PartsToCommit { get; set; }
        
        /// <value>
        /// The part numbers for the parts to be excluded from the completed object.
        /// Each part created for this upload must be in either partsToExclude or partsToCommit, but cannot be in both.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "partsToExclude")]
        public System.Collections.Generic.List<int> PartsToExclude { get; set; }
        
    }
}
