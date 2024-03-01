/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.14.635
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
    /// The file type of a source
    /// </summary>
    /// <value>The file type of a source</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SourceType
    {
        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 1,

        /// <summary>
        /// Enum Csv for value: Csv
        /// </summary>
        [EnumMember(Value = "Csv")]
        Csv = 2,

        /// <summary>
        /// Enum Excel for value: Excel
        /// </summary>
        [EnumMember(Value = "Excel")]
        Excel = 3,

        /// <summary>
        /// Enum SqLite for value: SqLite
        /// </summary>
        [EnumMember(Value = "SqLite")]
        SqLite = 4,

        /// <summary>
        /// Enum Xml for value: Xml
        /// </summary>
        [EnumMember(Value = "Xml")]
        Xml = 5,

        /// <summary>
        /// Enum Parquet for value: Parquet
        /// </summary>
        [EnumMember(Value = "Parquet")]
        Parquet = 6,

        /// <summary>
        /// Enum RawText for value: RawText
        /// </summary>
        [EnumMember(Value = "RawText")]
        RawText = 7

    }

}
