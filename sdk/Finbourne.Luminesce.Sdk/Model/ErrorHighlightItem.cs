/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.14.762
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
    /// Representation of a sql error
    /// </summary>
    [DataContract(Name = "ErrorHighlightItem")]
    public partial class ErrorHighlightItem : IEquatable<ErrorHighlightItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorHighlightItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ErrorHighlightItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorHighlightItem" /> class.
        /// </summary>
        /// <param name="start">start (required).</param>
        /// <param name="stop">stop (required).</param>
        /// <param name="length">The length of the error token counting line breaks if any (required).</param>
        /// <param name="message">The error message (required).</param>
        public ErrorHighlightItem(CursorPosition start = default(CursorPosition), CursorPosition stop = default(CursorPosition), int length = default(int), string message = default(string))
        {
            // to ensure "start" is required (not null)
            this.Start = start ?? throw new ArgumentNullException("start is a required property for ErrorHighlightItem and cannot be null");
            // to ensure "stop" is required (not null)
            this.Stop = stop ?? throw new ArgumentNullException("stop is a required property for ErrorHighlightItem and cannot be null");
            this.Length = length;
            // to ensure "message" is required (not null)
            this.Message = message ?? throw new ArgumentNullException("message is a required property for ErrorHighlightItem and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name = "start", IsRequired = true, EmitDefaultValue = false)]
        public CursorPosition Start { get; set; }

        /// <summary>
        /// Gets or Sets Stop
        /// </summary>
        [DataMember(Name = "stop", IsRequired = true, EmitDefaultValue = false)]
        public CursorPosition Stop { get; set; }

        /// <summary>
        /// The length of the error token counting line breaks if any
        /// </summary>
        /// <value>The length of the error token counting line breaks if any</value>
        [DataMember(Name = "length", IsRequired = true, EmitDefaultValue = true)]
        public int Length { get; set; }

        /// <summary>
        /// The error message
        /// </summary>
        /// <value>The error message</value>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorHighlightItem {\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Stop: ").Append(Stop).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as ErrorHighlightItem);
        }

        /// <summary>
        /// Returns true if ErrorHighlightItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorHighlightItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorHighlightItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.Stop == input.Stop ||
                    (this.Stop != null &&
                    this.Stop.Equals(input.Stop))
                ) && 
                (
                    this.Length == input.Length ||
                    this.Length.Equals(input.Length)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.Stop != null)
                    hashCode = hashCode * 59 + this.Stop.GetHashCode();
                hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }

    }
}
