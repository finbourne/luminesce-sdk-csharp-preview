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
    /// How to aggregate over a field
    /// </summary>
    [DataContract(Name = "Aggregation")]
    public partial class Aggregation : IEquatable<Aggregation>
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public AggregateFunction Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Aggregation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Aggregation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Aggregation" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="alias">Alias, if any, for the Aggregate expression when selected.</param>
        public Aggregation(AggregateFunction type = default(AggregateFunction), string alias = default(string))
        {
            this.Type = type;
            this.Alias = alias;
        }

        /// <summary>
        /// Alias, if any, for the Aggregate expression when selected
        /// </summary>
        /// <value>Alias, if any, for the Aggregate expression when selected</value>
        [DataMember(Name = "alias", EmitDefaultValue = true)]
        public string Alias { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Aggregation {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
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
            return this.Equals(input as Aggregation);
        }

        /// <summary>
        /// Returns true if Aggregation instances are equal
        /// </summary>
        /// <param name="input">Instance of Aggregation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Aggregation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                return hashCode;
            }
        }

    }
}
