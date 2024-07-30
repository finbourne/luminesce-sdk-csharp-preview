/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.16.379
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
    /// Defines IntellisenseType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum IntellisenseType
    {
        /// <summary>
        /// Enum Keyword for value: Keyword
        /// </summary>
        [EnumMember(Value = "Keyword")]
        Keyword = 1,

        /// <summary>
        /// Enum Symbol for value: Symbol
        /// </summary>
        [EnumMember(Value = "Symbol")]
        Symbol = 2,

        /// <summary>
        /// Enum Function for value: Function
        /// </summary>
        [EnumMember(Value = "Function")]
        Function = 3,

        /// <summary>
        /// Enum Operator for value: Operator
        /// </summary>
        [EnumMember(Value = "Operator")]
        Operator = 4,

        /// <summary>
        /// Enum Table for value: Table
        /// </summary>
        [EnumMember(Value = "Table")]
        Table = 5,

        /// <summary>
        /// Enum Column for value: Column
        /// </summary>
        [EnumMember(Value = "Column")]
        Column = 6,

        /// <summary>
        /// Enum Parameter for value: Parameter
        /// </summary>
        [EnumMember(Value = "Parameter")]
        Parameter = 7,

        /// <summary>
        /// Enum ScalarVariable for value: ScalarVariable
        /// </summary>
        [EnumMember(Value = "ScalarVariable")]
        ScalarVariable = 8

    }

}
