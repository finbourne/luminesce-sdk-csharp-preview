/*
 * FINBOURNE Luminesce Web API
 *
 *  ``` >   __                    _                             / /   __  ______ ___  (_)___  ___  _____________    / /   / / / / __ `__ / / __ / _ / ___/ ___/ _ \\  / /___/ /_/ / / / / / / / / / /  __(__  ) /__/  __/ /_____/\\__,_/_/ /_/ /_/_/_/ /_/\\___/____/\\___/\\___/  ```  ### Introduction to Luminesce   [Luminesce](https://support.lusid.com/knowledgebase/article/KA-01677/) is a data virtualization engine for LUSID and other applications.  It is proprietary technology designed and developed by FINBOURNE Technology Limited.  [Understanding the Luminesce platform architecture.](https://support.lusid.com/knowledgebase/article/KA-01707/)  Luminesce enables you to query multiple sources of business intelligence simultaneously in real-time—including investment management data stored in LUSID itself—and build a consolidated picture for analysis, optionally writing data back into LUSID. Alternatively, you can use Luminesce in a standalone capacity, without interacting with LUSID at all.  ### WebAPI  Allows for running queries and a variety of other functions relating to Luminesce. For example these REST APIs can execute queries, synchronously or better asynchronously, returning results in either Excel, CSV, SqLite, JSON among other formats.  ### Error Codes  | Code|Meaning | | - --|- -- | | <a name=\"233\">233</a>|Query Parser Failure | | <a name=\"850\">850</a>|Required provider not visible; provider may not exist, be temporarily unavailable, or you may not have the necessary permissions | | <a name=\"851\">851</a>|Query reached a timeout period or was cancelled | | <a name=\"852\">852</a>|Query failed during execution | | <a name=\"853\">853</a>|Query failed during execution for an unexpected reason | | <a name=\"854\">854</a>|Query failed during execution for a reason known to be an internal error (e.g. a Lusid provider where a corresponding API would return a 500) | | <a name=\"855\">855</a>|Required column is not in the queried provider(s) | | <a name=\"856\">856</a>|One or more columns are ambiguously referenced in the query | | <a name=\"857\">857</a>|Query failed during execution of a provider (e.g. in a way that might be transient, like an upstream issue) | | <a name=\"858\">858</a>|Query failed during execution within the Query Engine's SQL processing | | <a name=\"859\">859</a>|A variable has been defined more than once | 
 *
 * The version of the OpenAPI document: 1.16.640
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
    /// Column
    /// </summary>
    [DataContract(Name = "Column")]
    public partial class Column : IEquatable<Column>
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public DataType? Type { get; set; }

        /// <summary>
        /// Gets or Sets ConditionUsage
        /// </summary>
        [DataMember(Name = "conditionUsage", EmitDefaultValue = false)]
        public ConditionAttributes? ConditionUsage { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Column" /> class.
        /// </summary>
        /// <param name="isPrimaryKey">isPrimaryKey.</param>
        /// <param name="isMain">isMain.</param>
        /// <param name="isRequiredByProvider">isRequiredByProvider.</param>
        /// <param name="mandatoryForActions">mandatoryForActions.</param>
        /// <param name="clientIds">clientIds.</param>
        /// <param name="type">type.</param>
        /// <param name="description">description.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="conditionUsage">conditionUsage.</param>
        /// <param name="sampleValues">sampleValues.</param>
        /// <param name="allowedValues">allowedValues.</param>
        public Column(bool isPrimaryKey = default(bool), bool isMain = default(bool), bool isRequiredByProvider = default(bool), string mandatoryForActions = default(string), List<string> clientIds = default(List<string>), DataType? type = default(DataType?), string description = default(string), string displayName = default(string), ConditionAttributes? conditionUsage = default(ConditionAttributes?), string sampleValues = default(string), string allowedValues = default(string))
        {
            this.IsPrimaryKey = isPrimaryKey;
            this.IsMain = isMain;
            this.IsRequiredByProvider = isRequiredByProvider;
            this.MandatoryForActions = mandatoryForActions;
            this.ClientIds = clientIds;
            this.Type = type;
            this.Description = description;
            this.DisplayName = displayName;
            this.ConditionUsage = conditionUsage;
            this.SampleValues = sampleValues;
            this.AllowedValues = allowedValues;
        }

        /// <summary>
        /// Gets or Sets IsPrimaryKey
        /// </summary>
        [DataMember(Name = "isPrimaryKey", EmitDefaultValue = true)]
        public bool IsPrimaryKey { get; set; }

        /// <summary>
        /// Gets or Sets IsMain
        /// </summary>
        [DataMember(Name = "isMain", EmitDefaultValue = true)]
        public bool IsMain { get; set; }

        /// <summary>
        /// Gets or Sets IsRequiredByProvider
        /// </summary>
        [DataMember(Name = "isRequiredByProvider", EmitDefaultValue = true)]
        public bool IsRequiredByProvider { get; set; }

        /// <summary>
        /// Gets or Sets MandatoryForActions
        /// </summary>
        [DataMember(Name = "mandatoryForActions", EmitDefaultValue = true)]
        public string MandatoryForActions { get; set; }

        /// <summary>
        /// Gets or Sets ClientIds
        /// </summary>
        [DataMember(Name = "clientIds", EmitDefaultValue = true)]
        public List<string> ClientIds { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; private set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets SampleValues
        /// </summary>
        [DataMember(Name = "sampleValues", EmitDefaultValue = true)]
        public string SampleValues { get; set; }

        /// <summary>
        /// Gets or Sets AllowedValues
        /// </summary>
        [DataMember(Name = "allowedValues", EmitDefaultValue = true)]
        public string AllowedValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Column {\n");
            sb.Append("  IsPrimaryKey: ").Append(IsPrimaryKey).Append("\n");
            sb.Append("  IsMain: ").Append(IsMain).Append("\n");
            sb.Append("  IsRequiredByProvider: ").Append(IsRequiredByProvider).Append("\n");
            sb.Append("  MandatoryForActions: ").Append(MandatoryForActions).Append("\n");
            sb.Append("  ClientIds: ").Append(ClientIds).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  ConditionUsage: ").Append(ConditionUsage).Append("\n");
            sb.Append("  SampleValues: ").Append(SampleValues).Append("\n");
            sb.Append("  AllowedValues: ").Append(AllowedValues).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Column);
        }

        /// <summary>
        /// Returns true if Column instances are equal
        /// </summary>
        /// <param name="input">Instance of Column to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Column input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsPrimaryKey == input.IsPrimaryKey ||
                    this.IsPrimaryKey.Equals(input.IsPrimaryKey)
                ) && 
                (
                    this.IsMain == input.IsMain ||
                    this.IsMain.Equals(input.IsMain)
                ) && 
                (
                    this.IsRequiredByProvider == input.IsRequiredByProvider ||
                    this.IsRequiredByProvider.Equals(input.IsRequiredByProvider)
                ) && 
                (
                    this.MandatoryForActions == input.MandatoryForActions ||
                    (this.MandatoryForActions != null &&
                    this.MandatoryForActions.Equals(input.MandatoryForActions))
                ) && 
                (
                    this.ClientIds == input.ClientIds ||
                    this.ClientIds != null &&
                    input.ClientIds != null &&
                    this.ClientIds.SequenceEqual(input.ClientIds)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.ConditionUsage == input.ConditionUsage ||
                    this.ConditionUsage.Equals(input.ConditionUsage)
                ) && 
                (
                    this.SampleValues == input.SampleValues ||
                    (this.SampleValues != null &&
                    this.SampleValues.Equals(input.SampleValues))
                ) && 
                (
                    this.AllowedValues == input.AllowedValues ||
                    (this.AllowedValues != null &&
                    this.AllowedValues.Equals(input.AllowedValues))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.IsPrimaryKey.GetHashCode();
                hashCode = hashCode * 59 + this.IsMain.GetHashCode();
                hashCode = hashCode * 59 + this.IsRequiredByProvider.GetHashCode();
                if (this.MandatoryForActions != null)
                    hashCode = hashCode * 59 + this.MandatoryForActions.GetHashCode();
                if (this.ClientIds != null)
                    hashCode = hashCode * 59 + this.ClientIds.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                hashCode = hashCode * 59 + this.ConditionUsage.GetHashCode();
                if (this.SampleValues != null)
                    hashCode = hashCode * 59 + this.SampleValues.GetHashCode();
                if (this.AllowedValues != null)
                    hashCode = hashCode * 59 + this.AllowedValues.GetHashCode();
                return hashCode;
            }
        }

    }
}
