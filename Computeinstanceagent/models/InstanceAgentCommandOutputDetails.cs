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

namespace Oci.ComputeinstanceagentService.Models
{
    /// <summary>
    /// Command output.
    /// </summary>
    [JsonConverter(typeof(InstanceAgentCommandOutputDetailsModelConverter))]
    public class InstanceAgentCommandOutputDetails 
    {
                ///
        /// <value>
        /// The output type of the command. Use `OBJECT_STORAGE_URI` when specifying the Object Storage URL.
        /// Use `OBJECT_STORAGE_TUPLE` when specifying the namespace, bucket name, and object name.
        /// 
        /// </value>
        ///
        public enum OutputTypeEnum {
            [EnumMember(Value = "TEXT")]
            Text,
            [EnumMember(Value = "OBJECT_STORAGE_URI")]
            ObjectStorageUri,
            [EnumMember(Value = "OBJECT_STORAGE_TUPLE")]
            ObjectStorageTuple
        };

        
    }

    public class InstanceAgentCommandOutputDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(InstanceAgentCommandOutputDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(InstanceAgentCommandOutputDetails);
            var discriminator = jsonObject["outputType"].Value<string>();
            switch (discriminator)
            {
                case "OBJECT_STORAGE_URI":
                    obj = new InstanceAgentCommandOutputViaObjectStorageUriDetails();
                    break;
                case "OBJECT_STORAGE_TUPLE":
                    obj = new InstanceAgentCommandOutputViaObjectStorageTupleDetails();
                    break;
                case "TEXT":
                    obj = new InstanceAgentCommandOutputViaTextDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
