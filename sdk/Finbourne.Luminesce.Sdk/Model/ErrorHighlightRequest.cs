/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.14.755
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
    /// ErrorHighlightRequest
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
        public ErrorHighlightRequest(List<string> lines = default(List<string>))
        {
            // to ensure "lines" is required (not null)
            this.Lines = lines ?? throw new ArgumentNullException("lines is a required property for ErrorHighlightRequest and cannot be null");
        }

        /// <summary>
        /// The lines of text the user currently has in the editor
        /// </summary>
        /// <value>The lines of text the user currently has in the editor</value>
        [DataMember(Name = "lines", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Lines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorHighlightRequest {\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
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
                return hashCode;
            }
        }

    }
}
