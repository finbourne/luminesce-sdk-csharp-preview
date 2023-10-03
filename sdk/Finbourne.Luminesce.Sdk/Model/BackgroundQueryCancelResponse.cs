/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.13.611
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
    /// BackgroundQueryCancelResponse
    /// </summary>
    [DataContract(Name = "BackgroundQueryCancelResponse")]
    public partial class BackgroundQueryCancelResponse : IEquatable<BackgroundQueryCancelResponse>
    {

        /// <summary>
        /// Gets or Sets PreviousStatus
        /// </summary>
        [DataMember(Name = "previousStatus", EmitDefaultValue = false)]
        public TaskStatus? PreviousStatus { get; set; }

        /// <summary>
        /// Gets or Sets PreviousState
        /// </summary>
        [DataMember(Name = "previousState", EmitDefaultValue = false)]
        public BackgroundQueryState? PreviousState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundQueryCancelResponse" /> class.
        /// </summary>
        /// <param name="hadData">hadData.</param>
        /// <param name="previousStatus">previousStatus.</param>
        /// <param name="previousState">previousState.</param>
        /// <param name="progress">progress.</param>
        public BackgroundQueryCancelResponse(bool hadData = default(bool), TaskStatus? previousStatus = default(TaskStatus?), BackgroundQueryState? previousState = default(BackgroundQueryState?), string progress = default(string))
        {
            this.HadData = hadData;
            this.PreviousStatus = previousStatus;
            this.PreviousState = previousState;
            this.Progress = progress;
        }

        /// <summary>
        /// Gets or Sets HadData
        /// </summary>
        [DataMember(Name = "hadData", EmitDefaultValue = true)]
        public bool HadData { get; set; }

        /// <summary>
        /// Gets or Sets Progress
        /// </summary>
        [DataMember(Name = "progress", EmitDefaultValue = true)]
        public string Progress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackgroundQueryCancelResponse {\n");
            sb.Append("  HadData: ").Append(HadData).Append("\n");
            sb.Append("  PreviousStatus: ").Append(PreviousStatus).Append("\n");
            sb.Append("  PreviousState: ").Append(PreviousState).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
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
            return this.Equals(input as BackgroundQueryCancelResponse);
        }

        /// <summary>
        /// Returns true if BackgroundQueryCancelResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BackgroundQueryCancelResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackgroundQueryCancelResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HadData == input.HadData ||
                    this.HadData.Equals(input.HadData)
                ) && 
                (
                    this.PreviousStatus == input.PreviousStatus ||
                    this.PreviousStatus.Equals(input.PreviousStatus)
                ) && 
                (
                    this.PreviousState == input.PreviousState ||
                    this.PreviousState.Equals(input.PreviousState)
                ) && 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
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
                hashCode = hashCode * 59 + this.HadData.GetHashCode();
                hashCode = hashCode * 59 + this.PreviousStatus.GetHashCode();
                hashCode = hashCode * 59 + this.PreviousState.GetHashCode();
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
                return hashCode;
            }
        }

    }
}
