/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.12.186
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
        InstrumentDiscovery = 9

    }

}
