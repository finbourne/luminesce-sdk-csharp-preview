/*
 * FINBOURNE Luminesce Web API
 *
 *  ``` >   __                    _                             / /   __  ______ ___  (_)___  ___  _____________    / /   / / / / __ `__ / / __ / _ / ___/ ___/ _ \\  / /___/ /_/ / / / / / / / / / /  __(__  ) /__/  __/ /_____/\\__,_/_/ /_/ /_/_/_/ /_/\\___/____/\\___/\\___/  ```  ### Introduction to Luminesce   [Luminesce](https://support.lusid.com/knowledgebase/article/KA-01677/) is a data virtualization engine for LUSID and other applications.  It is proprietary technology designed and developed by FINBOURNE Technology Limited.  [Understanding the Luminesce platform architecture.](https://support.lusid.com/knowledgebase/article/KA-01707/)  Luminesce enables you to query multiple sources of business intelligence simultaneously in real-time—including investment management data stored in LUSID itself—and build a consolidated picture for analysis, optionally writing data back into LUSID. Alternatively, you can use Luminesce in a standalone capacity, without interacting with LUSID at all.  ### WebAPI  Allows for running queries and a variety of other functions relating to Luminesce. For example these REST APIs can execute queries, synchronously or better asynchronously, returning results in either Excel, CSV, SqLite, JSON among other formats.  ### Error Codes  | Code|Meaning | | - --|- -- | | <a name=\"233\">233</a>|Query Parser Failure | | <a name=\"850\">850</a>|Required provider not visible; provider may not exist, be temporarily unavailable, or you may not have the necessary permissions | | <a name=\"851\">851</a>|Query reached a timeout period or was cancelled | | <a name=\"852\">852</a>|Query failed during execution | | <a name=\"853\">853</a>|Query failed during execution for an unexpected reason | | <a name=\"854\">854</a>|Query failed during execution for a reason known to be an internal error (e.g. a Lusid provider where a corresponding API would return a 500) | | <a name=\"855\">855</a>|Required column is not in the queried provider(s) | | <a name=\"856\">856</a>|One or more columns are ambiguously referenced in the query | | <a name=\"857\">857</a>|Query failed during execution of a provider (e.g. in a way that might be transient, like an upstream issue) | | <a name=\"858\">858</a>|Query failed during execution within the Query Engine's SQL processing | | <a name=\"859\">859</a>|A variable has been defined more than once | 
 *
 * The version of the OpenAPI document: 1.16.736
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
    [DataContract(Name = "OptionsExcel")]
    public partial class OptionsExcel : IEquatable<OptionsExcel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsExcel" /> class.
        /// </summary>
        /// <param name="columnNames">Column Names either overrides the header row or steps in when there is no header row (comma delimited list).</param>
        /// <param name="columnTypes">Column types (comma delimited list of: &#39;{types}&#39;, some columns may be left blank while others are specified).</param>
        /// <param name="inferTypeRowCount">If non-zero and &#39;types&#39; is not specified (or not specified for some columns) this will look through N rows to attempt to work out the column types for columns not pre-specified.</param>
        /// <param name="noHeader">Set this if there is no header row.</param>
        /// <param name="calculate">Whether to attempt a calculation of the imported cell range prior to import.</param>
        /// <param name="password">If specified will be used as the password used for password protected workbooks.</param>
        /// <param name="worksheet">The worksheet containing the cell range to import (name or index, will default to first).</param>
        /// <param name="rangeOrTable">The cell range to import as either a specified range or a table name.</param>
        /// <param name="ignoreInvalidCells">If specified cells which can not be successfully converted to the target type will be ignored.</param>
        /// <param name="ignoreBlankRows">If the entire rows has only blank cells it will be ignored will be ignored.</param>
        public OptionsExcel(string columnNames = default(string), string columnTypes = default(string), int inferTypeRowCount = default(int), bool noHeader = default(bool), bool calculate = default(bool), string password = default(string), string worksheet = default(string), string rangeOrTable = default(string), bool ignoreInvalidCells = default(bool), bool ignoreBlankRows = default(bool))
        {
            this.ColumnNames = columnNames;
            this.ColumnTypes = columnTypes;
            this.InferTypeRowCount = inferTypeRowCount;
            this.NoHeader = noHeader;
            this.Calculate = calculate;
            this.Password = password;
            this.Worksheet = worksheet;
            this.RangeOrTable = rangeOrTable;
            this.IgnoreInvalidCells = ignoreInvalidCells;
            this.IgnoreBlankRows = ignoreBlankRows;
        }

        /// <summary>
        /// Column Names either overrides the header row or steps in when there is no header row (comma delimited list)
        /// </summary>
        /// <value>Column Names either overrides the header row or steps in when there is no header row (comma delimited list)</value>
        [DataMember(Name = "columnNames", EmitDefaultValue = true)]
        public string ColumnNames { get; set; }

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
        /// Whether to attempt a calculation of the imported cell range prior to import
        /// </summary>
        /// <value>Whether to attempt a calculation of the imported cell range prior to import</value>
        [DataMember(Name = "calculate", EmitDefaultValue = true)]
        public bool Calculate { get; set; }

        /// <summary>
        /// If specified will be used as the password used for password protected workbooks
        /// </summary>
        /// <value>If specified will be used as the password used for password protected workbooks</value>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// The worksheet containing the cell range to import (name or index, will default to first)
        /// </summary>
        /// <value>The worksheet containing the cell range to import (name or index, will default to first)</value>
        [DataMember(Name = "worksheet", EmitDefaultValue = true)]
        public string Worksheet { get; set; }

        /// <summary>
        /// The cell range to import as either a specified range or a table name
        /// </summary>
        /// <value>The cell range to import as either a specified range or a table name</value>
        [DataMember(Name = "rangeOrTable", EmitDefaultValue = true)]
        public string RangeOrTable { get; set; }

        /// <summary>
        /// If specified cells which can not be successfully converted to the target type will be ignored
        /// </summary>
        /// <value>If specified cells which can not be successfully converted to the target type will be ignored</value>
        [DataMember(Name = "ignoreInvalidCells", EmitDefaultValue = true)]
        public bool IgnoreInvalidCells { get; set; }

        /// <summary>
        /// If the entire rows has only blank cells it will be ignored will be ignored
        /// </summary>
        /// <value>If the entire rows has only blank cells it will be ignored will be ignored</value>
        [DataMember(Name = "ignoreBlankRows", EmitDefaultValue = true)]
        public bool IgnoreBlankRows { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionsExcel {\n");
            sb.Append("  ColumnNames: ").Append(ColumnNames).Append("\n");
            sb.Append("  ColumnTypes: ").Append(ColumnTypes).Append("\n");
            sb.Append("  InferTypeRowCount: ").Append(InferTypeRowCount).Append("\n");
            sb.Append("  NoHeader: ").Append(NoHeader).Append("\n");
            sb.Append("  Calculate: ").Append(Calculate).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Worksheet: ").Append(Worksheet).Append("\n");
            sb.Append("  RangeOrTable: ").Append(RangeOrTable).Append("\n");
            sb.Append("  IgnoreInvalidCells: ").Append(IgnoreInvalidCells).Append("\n");
            sb.Append("  IgnoreBlankRows: ").Append(IgnoreBlankRows).Append("\n");
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
            return this.Equals(input as OptionsExcel);
        }

        /// <summary>
        /// Returns true if OptionsExcel instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionsExcel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionsExcel input)
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
                    this.Calculate == input.Calculate ||
                    this.Calculate.Equals(input.Calculate)
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Worksheet == input.Worksheet ||
                    (this.Worksheet != null &&
                    this.Worksheet.Equals(input.Worksheet))
                ) && 
                (
                    this.RangeOrTable == input.RangeOrTable ||
                    (this.RangeOrTable != null &&
                    this.RangeOrTable.Equals(input.RangeOrTable))
                ) && 
                (
                    this.IgnoreInvalidCells == input.IgnoreInvalidCells ||
                    this.IgnoreInvalidCells.Equals(input.IgnoreInvalidCells)
                ) && 
                (
                    this.IgnoreBlankRows == input.IgnoreBlankRows ||
                    this.IgnoreBlankRows.Equals(input.IgnoreBlankRows)
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
                if (this.ColumnTypes != null)
                    hashCode = hashCode * 59 + this.ColumnTypes.GetHashCode();
                hashCode = hashCode * 59 + this.InferTypeRowCount.GetHashCode();
                hashCode = hashCode * 59 + this.NoHeader.GetHashCode();
                hashCode = hashCode * 59 + this.Calculate.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Worksheet != null)
                    hashCode = hashCode * 59 + this.Worksheet.GetHashCode();
                if (this.RangeOrTable != null)
                    hashCode = hashCode * 59 + this.RangeOrTable.GetHashCode();
                hashCode = hashCode * 59 + this.IgnoreInvalidCells.GetHashCode();
                hashCode = hashCode * 59 + this.IgnoreBlankRows.GetHashCode();
                return hashCode;
            }
        }

    }
}
