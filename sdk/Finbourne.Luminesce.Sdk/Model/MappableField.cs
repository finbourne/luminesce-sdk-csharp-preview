/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.16.540
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
    [DataContract(Name = "MappableField")]
    public partial class MappableField : IEquatable<MappableField>
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public DataType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MappableField" /> class.
        /// </summary>
        /// <param name="name">Name of the field in need of mapping (The field name from within the Table Parameter itself).</param>
        /// <param name="type">type.</param>
        /// <param name="description">Description of the field (just for rendering to the user).</param>
        /// <param name="displayName">Display Name of the field (just for rendering to the user).</param>
        /// <param name="sampleValues">Example values for the field (just for rendering to the user).</param>
        /// <param name="allowedValues">Any set of exactly allowed values for the field (perhaps just for rendering to the user, if nothing else).</param>
        /// <param name="mandatoryForActions">Which &#x60;Actions&#x60; is this mandatory for? If any (and potentially when), perhaps just for rendering to the user, if nothing else.</param>
        /// <param name="mapping">mapping.</param>
        public MappableField(string name = default(string), DataType? type = default(DataType?), string description = default(string), string displayName = default(string), string sampleValues = default(string), string allowedValues = default(string), string mandatoryForActions = default(string), ExpressionWithAlias mapping = default(ExpressionWithAlias))
        {
            this.Name = name;
            this.Type = type;
            this.Description = description;
            this.DisplayName = displayName;
            this.SampleValues = sampleValues;
            this.AllowedValues = allowedValues;
            this.MandatoryForActions = mandatoryForActions;
            this.Mapping = mapping;
        }

        /// <summary>
        /// Name of the field in need of mapping (The field name from within the Table Parameter itself)
        /// </summary>
        /// <value>Name of the field in need of mapping (The field name from within the Table Parameter itself)</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Description of the field (just for rendering to the user)
        /// </summary>
        /// <value>Description of the field (just for rendering to the user)</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Display Name of the field (just for rendering to the user)
        /// </summary>
        /// <value>Display Name of the field (just for rendering to the user)</value>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Example values for the field (just for rendering to the user)
        /// </summary>
        /// <value>Example values for the field (just for rendering to the user)</value>
        [DataMember(Name = "sampleValues", EmitDefaultValue = true)]
        public string SampleValues { get; set; }

        /// <summary>
        /// Any set of exactly allowed values for the field (perhaps just for rendering to the user, if nothing else)
        /// </summary>
        /// <value>Any set of exactly allowed values for the field (perhaps just for rendering to the user, if nothing else)</value>
        [DataMember(Name = "allowedValues", EmitDefaultValue = true)]
        public string AllowedValues { get; set; }

        /// <summary>
        /// Which &#x60;Actions&#x60; is this mandatory for? If any (and potentially when), perhaps just for rendering to the user, if nothing else
        /// </summary>
        /// <value>Which &#x60;Actions&#x60; is this mandatory for? If any (and potentially when), perhaps just for rendering to the user, if nothing else</value>
        [DataMember(Name = "mandatoryForActions", EmitDefaultValue = true)]
        public string MandatoryForActions { get; set; }

        /// <summary>
        /// Gets or Sets Mapping
        /// </summary>
        [DataMember(Name = "mapping", EmitDefaultValue = false)]
        public ExpressionWithAlias Mapping { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MappableField {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  SampleValues: ").Append(SampleValues).Append("\n");
            sb.Append("  AllowedValues: ").Append(AllowedValues).Append("\n");
            sb.Append("  MandatoryForActions: ").Append(MandatoryForActions).Append("\n");
            sb.Append("  Mapping: ").Append(Mapping).Append("\n");
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
            return this.Equals(input as MappableField);
        }

        /// <summary>
        /// Returns true if MappableField instances are equal
        /// </summary>
        /// <param name="input">Instance of MappableField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MappableField input)
        {
            if (input == null)
                return false;

            return 
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
                    this.SampleValues == input.SampleValues ||
                    (this.SampleValues != null &&
                    this.SampleValues.Equals(input.SampleValues))
                ) && 
                (
                    this.AllowedValues == input.AllowedValues ||
                    (this.AllowedValues != null &&
                    this.AllowedValues.Equals(input.AllowedValues))
                ) && 
                (
                    this.MandatoryForActions == input.MandatoryForActions ||
                    (this.MandatoryForActions != null &&
                    this.MandatoryForActions.Equals(input.MandatoryForActions))
                ) && 
                (
                    this.Mapping == input.Mapping ||
                    (this.Mapping != null &&
                    this.Mapping.Equals(input.Mapping))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.SampleValues != null)
                    hashCode = hashCode * 59 + this.SampleValues.GetHashCode();
                if (this.AllowedValues != null)
                    hashCode = hashCode * 59 + this.AllowedValues.GetHashCode();
                if (this.MandatoryForActions != null)
                    hashCode = hashCode * 59 + this.MandatoryForActions.GetHashCode();
                if (this.Mapping != null)
                    hashCode = hashCode * 59 + this.Mapping.GetHashCode();
                return hashCode;
            }
        }

    }
}
