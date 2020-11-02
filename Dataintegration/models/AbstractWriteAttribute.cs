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
    /// The abstract write attribute.
    /// </summary>
    [JsonConverter(typeof(AbstractWriteAttributeModelConverter))]
    public class AbstractWriteAttribute 
    {
                ///
        /// <value>
        /// The type of the abstract write attribute.
        /// </value>
        ///
        public enum ModelTypeEnum {
            [EnumMember(Value = "ORACLEWRITEATTRIBUTE")]
            Oraclewriteattribute,
            [EnumMember(Value = "ORACLEATPWRITEATTRIBUTE")]
            Oracleatpwriteattribute,
            [EnumMember(Value = "ORACLEADWCWRITEATTRIBUTE")]
            Oracleadwcwriteattribute,
            [EnumMember(Value = "ORACLE_WRITE_ATTRIBUTE")]
            OracleWriteAttribute,
            [EnumMember(Value = "ORACLE_ATP_WRITE_ATTRIBUTE")]
            OracleAtpWriteAttribute,
            [EnumMember(Value = "ORACLE_ADWC_WRITE_ATTRIBUTE")]
            OracleAdwcWriteAttribute
        };

        
    }

    public class AbstractWriteAttributeModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(AbstractWriteAttribute);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(AbstractWriteAttribute);
            var discriminator = jsonObject["modelType"].Value<string>();
            switch (discriminator)
            {
                case "ORACLEADWCWRITEATTRIBUTE":
                    obj = new OracleAdwcWriteAttribute();
                    break;
                case "ORACLEWRITEATTRIBUTE":
                    obj = new OracleWriteAttribute();
                    break;
                case "ORACLEATPWRITEATTRIBUTE":
                    obj = new OracleAtpWriteAttribute();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
