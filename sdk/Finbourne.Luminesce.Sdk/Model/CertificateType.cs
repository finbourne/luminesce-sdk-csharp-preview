/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.16.108
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Finbourne.Luminesce.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Luminesce.Sdk.Model
{
    /// <summary>
    /// The sort of certificate being Created / Revoked / Renewed
    /// </summary>
    /// <value>The sort of certificate being Created / Revoked / Renewed</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CertificateType
    {
        /// <summary>
        /// Enum Domain for value: Domain
        /// </summary>
        [EnumMember(Value = "Domain")]
        Domain = 1,

        /// <summary>
        /// Enum User for value: User
        /// </summary>
        [EnumMember(Value = "User")]
        User = 2

    }

}
