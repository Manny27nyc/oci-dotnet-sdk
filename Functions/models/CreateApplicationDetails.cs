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


namespace Oci.FunctionsService.Models
{
    /// <summary>
    /// Properties for a new application.
    /// 
    /// </summary>
    public class CreateApplicationDetails 
    {
        
        /// <value>
        /// The OCID of the compartment to create the application within.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The display name of the application. The display name must be unique within the compartment containing the application. Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Application configuration. These values are passed on to the function as environment variables, functions may override application configuration.
        /// Keys must be ASCII strings consisting solely of letters, digits, and the '_' (underscore) character, and must not begin with a digit. Values should be limited to printable unicode characters.
        /// <br/>
        /// Example: {&quot;MY_FUNCTION_CONFIG&quot;: &quot;ConfVal&quot;}The maximum size for all configuration keys and values is limited to 4KB. This is measured as the sum of octets necessary to represent each key and value in UTF-8.
        /// </value>
        [JsonProperty(PropertyName = "config")]
        public System.Collections.Generic.Dictionary<string, string> Config { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm)s of the subnets in which to run functions in the application.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetIds is required.")]
        [JsonProperty(PropertyName = "subnetIds")]
        public System.Collections.Generic.List<string> SubnetIds { get; set; }
        
        /// <value>
        /// A syslog URL to which to send all function logs. Supports tcp, udp, and tcp+tls.
        /// The syslog URL must be reachable from all of the subnets configured for the application.
        /// Note: If you enable the OCI Logging service for this application, the syslogUrl value is ignored. Function logs are sent to the OCI Logging service, and not to the syslog URL.
        /// <br/>
        /// Example: tcp://logserver.myserver:1234
        /// </value>
        [JsonProperty(PropertyName = "syslogUrl")]
        public string SyslogUrl { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
