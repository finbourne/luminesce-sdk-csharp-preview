/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.14.507
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
    /// The action to take with a certificate
    /// </summary>
    /// <value>The action to take with a certificate</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CertificateAction
    {
        /// <summary>
        /// Enum Create for value: Create
        /// </summary>
        [EnumMember(Value = "Create")]
        Create = 1,

        /// <summary>
        /// Enum CreateAndAllowMultipleWhichAreValid for value: CreateAndAllowMultipleWhichAreValid
        /// </summary>
        [EnumMember(Value = "CreateAndAllowMultipleWhichAreValid")]
        CreateAndAllowMultipleWhichAreValid = 2,

        /// <summary>
        /// Enum Renew for value: Renew
        /// </summary>
        [EnumMember(Value = "Renew")]
        Renew = 3,

        /// <summary>
        /// Enum Revoke for value: Revoke
        /// </summary>
        [EnumMember(Value = "Revoke")]
        Revoke = 4

    }

}
