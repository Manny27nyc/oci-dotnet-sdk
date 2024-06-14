/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatabasemanagementService.Models;

namespace Oci.DatabasemanagementService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/databasemanagement/GetSqlExecutionPlan.cs.html">here</a> to see an example of how to use GetSqlExecutionPlan request.
    /// </example>
    public class GetSqlExecutionPlanRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Managed Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ManagedDatabaseId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "managedDatabaseId")]
        public string ManagedDatabaseId { get; set; }
        
        /// <value>
        /// The SQL tuning task identifier. This is not the [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlTuningAdvisorTaskId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "sqlTuningAdvisorTaskId")]
        public System.Nullable<long> SqlTuningAdvisorTaskId { get; set; }
        
        /// <value>
        /// The SQL object id for the SQL tuning task. This is not the [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlObjectId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sqlObjectId")]
        public System.Nullable<long> SqlObjectId { get; set; }
        
        ///
        /// <value>
        /// The attribute of the SQL execution plan.
        /// </value>
        ///
        public enum AttributeEnum {
            [EnumMember(Value = "ORIGINAL")]
            Original,
            [EnumMember(Value = "ORIGINAL_WITH_ADJUSTED_COST")]
            OriginalWithAdjustedCost,
            [EnumMember(Value = "USING_SQL_PROFILE")]
            UsingSqlProfile,
            [EnumMember(Value = "USING_NEW_INDICES")]
            UsingNewIndices
        };

        /// <value>
        /// The attribute of the SQL execution plan.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Attribute is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "attribute")]
        public System.Nullable<AttributeEnum> Attribute { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}