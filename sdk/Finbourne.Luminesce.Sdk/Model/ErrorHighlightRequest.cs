/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.15.113
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
    /// Request for Error highlighting
    /// </summary>
    [DataContract(Name = "ErrorHighlightRequest")]
    public partial class ErrorHighlightRequest : IEquatable<ErrorHighlightRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorHighlightRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ErrorHighlightRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorHighlightRequest" /> class.
        /// </summary>
        /// <param name="lines">The lines of text the user currently has in the editor (required).</param>
        /// <param name="ensureSomeTextIsSelected">If an editor requires some selection of non-whitespace this can be set to true to force  at least one visible character to be selected..</param>
        public ErrorHighlightRequest(List<string> lines = default(List<string>), bool ensureSomeTextIsSelected = default(bool))
        {
            // to ensure "lines" is required (not null)
            this.Lines = lines ?? throw new ArgumentNullException("lines is a required property for ErrorHighlightRequest and cannot be null");
            this.EnsureSomeTextIsSelected = ensureSomeTextIsSelected;
        }

        /// <summary>
        /// The lines of text the user currently has in the editor
        /// </summary>
        /// <value>The lines of text the user currently has in the editor</value>
        [DataMember(Name = "lines", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Lines { get; set; }

        /// <summary>
        /// If an editor requires some selection of non-whitespace this can be set to true to force  at least one visible character to be selected.
        /// </summary>
        /// <value>If an editor requires some selection of non-whitespace this can be set to true to force  at least one visible character to be selected.</value>
        [DataMember(Name = "ensureSomeTextIsSelected", EmitDefaultValue = true)]
        public bool EnsureSomeTextIsSelected { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorHighlightRequest {\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("  EnsureSomeTextIsSelected: ").Append(EnsureSomeTextIsSelected).Append("\n");
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
            return this.Equals(input as ErrorHighlightRequest);
        }

        /// <summary>
        /// Returns true if ErrorHighlightRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorHighlightRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorHighlightRequest input)
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
                    this.EnsureSomeTextIsSelected == input.EnsureSomeTextIsSelected ||
                    this.EnsureSomeTextIsSelected.Equals(input.EnsureSomeTextIsSelected)
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
                hashCode = hashCode * 59 + this.EnsureSomeTextIsSelected.GetHashCode();
                return hashCode;
            }
        }

    }
}
