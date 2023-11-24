/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.14.39
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
    /// FeedbackEventArgs
    /// </summary>
    [DataContract(Name = "FeedbackEventArgs")]
    public partial class FeedbackEventArgs : IEquatable<FeedbackEventArgs>
    {

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public FeedbackLevel? Level { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackEventArgs" /> class.
        /// </summary>
        /// <param name="when">when.</param>
        /// <param name="sessionId">sessionId.</param>
        /// <param name="executionId">executionId.</param>
        /// <param name="level">level.</param>
        /// <param name="sender">sender.</param>
        /// <param name="stateId">stateId.</param>
        /// <param name="messageTemplate">messageTemplate.</param>
        /// <param name="propertyValues">propertyValues.</param>
        public FeedbackEventArgs(DateTimeOffset when = default(DateTimeOffset), Guid sessionId = default(Guid), Guid executionId = default(Guid), FeedbackLevel? level = default(FeedbackLevel?), string sender = default(string), int? stateId = default(int?), string messageTemplate = default(string), List<Object> propertyValues = default(List<Object>))
        {
            this.When = when;
            this.SessionId = sessionId;
            this.ExecutionId = executionId;
            this.Level = level;
            this.Sender = sender;
            this.StateId = stateId;
            this.MessageTemplate = messageTemplate;
            this.PropertyValues = propertyValues;
        }

        /// <summary>
        /// Gets or Sets When
        /// </summary>
        [DataMember(Name = "when", EmitDefaultValue = false)]
        public DateTimeOffset When { get; set; }

        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name = "sessionId", EmitDefaultValue = false)]
        public Guid SessionId { get; set; }

        /// <summary>
        /// Gets or Sets ExecutionId
        /// </summary>
        [DataMember(Name = "executionId", EmitDefaultValue = false)]
        public Guid ExecutionId { get; set; }

        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name = "sender", EmitDefaultValue = true)]
        public string Sender { get; set; }

        /// <summary>
        /// Gets or Sets StateId
        /// </summary>
        [DataMember(Name = "stateId", EmitDefaultValue = true)]
        public int? StateId { get; set; }

        /// <summary>
        /// Gets or Sets MessageTemplate
        /// </summary>
        [DataMember(Name = "messageTemplate", EmitDefaultValue = true)]
        public string MessageTemplate { get; set; }

        /// <summary>
        /// Gets or Sets PropertyValues
        /// </summary>
        [DataMember(Name = "propertyValues", EmitDefaultValue = true)]
        public List<Object> PropertyValues { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; private set; }

        /// <summary>
        /// Returns false as Message should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMessage()
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
            sb.Append("class FeedbackEventArgs {\n");
            sb.Append("  When: ").Append(When).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  StateId: ").Append(StateId).Append("\n");
            sb.Append("  MessageTemplate: ").Append(MessageTemplate).Append("\n");
            sb.Append("  PropertyValues: ").Append(PropertyValues).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as FeedbackEventArgs);
        }

        /// <summary>
        /// Returns true if FeedbackEventArgs instances are equal
        /// </summary>
        /// <param name="input">Instance of FeedbackEventArgs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeedbackEventArgs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.When == input.When ||
                    (this.When != null &&
                    this.When.Equals(input.When))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
                ) && 
                (
                    this.ExecutionId == input.ExecutionId ||
                    (this.ExecutionId != null &&
                    this.ExecutionId.Equals(input.ExecutionId))
                ) && 
                (
                    this.Level == input.Level ||
                    this.Level.Equals(input.Level)
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.StateId == input.StateId ||
                    (this.StateId != null &&
                    this.StateId.Equals(input.StateId))
                ) && 
                (
                    this.MessageTemplate == input.MessageTemplate ||
                    (this.MessageTemplate != null &&
                    this.MessageTemplate.Equals(input.MessageTemplate))
                ) && 
                (
                    this.PropertyValues == input.PropertyValues ||
                    this.PropertyValues != null &&
                    input.PropertyValues != null &&
                    this.PropertyValues.SequenceEqual(input.PropertyValues)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.When != null)
                    hashCode = hashCode * 59 + this.When.GetHashCode();
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.ExecutionId != null)
                    hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.StateId != null)
                    hashCode = hashCode * 59 + this.StateId.GetHashCode();
                if (this.MessageTemplate != null)
                    hashCode = hashCode * 59 + this.MessageTemplate.GetHashCode();
                if (this.PropertyValues != null)
                    hashCode = hashCode * 59 + this.PropertyValues.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }

    }
}
