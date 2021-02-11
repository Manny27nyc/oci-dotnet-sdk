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

namespace Oci.ApplicationmigrationService.Models
{
    /// <summary>
    /// Specify one of the following values depending for the 'type' attribute based on the application that you want to migrate.
    /// <br/>
    /// Specify `OCIC` if you want to migrate Oracle Java Cloud Service, Oracle Analytics Cloud - Classic, Oracle Integration, and Oracle
    /// SOA Cloud Service applications from Oracle Cloud Infrastructure - Classic.
    /// <br/>
    /// Specify `INTERNAL_COMPUTE` if you have a traditional Oracle Cloud Infrastructure - Classic account and you want to migrate Oracle
    /// Process Cloud Service or Oracle Integration Cloud Service applications.
    /// <br/>
    /// Specify `OCC` if you have an Oracle Cloud @ Customer account.
    /// 
    /// </summary>
    [JsonConverter(typeof(SourceDetailsModelConverter))]
    public class SourceDetails 
    {
        
        
    }

    public class SourceDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(SourceDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(SourceDetails);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "OCC":
                    obj = new OccSourceDetails();
                    break;
                case "INTERNAL_COMPUTE":
                    obj = new InternalSourceDetails();
                    break;
                case "OCIC":
                    obj = new OcicSourceDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
