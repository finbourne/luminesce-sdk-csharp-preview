/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.14.548
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
    /// BackgroundMultiQueryResponse
    /// </summary>
    [DataContract(Name = "BackgroundMultiQueryResponse")]
    public partial class BackgroundMultiQueryResponse : IEquatable<BackgroundMultiQueryResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundMultiQueryResponse" /> class.
        /// </summary>
        /// <param name="progress">progress.</param>
        /// <param name="cancel">cancel.</param>
        public BackgroundMultiQueryResponse(Link progress = default(Link), Link cancel = default(Link))
        {
            this.Progress = progress;
            this.Cancel = cancel;
        }

        /// <summary>
        /// Gets or Sets ExecutionId
        /// </summary>
        [DataMember(Name = "executionId", EmitDefaultValue = false)]
        public Guid ExecutionId { get; private set; }

        /// <summary>
        /// Returns false as ExecutionId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExecutionId()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Progress
        /// </summary>
        [DataMember(Name = "progress", EmitDefaultValue = false)]
        public Link Progress { get; set; }

        /// <summary>
        /// Gets or Sets Cancel
        /// </summary>
        [DataMember(Name = "cancel", EmitDefaultValue = false)]
        public Link Cancel { get; set; }

        /// <summary>
        /// Json (as a string) data request links for all of the child queries
        /// </summary>
        /// <value>Json (as a string) data request links for all of the child queries</value>
        [DataMember(Name = "fetchJson", EmitDefaultValue = true)]
        public List<Link> FetchJson { get; private set; }

        /// <summary>
        /// Returns false as FetchJson should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFetchJson()
        {
            return false;
        }

        /// <summary>
        /// Json-proper data request links for all of the child queries
        /// </summary>
        /// <value>Json-proper data request links for all of the child queries</value>
        [DataMember(Name = "fetchJsonProper", EmitDefaultValue = true)]
        public List<Link> FetchJsonProper { get; private set; }

        /// <summary>
        /// Returns false as FetchJsonProper should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFetchJsonProper()
        {
            return false;
        }

        /// <summary>
        /// Xml data request links for all of the child queries
        /// </summary>
        /// <value>Xml data request links for all of the child queries</value>
        [DataMember(Name = "fetchXml", EmitDefaultValue = true)]
        public List<Link> FetchXml { get; private set; }

        /// <summary>
        /// Returns false as FetchXml should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFetchXml()
        {
            return false;
        }

        /// <summary>
        /// Parquet data request links for all of the child queries
        /// </summary>
        /// <value>Parquet data request links for all of the child queries</value>
        [DataMember(Name = "fetchParquet", EmitDefaultValue = true)]
        public List<Link> FetchParquet { get; private set; }

        /// <summary>
        /// Returns false as FetchParquet should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFetchParquet()
        {
            return false;
        }

        /// <summary>
        /// CSV data request links for all of the child queries
        /// </summary>
        /// <value>CSV data request links for all of the child queries</value>
        [DataMember(Name = "fetchCsv", EmitDefaultValue = true)]
        public List<Link> FetchCsv { get; private set; }

        /// <summary>
        /// Returns false as FetchCsv should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFetchCsv()
        {
            return false;
        }

        /// <summary>
        /// Pipe delimited data request links for all of the child queries
        /// </summary>
        /// <value>Pipe delimited data request links for all of the child queries</value>
        [DataMember(Name = "fetchPipe", EmitDefaultValue = true)]
        public List<Link> FetchPipe { get; private set; }

        /// <summary>
        /// Returns false as FetchPipe should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFetchPipe()
        {
            return false;
        }

        /// <summary>
        /// Excel workbook data request links for all of the child queries
        /// </summary>
        /// <value>Excel workbook data request links for all of the child queries</value>
        [DataMember(Name = "fetchExcel", EmitDefaultValue = true)]
        public List<Link> FetchExcel { get; private set; }

        /// <summary>
        /// Returns false as FetchExcel should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFetchExcel()
        {
            return false;
        }

        /// <summary>
        /// SqLite DB data request links for all of the child queries
        /// </summary>
        /// <value>SqLite DB data request links for all of the child queries</value>
        [DataMember(Name = "fetchSqlite", EmitDefaultValue = true)]
        public List<Link> FetchSqlite { get; private set; }

        /// <summary>
        /// Returns false as FetchSqlite should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFetchSqlite()
        {
            return false;
        }

        /// <summary>
        /// Histogram links for all of the child queries
        /// </summary>
        /// <value>Histogram links for all of the child queries</value>
        [DataMember(Name = "histogram", EmitDefaultValue = true)]
        public List<Link> Histogram { get; private set; }

        /// <summary>
        /// Returns false as Histogram should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHistogram()
        {
            return false;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackgroundMultiQueryResponse {\n");
            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Cancel: ").Append(Cancel).Append("\n");
            sb.Append("  FetchJson: ").Append(FetchJson).Append("\n");
            sb.Append("  FetchJsonProper: ").Append(FetchJsonProper).Append("\n");
            sb.Append("  FetchXml: ").Append(FetchXml).Append("\n");
            sb.Append("  FetchParquet: ").Append(FetchParquet).Append("\n");
            sb.Append("  FetchCsv: ").Append(FetchCsv).Append("\n");
            sb.Append("  FetchPipe: ").Append(FetchPipe).Append("\n");
            sb.Append("  FetchExcel: ").Append(FetchExcel).Append("\n");
            sb.Append("  FetchSqlite: ").Append(FetchSqlite).Append("\n");
            sb.Append("  Histogram: ").Append(Histogram).Append("\n");
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
            return this.Equals(input as BackgroundMultiQueryResponse);
        }

        /// <summary>
        /// Returns true if BackgroundMultiQueryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BackgroundMultiQueryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackgroundMultiQueryResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExecutionId == input.ExecutionId ||
                    (this.ExecutionId != null &&
                    this.ExecutionId.Equals(input.ExecutionId))
                ) && 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
                ) && 
                (
                    this.Cancel == input.Cancel ||
                    (this.Cancel != null &&
                    this.Cancel.Equals(input.Cancel))
                ) && 
                (
                    this.FetchJson == input.FetchJson ||
                    this.FetchJson != null &&
                    input.FetchJson != null &&
                    this.FetchJson.SequenceEqual(input.FetchJson)
                ) && 
                (
                    this.FetchJsonProper == input.FetchJsonProper ||
                    this.FetchJsonProper != null &&
                    input.FetchJsonProper != null &&
                    this.FetchJsonProper.SequenceEqual(input.FetchJsonProper)
                ) && 
                (
                    this.FetchXml == input.FetchXml ||
                    this.FetchXml != null &&
                    input.FetchXml != null &&
                    this.FetchXml.SequenceEqual(input.FetchXml)
                ) && 
                (
                    this.FetchParquet == input.FetchParquet ||
                    this.FetchParquet != null &&
                    input.FetchParquet != null &&
                    this.FetchParquet.SequenceEqual(input.FetchParquet)
                ) && 
                (
                    this.FetchCsv == input.FetchCsv ||
                    this.FetchCsv != null &&
                    input.FetchCsv != null &&
                    this.FetchCsv.SequenceEqual(input.FetchCsv)
                ) && 
                (
                    this.FetchPipe == input.FetchPipe ||
                    this.FetchPipe != null &&
                    input.FetchPipe != null &&
                    this.FetchPipe.SequenceEqual(input.FetchPipe)
                ) && 
                (
                    this.FetchExcel == input.FetchExcel ||
                    this.FetchExcel != null &&
                    input.FetchExcel != null &&
                    this.FetchExcel.SequenceEqual(input.FetchExcel)
                ) && 
                (
                    this.FetchSqlite == input.FetchSqlite ||
                    this.FetchSqlite != null &&
                    input.FetchSqlite != null &&
                    this.FetchSqlite.SequenceEqual(input.FetchSqlite)
                ) && 
                (
                    this.Histogram == input.Histogram ||
                    this.Histogram != null &&
                    input.Histogram != null &&
                    this.Histogram.SequenceEqual(input.Histogram)
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
                if (this.ExecutionId != null)
                    hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.Cancel != null)
                    hashCode = hashCode * 59 + this.Cancel.GetHashCode();
                if (this.FetchJson != null)
                    hashCode = hashCode * 59 + this.FetchJson.GetHashCode();
                if (this.FetchJsonProper != null)
                    hashCode = hashCode * 59 + this.FetchJsonProper.GetHashCode();
                if (this.FetchXml != null)
                    hashCode = hashCode * 59 + this.FetchXml.GetHashCode();
                if (this.FetchParquet != null)
                    hashCode = hashCode * 59 + this.FetchParquet.GetHashCode();
                if (this.FetchCsv != null)
                    hashCode = hashCode * 59 + this.FetchCsv.GetHashCode();
                if (this.FetchPipe != null)
                    hashCode = hashCode * 59 + this.FetchPipe.GetHashCode();
                if (this.FetchExcel != null)
                    hashCode = hashCode * 59 + this.FetchExcel.GetHashCode();
                if (this.FetchSqlite != null)
                    hashCode = hashCode * 59 + this.FetchSqlite.GetHashCode();
                if (this.Histogram != null)
                    hashCode = hashCode * 59 + this.Histogram.GetHashCode();
                return hashCode;
            }
        }

    }
}
