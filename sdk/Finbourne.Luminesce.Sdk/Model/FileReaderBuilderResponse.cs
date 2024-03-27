/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.14.841
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
    [DataContract(Name = "FileReaderBuilderResponse")]
    public partial class FileReaderBuilderResponse : IEquatable<FileReaderBuilderResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileReaderBuilderResponse" /> class.
        /// </summary>
        /// <param name="query">The generated SQL.</param>
        /// <param name="error">The error from running generated SQL Query, if any.</param>
        /// <param name="columns">Column information for the results.</param>
        /// <param name="data">The resulting data from running the Query.</param>
        public FileReaderBuilderResponse(string query = default(string), string error = default(string), List<ColumnInfo> columns = default(List<ColumnInfo>), Object data = default(Object))
        {
            this.Query = query;
            this.Error = error;
            this.Columns = columns;
            this.Data = data;
        }

        /// <summary>
        /// The generated SQL
        /// </summary>
        /// <value>The generated SQL</value>
        [DataMember(Name = "query", EmitDefaultValue = true)]
        public string Query { get; set; }

        /// <summary>
        /// The error from running generated SQL Query, if any
        /// </summary>
        /// <value>The error from running generated SQL Query, if any</value>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// Column information for the results
        /// </summary>
        /// <value>Column information for the results</value>
        [DataMember(Name = "columns", EmitDefaultValue = true)]
        public List<ColumnInfo> Columns { get; set; }

        /// <summary>
        /// The resulting data from running the Query
        /// </summary>
        /// <value>The resulting data from running the Query</value>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public Object Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileReaderBuilderResponse {\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as FileReaderBuilderResponse);
        }

        /// <summary>
        /// Returns true if FileReaderBuilderResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FileReaderBuilderResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileReaderBuilderResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Columns == input.Columns ||
                    this.Columns != null &&
                    input.Columns != null &&
                    this.Columns.SequenceEqual(input.Columns)
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Columns != null)
                    hashCode = hashCode * 59 + this.Columns.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                return hashCode;
            }
        }

    }
}
