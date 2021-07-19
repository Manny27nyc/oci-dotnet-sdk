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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The information about the SQL task.
    /// </summary>
    public class CreateTaskFromSQLTask : CreateTaskDetails
    {
        
        [JsonProperty(PropertyName = "script")]
        public Script Script { get; set; }
                ///
        /// <value>
        /// Indicates whether the task is invoking a custom SQL script or stored procedure.
        /// </value>
        ///
        public enum SqlScriptTypeEnum {
            [EnumMember(Value = "STORED_PROCEDURE")]
            StoredProcedure,
            [EnumMember(Value = "SQL_CODE")]
            SqlCode
        };

        /// <value>
        /// Indicates whether the task is invoking a custom SQL script or stored procedure.
        /// </value>
        [JsonProperty(PropertyName = "sqlScriptType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SqlScriptTypeEnum> SqlScriptType { get; set; }
        
        /// <value>
        /// Describes the shape of the execution result
        /// </value>
        [JsonProperty(PropertyName = "operation")]
        public System.Object Operation { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "SQL_TASK";
    }
}
