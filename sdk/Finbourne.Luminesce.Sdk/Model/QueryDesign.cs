/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.13.471
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
    /// Representation of a \&quot;designable Query\&quot; suitable for formatting to SQL or being built from compliant SQL.
    /// </summary>
    [DataContract(Name = "QueryDesign")]
    public partial class QueryDesign : IEquatable<QueryDesign>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryDesign" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueryDesign() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryDesign" /> class.
        /// </summary>
        /// <param name="tableName">Name of the table being designed (required).</param>
        /// <param name="alias">Alias for the table in the generated SQL, if any.</param>
        /// <param name="fields">Fields to be selected, aggregated over and/or filtered on (required).</param>
        /// <param name="orderBy">Order By clauses to apply.</param>
        /// <param name="limit">Row limit to apply, if any.</param>
        /// <param name="warnings">Any warnings to show the user when converting from SQL to this representation.</param>
        /// <param name="availableFields">Fields that are known to be available for design when parsing SQL.</param>
        public QueryDesign(string tableName = default(string), string alias = default(string), List<FieldDesign> fields = default(List<FieldDesign>), List<OrderByTermDesign> orderBy = default(List<OrderByTermDesign>), int? limit = default(int?), List<string> warnings = default(List<string>), List<AvailableField> availableFields = default(List<AvailableField>))
        {
            // to ensure "tableName" is required (not null)
            this.TableName = tableName ?? throw new ArgumentNullException("tableName is a required property for QueryDesign and cannot be null");
            // to ensure "fields" is required (not null)
            this.Fields = fields ?? throw new ArgumentNullException("fields is a required property for QueryDesign and cannot be null");
            this.Alias = alias;
            this.OrderBy = orderBy;
            this.Limit = limit;
            this.Warnings = warnings;
            this.AvailableFields = availableFields;
        }

        /// <summary>
        /// Name of the table being designed
        /// </summary>
        /// <value>Name of the table being designed</value>
        [DataMember(Name = "tableName", IsRequired = true, EmitDefaultValue = false)]
        public string TableName { get; set; }

        /// <summary>
        /// Alias for the table in the generated SQL, if any
        /// </summary>
        /// <value>Alias for the table in the generated SQL, if any</value>
        [DataMember(Name = "alias", EmitDefaultValue = true)]
        public string Alias { get; set; }

        /// <summary>
        /// Fields to be selected, aggregated over and/or filtered on
        /// </summary>
        /// <value>Fields to be selected, aggregated over and/or filtered on</value>
        [DataMember(Name = "fields", IsRequired = true, EmitDefaultValue = false)]
        public List<FieldDesign> Fields { get; set; }

        /// <summary>
        /// Order By clauses to apply
        /// </summary>
        /// <value>Order By clauses to apply</value>
        [DataMember(Name = "orderBy", EmitDefaultValue = true)]
        public List<OrderByTermDesign> OrderBy { get; set; }

        /// <summary>
        /// Row limit to apply, if any
        /// </summary>
        /// <value>Row limit to apply, if any</value>
        [DataMember(Name = "limit", EmitDefaultValue = true)]
        public int? Limit { get; set; }

        /// <summary>
        /// Any warnings to show the user when converting from SQL to this representation
        /// </summary>
        /// <value>Any warnings to show the user when converting from SQL to this representation</value>
        [DataMember(Name = "warnings", EmitDefaultValue = true)]
        public List<string> Warnings { get; set; }

        /// <summary>
        /// Fields that are known to be available for design when parsing SQL
        /// </summary>
        /// <value>Fields that are known to be available for design when parsing SQL</value>
        [DataMember(Name = "availableFields", EmitDefaultValue = true)]
        public List<AvailableField> AvailableFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryDesign {\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  OrderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
            sb.Append("  AvailableFields: ").Append(AvailableFields).Append("\n");
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
            return this.Equals(input as QueryDesign);
        }

        /// <summary>
        /// Returns true if QueryDesign instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryDesign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryDesign input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.OrderBy == input.OrderBy ||
                    this.OrderBy != null &&
                    input.OrderBy != null &&
                    this.OrderBy.SequenceEqual(input.OrderBy)
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
                ) && 
                (
                    this.AvailableFields == input.AvailableFields ||
                    this.AvailableFields != null &&
                    input.AvailableFields != null &&
                    this.AvailableFields.SequenceEqual(input.AvailableFields)
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
                if (this.TableName != null)
                    hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.OrderBy != null)
                    hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Warnings != null)
                    hashCode = hashCode * 59 + this.Warnings.GetHashCode();
                if (this.AvailableFields != null)
                    hashCode = hashCode * 59 + this.AvailableFields.GetHashCode();
                return hashCode;
            }
        }

    }
}
