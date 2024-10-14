/*
 * FINBOURNE Luminesce Web API
 *
 *  ``` >   __                    _                             / /   __  ______ ___  (_)___  ___  _____________    / /   / / / / __ `__ / / __ / _ / ___/ ___/ _ \\  / /___/ /_/ / / / / / / / / / /  __(__  ) /__/  __/ /_____/\\__,_/_/ /_/ /_/_/_/ /_/\\___/____/\\___/\\___/  ```  ### Introduction to Luminesce   [Luminesce](https://support.lusid.com/knowledgebase/article/KA-01677/) is a data virtualization engine for LUSID and other applications.  It is proprietary technology designed and developed by FINBOURNE Technology Limited.  [Understanding the Luminesce platform architecture.](https://support.lusid.com/knowledgebase/article/KA-01707/)  Luminesce enables you to query multiple sources of business intelligence simultaneously in real-time—including investment management data stored in LUSID itself—and build a consolidated picture for analysis, optionally writing data back into LUSID. Alternatively, you can use Luminesce in a standalone capacity, without interacting with LUSID at all.  ### WebAPI  Allows for running queries and a variety of other functions relating to Luminesce. For example these REST APIs can execute queries, synchronously or better asynchronously, returning results in either Excel, CSV, SqLite, JSON among other formats.  ### Error Codes  | Code|Meaning | | - --|- -- | | <a name=\"233\">233</a>|Query Parser Failure | | <a name=\"850\">850</a>|Required provider not visible; provider may not exist, be temporarily unavailable, or you may not have the necessary permissions | | <a name=\"851\">851</a>|Query reached a timeout period or was cancelled | | <a name=\"852\">852</a>|Query failed during execution | | <a name=\"853\">853</a>|Query failed during execution for an unexpected reason | | <a name=\"854\">854</a>|Query failed during execution for a reason known to be an internal error (e.g. a Lusid provider where a corresponding API would return a 500) | | <a name=\"855\">855</a>|Required column is not in the queried provider(s) | | <a name=\"856\">856</a>|One or more columns are ambiguously referenced in the query | | <a name=\"857\">857</a>|Query failed during execution of a provider (e.g. in a way that might be transient, like an upstream issue) | | <a name=\"858\">858</a>|Query failed during execution within the Query Engine's SQL processing | | <a name=\"859\">859</a>|A variable has been defined more than once | 
 *
 * The version of the OpenAPI document: 1.16.699
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
        /// Enum SqlDbProvidersAwsDynamoDb for value: SqlDb_Providers_AwsDynamoDb
        /// </summary>
        [EnumMember(Value = "SqlDb_Providers_AwsDynamoDb")]
        SqlDbProvidersAwsDynamoDb = 17,

        /// <summary>
        /// Enum SqlDbProvidersSqlServerOracle for value: SqlDb_Providers_SqlServer_Oracle
        /// </summary>
        [EnumMember(Value = "SqlDb_Providers_SqlServer_Oracle")]
        SqlDbProvidersSqlServerOracle = 18,

        /// <summary>
        /// Enum JdbcDriver for value: Jdbc_Driver
        /// </summary>
        [EnumMember(Value = "Jdbc_Driver")]
        JdbcDriver = 19,

        /// <summary>
        /// Enum PowerBiConnector for value: PowerBi_Connector
        /// </summary>
        [EnumMember(Value = "PowerBi_Connector")]
        PowerBiConnector = 20,

        /// <summary>
        /// Enum OdbcWin64Driver for value: Odbc_Win64_Driver
        /// </summary>
        [EnumMember(Value = "Odbc_Win64_Driver")]
        OdbcWin64Driver = 21

    }

}
