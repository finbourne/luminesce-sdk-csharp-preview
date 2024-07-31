/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.16.385
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
    /// Defines MappingFlags
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MappingFlags
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum Exact for value: Exact
        /// </summary>
        [EnumMember(Value = "Exact")]
        Exact = 2,

        /// <summary>
        /// Enum Similar for value: Similar
        /// </summary>
        [EnumMember(Value = "Similar")]
        Similar = 3,

        /// <summary>
        /// Enum Additional for value: Additional
        /// </summary>
        [EnumMember(Value = "Additional")]
        Additional = 4

    }

}
