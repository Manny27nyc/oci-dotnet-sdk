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


namespace Oci.OsmanagementService.Models
{
    /// <summary>
    /// An OCI Compute instance that is being managed
    /// </summary>
    public class ManagedInstanceSummary 
    {
        
        /// <value>
        /// user settable name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// OCID for the managed instance
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Time at which the instance last checked in
        /// </value>
        [JsonProperty(PropertyName = "lastCheckin")]
        public string LastCheckin { get; set; }
        
        /// <value>
        /// Time at which the instance last booted
        /// </value>
        [JsonProperty(PropertyName = "lastBoot")]
        public string LastBoot { get; set; }
        
        /// <value>
        /// Number of updates available to be installed
        /// </value>
        [JsonProperty(PropertyName = "updatesAvailable")]
        public System.Nullable<int> UpdatesAvailable { get; set; }
        
        /// <value>
        /// OCID for the Compartment
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Information specified by the user about the managed instance
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
                ///
        /// <value>
        /// status of the managed instance.
        /// </value>
        ///
        public enum StatusEnum {
            [EnumMember(Value = "NORMAL")]
            Normal,
            [EnumMember(Value = "UNREACHABLE")]
            Unreachable,
            [EnumMember(Value = "ERROR")]
            Error,
            [EnumMember(Value = "WARNING")]
            Warning
        };

        /// <value>
        /// status of the managed instance.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// The Operating System type of the managed instance.
        /// </value>
        [JsonProperty(PropertyName = "osFamily")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OsFamilies> OsFamily { get; set; }
        
        /// <value>
        /// Indicates whether a reboot is required to complete installation of updates.
        /// </value>
        [JsonProperty(PropertyName = "isRebootRequired")]
        public System.Nullable<bool> IsRebootRequired { get; set; }
        
    }
}
