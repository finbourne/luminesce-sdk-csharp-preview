/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.13.651
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
    /// Defines FieldType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FieldType
    {
        /// <summary>
        /// Enum Column for value: Column
        /// </summary>
        [EnumMember(Value = "Column")]
        Column = 1,

        /// <summary>
        /// Enum Parameter for value: Parameter
        /// </summary>
        [EnumMember(Value = "Parameter")]
        Parameter = 2

    }

}
