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

namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// Base policy for how a response from a backend is cached in the Response Cache.
    /// 
    /// </summary>
    [JsonConverter(typeof(ResponseCacheStorePolicyModelConverter))]
    public class ResponseCacheStorePolicy 
    {
                ///
        /// <value>
        /// Type of the Response Cache Store Policy.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "FIXED_TTL_STORE_POLICY")]
            FixedTtlStorePolicy
        };

        
    }

    public class ResponseCacheStorePolicyModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ResponseCacheStorePolicy);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ResponseCacheStorePolicy);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "FIXED_TTL_STORE_POLICY":
                    obj = new FixedTTLResponseCacheStorePolicy();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}