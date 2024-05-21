/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.15.231
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
    /// Available intellisense response information
    /// </summary>
    [DataContract(Name = "IntellisenseResponse")]
    public partial class IntellisenseResponse : IEquatable<IntellisenseResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntellisenseResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IntellisenseResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntellisenseResponse" /> class.
        /// </summary>
        /// <param name="autoCompleteList">The available items at this point (required).</param>
        /// <param name="tryAgainSoonForMore">Should the caller try again soon? (true means a cache is being built and this is a preliminary response!) (required).</param>
        /// <param name="sqlWithMarker">The SQL this is for with characters indicating the location the pop-up is for (required).</param>
        /// <param name="startReplacementPosition">startReplacementPosition (required).</param>
        /// <param name="endReplacementPosition">endReplacementPosition (required).</param>
        public IntellisenseResponse(List<IntellisenseItem> autoCompleteList = default(List<IntellisenseItem>), bool tryAgainSoonForMore = default(bool), string sqlWithMarker = default(string), CursorPosition startReplacementPosition = default(CursorPosition), CursorPosition endReplacementPosition = default(CursorPosition))
        {
            // to ensure "autoCompleteList" is required (not null)
            this.AutoCompleteList = autoCompleteList ?? throw new ArgumentNullException("autoCompleteList is a required property for IntellisenseResponse and cannot be null");
            this.TryAgainSoonForMore = tryAgainSoonForMore;
            // to ensure "sqlWithMarker" is required (not null)
            this.SqlWithMarker = sqlWithMarker ?? throw new ArgumentNullException("sqlWithMarker is a required property for IntellisenseResponse and cannot be null");
            // to ensure "startReplacementPosition" is required (not null)
            this.StartReplacementPosition = startReplacementPosition ?? throw new ArgumentNullException("startReplacementPosition is a required property for IntellisenseResponse and cannot be null");
            // to ensure "endReplacementPosition" is required (not null)
            this.EndReplacementPosition = endReplacementPosition ?? throw new ArgumentNullException("endReplacementPosition is a required property for IntellisenseResponse and cannot be null");
        }

        /// <summary>
        /// The available items at this point
        /// </summary>
        /// <value>The available items at this point</value>
        [DataMember(Name = "autoCompleteList", IsRequired = true, EmitDefaultValue = false)]
        public List<IntellisenseItem> AutoCompleteList { get; set; }

        /// <summary>
        /// Should the caller try again soon? (true means a cache is being built and this is a preliminary response!)
        /// </summary>
        /// <value>Should the caller try again soon? (true means a cache is being built and this is a preliminary response!)</value>
        [DataMember(Name = "tryAgainSoonForMore", IsRequired = true, EmitDefaultValue = true)]
        public bool TryAgainSoonForMore { get; set; }

        /// <summary>
        /// The SQL this is for with characters indicating the location the pop-up is for
        /// </summary>
        /// <value>The SQL this is for with characters indicating the location the pop-up is for</value>
        [DataMember(Name = "sqlWithMarker", IsRequired = true, EmitDefaultValue = false)]
        public string SqlWithMarker { get; set; }

        /// <summary>
        /// Gets or Sets StartReplacementPosition
        /// </summary>
        [DataMember(Name = "startReplacementPosition", IsRequired = true, EmitDefaultValue = false)]
        public CursorPosition StartReplacementPosition { get; set; }

        /// <summary>
        /// Gets or Sets EndReplacementPosition
        /// </summary>
        [DataMember(Name = "endReplacementPosition", IsRequired = true, EmitDefaultValue = false)]
        public CursorPosition EndReplacementPosition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntellisenseResponse {\n");
            sb.Append("  AutoCompleteList: ").Append(AutoCompleteList).Append("\n");
            sb.Append("  TryAgainSoonForMore: ").Append(TryAgainSoonForMore).Append("\n");
            sb.Append("  SqlWithMarker: ").Append(SqlWithMarker).Append("\n");
            sb.Append("  StartReplacementPosition: ").Append(StartReplacementPosition).Append("\n");
            sb.Append("  EndReplacementPosition: ").Append(EndReplacementPosition).Append("\n");
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
            return this.Equals(input as IntellisenseResponse);
        }

        /// <summary>
        /// Returns true if IntellisenseResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of IntellisenseResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntellisenseResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoCompleteList == input.AutoCompleteList ||
                    this.AutoCompleteList != null &&
                    input.AutoCompleteList != null &&
                    this.AutoCompleteList.SequenceEqual(input.AutoCompleteList)
                ) && 
                (
                    this.TryAgainSoonForMore == input.TryAgainSoonForMore ||
                    this.TryAgainSoonForMore.Equals(input.TryAgainSoonForMore)
                ) && 
                (
                    this.SqlWithMarker == input.SqlWithMarker ||
                    (this.SqlWithMarker != null &&
                    this.SqlWithMarker.Equals(input.SqlWithMarker))
                ) && 
                (
                    this.StartReplacementPosition == input.StartReplacementPosition ||
                    (this.StartReplacementPosition != null &&
                    this.StartReplacementPosition.Equals(input.StartReplacementPosition))
                ) && 
                (
                    this.EndReplacementPosition == input.EndReplacementPosition ||
                    (this.EndReplacementPosition != null &&
                    this.EndReplacementPosition.Equals(input.EndReplacementPosition))
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
                if (this.AutoCompleteList != null)
                    hashCode = hashCode * 59 + this.AutoCompleteList.GetHashCode();
                hashCode = hashCode * 59 + this.TryAgainSoonForMore.GetHashCode();
                if (this.SqlWithMarker != null)
                    hashCode = hashCode * 59 + this.SqlWithMarker.GetHashCode();
                if (this.StartReplacementPosition != null)
                    hashCode = hashCode * 59 + this.StartReplacementPosition.GetHashCode();
                if (this.EndReplacementPosition != null)
                    hashCode = hashCode * 59 + this.EndReplacementPosition.GetHashCode();
                return hashCode;
            }
        }

    }
}
