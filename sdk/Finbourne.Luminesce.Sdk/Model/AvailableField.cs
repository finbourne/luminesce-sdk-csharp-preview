/*
 * FINBOURNE Luminesce Web API
 *
 *  ``` >   __                    _                             / /   __  ______ ___  (_)___  ___  _____________    / /   / / / / __ `__ / / __ / _ / ___/ ___/ _ \\  / /___/ /_/ / / / / / / / / / /  __(__  ) /__/  __/ /_____/\\__,_/_/ /_/ /_/_/_/ /_/\\___/____/\\___/\\___/  ```  ### Introduction to Luminesce  [Luminesce](https://support.lusid.com/knowledgebase/article/KA-01677/) is a data virtualization engine for LUSID and other applications.  It is proprietary technology designed and developed by FINBOURNE Technology Limited.  [Understanding the Luminesce platform architecture.](https://support.lusid.com/knowledgebase/article/KA-01707/)  Luminesce enables you to query multiple sources of business intelligence simultaneously in real-time—including investment management data stored in LUSID itself—and build a consolidated picture for analysis, optionally writing data back into LUSID. Alternatively, you can use Luminesce in a standalone capacity, without interacting with LUSID at all.  ### WebAPI  Allows for running queries and a variety of other functions relating to Luminesce. For example these REST APIs can execute queries, synchronously or better asynchronously, returning results in either Excel, CSV, SqLite, JSON among other formats.     ### Error Codes  | Code|Meaning | | - --|- -- | | <a name=\"233\">233</a>|Query Parser Failure | | <a name=\"850\">850</a>|Required provider not visible; provider may not exist, be temporarily unavailable, or you may not have the necessary permissions | | <a name=\"851\">851</a>|Query reached a timeout period or was cancelled | | <a name=\"852\">852</a>|Query failed during execution | | <a name=\"853\">853</a>|Query failed during execution for an unexpected reason | | <a name=\"854\">854</a>|Query failed during execution for a reason known to be an internal error (e.g. a Lusid provider where a corresponding API would return a 500) | | <a name=\"855\">855</a>|Required column is not in the queried provider(s) | | <a name=\"856\">856</a>|One or more columns are ambiguously referenced in the query | | <a name=\"857\">857</a>|Query failed during execution of a provider (e.g. in a way that might be transient, like an upstream issue) | | <a name=\"858\">858</a>|Query failed during execution within the Query Engine's SQL processing | | <a name=\"859\">859</a>|A variable has been defined more than once | 
 *
 * The version of the OpenAPI document: 1.16.606
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
    /// Information about a field that can be designed on (regardless if it currently is)  Kind of a \&quot;mini-available catalog entry\&quot;
    /// </summary>
    [DataContract(Name = "AvailableField")]
    public partial class AvailableField : IEquatable<AvailableField>
    {

        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name = "dataType", EmitDefaultValue = false)]
        public DataType? DataType { get; set; }

        /// <summary>
        /// Gets or Sets FieldType
        /// </summary>
        [DataMember(Name = "fieldType", IsRequired = true, EmitDefaultValue = false)]
        public FieldType FieldType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AvailableField() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableField" /> class.
        /// </summary>
        /// <param name="name">Name of the Field (required).</param>
        /// <param name="dataType">dataType.</param>
        /// <param name="fieldType">fieldType (required).</param>
        /// <param name="isMain">Is this a Main Field within the Provider.</param>
        /// <param name="isPrimaryKey">Is this a member of the PrimaryKey of the Provider.</param>
        public AvailableField(string name = default(string), DataType? dataType = default(DataType?), FieldType fieldType = default(FieldType), bool? isMain = default(bool?), bool? isPrimaryKey = default(bool?))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for AvailableField and cannot be null");
            this.FieldType = fieldType;
            this.DataType = dataType;
            this.IsMain = isMain;
            this.IsPrimaryKey = isPrimaryKey;
        }

        /// <summary>
        /// Name of the Field
        /// </summary>
        /// <value>Name of the Field</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Is this a Main Field within the Provider
        /// </summary>
        /// <value>Is this a Main Field within the Provider</value>
        [DataMember(Name = "isMain", EmitDefaultValue = true)]
        public bool? IsMain { get; set; }

        /// <summary>
        /// Is this a member of the PrimaryKey of the Provider
        /// </summary>
        /// <value>Is this a member of the PrimaryKey of the Provider</value>
        [DataMember(Name = "isPrimaryKey", EmitDefaultValue = true)]
        public bool? IsPrimaryKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailableField {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
            sb.Append("  IsMain: ").Append(IsMain).Append("\n");
            sb.Append("  IsPrimaryKey: ").Append(IsPrimaryKey).Append("\n");
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
            return this.Equals(input as AvailableField);
        }

        /// <summary>
        /// Returns true if AvailableField instances are equal
        /// </summary>
        /// <param name="input">Instance of AvailableField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailableField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DataType == input.DataType ||
                    this.DataType.Equals(input.DataType)
                ) && 
                (
                    this.FieldType == input.FieldType ||
                    this.FieldType.Equals(input.FieldType)
                ) && 
                (
                    this.IsMain == input.IsMain ||
                    (this.IsMain != null &&
                    this.IsMain.Equals(input.IsMain))
                ) && 
                (
                    this.IsPrimaryKey == input.IsPrimaryKey ||
                    (this.IsPrimaryKey != null &&
                    this.IsPrimaryKey.Equals(input.IsPrimaryKey))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.DataType.GetHashCode();
                hashCode = hashCode * 59 + this.FieldType.GetHashCode();
                if (this.IsMain != null)
                    hashCode = hashCode * 59 + this.IsMain.GetHashCode();
                if (this.IsPrimaryKey != null)
                    hashCode = hashCode * 59 + this.IsPrimaryKey.GetHashCode();
                return hashCode;
            }
        }

    }
}
