/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.11.180
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
    /// Defines TaskStatus
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TaskStatus
    {
        /// <summary>
        /// Enum Created for value: Created
        /// </summary>
        [EnumMember(Value = "Created")]
        Created = 1,

        /// <summary>
        /// Enum WaitingForActivation for value: WaitingForActivation
        /// </summary>
        [EnumMember(Value = "WaitingForActivation")]
        WaitingForActivation = 2,

        /// <summary>
        /// Enum WaitingToRun for value: WaitingToRun
        /// </summary>
        [EnumMember(Value = "WaitingToRun")]
        WaitingToRun = 3,

        /// <summary>
        /// Enum Running for value: Running
        /// </summary>
        [EnumMember(Value = "Running")]
        Running = 4,

        /// <summary>
        /// Enum WaitingForChildrenToComplete for value: WaitingForChildrenToComplete
        /// </summary>
        [EnumMember(Value = "WaitingForChildrenToComplete")]
        WaitingForChildrenToComplete = 5,

        /// <summary>
        /// Enum RanToCompletion for value: RanToCompletion
        /// </summary>
        [EnumMember(Value = "RanToCompletion")]
        RanToCompletion = 6,

        /// <summary>
        /// Enum Canceled for value: Canceled
        /// </summary>
        [EnumMember(Value = "Canceled")]
        Canceled = 7,

        /// <summary>
        /// Enum Faulted for value: Faulted
        /// </summary>
        [EnumMember(Value = "Faulted")]
        Faulted = 8

    }

}
