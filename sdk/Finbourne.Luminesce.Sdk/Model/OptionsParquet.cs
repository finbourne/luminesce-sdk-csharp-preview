/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.13.847
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
    [DataContract(Name = "OptionsParquet")]
    public partial class OptionsParquet : IEquatable<OptionsParquet>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsParquet" /> class.
        /// </summary>
        /// <param name="columnNamesWanted">Column (by Name) that should be returned (comma delimited list).</param>
        public OptionsParquet(string columnNamesWanted = default(string))
        {
            this.ColumnNamesWanted = columnNamesWanted;
        }

        /// <summary>
        /// Column (by Name) that should be returned (comma delimited list)
        /// </summary>
        /// <value>Column (by Name) that should be returned (comma delimited list)</value>
        [DataMember(Name = "columnNamesWanted", EmitDefaultValue = true)]
        public string ColumnNamesWanted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionsParquet {\n");
            sb.Append("  ColumnNamesWanted: ").Append(ColumnNamesWanted).Append("\n");
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
            return this.Equals(input as OptionsParquet);
        }

        /// <summary>
        /// Returns true if OptionsParquet instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionsParquet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionsParquet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ColumnNamesWanted == input.ColumnNamesWanted ||
                    (this.ColumnNamesWanted != null &&
                    this.ColumnNamesWanted.Equals(input.ColumnNamesWanted))
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
                if (this.ColumnNamesWanted != null)
                    hashCode = hashCode * 59 + this.ColumnNamesWanted.GetHashCode();
                return hashCode;
            }
        }

    }
}