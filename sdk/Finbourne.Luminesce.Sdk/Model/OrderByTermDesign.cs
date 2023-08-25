/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.13.366
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
    /// A single clause within an Order BY
    /// </summary>
    [DataContract(Name = "OrderByTermDesign")]
    public partial class OrderByTermDesign : IEquatable<OrderByTermDesign>
    {

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name = "direction", EmitDefaultValue = false)]
        public OrderByDirection? Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderByTermDesign" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderByTermDesign() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderByTermDesign" /> class.
        /// </summary>
        /// <param name="field">Name of the field to order by (required).</param>
        /// <param name="direction">direction.</param>
        public OrderByTermDesign(string field = default(string), OrderByDirection? direction = default(OrderByDirection?))
        {
            // to ensure "field" is required (not null)
            this.Field = field ?? throw new ArgumentNullException("field is a required property for OrderByTermDesign and cannot be null");
            this.Direction = direction;
        }

        /// <summary>
        /// Name of the field to order by
        /// </summary>
        /// <value>Name of the field to order by</value>
        [DataMember(Name = "field", IsRequired = true, EmitDefaultValue = false)]
        public string Field { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderByTermDesign {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
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
            return this.Equals(input as OrderByTermDesign);
        }

        /// <summary>
        /// Returns true if OrderByTermDesign instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderByTermDesign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderByTermDesign input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
                ) && 
                (
                    this.Direction == input.Direction ||
                    this.Direction.Equals(input.Direction)
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
                if (this.Field != null)
                    hashCode = hashCode * 59 + this.Field.GetHashCode();
                hashCode = hashCode * 59 + this.Direction.GetHashCode();
                return hashCode;
            }
        }

    }
}
