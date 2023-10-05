/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.13.614
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
    /// Aggregation function type
    /// </summary>
    /// <value>Aggregation function type</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AggregateFunction
    {
        /// <summary>
        /// Enum Count for value: count
        /// </summary>
        [EnumMember(Value = "count")]
        Count = 1,

        /// <summary>
        /// Enum CountDistinct for value: count_distinct
        /// </summary>
        [EnumMember(Value = "count_distinct")]
        CountDistinct = 2,

        /// <summary>
        /// Enum Sum for value: sum
        /// </summary>
        [EnumMember(Value = "sum")]
        Sum = 3,

        /// <summary>
        /// Enum Total for value: total
        /// </summary>
        [EnumMember(Value = "total")]
        Total = 4,

        /// <summary>
        /// Enum Avg for value: avg
        /// </summary>
        [EnumMember(Value = "avg")]
        Avg = 5,

        /// <summary>
        /// Enum Min for value: min
        /// </summary>
        [EnumMember(Value = "min")]
        Min = 6,

        /// <summary>
        /// Enum Max for value: max
        /// </summary>
        [EnumMember(Value = "max")]
        Max = 7,

        /// <summary>
        /// Enum GroupConcat for value: group_concat
        /// </summary>
        [EnumMember(Value = "group_concat")]
        GroupConcat = 8

    }

}
