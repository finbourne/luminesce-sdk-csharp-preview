/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.16.251
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
    [DataContract(Name = "OptionsSqLite")]
    public partial class OptionsSqLite : IEquatable<OptionsSqLite>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsSqLite" /> class.
        /// </summary>
        /// <param name="table">Table name to read.  If missing then an error will be raised if there is any number of tables other than one..</param>
        public OptionsSqLite(string table = default(string))
        {
            this.Table = table;
        }

        /// <summary>
        /// Table name to read.  If missing then an error will be raised if there is any number of tables other than one.
        /// </summary>
        /// <value>Table name to read.  If missing then an error will be raised if there is any number of tables other than one.</value>
        [DataMember(Name = "table", EmitDefaultValue = true)]
        public string Table { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionsSqLite {\n");
            sb.Append("  Table: ").Append(Table).Append("\n");
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
            return this.Equals(input as OptionsSqLite);
        }

        /// <summary>
        /// Returns true if OptionsSqLite instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionsSqLite to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionsSqLite input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Table == input.Table ||
                    (this.Table != null &&
                    this.Table.Equals(input.Table))
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
                if (this.Table != null)
                    hashCode = hashCode * 59 + this.Table.GetHashCode();
                return hashCode;
            }
        }

    }
}
