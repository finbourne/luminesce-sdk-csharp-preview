/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.16.73
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
    /// Representation of a set of inlined properties for a given provider so that SQL can be generated to be able to inline properties into luminesce
    /// </summary>
    [DataContract(Name = "InlinedPropertyDesign")]
    public partial class InlinedPropertyDesign : IEquatable<InlinedPropertyDesign>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlinedPropertyDesign" /> class.
        /// </summary>
        /// <param name="providerName">The provider name for which these properties are to be inlined.</param>
        /// <param name="inlinedPropertyItems">Collection of Inlined properties.</param>
        public InlinedPropertyDesign(string providerName = default(string), List<InlinedPropertyItem> inlinedPropertyItems = default(List<InlinedPropertyItem>))
        {
            this.ProviderName = providerName;
            this.InlinedPropertyItems = inlinedPropertyItems;
        }

        /// <summary>
        /// The provider name for which these properties are to be inlined
        /// </summary>
        /// <value>The provider name for which these properties are to be inlined</value>
        [DataMember(Name = "providerName", EmitDefaultValue = true)]
        public string ProviderName { get; set; }

        /// <summary>
        /// Collection of Inlined properties
        /// </summary>
        /// <value>Collection of Inlined properties</value>
        [DataMember(Name = "inlinedPropertyItems", EmitDefaultValue = true)]
        public List<InlinedPropertyItem> InlinedPropertyItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlinedPropertyDesign {\n");
            sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
            sb.Append("  InlinedPropertyItems: ").Append(InlinedPropertyItems).Append("\n");
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
            return this.Equals(input as InlinedPropertyDesign);
        }

        /// <summary>
        /// Returns true if InlinedPropertyDesign instances are equal
        /// </summary>
        /// <param name="input">Instance of InlinedPropertyDesign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlinedPropertyDesign input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProviderName == input.ProviderName ||
                    (this.ProviderName != null &&
                    this.ProviderName.Equals(input.ProviderName))
                ) && 
                (
                    this.InlinedPropertyItems == input.InlinedPropertyItems ||
                    this.InlinedPropertyItems != null &&
                    input.InlinedPropertyItems != null &&
                    this.InlinedPropertyItems.SequenceEqual(input.InlinedPropertyItems)
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
                if (this.ProviderName != null)
                    hashCode = hashCode * 59 + this.ProviderName.GetHashCode();
                if (this.InlinedPropertyItems != null)
                    hashCode = hashCode * 59 + this.InlinedPropertyItems.GetHashCode();
                return hashCode;
            }
        }

    }
}
