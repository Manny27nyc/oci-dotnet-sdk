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
using Newtonsoft.Json.Linq;

namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The connection for a data asset.
    /// </summary>
    [JsonConverter(typeof(ConnectionModelConverter))]
    public class Connection 
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
            GenericJdbcConnection,
            [EnumMember(Value = "BICC_CONNECTION")]
            BiccConnection,
            [EnumMember(Value = "AMAZON_S3_CONNECTION")]
            AmazonS3Connection
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
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// User-defined description for the connection.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The version of the object that is used to track changes in the object instance.
        /// </value>
        [JsonProperty(PropertyName = "objectVersion")]
        public System.Nullable<int> ObjectVersion { get; set; }
        
        /// <value>
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }
        
        /// <value>
        /// Value can only contain upper case letters, underscore, and numbers. It should begin with upper case letter or underscore. The value can be modified.
        /// </value>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        [JsonProperty(PropertyName = "primarySchema")]
        public Schema PrimarySchema { get; set; }
        
        /// <value>
        /// The properties for the connection.
        /// </value>
        [JsonProperty(PropertyName = "connectionProperties")]
        public System.Collections.Generic.List<ConnectionProperty> ConnectionProperties { get; set; }
        
        /// <value>
        /// The default property for the connection.
        /// </value>
        [JsonProperty(PropertyName = "isDefault")]
        public System.Nullable<bool> IsDefault { get; set; }
        
        [JsonProperty(PropertyName = "metadata")]
        public ObjectMetadata Metadata { get; set; }
        
        /// <value>
        /// A key map. If provided, key is replaced with generated key. This structure provides mapping between user provided key and generated key.
        /// </value>
        [JsonProperty(PropertyName = "keyMap")]
        public System.Collections.Generic.Dictionary<string, string> KeyMap { get; set; }
        
    }

    public class ConnectionModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(Connection);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(Connection);
            var discriminator = jsonObject["modelType"].Value<string>();
            switch (discriminator)
            {
                case "ORACLE_OBJECT_STORAGE_CONNECTION":
                    obj = new ConnectionFromObjectStorage();
                    break;
                case "ORACLE_ADWC_CONNECTION":
                    obj = new ConnectionFromAdwc();
                    break;
                case "ORACLE_ATP_CONNECTION":
                    obj = new ConnectionFromAtp();
                    break;
                case "ORACLEDB_CONNECTION":
                    obj = new ConnectionFromOracle();
                    break;
                case "AMAZON_S3_CONNECTION":
                    obj = new ConnectionFromAmazonS3();
                    break;
                case "MYSQL_CONNECTION":
                    obj = new ConnectionFromMySQL();
                    break;
                case "GENERIC_JDBC_CONNECTION":
                    obj = new ConnectionFromJdbc();
                    break;
                case "BICC_CONNECTION":
                    obj = new ConnectionFromBICC();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
