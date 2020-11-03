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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Summary of a term associated with an object. This is a brief summary returned as part of the search result.
    /// 
    /// </summary>
    public class SearchTermSummary 
    {
        
        /// <value>
        /// Unique term key that is immutable.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// A user-friendly display name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Unique id of the parent glossary.
        /// </value>
        [JsonProperty(PropertyName = "glossaryKey")]
        public string GlossaryKey { get; set; }
        
        /// <value>
        /// Name of the parent glossary.
        /// </value>
        [JsonProperty(PropertyName = "glossaryName")]
        public string GlossaryName { get; set; }
        
        /// <value>
        /// This terms parent term key. Will be null if the term has no parent term.
        /// </value>
        [JsonProperty(PropertyName = "parentTermKey")]
        public string ParentTermKey { get; set; }
        
        /// <value>
        /// Name of the parent term key. Will be null if the term has no parent term.
        /// </value>
        [JsonProperty(PropertyName = "parentTermName")]
        public string ParentTermName { get; set; }
        
    }
}
