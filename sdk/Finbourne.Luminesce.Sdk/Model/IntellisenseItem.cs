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
    /// Representation of an item in an Intellisense popup
    /// </summary>
    [DataContract(Name = "IntellisenseItem")]
    public partial class IntellisenseItem : IEquatable<IntellisenseItem>
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public IntellisenseType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntellisenseItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IntellisenseItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntellisenseItem" /> class.
        /// </summary>
        /// <param name="caption">The value to show the user in the popup (required).</param>
        /// <param name="value">The value to substitute in (required).</param>
        /// <param name="meta">The light-grey text shown to the right of the Caption in the popup.</param>
        /// <param name="score">How important is this.  Bigger is more important..</param>
        /// <param name="docHTML">Popup further info (as in a whole documentation article!).</param>
        /// <param name="type">type.</param>
        public IntellisenseItem(string caption = default(string), string value = default(string), string meta = default(string), int score = default(int), string docHTML = default(string), IntellisenseType? type = default(IntellisenseType?))
        {
            // to ensure "caption" is required (not null)
            this.Caption = caption ?? throw new ArgumentNullException("caption is a required property for IntellisenseItem and cannot be null");
            // to ensure "value" is required (not null)
            this.Value = value ?? throw new ArgumentNullException("value is a required property for IntellisenseItem and cannot be null");
            this.Meta = meta;
            this.Score = score;
            this.DocHTML = docHTML;
            this.Type = type;
        }

        /// <summary>
        /// The value to show the user in the popup
        /// </summary>
        /// <value>The value to show the user in the popup</value>
        [DataMember(Name = "caption", IsRequired = true, EmitDefaultValue = false)]
        public string Caption { get; set; }

        /// <summary>
        /// The value to substitute in
        /// </summary>
        /// <value>The value to substitute in</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// The light-grey text shown to the right of the Caption in the popup
        /// </summary>
        /// <value>The light-grey text shown to the right of the Caption in the popup</value>
        [DataMember(Name = "meta", EmitDefaultValue = true)]
        public string Meta { get; set; }

        /// <summary>
        /// How important is this.  Bigger is more important.
        /// </summary>
        /// <value>How important is this.  Bigger is more important.</value>
        [DataMember(Name = "score", EmitDefaultValue = true)]
        public int Score { get; set; }

        /// <summary>
        /// Popup further info (as in a whole documentation article!)
        /// </summary>
        /// <value>Popup further info (as in a whole documentation article!)</value>
        [DataMember(Name = "docHTML", EmitDefaultValue = true)]
        public string DocHTML { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntellisenseItem {\n");
            sb.Append("  Caption: ").Append(Caption).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  DocHTML: ").Append(DocHTML).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as IntellisenseItem);
        }

        /// <summary>
        /// Returns true if IntellisenseItem instances are equal
        /// </summary>
        /// <param name="input">Instance of IntellisenseItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntellisenseItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Caption == input.Caption ||
                    (this.Caption != null &&
                    this.Caption.Equals(input.Caption))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
                ) && 
                (
                    this.Score == input.Score ||
                    this.Score.Equals(input.Score)
                ) && 
                (
                    this.DocHTML == input.DocHTML ||
                    (this.DocHTML != null &&
                    this.DocHTML.Equals(input.DocHTML))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Caption != null)
                    hashCode = hashCode * 59 + this.Caption.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
                hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.DocHTML != null)
                    hashCode = hashCode * 59 + this.DocHTML.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }
}
