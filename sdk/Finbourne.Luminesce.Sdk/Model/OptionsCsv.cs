/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.14.688
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
    [DataContract(Name = "OptionsCsv")]
    public partial class OptionsCsv : IEquatable<OptionsCsv>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsCsv" /> class.
        /// </summary>
        /// <param name="columnNames">Column Names either overrides the header row or steps in when there is no header row (comma delimited list).</param>
        /// <param name="columnNamesWanted">Column (by Name) that should be returned (comma delimited list).</param>
        /// <param name="columnTypes">Column types (comma delimited list of: &#39;{types}&#39;, some columns may be left blank while others are specified).</param>
        /// <param name="inferTypeRowCount">If non-zero and &#39;types&#39; is not specified (or not specified for some columns) this will look through N rows to attempt to work out the column types for columns not pre-specified.</param>
        /// <param name="noHeader">Set this if there is no header row.</param>
        /// <param name="delimiter">The delimiter between values (\\t for tab).</param>
        /// <param name="escape">Character used to escape the &#39;Quote&#39; character when within a value.</param>
        /// <param name="quote">Character used around any field containing the &#39;delimiter&#39; or a line break..</param>
        /// <param name="valuesToMakeNull">Regex of values to map to &#39;null&#39; in the returned data..</param>
        /// <param name="skipPreHeader">Number of rows to ignore before the header row.</param>
        /// <param name="skipPostHeader">Number of rows to ignore after the header row.</param>
        /// <param name="skipInvalidRows">Skip invalid data rows (totally invalid ones),   This also allows for potentially wrong data if it can be handled somewhat e.g. embedded quotes misused (and still returns such rows).  In either case a warning will show in the progress feedback..</param>
        public OptionsCsv(string columnNames = default(string), string columnNamesWanted = default(string), string columnTypes = default(string), int inferTypeRowCount = default(int), bool noHeader = default(bool), string delimiter = default(string), string escape = default(string), string quote = default(string), string valuesToMakeNull = default(string), int skipPreHeader = default(int), int skipPostHeader = default(int), bool skipInvalidRows = default(bool))
        {
            this.ColumnNames = columnNames;
            this.ColumnNamesWanted = columnNamesWanted;
            this.ColumnTypes = columnTypes;
            this.InferTypeRowCount = inferTypeRowCount;
            this.NoHeader = noHeader;
            this.Delimiter = delimiter;
            this.Escape = escape;
            this.Quote = quote;
            this.ValuesToMakeNull = valuesToMakeNull;
            this.SkipPreHeader = skipPreHeader;
            this.SkipPostHeader = skipPostHeader;
            this.SkipInvalidRows = skipInvalidRows;
        }

        /// <summary>
        /// Column Names either overrides the header row or steps in when there is no header row (comma delimited list)
        /// </summary>
        /// <value>Column Names either overrides the header row or steps in when there is no header row (comma delimited list)</value>
        [DataMember(Name = "columnNames", EmitDefaultValue = true)]
        public string ColumnNames { get; set; }

        /// <summary>
        /// Column (by Name) that should be returned (comma delimited list)
        /// </summary>
        /// <value>Column (by Name) that should be returned (comma delimited list)</value>
        [DataMember(Name = "columnNamesWanted", EmitDefaultValue = true)]
        public string ColumnNamesWanted { get; set; }

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
        /// Set this if there is no header row
        /// </summary>
        /// <value>Set this if there is no header row</value>
        [DataMember(Name = "noHeader", EmitDefaultValue = true)]
        public bool NoHeader { get; set; }

        /// <summary>
        /// The delimiter between values (\\t for tab)
        /// </summary>
        /// <value>The delimiter between values (\\t for tab)</value>
        [DataMember(Name = "delimiter", EmitDefaultValue = true)]
        public string Delimiter { get; set; }

        /// <summary>
        /// Character used to escape the &#39;Quote&#39; character when within a value
        /// </summary>
        /// <value>Character used to escape the &#39;Quote&#39; character when within a value</value>
        [DataMember(Name = "escape", EmitDefaultValue = true)]
        public string Escape { get; set; }

        /// <summary>
        /// Character used around any field containing the &#39;delimiter&#39; or a line break.
        /// </summary>
        /// <value>Character used around any field containing the &#39;delimiter&#39; or a line break.</value>
        [DataMember(Name = "quote", EmitDefaultValue = true)]
        public string Quote { get; set; }

        /// <summary>
        /// Regex of values to map to &#39;null&#39; in the returned data.
        /// </summary>
        /// <value>Regex of values to map to &#39;null&#39; in the returned data.</value>
        [DataMember(Name = "valuesToMakeNull", EmitDefaultValue = true)]
        public string ValuesToMakeNull { get; set; }

        /// <summary>
        /// Number of rows to ignore before the header row
        /// </summary>
        /// <value>Number of rows to ignore before the header row</value>
        [DataMember(Name = "skipPreHeader", EmitDefaultValue = true)]
        public int SkipPreHeader { get; set; }

        /// <summary>
        /// Number of rows to ignore after the header row
        /// </summary>
        /// <value>Number of rows to ignore after the header row</value>
        [DataMember(Name = "skipPostHeader", EmitDefaultValue = true)]
        public int SkipPostHeader { get; set; }

        /// <summary>
        /// Skip invalid data rows (totally invalid ones),   This also allows for potentially wrong data if it can be handled somewhat e.g. embedded quotes misused (and still returns such rows).  In either case a warning will show in the progress feedback.
        /// </summary>
        /// <value>Skip invalid data rows (totally invalid ones),   This also allows for potentially wrong data if it can be handled somewhat e.g. embedded quotes misused (and still returns such rows).  In either case a warning will show in the progress feedback.</value>
        [DataMember(Name = "skipInvalidRows", EmitDefaultValue = true)]
        public bool SkipInvalidRows { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionsCsv {\n");
            sb.Append("  ColumnNames: ").Append(ColumnNames).Append("\n");
            sb.Append("  ColumnNamesWanted: ").Append(ColumnNamesWanted).Append("\n");
            sb.Append("  ColumnTypes: ").Append(ColumnTypes).Append("\n");
            sb.Append("  InferTypeRowCount: ").Append(InferTypeRowCount).Append("\n");
            sb.Append("  NoHeader: ").Append(NoHeader).Append("\n");
            sb.Append("  Delimiter: ").Append(Delimiter).Append("\n");
            sb.Append("  Escape: ").Append(Escape).Append("\n");
            sb.Append("  Quote: ").Append(Quote).Append("\n");
            sb.Append("  ValuesToMakeNull: ").Append(ValuesToMakeNull).Append("\n");
            sb.Append("  SkipPreHeader: ").Append(SkipPreHeader).Append("\n");
            sb.Append("  SkipPostHeader: ").Append(SkipPostHeader).Append("\n");
            sb.Append("  SkipInvalidRows: ").Append(SkipInvalidRows).Append("\n");
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
            return this.Equals(input as OptionsCsv);
        }

        /// <summary>
        /// Returns true if OptionsCsv instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionsCsv to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionsCsv input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ColumnNames == input.ColumnNames ||
                    (this.ColumnNames != null &&
                    this.ColumnNames.Equals(input.ColumnNames))
                ) && 
                (
                    this.ColumnNamesWanted == input.ColumnNamesWanted ||
                    (this.ColumnNamesWanted != null &&
                    this.ColumnNamesWanted.Equals(input.ColumnNamesWanted))
                ) && 
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
                    this.NoHeader == input.NoHeader ||
                    this.NoHeader.Equals(input.NoHeader)
                ) && 
                (
                    this.Delimiter == input.Delimiter ||
                    (this.Delimiter != null &&
                    this.Delimiter.Equals(input.Delimiter))
                ) && 
                (
                    this.Escape == input.Escape ||
                    (this.Escape != null &&
                    this.Escape.Equals(input.Escape))
                ) && 
                (
                    this.Quote == input.Quote ||
                    (this.Quote != null &&
                    this.Quote.Equals(input.Quote))
                ) && 
                (
                    this.ValuesToMakeNull == input.ValuesToMakeNull ||
                    (this.ValuesToMakeNull != null &&
                    this.ValuesToMakeNull.Equals(input.ValuesToMakeNull))
                ) && 
                (
                    this.SkipPreHeader == input.SkipPreHeader ||
                    this.SkipPreHeader.Equals(input.SkipPreHeader)
                ) && 
                (
                    this.SkipPostHeader == input.SkipPostHeader ||
                    this.SkipPostHeader.Equals(input.SkipPostHeader)
                ) && 
                (
                    this.SkipInvalidRows == input.SkipInvalidRows ||
                    this.SkipInvalidRows.Equals(input.SkipInvalidRows)
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
                if (this.ColumnNames != null)
                    hashCode = hashCode * 59 + this.ColumnNames.GetHashCode();
                if (this.ColumnNamesWanted != null)
                    hashCode = hashCode * 59 + this.ColumnNamesWanted.GetHashCode();
                if (this.ColumnTypes != null)
                    hashCode = hashCode * 59 + this.ColumnTypes.GetHashCode();
                hashCode = hashCode * 59 + this.InferTypeRowCount.GetHashCode();
                hashCode = hashCode * 59 + this.NoHeader.GetHashCode();
                if (this.Delimiter != null)
                    hashCode = hashCode * 59 + this.Delimiter.GetHashCode();
                if (this.Escape != null)
                    hashCode = hashCode * 59 + this.Escape.GetHashCode();
                if (this.Quote != null)
                    hashCode = hashCode * 59 + this.Quote.GetHashCode();
                if (this.ValuesToMakeNull != null)
                    hashCode = hashCode * 59 + this.ValuesToMakeNull.GetHashCode();
                hashCode = hashCode * 59 + this.SkipPreHeader.GetHashCode();
                hashCode = hashCode * 59 + this.SkipPostHeader.GetHashCode();
                hashCode = hashCode * 59 + this.SkipInvalidRows.GetHashCode();
                return hashCode;
            }
        }

    }
}
