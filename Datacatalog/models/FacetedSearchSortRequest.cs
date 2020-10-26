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
    /// Object with sort criteria details
    /// </summary>
    public class FacetedSearchSortRequest 
    {
        
        /// <value>
        /// Filed name that needs to be sorted by.
        /// </value>
        [JsonProperty(PropertyName = "sortBy")]
        public string SortBy { get; set; }
        ///
        /// <value>
        /// Sort order for search results.
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// Sort order for search results.
        /// </value>
        [JsonProperty(PropertyName = "sortOrder")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
    }
}