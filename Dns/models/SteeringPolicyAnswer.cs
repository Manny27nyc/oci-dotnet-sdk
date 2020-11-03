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


namespace Oci.DnsService.Models
{
    /// <summary>
    /// DNS record data with metadata for processing in a steering policy.
    /// <br/>
    /// 
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class SteeringPolicyAnswer 
    {
        
        /// <value>
        /// A user-friendly name for the answer, unique within the steering policy.
        /// An answer's `name` property can be referenced in `answerCondition` properties
        /// of rules using `answer.name`.
        /// <br/>
        /// **Example: **  &quot;rules&quot;: [    {      &quot;ruleType&quot;: &quot;FILTER&quot;,      &quot;defaultAnswerData&quot;:  [        {          &quot;answerCondition&quot;: &quot;answer.name == 'server 1'&quot;,          &quot;shouldKeep&quot;: true        }      ]    }  ]
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The canonical name for the record's type. Only A, AAAA, and CNAME are supported. For more
        /// information, see [Supported DNS Resource Record Types](https://docs.cloud.oracle.com/iaas/Content/DNS/Reference/supporteddnsresource.htm).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Rtype is required.")]
        [JsonProperty(PropertyName = "rtype")]
        public string Rtype { get; set; }
        
        /// <value>
        /// The record's data, as whitespace-delimited tokens in
        /// type-specific presentation format. All RDATA is normalized and the
        /// returned presentation of your RDATA may differ from its initial input.
        /// For more information about RDATA, see [Supported DNS Resource Record Types](https://docs.cloud.oracle.com/iaas/Content/DNS/Reference/supporteddnsresource.htm).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Rdata is required.")]
        [JsonProperty(PropertyName = "rdata")]
        public string Rdata { get; set; }
        
        /// <value>
        /// The freeform name of a group of one or more records in which this record is included,
        /// such as \"LAX data center\". An answer's `pool` property can be referenced in `answerCondition`
        /// properties of rules using `answer.pool`.
        /// <br/>
        /// **Example: **  &quot;rules&quot;: [    {      &quot;ruleType&quot;: &quot;FILTER&quot;,      &quot;defaultAnswerData&quot;:  [        {          &quot;answerCondition&quot;: &quot;answer.pool == 'US East Servers'&quot;,          &quot;shouldKeep&quot;: true        }      ]    }  ]
        /// </value>
        [JsonProperty(PropertyName = "pool")]
        public string Pool { get; set; }
        
        /// <value>
        /// Set this property to `true` to indicate that the answer is administratively disabled,
        /// such as when the corresponding server is down for maintenance. An answer's `isDisabled`
        /// property can be referenced in `answerCondition` properties in rules using `answer.isDisabled`.
        /// <br/>
        /// **Example: **  &quot;rules&quot;: [    {      &quot;ruleType&quot;: &quot;FILTER&quot;,      &quot;defaultAnswerData&quot;: [        {          &quot;answerCondition&quot;: &quot;answer.isDisabled != true&quot;,          &quot;shouldKeep&quot;: true        }      ]    },
        /// </value>
        [JsonProperty(PropertyName = "isDisabled")]
        public System.Nullable<bool> IsDisabled { get; set; }
        
    }
}
