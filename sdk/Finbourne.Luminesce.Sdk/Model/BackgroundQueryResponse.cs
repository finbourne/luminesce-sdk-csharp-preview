/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.14.5
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
    /// Response for Background Query Start requests
    /// </summary>
    [DataContract(Name = "BackgroundQueryResponse")]
    public partial class BackgroundQueryResponse : IEquatable<BackgroundQueryResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundQueryResponse" /> class.
        /// </summary>
        /// <param name="executionId">ExecutionId of the started-query.</param>
        /// <param name="progress">progress.</param>
        /// <param name="cancel">cancel.</param>
        /// <param name="fetchJson">fetchJson.</param>
        /// <param name="fetchJsonProper">fetchJsonProper.</param>
        /// <param name="fetchXml">fetchXml.</param>
        /// <param name="fetchParquet">fetchParquet.</param>
        /// <param name="fetchCsv">fetchCsv.</param>
        /// <param name="fetchPipe">fetchPipe.</param>
        /// <param name="fetchExcel">fetchExcel.</param>
        /// <param name="fetchSqlite">fetchSqlite.</param>
        /// <param name="histogram">histogram.</param>
        public BackgroundQueryResponse(string executionId = default(string), Link progress = default(Link), Link cancel = default(Link), Link fetchJson = default(Link), Link fetchJsonProper = default(Link), Link fetchXml = default(Link), Link fetchParquet = default(Link), Link fetchCsv = default(Link), Link fetchPipe = default(Link), Link fetchExcel = default(Link), Link fetchSqlite = default(Link), Link histogram = default(Link))
        {
            this.ExecutionId = executionId;
            this.Progress = progress;
            this.Cancel = cancel;
            this.FetchJson = fetchJson;
            this.FetchJsonProper = fetchJsonProper;
            this.FetchXml = fetchXml;
            this.FetchParquet = fetchParquet;
            this.FetchCsv = fetchCsv;
            this.FetchPipe = fetchPipe;
            this.FetchExcel = fetchExcel;
            this.FetchSqlite = fetchSqlite;
            this.Histogram = histogram;
        }

        /// <summary>
        /// ExecutionId of the started-query
        /// </summary>
        /// <value>ExecutionId of the started-query</value>
        [DataMember(Name = "executionId", EmitDefaultValue = true)]
        public string ExecutionId { get; set; }

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
        /// Gets or Sets FetchJson
        /// </summary>
        [DataMember(Name = "fetchJson", EmitDefaultValue = false)]
        public Link FetchJson { get; set; }

        /// <summary>
        /// Gets or Sets FetchJsonProper
        /// </summary>
        [DataMember(Name = "fetchJsonProper", EmitDefaultValue = false)]
        public Link FetchJsonProper { get; set; }

        /// <summary>
        /// Gets or Sets FetchXml
        /// </summary>
        [DataMember(Name = "fetchXml", EmitDefaultValue = false)]
        public Link FetchXml { get; set; }

        /// <summary>
        /// Gets or Sets FetchParquet
        /// </summary>
        [DataMember(Name = "fetchParquet", EmitDefaultValue = false)]
        public Link FetchParquet { get; set; }

        /// <summary>
        /// Gets or Sets FetchCsv
        /// </summary>
        [DataMember(Name = "fetchCsv", EmitDefaultValue = false)]
        public Link FetchCsv { get; set; }

        /// <summary>
        /// Gets or Sets FetchPipe
        /// </summary>
        [DataMember(Name = "fetchPipe", EmitDefaultValue = false)]
        public Link FetchPipe { get; set; }

        /// <summary>
        /// Gets or Sets FetchExcel
        /// </summary>
        [DataMember(Name = "fetchExcel", EmitDefaultValue = false)]
        public Link FetchExcel { get; set; }

        /// <summary>
        /// Gets or Sets FetchSqlite
        /// </summary>
        [DataMember(Name = "fetchSqlite", EmitDefaultValue = false)]
        public Link FetchSqlite { get; set; }

        /// <summary>
        /// Gets or Sets Histogram
        /// </summary>
        [DataMember(Name = "histogram", EmitDefaultValue = false)]
        public Link Histogram { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackgroundQueryResponse {\n");
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
            return this.Equals(input as BackgroundQueryResponse);
        }

        /// <summary>
        /// Returns true if BackgroundQueryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BackgroundQueryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackgroundQueryResponse input)
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
                    (this.FetchJson != null &&
                    this.FetchJson.Equals(input.FetchJson))
                ) && 
                (
                    this.FetchJsonProper == input.FetchJsonProper ||
                    (this.FetchJsonProper != null &&
                    this.FetchJsonProper.Equals(input.FetchJsonProper))
                ) && 
                (
                    this.FetchXml == input.FetchXml ||
                    (this.FetchXml != null &&
                    this.FetchXml.Equals(input.FetchXml))
                ) && 
                (
                    this.FetchParquet == input.FetchParquet ||
                    (this.FetchParquet != null &&
                    this.FetchParquet.Equals(input.FetchParquet))
                ) && 
                (
                    this.FetchCsv == input.FetchCsv ||
                    (this.FetchCsv != null &&
                    this.FetchCsv.Equals(input.FetchCsv))
                ) && 
                (
                    this.FetchPipe == input.FetchPipe ||
                    (this.FetchPipe != null &&
                    this.FetchPipe.Equals(input.FetchPipe))
                ) && 
                (
                    this.FetchExcel == input.FetchExcel ||
                    (this.FetchExcel != null &&
                    this.FetchExcel.Equals(input.FetchExcel))
                ) && 
                (
                    this.FetchSqlite == input.FetchSqlite ||
                    (this.FetchSqlite != null &&
                    this.FetchSqlite.Equals(input.FetchSqlite))
                ) && 
                (
                    this.Histogram == input.Histogram ||
                    (this.Histogram != null &&
                    this.Histogram.Equals(input.Histogram))
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
