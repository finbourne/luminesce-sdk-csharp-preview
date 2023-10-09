/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.13.638
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
    /// Defines BackgroundQueryState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum BackgroundQueryState
    {
        /// <summary>
        /// Enum New for value: New
        /// </summary>
        [EnumMember(Value = "New")]
        New = 1,

        /// <summary>
        /// Enum Running for value: Running
        /// </summary>
        [EnumMember(Value = "Running")]
        Running = 2,

        /// <summary>
        /// Enum Errored for value: Errored
        /// </summary>
        [EnumMember(Value = "Errored")]
        Errored = 3,

        /// <summary>
        /// Enum Cancelled for value: Cancelled
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled = 4,

        /// <summary>
        /// Enum Executed for value: Executed
        /// </summary>
        [EnumMember(Value = "Executed")]
        Executed = 5,

        /// <summary>
        /// Enum ExecutedNoSerializationRequired for value: ExecutedNoSerializationRequired
        /// </summary>
        [EnumMember(Value = "ExecutedNoSerializationRequired")]
        ExecutedNoSerializationRequired = 6,

        /// <summary>
        /// Enum Serialized for value: Serialized
        /// </summary>
        [EnumMember(Value = "Serialized")]
        Serialized = 7,

        /// <summary>
        /// Enum SerializationFailed for value: SerializationFailed
        /// </summary>
        [EnumMember(Value = "SerializationFailed")]
        SerializationFailed = 8,

        /// <summary>
        /// Enum AttemptingToDeserialize for value: AttemptingToDeserialize
        /// </summary>
        [EnumMember(Value = "AttemptingToDeserialize")]
        AttemptingToDeserialize = 9,

        /// <summary>
        /// Enum Loaded for value: Loaded
        /// </summary>
        [EnumMember(Value = "Loaded")]
        Loaded = 10,

        /// <summary>
        /// Enum Cleared for value: Cleared
        /// </summary>
        [EnumMember(Value = "Cleared")]
        Cleared = 11,

        /// <summary>
        /// Enum Disposed for value: Disposed
        /// </summary>
        [EnumMember(Value = "Disposed")]
        Disposed = 12

    }

}
