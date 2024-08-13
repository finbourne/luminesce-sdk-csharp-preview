/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.16.448
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
    /// Which System(s) have been updated with a given request
    /// </summary>
    /// <value>Which System(s) have been updated with a given request</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CertificateStatus
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum WebApiPersistence for value: WebApiPersistence
        /// </summary>
        [EnumMember(Value = "WebApiPersistence")]
        WebApiPersistence = 2,

        /// <summary>
        /// Enum Vault for value: Vault
        /// </summary>
        [EnumMember(Value = "Vault")]
        Vault = 3,

        /// <summary>
        /// Enum Rabbit for value: Rabbit
        /// </summary>
        [EnumMember(Value = "Rabbit")]
        Rabbit = 4,

        /// <summary>
        /// Enum ConfigStore for value: ConfigStore
        /// </summary>
        [EnumMember(Value = "ConfigStore")]
        ConfigStore = 5,

        /// <summary>
        /// Enum AllSystems for value: AllSystems
        /// </summary>
        [EnumMember(Value = "AllSystems")]
        AllSystems = 6

    }

}
