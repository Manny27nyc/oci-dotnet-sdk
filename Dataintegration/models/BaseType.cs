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
    /// Base type for the type system.
    /// </summary>
    [JsonConverter(typeof(BaseTypeModelConverter))]
    public class BaseType 
    {
                ///
        /// <value>
        /// The property which disciminates the subtypes.
        /// </value>
        ///
        public enum ModelTypeEnum {
            [EnumMember(Value = "DYNAMIC_TYPE")]
            DynamicType,
            [EnumMember(Value = "STRUCTURED_TYPE")]
            StructuredType,
            [EnumMember(Value = "DATA_TYPE")]
            DataType,
            [EnumMember(Value = "JAVA_TYPE")]
            JavaType,
            [EnumMember(Value = "CONFIGURED_TYPE")]
            ConfiguredType,
            [EnumMember(Value = "COMPOSITE_TYPE")]
            CompositeType
        };

        
        /// <value>
        /// The key of the object.
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
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }
        
        /// <value>
        /// A user defined description for the object.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
    }

    public class BaseTypeModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(BaseType);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(BaseType);
            var discriminator = jsonObject["modelType"].Value<string>();
            switch (discriminator)
            {
                case "CONFIGURED_TYPE":
                    obj = new ConfiguredType();
                    break;
                case "JAVA_TYPE":
                    obj = new JavaType();
                    break;
                case "DYNAMIC_TYPE":
                    obj = new DynamicType();
                    break;
                case "DERIVED_TYPE":
                    obj = new DerivedType();
                    break;
                case "DATA_TYPE":
                    obj = new DataType();
                    break;
                case "COMPOSITE_TYPE":
                    obj = new CompositeType();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
