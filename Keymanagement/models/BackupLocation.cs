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

namespace Oci.KeymanagementService.Models
{
    /// <summary>
    /// Backup upload location
    /// </summary>
    [JsonConverter(typeof(BackupLocationModelConverter))]
    public class BackupLocation 
    {
                ///
        /// <value>
        /// 'Backup location destination:
        /// BUCKET - Uploading or downloading backup via object store bucket
        /// PRE_AUTHENTICATED_REQUEST_URI - Uploading or downloading backup via a PreAuthenticated object store URI'
        /// 
        /// </value>
        ///
        public enum DestinationEnum {
            [EnumMember(Value = "BUCKET")]
            Bucket,
            [EnumMember(Value = "PRE_AUTHENTICATED_REQUEST_URI")]
            PreAuthenticatedRequestUri
        };

        
    }

    public class BackupLocationModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(BackupLocation);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(BackupLocation);
            var discriminator = jsonObject["destination"].Value<string>();
            switch (discriminator)
            {
                case "BUCKET":
                    obj = new BackupLocationBucket();
                    break;
                case "PRE_AUTHENTICATED_REQUEST_URI":
                    obj = new BackupLocationURI();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
