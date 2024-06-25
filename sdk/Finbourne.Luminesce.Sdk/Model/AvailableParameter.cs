/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.16.179
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
    /// Information about a field that can be designed on (regardless if it currently is)  Kind of a \&quot;mini-available catalog entry\&quot;
    /// </summary>
    [DataContract(Name = "AvailableParameter")]
    public partial class AvailableParameter : IEquatable<AvailableParameter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableParameter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AvailableParameter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableParameter" /> class.
        /// </summary>
        /// <param name="providerName">Name of the Provider with a TableParameter (required).</param>
        /// <param name="parameterName">Name of the TableParameter on the Provider (required).</param>
        /// <param name="fields">Fields that can be mapped to (required).</param>
        public AvailableParameter(string providerName = default(string), string parameterName = default(string), List<MappableField> fields = default(List<MappableField>))
        {
            // to ensure "providerName" is required (not null)
            this.ProviderName = providerName ?? throw new ArgumentNullException("providerName is a required property for AvailableParameter and cannot be null");
            // to ensure "parameterName" is required (not null)
            this.ParameterName = parameterName ?? throw new ArgumentNullException("parameterName is a required property for AvailableParameter and cannot be null");
            // to ensure "fields" is required (not null)
            this.Fields = fields ?? throw new ArgumentNullException("fields is a required property for AvailableParameter and cannot be null");
        }

        /// <summary>
        /// Name of the Provider with a TableParameter
        /// </summary>
        /// <value>Name of the Provider with a TableParameter</value>
        [DataMember(Name = "providerName", IsRequired = true, EmitDefaultValue = false)]
        public string ProviderName { get; set; }

        /// <summary>
        /// Name of the TableParameter on the Provider
        /// </summary>
        /// <value>Name of the TableParameter on the Provider</value>
        [DataMember(Name = "parameterName", IsRequired = true, EmitDefaultValue = false)]
        public string ParameterName { get; set; }

        /// <summary>
        /// Fields that can be mapped to
        /// </summary>
        /// <value>Fields that can be mapped to</value>
        [DataMember(Name = "fields", IsRequired = true, EmitDefaultValue = false)]
        public List<MappableField> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailableParameter {\n");
            sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
            sb.Append("  ParameterName: ").Append(ParameterName).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(input as AvailableParameter);
        }

        /// <summary>
        /// Returns true if AvailableParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of AvailableParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailableParameter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProviderName == input.ProviderName ||
                    (this.ProviderName != null &&
                    this.ProviderName.Equals(input.ProviderName))
                ) && 
                (
                    this.ParameterName == input.ParameterName ||
                    (this.ParameterName != null &&
                    this.ParameterName.Equals(input.ParameterName))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
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
                if (this.ProviderName != null)
                    hashCode = hashCode * 59 + this.ProviderName.GetHashCode();
                if (this.ParameterName != null)
                    hashCode = hashCode * 59 + this.ParameterName.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                return hashCode;
            }
        }

    }
}
