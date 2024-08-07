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
    /// Represents a cursor location
    /// </summary>
    [DataContract(Name = "CursorPosition")]
    public partial class CursorPosition : IEquatable<CursorPosition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CursorPosition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CursorPosition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CursorPosition" /> class.
        /// </summary>
        /// <param name="row">Row (0 based) of the user&#39;s cursor position (required).</param>
        /// <param name="column">Column (0 based) of the user&#39;s cursor position (required).</param>
        public CursorPosition(int row = default(int), int column = default(int))
        {
            this.Row = row;
            this.Column = column;
        }

        /// <summary>
        /// Row (0 based) of the user&#39;s cursor position
        /// </summary>
        /// <value>Row (0 based) of the user&#39;s cursor position</value>
        [DataMember(Name = "row", IsRequired = true, EmitDefaultValue = true)]
        public int Row { get; set; }

        /// <summary>
        /// Column (0 based) of the user&#39;s cursor position
        /// </summary>
        /// <value>Column (0 based) of the user&#39;s cursor position</value>
        [DataMember(Name = "column", IsRequired = true, EmitDefaultValue = true)]
        public int Column { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CursorPosition {\n");
            sb.Append("  Row: ").Append(Row).Append("\n");
            sb.Append("  Column: ").Append(Column).Append("\n");
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
            return this.Equals(input as CursorPosition);
        }

        /// <summary>
        /// Returns true if CursorPosition instances are equal
        /// </summary>
        /// <param name="input">Instance of CursorPosition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CursorPosition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Row == input.Row ||
                    this.Row.Equals(input.Row)
                ) && 
                (
                    this.Column == input.Column ||
                    this.Column.Equals(input.Column)
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
                hashCode = hashCode * 59 + this.Row.GetHashCode();
                hashCode = hashCode * 59 + this.Column.GetHashCode();
                return hashCode;
            }
        }

    }
}
