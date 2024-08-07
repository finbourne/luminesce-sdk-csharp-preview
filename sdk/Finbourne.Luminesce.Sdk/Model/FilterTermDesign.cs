/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.16.430
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
    /// A single filter clause
    /// </summary>
    [DataContract(Name = "FilterTermDesign")]
    public partial class FilterTermDesign : IEquatable<FilterTermDesign>
    {

        /// <summary>
        /// Gets or Sets Operator
        /// </summary>
        [DataMember(Name = "operator", IsRequired = true, EmitDefaultValue = false)]
        public QueryDesignerBinaryOperator Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterTermDesign" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FilterTermDesign() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterTermDesign" /> class.
        /// </summary>
        /// <param name="_operator">_operator (required).</param>
        /// <param name="value">The value to compare against (always as a string, but will be formatted to the correct type) (required).</param>
        public FilterTermDesign(QueryDesignerBinaryOperator _operator = default(QueryDesignerBinaryOperator), string value = default(string))
        {
            this.Operator = _operator;
            // to ensure "value" is required (not null)
            this.Value = value ?? throw new ArgumentNullException("value is a required property for FilterTermDesign and cannot be null");
        }

        /// <summary>
        /// The value to compare against (always as a string, but will be formatted to the correct type)
        /// </summary>
        /// <value>The value to compare against (always as a string, but will be formatted to the correct type)</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilterTermDesign {\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as FilterTermDesign);
        }

        /// <summary>
        /// Returns true if FilterTermDesign instances are equal
        /// </summary>
        /// <param name="input">Instance of FilterTermDesign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilterTermDesign input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Operator == input.Operator ||
                    this.Operator.Equals(input.Operator)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }
}
