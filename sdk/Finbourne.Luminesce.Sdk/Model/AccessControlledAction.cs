/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.13.327
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
    /// AccessControlledAction
    /// </summary>
    [DataContract(Name = "AccessControlledAction")]
    public partial class AccessControlledAction : IEquatable<AccessControlledAction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessControlledAction" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="action">action.</param>
        /// <param name="limitedSet">limitedSet.</param>
        public AccessControlledAction(string description = default(string), ActionId action = default(ActionId), List<IdSelectorDefinition> limitedSet = default(List<IdSelectorDefinition>))
        {
            this.Description = description;
            this.Action = action;
            this.LimitedSet = limitedSet;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public ActionId Action { get; set; }

        /// <summary>
        /// Gets or Sets LimitedSet
        /// </summary>
        [DataMember(Name = "limitedSet", EmitDefaultValue = true)]
        public List<IdSelectorDefinition> LimitedSet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessControlledAction {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  LimitedSet: ").Append(LimitedSet).Append("\n");
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
            return this.Equals(input as AccessControlledAction);
        }

        /// <summary>
        /// Returns true if AccessControlledAction instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessControlledAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessControlledAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.LimitedSet == input.LimitedSet ||
                    this.LimitedSet != null &&
                    input.LimitedSet != null &&
                    this.LimitedSet.SequenceEqual(input.LimitedSet)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.LimitedSet != null)
                    hashCode = hashCode * 59 + this.LimitedSet.GetHashCode();
                return hashCode;
            }
        }

    }
}
