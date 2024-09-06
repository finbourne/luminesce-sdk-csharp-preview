/*
 * FINBOURNE Luminesce Web API
 *
 *  ``` >   __                    _                             / /   __  ______ ___  (_)___  ___  _____________    / /   / / / / __ `__ / / __ / _ / ___/ ___/ _ \\  / /___/ /_/ / / / / / / / / / /  __(__  ) /__/  __/ /_____/\\__,_/_/ /_/ /_/_/_/ /_/\\___/____/\\___/\\___/  ```  ### Introduction to Luminesce  [Luminesce](https://support.lusid.com/knowledgebase/article/KA-01677/) is a data virtualization engine for LUSID and other applications.  It is proprietary technology designed and developed by FINBOURNE Technology Limited.  [Understanding the Luminesce platform architecture.](https://support.lusid.com/knowledgebase/article/KA-01707/)  Luminesce enables you to query multiple sources of business intelligence simultaneously in real-time—including investment management data stored in LUSID itself—and build a consolidated picture for analysis, optionally writing data back into LUSID. Alternatively, you can use Luminesce in a standalone capacity, without interacting with LUSID at all.  ### WebAPI  Allows for running queries and a variety of other functions relating to Luminesce. For example these REST APIs can execute queries, synchronously or better asynchronously, returning results in either Excel, CSV, SqLite, JSON among other formats.     ### Error Codes  | Code|Meaning | | - --|- -- | | <a name=\"233\">233</a>|Query Parser Failure | | <a name=\"850\">850</a>|Required provider not visible; provider may not exist, be temporarily unavailable, or you may not have the necessary permissions | | <a name=\"851\">851</a>|Query reached a timeout period or was cancelled | | <a name=\"852\">852</a>|Query failed during execution | | <a name=\"853\">853</a>|Query failed during execution for an unexpected reason | | <a name=\"854\">854</a>|Query failed during execution for a reason known to be an internal error (e.g. a Lusid provider where a corresponding API would return a 500) | | <a name=\"855\">855</a>|Required column is not in the queried provider(s) | | <a name=\"856\">856</a>|One or more columns are ambiguously referenced in the query | | <a name=\"857\">857</a>|Query failed during execution of a provider (e.g. in a way that might be transient, like an upstream issue) | | <a name=\"858\">858</a>|Query failed during execution within the Query Engine's SQL processing | | <a name=\"859\">859</a>|A variable has been defined more than once | 
 *
 * The version of the OpenAPI document: 1.16.590
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
    /// Represents a cursor location
    /// </summary>
    [DataContract(Name = "CursorPosition")]
    public partial class CursorPosition : IEquatable<CursorPosition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CursorPosition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CursorPosition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CursorPosition" /> class.
        /// </summary>
        /// <param name="row">Row (0 based) of the user&#39;s cursor position (required).</param>
        /// <param name="column">Column (0 based) of the user&#39;s cursor position (required).</param>
        public CursorPosition(int row = default(int), int column = default(int))
        {
            this.Row = row;
            this.Column = column;
        }

        /// <summary>
        /// Row (0 based) of the user&#39;s cursor position
        /// </summary>
        /// <value>Row (0 based) of the user&#39;s cursor position</value>
        [DataMember(Name = "row", IsRequired = true, EmitDefaultValue = true)]
        public int Row { get; set; }

        /// <summary>
        /// Column (0 based) of the user&#39;s cursor position
        /// </summary>
        /// <value>Column (0 based) of the user&#39;s cursor position</value>
        [DataMember(Name = "column", IsRequired = true, EmitDefaultValue = true)]
        public int Column { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CursorPosition {\n");
            sb.Append("  Row: ").Append(Row).Append("\n");
            sb.Append("  Column: ").Append(Column).Append("\n");
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
            return this.Equals(input as CursorPosition);
        }

        /// <summary>
        /// Returns true if CursorPosition instances are equal
        /// </summary>
        /// <param name="input">Instance of CursorPosition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CursorPosition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Row == input.Row ||
                    this.Row.Equals(input.Row)
                ) && 
                (
                    this.Column == input.Column ||
                    this.Column.Equals(input.Column)
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
                hashCode = hashCode * 59 + this.Row.GetHashCode();
                hashCode = hashCode * 59 + this.Column.GetHashCode();
                return hashCode;
            }
        }

    }
}
