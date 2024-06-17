/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.16.128
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
    /// Defines QueryDesignerBinaryOperator
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum QueryDesignerBinaryOperator
    {
        /// <summary>
        /// Enum Lt for value: Lt
        /// </summary>
        [EnumMember(Value = "Lt")]
        Lt = 1,

        /// <summary>
        /// Enum Lte for value: Lte
        /// </summary>
        [EnumMember(Value = "Lte")]
        Lte = 2,

        /// <summary>
        /// Enum Gt for value: Gt
        /// </summary>
        [EnumMember(Value = "Gt")]
        Gt = 3,

        /// <summary>
        /// Enum Gte for value: Gte
        /// </summary>
        [EnumMember(Value = "Gte")]
        Gte = 4,

        /// <summary>
        /// Enum Eq for value: Eq
        /// </summary>
        [EnumMember(Value = "Eq")]
        Eq = 5,

        /// <summary>
        /// Enum Neq for value: Neq
        /// </summary>
        [EnumMember(Value = "Neq")]
        Neq = 6,

        /// <summary>
        /// Enum Like for value: Like
        /// </summary>
        [EnumMember(Value = "Like")]
        Like = 7,

        /// <summary>
        /// Enum Contains for value: Contains
        /// </summary>
        [EnumMember(Value = "Contains")]
        Contains = 8,

        /// <summary>
        /// Enum StartsWith for value: StartsWith
        /// </summary>
        [EnumMember(Value = "StartsWith")]
        StartsWith = 9,

        /// <summary>
        /// Enum EndsWith for value: EndsWith
        /// </summary>
        [EnumMember(Value = "EndsWith")]
        EndsWith = 10

    }

}
