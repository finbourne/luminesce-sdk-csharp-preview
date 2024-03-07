/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.14.677
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
    /// Representation of a \&quot;designable Query for a writer\&quot; suitable for formatting to SQL or being built from compliant SQL.
    /// </summary>
    [DataContract(Name = "WriterDesign")]
    public partial class WriterDesign : IEquatable<WriterDesign>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WriterDesign" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WriterDesign() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WriterDesign" /> class.
        /// </summary>
        /// <param name="sql">Original SQL that started this off (required).</param>
        /// <param name="availableToMapFrom">The data able to be mapped from as derived from the Sql.</param>
        /// <param name="_parameter">_parameter.</param>
        /// <param name="availableParameters">All the parameter the user may wish to design.</param>
        public WriterDesign(string sql = default(string), List<ExpressionWithAlias> availableToMapFrom = default(List<ExpressionWithAlias>), AvailableParameter _parameter = default(AvailableParameter), List<AvailableParameter> availableParameters = default(List<AvailableParameter>))
        {
            // to ensure "sql" is required (not null)
            this.Sql = sql ?? throw new ArgumentNullException("sql is a required property for WriterDesign and cannot be null");
            this.AvailableToMapFrom = availableToMapFrom;
            this.Parameter = _parameter;
            this.AvailableParameters = availableParameters;
        }

        /// <summary>
        /// Original SQL that started this off
        /// </summary>
        /// <value>Original SQL that started this off</value>
        [DataMember(Name = "sql", IsRequired = true, EmitDefaultValue = false)]
        public string Sql { get; set; }

        /// <summary>
        /// The data able to be mapped from as derived from the Sql
        /// </summary>
        /// <value>The data able to be mapped from as derived from the Sql</value>
        [DataMember(Name = "availableToMapFrom", EmitDefaultValue = true)]
        public List<ExpressionWithAlias> AvailableToMapFrom { get; set; }

        /// <summary>
        /// Gets or Sets Parameter
        /// </summary>
        [DataMember(Name = "parameter", EmitDefaultValue = false)]
        public AvailableParameter Parameter { get; set; }

        /// <summary>
        /// All the parameter the user may wish to design
        /// </summary>
        /// <value>All the parameter the user may wish to design</value>
        [DataMember(Name = "availableParameters", EmitDefaultValue = true)]
        public List<AvailableParameter> AvailableParameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WriterDesign {\n");
            sb.Append("  Sql: ").Append(Sql).Append("\n");
            sb.Append("  AvailableToMapFrom: ").Append(AvailableToMapFrom).Append("\n");
            sb.Append("  Parameter: ").Append(Parameter).Append("\n");
            sb.Append("  AvailableParameters: ").Append(AvailableParameters).Append("\n");
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
            return this.Equals(input as WriterDesign);
        }

        /// <summary>
        /// Returns true if WriterDesign instances are equal
        /// </summary>
        /// <param name="input">Instance of WriterDesign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WriterDesign input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sql == input.Sql ||
                    (this.Sql != null &&
                    this.Sql.Equals(input.Sql))
                ) && 
                (
                    this.AvailableToMapFrom == input.AvailableToMapFrom ||
                    this.AvailableToMapFrom != null &&
                    input.AvailableToMapFrom != null &&
                    this.AvailableToMapFrom.SequenceEqual(input.AvailableToMapFrom)
                ) && 
                (
                    this.Parameter == input.Parameter ||
                    (this.Parameter != null &&
                    this.Parameter.Equals(input.Parameter))
                ) && 
                (
                    this.AvailableParameters == input.AvailableParameters ||
                    this.AvailableParameters != null &&
                    input.AvailableParameters != null &&
                    this.AvailableParameters.SequenceEqual(input.AvailableParameters)
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
                if (this.Sql != null)
                    hashCode = hashCode * 59 + this.Sql.GetHashCode();
                if (this.AvailableToMapFrom != null)
                    hashCode = hashCode * 59 + this.AvailableToMapFrom.GetHashCode();
                if (this.Parameter != null)
                    hashCode = hashCode * 59 + this.Parameter.GetHashCode();
                if (this.AvailableParameters != null)
                    hashCode = hashCode * 59 + this.AvailableParameters.GetHashCode();
                return hashCode;
            }
        }

    }
}
