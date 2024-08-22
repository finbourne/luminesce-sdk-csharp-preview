/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.16.516
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
    /// Defines DataType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DataType
    {
        /// <summary>
        /// Enum Boolean for value: Boolean
        /// </summary>
        [EnumMember(Value = "Boolean")]
        Boolean = 1,

        /// <summary>
        /// Enum Date for value: Date
        /// </summary>
        [EnumMember(Value = "Date")]
        Date = 2,

        /// <summary>
        /// Enum DateTime for value: DateTime
        /// </summary>
        [EnumMember(Value = "DateTime")]
        DateTime = 3,

        /// <summary>
        /// Enum Decimal for value: Decimal
        /// </summary>
        [EnumMember(Value = "Decimal")]
        Decimal = 4,

        /// <summary>
        /// Enum Double for value: Double
        /// </summary>
        [EnumMember(Value = "Double")]
        Double = 5,

        /// <summary>
        /// Enum Int for value: Int
        /// </summary>
        [EnumMember(Value = "Int")]
        Int = 6,

        /// <summary>
        /// Enum BigInt for value: BigInt
        /// </summary>
        [EnumMember(Value = "BigInt")]
        BigInt = 7,

        /// <summary>
        /// Enum Text for value: Text
        /// </summary>
        [EnumMember(Value = "Text")]
        Text = 8,

        /// <summary>
        /// Enum Table for value: Table
        /// </summary>
        [EnumMember(Value = "Table")]
        Table = 9

    }

}
