/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.16.31
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
    /// Response for error highlighting
    /// </summary>
    [DataContract(Name = "ErrorHighlightResponse")]
    public partial class ErrorHighlightResponse : IEquatable<ErrorHighlightResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorHighlightResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ErrorHighlightResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorHighlightResponse" /> class.
        /// </summary>
        /// <param name="errors">The errors within the Sql (required).</param>
        /// <param name="sqlWithMarker">The SQL this is for, with characters indicating the error locations (required).</param>
        public ErrorHighlightResponse(List<ErrorHighlightItem> errors = default(List<ErrorHighlightItem>), string sqlWithMarker = default(string))
        {
            // to ensure "errors" is required (not null)
            this.Errors = errors ?? throw new ArgumentNullException("errors is a required property for ErrorHighlightResponse and cannot be null");
            // to ensure "sqlWithMarker" is required (not null)
            this.SqlWithMarker = sqlWithMarker ?? throw new ArgumentNullException("sqlWithMarker is a required property for ErrorHighlightResponse and cannot be null");
        }

        /// <summary>
        /// The errors within the Sql
        /// </summary>
        /// <value>The errors within the Sql</value>
        [DataMember(Name = "errors", IsRequired = true, EmitDefaultValue = false)]
        public List<ErrorHighlightItem> Errors { get; set; }

        /// <summary>
        /// The SQL this is for, with characters indicating the error locations
        /// </summary>
        /// <value>The SQL this is for, with characters indicating the error locations</value>
        [DataMember(Name = "sqlWithMarker", IsRequired = true, EmitDefaultValue = false)]
        public string SqlWithMarker { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorHighlightResponse {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  SqlWithMarker: ").Append(SqlWithMarker).Append("\n");
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
            return this.Equals(input as ErrorHighlightResponse);
        }

        /// <summary>
        /// Returns true if ErrorHighlightResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorHighlightResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorHighlightResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                ) && 
                (
                    this.SqlWithMarker == input.SqlWithMarker ||
                    (this.SqlWithMarker != null &&
                    this.SqlWithMarker.Equals(input.SqlWithMarker))
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
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                if (this.SqlWithMarker != null)
                    hashCode = hashCode * 59 + this.SqlWithMarker.GetHashCode();
                return hashCode;
            }
        }

    }
}
