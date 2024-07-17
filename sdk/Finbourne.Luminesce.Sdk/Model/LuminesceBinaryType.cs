/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.16.322
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
        /// Enum AzureProviders for value: Azure_Providers
        /// </summary>
        [EnumMember(Value = "Azure_Providers")]
        AzureProviders = 6,

        /// <summary>
        /// Enum SqlDbProvidersDb2Linux for value: SqlDb_Providers_Db2Linux
        /// </summary>
        [EnumMember(Value = "SqlDb_Providers_Db2Linux")]
        SqlDbProvidersDb2Linux = 7,

        /// <summary>
        /// Enum SqlDbProvidersMySql for value: SqlDb_Providers_MySql
        /// </summary>
        [EnumMember(Value = "SqlDb_Providers_MySql")]
        SqlDbProvidersMySql = 8,

        /// <summary>
        /// Enum SqlDbProvidersOracle for value: SqlDb_Providers_Oracle
        /// </summary>
        [EnumMember(Value = "SqlDb_Providers_Oracle")]
        SqlDbProvidersOracle = 9,

        /// <summary>
        /// Enum SqlDbProvidersOracleSnowflake for value: SqlDb_Providers_Oracle_Snowflake
        /// </summary>
        [EnumMember(Value = "SqlDb_Providers_Oracle_Snowflake")]
        SqlDbProvidersOracleSnowflake = 10,

        /// <summary>
        /// Enum SqlDbProvidersPostgresql for value: SqlDb_Providers_Postgresql
        /// </summary>
        [EnumMember(Value = "SqlDb_Providers_Postgresql")]
        SqlDbProvidersPostgresql = 11,

        /// <summary>
        /// Enum SqlDbProvidersSnowflake for value: SqlDb_Providers_Snowflake
        /// </summary>
        [EnumMember(Value = "SqlDb_Providers_Snowflake")]
        SqlDbProvidersSnowflake = 12,

        /// <summary>
        /// Enum SqlDbProvidersSqlServer for value: SqlDb_Providers_SqlServer
        /// </summary>
        [EnumMember(Value = "SqlDb_Providers_SqlServer")]
        SqlDbProvidersSqlServer = 13,

        /// <summary>
        /// Enum SqlDbProvidersSybaseAse for value: SqlDb_Providers_SybaseAse
        /// </summary>
        [EnumMember(Value = "SqlDb_Providers_SybaseAse")]
        SqlDbProvidersSybaseAse = 14,

        /// <summary>
        /// Enum SqlDbProvidersSqLite for value: SqlDb_Providers_SqLite
        /// </summary>
        [EnumMember(Value = "SqlDb_Providers_SqLite")]
        SqlDbProvidersSqLite = 15,

        /// <summary>
        /// Enum SqlDbProvidersDuckDb for value: SqlDb_Providers_DuckDb
        /// </summary>
        [EnumMember(Value = "SqlDb_Providers_DuckDb")]
        SqlDbProvidersDuckDb = 16,

        /// <summary>
        /// Enum JdbcDriver for value: Jdbc_Driver
        /// </summary>
        [EnumMember(Value = "Jdbc_Driver")]
        JdbcDriver = 17,

        /// <summary>
        /// Enum PowerBiConnector for value: PowerBi_Connector
        /// </summary>
        [EnumMember(Value = "PowerBi_Connector")]
        PowerBiConnector = 18,

        /// <summary>
        /// Enum OdbcWin64Driver for value: Odbc_Win64_Driver
        /// </summary>
        [EnumMember(Value = "Odbc_Win64_Driver")]
        OdbcWin64Driver = 19

    }

}
