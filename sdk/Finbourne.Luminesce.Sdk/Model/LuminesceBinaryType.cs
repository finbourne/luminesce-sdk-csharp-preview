/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.14.578
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
    /// Binaries that can be downloaded
    /// </summary>
    /// <value>Binaries that can be downloaded</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum LuminesceBinaryType
    {
        /// <summary>
        /// Enum CommandLineTool for value: CommandLineTool
        /// </summary>
        [EnumMember(Value = "CommandLineTool")]
        CommandLineTool = 1,

        /// <summary>
        /// Enum LocalFileSystemProviders for value: LocalFileSystem_Providers
        /// </summary>
        [EnumMember(Value = "LocalFileSystem_Providers")]
        LocalFileSystemProviders = 2,

        /// <summary>
        /// Enum EmailProviders for value: Email_Providers
        /// </summary>
        [EnumMember(Value = "Email_Providers")]
        EmailProviders = 3,

        /// <summary>
        /// Enum PythonProviders for value: Python_Providers
        /// </summary>
        [EnumMember(Value = "Python_Providers")]
        PythonProviders = 4,

        /// <summary>
        /// Enum AwsS3Providers for value: AwsS3_Providers
        /// </summary>
        [EnumMember(Value = "AwsS3_Providers")]
        AwsS3Providers = 5,

        /// <summary>
        /// Enum SqlDbProvidersDb2Linux for value: SqlDb_Providers_Db2Linux
        /// </summary>
        [EnumMember(Value = "SqlDb_Providers_Db2Linux")]
        SqlDbProvidersDb2Linux = 6,

        /// <summary>
        /// Enum SqlDbProvidersMySql for value: SqlDb_Providers_MySql
        /// </summary>
        [EnumMember(Value = "SqlDb_Providers_MySql")]
        SqlDbProvidersMySql = 7,

        /// <summary>
        /// Enum SqlDbProvidersOracle for value: SqlDb_Providers_Oracle
        /// </summary>
        [EnumMember(Value = "SqlDb_Providers_Oracle")]
        SqlDbProvidersOracle = 8,

        /// <summary>
        /// Enum SqlDbProvidersOracleSnowflake for value: SqlDb_Providers_Oracle_Snowflake
        /// </summary>
        [EnumMember(Value = "SqlDb_Providers_Oracle_Snowflake")]
        SqlDbProvidersOracleSnowflake = 9,

        /// <summary>
        /// Enum SqlDbProvidersPostgresql for value: SqlDb_Providers_Postgresql
        /// </summary>
        [EnumMember(Value = "SqlDb_Providers_Postgresql")]
        SqlDbProvidersPostgresql = 10,

        /// <summary>
        /// Enum SqlDbProvidersSnowflake for value: SqlDb_Providers_Snowflake
        /// </summary>
        [EnumMember(Value = "SqlDb_Providers_Snowflake")]
        SqlDbProvidersSnowflake = 11,

        /// <summary>
        /// Enum SqlDbProvidersSqlServer for value: SqlDb_Providers_SqlServer
        /// </summary>
        [EnumMember(Value = "SqlDb_Providers_SqlServer")]
        SqlDbProvidersSqlServer = 12,

        /// <summary>
        /// Enum SqlDbProvidersSybaseAse for value: SqlDb_Providers_SybaseAse
        /// </summary>
        [EnumMember(Value = "SqlDb_Providers_SybaseAse")]
        SqlDbProvidersSybaseAse = 13,

        /// <summary>
        /// Enum JdbcDriver for value: Jdbc_Driver
        /// </summary>
        [EnumMember(Value = "Jdbc_Driver")]
        JdbcDriver = 14

    }

}
