/*
 * FINBOURNE Honeycomb Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.5.207
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
    /// Defines MultiQueryDefinitionType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MultiQueryDefinitionType
    {
        /// <summary>
        /// Enum Instrument for value: Instrument
        /// </summary>
        [EnumMember(Value = "Instrument")]
        Instrument = 1,

        /// <summary>
        /// Enum Expiry for value: Expiry
        /// </summary>
        [EnumMember(Value = "Expiry")]
        Expiry = 2,

        /// <summary>
        /// Enum CorporateActions for value: CorporateActions
        /// </summary>
        [EnumMember(Value = "CorporateActions")]
        CorporateActions = 3,

        /// <summary>
        /// Enum GetFees for value: GetFees
        /// </summary>
        [EnumMember(Value = "GetFees")]
        GetFees = 4,

        /// <summary>
        /// Enum ListFees for value: ListFees
        /// </summary>
        [EnumMember(Value = "ListFees")]
        ListFees = 5,

        /// <summary>
        /// Enum PostTradeCompliance for value: PostTradeCompliance
        /// </summary>
        [EnumMember(Value = "PostTradeCompliance")]
        PostTradeCompliance = 6,

        /// <summary>
        /// Enum Testing for value: Testing
        /// </summary>
        [EnumMember(Value = "Testing")]
        Testing = 7

    }

}
