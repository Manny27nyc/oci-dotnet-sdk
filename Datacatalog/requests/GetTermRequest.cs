/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatacatalogService.Models;

namespace Oci.DatacatalogService.Requests
{
    public class GetTermRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Unique catalog identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CatalogId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "catalogId")]
        public string CatalogId { get; set; }
        
        /// <value>
        /// Unique glossary key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GlossaryKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "glossaryKey")]
        public string GlossaryKey { get; set; }
        
        /// <value>
        /// Unique glossary term key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TermKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "termKey")]
        public string TermKey { get; set; }
        
        ///
        /// <value>
        /// Specifies the fields to return in a term response.
        /// 
        /// </value>
        ///
        public enum FieldsEnum {
            [EnumMember(Value = "key")]
            Key,
            [EnumMember(Value = "displayName")]
            DisplayName,
            [EnumMember(Value = "description")]
            Description,
            [EnumMember(Value = "glossaryKey")]
            GlossaryKey,
            [EnumMember(Value = "parentTermKey")]
            ParentTermKey,
            [EnumMember(Value = "isAllowedToHaveChildTerms")]
            IsAllowedToHaveChildTerms,
            [EnumMember(Value = "path")]
            Path,
            [EnumMember(Value = "lifecycleState")]
            LifecycleState,
            [EnumMember(Value = "timeCreated")]
            TimeCreated,
            [EnumMember(Value = "timeUpdated")]
            TimeUpdated,
            [EnumMember(Value = "createdById")]
            CreatedById,
            [EnumMember(Value = "updatedById")]
            UpdatedById,
            [EnumMember(Value = "owner")]
            Owner,
            [EnumMember(Value = "workflowStatus")]
            WorkflowStatus,
            [EnumMember(Value = "uri")]
            Uri,
            [EnumMember(Value = "relatedTerms")]
            RelatedTerms,
            [EnumMember(Value = "associatedObjectCount")]
            AssociatedObjectCount,
            [EnumMember(Value = "associatedObjects")]
            AssociatedObjects
        };

        /// <value>
        /// Specifies the fields to return in a term response.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "fields")]
        public System.Collections.Generic.List<FieldsEnum> Fields { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}