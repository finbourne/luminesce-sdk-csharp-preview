/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.14.106
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
    /// Additional options applicable to the given SourceType
    /// </summary>
    [DataContract(Name = "OptionsXml")]
    public partial class OptionsXml : IEquatable<OptionsXml>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsXml" /> class.
        /// </summary>
        /// <param name="columnTypes">Column types (comma delimited list of: &#39;{types}&#39;, some columns may be left blank while others are specified).</param>
        /// <param name="inferTypeRowCount">If non-zero and &#39;types&#39; is not specified (or not specified for some columns) this will look through N rows to attempt to work out the column types for columns not pre-specified.</param>
        /// <param name="valuesToMakeNull">Regex of values to map to &#39;null&#39; in the returned data..</param>
        /// <param name="columnNames">Column Names either overrides the header row or steps in when there is no header row (comma delimited list).</param>
        /// <param name="nodePath">XPath query that selects the nodes to map to rows.</param>
        /// <param name="namespaces">Selected prefix(es) and namespace(s):prefix1&#x3D;namespace1-uri1,prefix2&#x3D;namespace2-uri2,...prefixN&#x3D;namespaceN-uriN.</param>
        public OptionsXml(string columnTypes = default(string), int inferTypeRowCount = default(int), string valuesToMakeNull = default(string), string columnNames = default(string), string nodePath = default(string), string namespaces = default(string))
        {
            this.ColumnTypes = columnTypes;
            this.InferTypeRowCount = inferTypeRowCount;
            this.ValuesToMakeNull = valuesToMakeNull;
            this.ColumnNames = columnNames;
            this.NodePath = nodePath;
            this.Namespaces = namespaces;
        }

        /// <summary>
        /// Column types (comma delimited list of: &#39;{types}&#39;, some columns may be left blank while others are specified)
        /// </summary>
        /// <value>Column types (comma delimited list of: &#39;{types}&#39;, some columns may be left blank while others are specified)</value>
        [DataMember(Name = "columnTypes", EmitDefaultValue = true)]
        public string ColumnTypes { get; set; }

        /// <summary>
        /// If non-zero and &#39;types&#39; is not specified (or not specified for some columns) this will look through N rows to attempt to work out the column types for columns not pre-specified
        /// </summary>
        /// <value>If non-zero and &#39;types&#39; is not specified (or not specified for some columns) this will look through N rows to attempt to work out the column types for columns not pre-specified</value>
        [DataMember(Name = "inferTypeRowCount", EmitDefaultValue = true)]
        public int InferTypeRowCount { get; set; }

        /// <summary>
        /// Regex of values to map to &#39;null&#39; in the returned data.
        /// </summary>
        /// <value>Regex of values to map to &#39;null&#39; in the returned data.</value>
        [DataMember(Name = "valuesToMakeNull", EmitDefaultValue = true)]
        public string ValuesToMakeNull { get; set; }

        /// <summary>
        /// Column Names either overrides the header row or steps in when there is no header row (comma delimited list)
        /// </summary>
        /// <value>Column Names either overrides the header row or steps in when there is no header row (comma delimited list)</value>
        [DataMember(Name = "columnNames", EmitDefaultValue = true)]
        public string ColumnNames { get; set; }

        /// <summary>
        /// XPath query that selects the nodes to map to rows
        /// </summary>
        /// <value>XPath query that selects the nodes to map to rows</value>
        [DataMember(Name = "nodePath", EmitDefaultValue = true)]
        public string NodePath { get; set; }

        /// <summary>
        /// Selected prefix(es) and namespace(s):prefix1&#x3D;namespace1-uri1,prefix2&#x3D;namespace2-uri2,...prefixN&#x3D;namespaceN-uriN
        /// </summary>
        /// <value>Selected prefix(es) and namespace(s):prefix1&#x3D;namespace1-uri1,prefix2&#x3D;namespace2-uri2,...prefixN&#x3D;namespaceN-uriN</value>
        [DataMember(Name = "namespaces", EmitDefaultValue = true)]
        public string Namespaces { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionsXml {\n");
            sb.Append("  ColumnTypes: ").Append(ColumnTypes).Append("\n");
            sb.Append("  InferTypeRowCount: ").Append(InferTypeRowCount).Append("\n");
            sb.Append("  ValuesToMakeNull: ").Append(ValuesToMakeNull).Append("\n");
            sb.Append("  ColumnNames: ").Append(ColumnNames).Append("\n");
            sb.Append("  NodePath: ").Append(NodePath).Append("\n");
            sb.Append("  Namespaces: ").Append(Namespaces).Append("\n");
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
            return this.Equals(input as OptionsXml);
        }

        /// <summary>
        /// Returns true if OptionsXml instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionsXml to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionsXml input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ColumnTypes == input.ColumnTypes ||
                    (this.ColumnTypes != null &&
                    this.ColumnTypes.Equals(input.ColumnTypes))
                ) && 
                (
                    this.InferTypeRowCount == input.InferTypeRowCount ||
                    this.InferTypeRowCount.Equals(input.InferTypeRowCount)
                ) && 
                (
                    this.ValuesToMakeNull == input.ValuesToMakeNull ||
                    (this.ValuesToMakeNull != null &&
                    this.ValuesToMakeNull.Equals(input.ValuesToMakeNull))
                ) && 
                (
                    this.ColumnNames == input.ColumnNames ||
                    (this.ColumnNames != null &&
                    this.ColumnNames.Equals(input.ColumnNames))
                ) && 
                (
                    this.NodePath == input.NodePath ||
                    (this.NodePath != null &&
                    this.NodePath.Equals(input.NodePath))
                ) && 
                (
                    this.Namespaces == input.Namespaces ||
                    (this.Namespaces != null &&
                    this.Namespaces.Equals(input.Namespaces))
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
                if (this.ColumnTypes != null)
                    hashCode = hashCode * 59 + this.ColumnTypes.GetHashCode();
                hashCode = hashCode * 59 + this.InferTypeRowCount.GetHashCode();
                if (this.ValuesToMakeNull != null)
                    hashCode = hashCode * 59 + this.ValuesToMakeNull.GetHashCode();
                if (this.ColumnNames != null)
                    hashCode = hashCode * 59 + this.ColumnNames.GetHashCode();
                if (this.NodePath != null)
                    hashCode = hashCode * 59 + this.NodePath.GetHashCode();
                if (this.Namespaces != null)
                    hashCode = hashCode * 59 + this.Namespaces.GetHashCode();
                return hashCode;
            }
        }

    }
}
