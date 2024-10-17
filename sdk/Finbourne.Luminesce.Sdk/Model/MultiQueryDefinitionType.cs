/*
 * FINBOURNE Luminesce Web API
 *
 *  ``` >   __                    _                             / /   __  ______ ___  (_)___  ___  _____________    / /   / / / / __ `__ / / __ / _ / ___/ ___/ _ \\  / /___/ /_/ / / / / / / / / / /  __(__  ) /__/  __/ /_____/\\__,_/_/ /_/ /_/_/_/ /_/\\___/____/\\___/\\___/  ```  ### Introduction to Luminesce   [Luminesce](https://support.lusid.com/knowledgebase/article/KA-01677/) is a data virtualization engine for LUSID and other applications.  It is proprietary technology designed and developed by FINBOURNE Technology Limited.  [Understanding the Luminesce platform architecture.](https://support.lusid.com/knowledgebase/article/KA-01707/)  Luminesce enables you to query multiple sources of business intelligence simultaneously in real-time—including investment management data stored in LUSID itself—and build a consolidated picture for analysis, optionally writing data back into LUSID. Alternatively, you can use Luminesce in a standalone capacity, without interacting with LUSID at all.  ### WebAPI  Allows for running queries and a variety of other functions relating to Luminesce. For example these REST APIs can execute queries, synchronously or better asynchronously, returning results in either Excel, CSV, SqLite, JSON among other formats.  ### Error Codes  | Code|Meaning | | - --|- -- | | <a name=\"233\">233</a>|Query Parser Failure | | <a name=\"850\">850</a>|Required provider not visible; provider may not exist, be temporarily unavailable, or you may not have the necessary permissions | | <a name=\"851\">851</a>|Query reached a timeout period or was cancelled | | <a name=\"852\">852</a>|Query failed during execution | | <a name=\"853\">853</a>|Query failed during execution for an unexpected reason | | <a name=\"854\">854</a>|Query failed during execution for a reason known to be an internal error (e.g. a Lusid provider where a corresponding API would return a 500) | | <a name=\"855\">855</a>|Required column is not in the queried provider(s) | | <a name=\"856\">856</a>|One or more columns are ambiguously referenced in the query | | <a name=\"857\">857</a>|Query failed during execution of a provider (e.g. in a way that might be transient, like an upstream issue) | | <a name=\"858\">858</a>|Query failed during execution within the Query Engine's SQL processing | | <a name=\"859\">859</a>|A variable has been defined more than once | 
 *
 * The version of the OpenAPI document: 1.16.736
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
        /// Enum EdiInstrument for value: EdiInstrument
        /// </summary>
        [EnumMember(Value = "EdiInstrument")]
        EdiInstrument = 4,

        /// <summary>
        /// Enum EdiInstrumentWriter for value: EdiInstrumentWriter
        /// </summary>
        [EnumMember(Value = "EdiInstrumentWriter")]
        EdiInstrumentWriter = 5,

        /// <summary>
        /// Enum Testing for value: Testing
        /// </summary>
        [EnumMember(Value = "Testing")]
        Testing = 6,

        /// <summary>
        /// Enum MarketplaceClientLoadHistory for value: MarketplaceClientLoadHistory
        /// </summary>
        [EnumMember(Value = "MarketplaceClientLoadHistory")]
        MarketplaceClientLoadHistory = 7,

        /// <summary>
        /// Enum InsightsMetricsEntitlement for value: InsightsMetricsEntitlement
        /// </summary>
        [EnumMember(Value = "InsightsMetricsEntitlement")]
        InsightsMetricsEntitlement = 8,

        /// <summary>
        /// Enum InstrumentDiscovery for value: InstrumentDiscovery
        /// </summary>
        [EnumMember(Value = "InstrumentDiscovery")]
        InstrumentDiscovery = 9,

        /// <summary>
        /// Enum InstrumentUpsert for value: InstrumentUpsert
        /// </summary>
        [EnumMember(Value = "InstrumentUpsert")]
        InstrumentUpsert = 10

    }

}
