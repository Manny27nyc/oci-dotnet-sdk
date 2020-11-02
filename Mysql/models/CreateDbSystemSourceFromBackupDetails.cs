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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// Use the backupId to specify from which backup the new DB System will be created.
    /// 
    /// </summary>
    public class CreateDbSystemSourceFromBackupDetails : CreateDbSystemSourceDetails
    {
        
        /// <value>
        /// The OCID of the backup to be used as the source for the new DB System.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BackupId is required.")]
        [JsonProperty(PropertyName = "backupId")]
        public string BackupId { get; set; }
        
        [JsonProperty(PropertyName = "sourceType")]
        private readonly string sourceType = "BACKUP";
    }
}
