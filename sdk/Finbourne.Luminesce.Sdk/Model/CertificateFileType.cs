/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.16.490
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
    /// The type of the certificate file to be downloaded (both public and private are needed to connect)
    /// </summary>
    /// <value>The type of the certificate file to be downloaded (both public and private are needed to connect)</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CertificateFileType
    {
        /// <summary>
        /// Enum Public for value: Public
        /// </summary>
        [EnumMember(Value = "Public")]
        Public = 1,

        /// <summary>
        /// Enum Private for value: Private
        /// </summary>
        [EnumMember(Value = "Private")]
        Private = 2

    }

}
