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


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// The standalone job infrastructure configuration.
    /// </summary>
    public class StandaloneJobInfrastructureConfigurationDetails : JobInfrastructureConfigurationDetails
    {
        
        /// <value>
        /// The shape used to launch the job run instances.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShapeName is required.")]
        [JsonProperty(PropertyName = "shapeName")]
        public string ShapeName { get; set; }
        
        /// <value>
        /// The subnet to create a secondary vnic in to attach to the instance running the job
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// The size of the block storage volume to attach to the instance running the job
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BlockStorageSizeInGBs is required.")]
        [JsonProperty(PropertyName = "blockStorageSizeInGBs")]
        public System.Nullable<int> BlockStorageSizeInGBs { get; set; }
        
        [JsonProperty(PropertyName = "jobInfrastructureType")]
        private readonly string jobInfrastructureType = "STANDALONE";
    }
}
