/*
 * FINBOURNE Luminesce Web API
 *
 *  ``` >   __                    _                             / /   __  ______ ___  (_)___  ___  _____________    / /   / / / / __ `__ / / __ / _ / ___/ ___/ _ \\  / /___/ /_/ / / / / / / / / / /  __(__  ) /__/  __/ /_____/\\__,_/_/ /_/ /_/_/_/ /_/\\___/____/\\___/\\___/  ```  ### Introduction to Luminesce  [Luminesce](https://support.lusid.com/knowledgebase/article/KA-01677/) is a data virtualization engine for LUSID and other applications.  It is proprietary technology designed and developed by FINBOURNE Technology Limited.  [Understanding the Luminesce platform architecture.](https://support.lusid.com/knowledgebase/article/KA-01707/)  Luminesce enables you to query multiple sources of business intelligence simultaneously in real-time—including investment management data stored in LUSID itself—and build a consolidated picture for analysis, optionally writing data back into LUSID. Alternatively, you can use Luminesce in a standalone capacity, without interacting with LUSID at all.  ### WebAPI  Allows for running queries and a variety of other functions relating to Luminesce. For example these REST APIs can execute queries, synchronously or better asynchronously, returning results in either Excel, CSV, SqLite, JSON among other formats.     ### Error Codes  | Code|Meaning | | - --|- -- | | <a name=\"233\">233</a>|Query Parser Failure | | <a name=\"850\">850</a>|Required provider not visible; provider may not exist, be temporarily unavailable, or you may not have the necessary permissions | | <a name=\"851\">851</a>|Query reached a timeout period or was cancelled | | <a name=\"852\">852</a>|Query failed during execution | | <a name=\"853\">853</a>|Query failed during execution for an unexpected reason | | <a name=\"854\">854</a>|Query failed during execution for a reason known to be an internal error (e.g. a Lusid provider where a corresponding API would return a 500) | | <a name=\"855\">855</a>|Required column is not in the queried provider(s) | | <a name=\"856\">856</a>|One or more columns are ambiguously referenced in the query | | <a name=\"857\">857</a>|Query failed during execution of a provider (e.g. in a way that might be transient, like an upstream issue) | | <a name=\"858\">858</a>|Query failed during execution within the Query Engine's SQL processing | | <a name=\"859\">859</a>|A variable has been defined more than once | 
 *
 * The version of the OpenAPI document: 1.16.616
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
    /// Contract for an expression of data we \&quot;have\&quot; that we may \&quot;want to map to a table-parameter&#39;s column\&quot;
    /// </summary>
    [DataContract(Name = "ExpressionWithAlias")]
    public partial class ExpressionWithAlias : IEquatable<ExpressionWithAlias>
    {

        /// <summary>
        /// Gets or Sets Flags
        /// </summary>
        [DataMember(Name = "flags", EmitDefaultValue = false)]
        public MappingFlags? Flags { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionWithAlias" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExpressionWithAlias() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionWithAlias" /> class.
        /// </summary>
        /// <param name="expression">Expression (column name, constant, complex expression, etc.) (required).</param>
        /// <param name="alias">Column Alias for the expression.</param>
        /// <param name="flags">flags.</param>
        public ExpressionWithAlias(string expression = default(string), string alias = default(string), MappingFlags? flags = default(MappingFlags?))
        {
            // to ensure "expression" is required (not null)
            this.Expression = expression ?? throw new ArgumentNullException("expression is a required property for ExpressionWithAlias and cannot be null");
            this.Alias = alias;
            this.Flags = flags;
        }

        /// <summary>
        /// Expression (column name, constant, complex expression, etc.)
        /// </summary>
        /// <value>Expression (column name, constant, complex expression, etc.)</value>
        [DataMember(Name = "expression", IsRequired = true, EmitDefaultValue = false)]
        public string Expression { get; set; }

        /// <summary>
        /// Column Alias for the expression
        /// </summary>
        /// <value>Column Alias for the expression</value>
        [DataMember(Name = "alias", EmitDefaultValue = true)]
        public string Alias { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpressionWithAlias {\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
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
            return this.Equals(input as ExpressionWithAlias);
        }

        /// <summary>
        /// Returns true if ExpressionWithAlias instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpressionWithAlias to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpressionWithAlias input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Expression == input.Expression ||
                    (this.Expression != null &&
                    this.Expression.Equals(input.Expression))
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.Flags == input.Flags ||
                    this.Flags.Equals(input.Flags)
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
                if (this.Expression != null)
                    hashCode = hashCode * 59 + this.Expression.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                hashCode = hashCode * 59 + this.Flags.GetHashCode();
                return hashCode;
            }
        }

    }
}
