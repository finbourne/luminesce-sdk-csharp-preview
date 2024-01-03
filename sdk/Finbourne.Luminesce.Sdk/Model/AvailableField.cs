/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.14.225
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
    /// Information about a field that can be designed on (regardless if it currently is)  Kind of a \&quot;mini-available catalog entry\&quot;
    /// </summary>
    [DataContract(Name = "AvailableField")]
    public partial class AvailableField : IEquatable<AvailableField>
    {

        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name = "dataType", EmitDefaultValue = false)]
        public DataType? DataType { get; set; }

        /// <summary>
        /// Gets or Sets FieldType
        /// </summary>
        [DataMember(Name = "fieldType", IsRequired = true, EmitDefaultValue = false)]
        public FieldType FieldType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AvailableField() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableField" /> class.
        /// </summary>
        /// <param name="name">Name of the Field (required).</param>
        /// <param name="dataType">dataType.</param>
        /// <param name="fieldType">fieldType (required).</param>
        /// <param name="isMain">Is this a Main Field within the Provider.</param>
        /// <param name="isPrimaryKey">Is this a member of the PrimaryKey of the Provider.</param>
        public AvailableField(string name = default(string), DataType? dataType = default(DataType?), FieldType fieldType = default(FieldType), bool? isMain = default(bool?), bool? isPrimaryKey = default(bool?))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for AvailableField and cannot be null");
            this.FieldType = fieldType;
            this.DataType = dataType;
            this.IsMain = isMain;
            this.IsPrimaryKey = isPrimaryKey;
        }

        /// <summary>
        /// Name of the Field
        /// </summary>
        /// <value>Name of the Field</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Is this a Main Field within the Provider
        /// </summary>
        /// <value>Is this a Main Field within the Provider</value>
        [DataMember(Name = "isMain", EmitDefaultValue = true)]
        public bool? IsMain { get; set; }

        /// <summary>
        /// Is this a member of the PrimaryKey of the Provider
        /// </summary>
        /// <value>Is this a member of the PrimaryKey of the Provider</value>
        [DataMember(Name = "isPrimaryKey", EmitDefaultValue = true)]
        public bool? IsPrimaryKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailableField {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
            sb.Append("  IsMain: ").Append(IsMain).Append("\n");
            sb.Append("  IsPrimaryKey: ").Append(IsPrimaryKey).Append("\n");
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
            return this.Equals(input as AvailableField);
        }

        /// <summary>
        /// Returns true if AvailableField instances are equal
        /// </summary>
        /// <param name="input">Instance of AvailableField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailableField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DataType == input.DataType ||
                    this.DataType.Equals(input.DataType)
                ) && 
                (
                    this.FieldType == input.FieldType ||
                    this.FieldType.Equals(input.FieldType)
                ) && 
                (
                    this.IsMain == input.IsMain ||
                    (this.IsMain != null &&
                    this.IsMain.Equals(input.IsMain))
                ) && 
                (
                    this.IsPrimaryKey == input.IsPrimaryKey ||
                    (this.IsPrimaryKey != null &&
                    this.IsPrimaryKey.Equals(input.IsPrimaryKey))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.DataType.GetHashCode();
                hashCode = hashCode * 59 + this.FieldType.GetHashCode();
                if (this.IsMain != null)
                    hashCode = hashCode * 59 + this.IsMain.GetHashCode();
                if (this.IsPrimaryKey != null)
                    hashCode = hashCode * 59 + this.IsPrimaryKey.GetHashCode();
                return hashCode;
            }
        }

    }
}
