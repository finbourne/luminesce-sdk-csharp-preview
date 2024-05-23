/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.15.278
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
    /// Representation of a request for IntellisenseItems
    /// </summary>
    [DataContract(Name = "IntellisenseRequest")]
    public partial class IntellisenseRequest : IEquatable<IntellisenseRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntellisenseRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IntellisenseRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntellisenseRequest" /> class.
        /// </summary>
        /// <param name="lines">The lines of text the user currently has in the editor (required).</param>
        /// <param name="position">position (required).</param>
        public IntellisenseRequest(List<string> lines = default(List<string>), CursorPosition position = default(CursorPosition))
        {
            // to ensure "lines" is required (not null)
            this.Lines = lines ?? throw new ArgumentNullException("lines is a required property for IntellisenseRequest and cannot be null");
            // to ensure "position" is required (not null)
            this.Position = position ?? throw new ArgumentNullException("position is a required property for IntellisenseRequest and cannot be null");
        }

        /// <summary>
        /// The lines of text the user currently has in the editor
        /// </summary>
        /// <value>The lines of text the user currently has in the editor</value>
        [DataMember(Name = "lines", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Lines { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", IsRequired = true, EmitDefaultValue = false)]
        public CursorPosition Position { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntellisenseRequest {\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
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
            return this.Equals(input as IntellisenseRequest);
        }

        /// <summary>
        /// Returns true if IntellisenseRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of IntellisenseRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntellisenseRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Lines == input.Lines ||
                    this.Lines != null &&
                    input.Lines != null &&
                    this.Lines.SequenceEqual(input.Lines)
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
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
                if (this.Lines != null)
                    hashCode = hashCode * 59 + this.Lines.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                return hashCode;
            }
        }

    }
}
