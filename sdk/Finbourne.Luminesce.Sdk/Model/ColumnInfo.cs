/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.14.76
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
    /// Information on how to construct a file-read sql query
    /// </summary>
    [DataContract(Name = "ColumnInfo")]
    public partial class ColumnInfo : IEquatable<ColumnInfo>
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public DataType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnInfo" /> class.
        /// </summary>
        /// <param name="select">Should the column be used/selected?.</param>
        /// <param name="type">type.</param>
        /// <param name="name">The name of the column.</param>
        /// <param name="xPath">Xpath for the column (only applicable to XML defined columns).</param>
        public ColumnInfo(bool select = default(bool), DataType? type = default(DataType?), string name = default(string), string xPath = default(string))
        {
            this.Select = select;
            this.Type = type;
            this.Name = name;
            this.XPath = xPath;
        }

        /// <summary>
        /// Should the column be used/selected?
        /// </summary>
        /// <value>Should the column be used/selected?</value>
        [DataMember(Name = "select", EmitDefaultValue = true)]
        public bool Select { get; set; }

        /// <summary>
        /// The name of the column
        /// </summary>
        /// <value>The name of the column</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Xpath for the column (only applicable to XML defined columns)
        /// </summary>
        /// <value>Xpath for the column (only applicable to XML defined columns)</value>
        [DataMember(Name = "xPath", EmitDefaultValue = true)]
        public string XPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ColumnInfo {\n");
            sb.Append("  Select: ").Append(Select).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  XPath: ").Append(XPath).Append("\n");
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
            return this.Equals(input as ColumnInfo);
        }

        /// <summary>
        /// Returns true if ColumnInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ColumnInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ColumnInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Select == input.Select ||
                    this.Select.Equals(input.Select)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.XPath == input.XPath ||
                    (this.XPath != null &&
                    this.XPath.Equals(input.XPath))
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
                hashCode = hashCode * 59 + this.Select.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.XPath != null)
                    hashCode = hashCode * 59 + this.XPath.GetHashCode();
                return hashCode;
            }
        }

    }
}
