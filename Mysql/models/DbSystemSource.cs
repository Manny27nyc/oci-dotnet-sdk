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

namespace Oci.MysqlService.Models
{
    /// <summary>
    /// Parameters detailing how to provision the initial data of the DB System.
    /// 
    /// </summary>
    [JsonConverter(typeof(DbSystemSourceModelConverter))]
    public class DbSystemSource 
    {
                ///
        /// <value>
        /// The specific source identifier.
        /// 
        /// </value>
        ///
        public enum SourceTypeEnum {
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "BACKUP")]
            Backup,
            [EnumMember(Value = "IMPORTURL")]
            Importurl
        };

        
    }

    public class DbSystemSourceModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DbSystemSource);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DbSystemSource);
            var discriminator = jsonObject["sourceType"].Value<string>();
            switch (discriminator)
            {
                case "BACKUP":
                    obj = new DbSystemSourceFromBackup();
                    break;
                case "IMPORTURL":
                    obj = new DbSystemSourceImportFromUrl();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
