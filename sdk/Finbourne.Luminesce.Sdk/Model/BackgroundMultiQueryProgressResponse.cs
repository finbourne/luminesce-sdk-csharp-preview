/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.13.302
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
    /// BackgroundMultiQueryProgressResponse
    /// </summary>
    [DataContract(Name = "BackgroundMultiQueryProgressResponse")]
    public partial class BackgroundMultiQueryProgressResponse : IEquatable<BackgroundMultiQueryProgressResponse>
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public TaskStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundMultiQueryProgressResponse" /> class.
        /// </summary>
        /// <param name="progress">The full progress log (up to this point at least).</param>
        /// <param name="feedback">Individual Feedback Messages (to replace Progress).  A given message will be returned from only one call..</param>
        /// <param name="status">status.</param>
        /// <param name="queries">queries.</param>
        public BackgroundMultiQueryProgressResponse(string progress = default(string), List<FeedbackEventArgs> feedback = default(List<FeedbackEventArgs>), TaskStatus? status = default(TaskStatus?), List<BackgroundQueryProgressResponse> queries = default(List<BackgroundQueryProgressResponse>))
        {
            this.Progress = progress;
            this.Feedback = feedback;
            this.Status = status;
            this.Queries = queries;
        }

        /// <summary>
        /// The full progress log (up to this point at least)
        /// </summary>
        /// <value>The full progress log (up to this point at least)</value>
        [DataMember(Name = "progress", EmitDefaultValue = true)]
        public string Progress { get; set; }

        /// <summary>
        /// Individual Feedback Messages (to replace Progress).  A given message will be returned from only one call.
        /// </summary>
        /// <value>Individual Feedback Messages (to replace Progress).  A given message will be returned from only one call.</value>
        [DataMember(Name = "feedback", EmitDefaultValue = true)]
        public List<FeedbackEventArgs> Feedback { get; set; }

        /// <summary>
        /// Gets or Sets Queries
        /// </summary>
        [DataMember(Name = "queries", EmitDefaultValue = true)]
        public List<BackgroundQueryProgressResponse> Queries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackgroundMultiQueryProgressResponse {\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Feedback: ").Append(Feedback).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Queries: ").Append(Queries).Append("\n");
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
            return this.Equals(input as BackgroundMultiQueryProgressResponse);
        }

        /// <summary>
        /// Returns true if BackgroundMultiQueryProgressResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BackgroundMultiQueryProgressResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackgroundMultiQueryProgressResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
                ) && 
                (
                    this.Feedback == input.Feedback ||
                    this.Feedback != null &&
                    input.Feedback != null &&
                    this.Feedback.SequenceEqual(input.Feedback)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Queries == input.Queries ||
                    this.Queries != null &&
                    input.Queries != null &&
                    this.Queries.SequenceEqual(input.Queries)
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
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.Feedback != null)
                    hashCode = hashCode * 59 + this.Feedback.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Queries != null)
                    hashCode = hashCode * 59 + this.Queries.GetHashCode();
                return hashCode;
            }
        }

    }
}
