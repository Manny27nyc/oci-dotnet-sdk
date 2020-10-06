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
    /// Base type for how fields are projected. There are many different mechanisms for doing this such as by a name pattern, datatype and so on. See the `modelType` property for the types.
    /// </summary>
    [JsonConverter(typeof(ProjectionRuleModelConverter))]
    public class ProjectionRule 
    {
                ///
        /// <value>
        /// The type of the project rule.
        /// </value>
        ///
        public enum ModelTypeEnum {
            [EnumMember(Value = "NAME_PATTERN_RULE")]
            NamePatternRule,
            [EnumMember(Value = "TYPE_LIST_RULE")]
            TypeListRule,
            [EnumMember(Value = "NAME_LIST_RULE")]
            NameListRule,
            [EnumMember(Value = "TYPED_NAME_PATTERN_RULE")]
            TypedNamePatternRule,
            [EnumMember(Value = "RENAME_RULE")]
            RenameRule
        };

        /// <value>
        /// The type of the project rule.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModelType is required.")]
        [JsonProperty(PropertyName = "modelType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ModelTypeEnum> ModelType { get; set; }

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
        /// Specifies whether the rule uses a java regex syntax.
        /// </value>
        [JsonProperty(PropertyName = "isJavaRegexSyntax")]
        public System.Nullable<bool> IsJavaRegexSyntax { get; set; }

        [JsonProperty(PropertyName = "configValues")]
        public ConfigValues ConfigValues { get; set; }

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

    public class ProjectionRuleModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ProjectionRule);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ProjectionRule);
            var discriminator = jsonObject["modelType"].Value<string>();
            switch (discriminator)
            {
                case "RENAME_RULE":
                    obj = new RenameRule();
                    break;
                case "TYPE_LIST_RULE":
                    obj = new TypeListRule();
                    break;
                case "TYPED_NAME_PATTERN_RULE":
                    obj = new TypedNamePatternRule();
                    break;
                case "NAME_PATTERN_RULE":
                    obj = new NamePatternRule();
                    break;
                case "NAME_LIST_RULE":
                    obj = new NameListRule();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
