/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.13.302
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
    /// Direction of Order By terms in the Order By clause
    /// </summary>
    /// <value>Direction of Order By terms in the Order By clause</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum OrderByDirection
    {
        /// <summary>
        /// Enum Asc for value: asc
        /// </summary>
        [EnumMember(Value = "asc")]
        Asc = 1,

        /// <summary>
        /// Enum Desc for value: desc
        /// </summary>
        [EnumMember(Value = "desc")]
        Desc = 2

    }

}
