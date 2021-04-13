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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// The criteria by which a specific attachment will import routes to the DRG.
    /// 
    /// </summary>
    public class DrgAttachmentIdDrgRouteDistributionMatchCriteria : DrgRouteDistributionMatchCriteria
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the DRG attachment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DrgAttachmentId is required.")]
        [JsonProperty(PropertyName = "drgAttachmentId")]
        public string DrgAttachmentId { get; set; }
        
        [JsonProperty(PropertyName = "matchType")]
        private readonly string matchType = "DRG_ATTACHMENT_ID";
    }
}