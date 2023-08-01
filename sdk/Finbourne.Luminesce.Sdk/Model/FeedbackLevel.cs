/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.13.232
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
    /// Defines FeedbackLevel
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FeedbackLevel
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum Progress for value: Progress
        /// </summary>
        [EnumMember(Value = "Progress")]
        Progress = 2,

        /// <summary>
        /// Enum Debug for value: Debug
        /// </summary>
        [EnumMember(Value = "Debug")]
        Debug = 3,

        /// <summary>
        /// Enum Information for value: Information
        /// </summary>
        [EnumMember(Value = "Information")]
        Information = 4,

        /// <summary>
        /// Enum Warning for value: Warning
        /// </summary>
        [EnumMember(Value = "Warning")]
        Warning = 5,

        /// <summary>
        /// Enum Error for value: Error
        /// </summary>
        [EnumMember(Value = "Error")]
        Error = 6,

        /// <summary>
        /// Enum ProgressAndError for value: ProgressAndError
        /// </summary>
        [EnumMember(Value = "ProgressAndError")]
        ProgressAndError = 7,

        /// <summary>
        /// Enum ProgressAndWarning for value: ProgressAndWarning
        /// </summary>
        [EnumMember(Value = "ProgressAndWarning")]
        ProgressAndWarning = 8,

        /// <summary>
        /// Enum ProgressAndInformation for value: ProgressAndInformation
        /// </summary>
        [EnumMember(Value = "ProgressAndInformation")]
        ProgressAndInformation = 9,

        /// <summary>
        /// Enum ProgressAndDebug for value: ProgressAndDebug
        /// </summary>
        [EnumMember(Value = "ProgressAndDebug")]
        ProgressAndDebug = 10,

        /// <summary>
        /// Enum ExecutionKeepAlive for value: ExecutionKeepAlive
        /// </summary>
        [EnumMember(Value = "ExecutionKeepAlive")]
        ExecutionKeepAlive = 11

    }

}
