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
    /// Information about a case statement.  A typical case statement would look like:  CASE WHEN Field {Filter} Source THEN Target  For example: CASE WHEN &#39;currency&#39; &#x3D; &#39;USD&#39; THEN &#39;US&#39;  Here the Field is &#39;currency&#39;, the Source is &#39;USD&#39;, the Filter is &#39;&#x3D;&#39;, and the Target is &#39;US&#39;
    /// </summary>
    [DataContract(Name = "CaseStatementItem")]
    public partial class CaseStatementItem : IEquatable<CaseStatementItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseStatementItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CaseStatementItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseStatementItem" /> class.
        /// </summary>
        /// <param name="filter">The operator in the case statement SQL expression (required).</param>
        /// <param name="source">The expression that is on the LHS of the operator  A typical case statement would look like:  CASE Field {Filter} Source THEN Target (required).</param>
        /// <param name="target">The expression that is on the RHS of the operator  A typical case statement would look like:  CASE Field {Filter} Source THEN Target (required).</param>
        public CaseStatementItem(string filter = default(string), string source = default(string), string target = default(string))
        {
            // to ensure "filter" is required (not null)
            this.Filter = filter ?? throw new ArgumentNullException("filter is a required property for CaseStatementItem and cannot be null");
            // to ensure "source" is required (not null)
            this.Source = source ?? throw new ArgumentNullException("source is a required property for CaseStatementItem and cannot be null");
            // to ensure "target" is required (not null)
            this.Target = target ?? throw new ArgumentNullException("target is a required property for CaseStatementItem and cannot be null");
        }

        /// <summary>
        /// The operator in the case statement SQL expression
        /// </summary>
        /// <value>The operator in the case statement SQL expression</value>
        [DataMember(Name = "filter", IsRequired = true, EmitDefaultValue = false)]
        public string Filter { get; set; }

        /// <summary>
        /// The expression that is on the LHS of the operator  A typical case statement would look like:  CASE Field {Filter} Source THEN Target
        /// </summary>
        /// <value>The expression that is on the LHS of the operator  A typical case statement would look like:  CASE Field {Filter} Source THEN Target</value>
        [DataMember(Name = "source", IsRequired = true, EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// The expression that is on the RHS of the operator  A typical case statement would look like:  CASE Field {Filter} Source THEN Target
        /// </summary>
        /// <value>The expression that is on the RHS of the operator  A typical case statement would look like:  CASE Field {Filter} Source THEN Target</value>
        [DataMember(Name = "target", IsRequired = true, EmitDefaultValue = false)]
        public string Target { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseStatementItem {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
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
            return this.Equals(input as CaseStatementItem);
        }

        /// <summary>
        /// Returns true if CaseStatementItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CaseStatementItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseStatementItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
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
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
                return hashCode;
            }
        }

    }
}
