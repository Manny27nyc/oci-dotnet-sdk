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
using Newtonsoft.Json.Linq;

namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Properties used in connection create operations.
    /// </summary>
    [JsonConverter(typeof(CreateConnectionDetailsModelConverter))]
    public class CreateConnectionDetails 
    {
                ///
        /// <value>
        /// The type of the connection.
        /// </value>
        ///
        public enum ModelTypeEnum {
            [EnumMember(Value = "ORACLE_ADWC_CONNECTION")]
            OracleAdwcConnection,
            [EnumMember(Value = "ORACLE_ATP_CONNECTION")]
            OracleAtpConnection,
            [EnumMember(Value = "ORACLE_OBJECT_STORAGE_CONNECTION")]
            OracleObjectStorageConnection,
            [EnumMember(Value = "ORACLEDB_CONNECTION")]
            OracledbConnection,
            [EnumMember(Value = "MYSQL_CONNECTION")]
            MysqlConnection,
            [EnumMember(Value = "GENERIC_JDBC_CONNECTION")]
            GenericJdbcConnection
        };

        
        /// <value>
        /// Generated key that can be used in API calls to identify connection. On scenarios where reference to the connection is needed, a value can be passed in create.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The model version of an object.
        /// </value>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }
        
        [JsonProperty(PropertyName = "parentRef")]
        public ParentReference ParentRef { get; set; }
        
        /// <value>
        /// Free form text without any restriction on permitted characters. Name can have letters, numbers, and special characters. The value is editable and is restricted to 1000 characters.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// User-defined description for the connection.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }
        
        /// <value>
        /// Value can only contain upper case letters, underscore, and numbers. It should begin with upper case letter or underscore. The value can be modified.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Identifier is required.")]
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        /// <value>
        /// The properties for the connection.
        /// </value>
        [JsonProperty(PropertyName = "connectionProperties")]
        public System.Collections.Generic.List<ConnectionProperty> ConnectionProperties { get; set; }
        
        [JsonProperty(PropertyName = "registryMetadata")]
        public RegistryMetadata RegistryMetadata { get; set; }
        
    }

    public class CreateConnectionDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateConnectionDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateConnectionDetails);
            var discriminator = jsonObject["modelType"].Value<string>();
            switch (discriminator)
            {
                case "MYSQL_CONNECTION":
                    obj = new CreateConnectionFromMySQL();
                    break;
                case "GENERIC_JDBC_CONNECTION":
                    obj = new CreateConnectionFromJdbc();
                    break;
                case "ORACLE_ATP_CONNECTION":
                    obj = new CreateConnectionFromAtp();
                    break;
                case "ORACLE_ADWC_CONNECTION":
                    obj = new CreateConnectionFromAdwc();
                    break;
                case "ORACLEDB_CONNECTION":
                    obj = new CreateConnectionFromOracle();
                    break;
                case "ORACLE_OBJECT_STORAGE_CONNECTION":
                    obj = new CreateConnectionFromObjectStorage();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
