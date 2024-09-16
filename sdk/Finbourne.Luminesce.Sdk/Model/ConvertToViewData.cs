/*
 * FINBOURNE Luminesce Web API
 *
 *  ``` >   __                    _                             / /   __  ______ ___  (_)___  ___  _____________    / /   / / / / __ `__ / / __ / _ / ___/ ___/ _ \\  / /___/ /_/ / / / / / / / / / /  __(__  ) /__/  __/ /_____/\\__,_/_/ /_/ /_/_/_/ /_/\\___/____/\\___/\\___/  ```  ### Introduction to Luminesce  [Luminesce](https://support.lusid.com/knowledgebase/article/KA-01677/) is a data virtualization engine for LUSID and other applications.  It is proprietary technology designed and developed by FINBOURNE Technology Limited.  [Understanding the Luminesce platform architecture.](https://support.lusid.com/knowledgebase/article/KA-01707/)  Luminesce enables you to query multiple sources of business intelligence simultaneously in real-time—including investment management data stored in LUSID itself—and build a consolidated picture for analysis, optionally writing data back into LUSID. Alternatively, you can use Luminesce in a standalone capacity, without interacting with LUSID at all.  ### WebAPI  Allows for running queries and a variety of other functions relating to Luminesce. For example these REST APIs can execute queries, synchronously or better asynchronously, returning results in either Excel, CSV, SqLite, JSON among other formats.     ### Error Codes  | Code|Meaning | | - --|- -- | | <a name=\"233\">233</a>|Query Parser Failure | | <a name=\"850\">850</a>|Required provider not visible; provider may not exist, be temporarily unavailable, or you may not have the necessary permissions | | <a name=\"851\">851</a>|Query reached a timeout period or was cancelled | | <a name=\"852\">852</a>|Query failed during execution | | <a name=\"853\">853</a>|Query failed during execution for an unexpected reason | | <a name=\"854\">854</a>|Query failed during execution for a reason known to be an internal error (e.g. a Lusid provider where a corresponding API would return a 500) | | <a name=\"855\">855</a>|Required column is not in the queried provider(s) | | <a name=\"856\">856</a>|One or more columns are ambiguously referenced in the query | | <a name=\"857\">857</a>|Query failed during execution of a provider (e.g. in a way that might be transient, like an upstream issue) | | <a name=\"858\">858</a>|Query failed during execution within the Query Engine's SQL processing | | <a name=\"859\">859</a>|A variable has been defined more than once | 
 *
 * The version of the OpenAPI document: 1.16.612
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
    /// Representation of view data where will template the data into a &#39;create view&#39; sql
    /// </summary>
    [DataContract(Name = "ConvertToViewData")]
    public partial class ConvertToViewData : IEquatable<ConvertToViewData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertToViewData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConvertToViewData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertToViewData" /> class.
        /// </summary>
        /// <param name="query">view query (required).</param>
        /// <param name="name">Name of view (required).</param>
        /// <param name="description">Description of view.</param>
        /// <param name="documentationLink">Documentation link.</param>
        /// <param name="viewParameters">View parameters.</param>
        /// <param name="otherParameters">Other parameters not explicitly handled by the ConvertToView generation.  These will be populated by the \&quot;From SQL\&quot; and should simply be returned by  the web GUI should the user edit / update / regenerate.</param>
        /// <param name="startingVariableName">Which variable the this start with, null if not started from a full Create View Sql Statement..</param>
        public ConvertToViewData(string query = default(string), string name = default(string), string description = default(string), string documentationLink = default(string), List<ViewParameter> viewParameters = default(List<ViewParameter>), Dictionary<string, string> otherParameters = default(Dictionary<string, string>), string startingVariableName = default(string))
        {
            // to ensure "query" is required (not null)
            this.Query = query ?? throw new ArgumentNullException("query is a required property for ConvertToViewData and cannot be null");
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for ConvertToViewData and cannot be null");
            this.Description = description;
            this.DocumentationLink = documentationLink;
            this.ViewParameters = viewParameters;
            this.OtherParameters = otherParameters;
            this.StartingVariableName = startingVariableName;
        }

        /// <summary>
        /// view query
        /// </summary>
        /// <value>view query</value>
        [DataMember(Name = "query", IsRequired = true, EmitDefaultValue = false)]
        public string Query { get; set; }

        /// <summary>
        /// Name of view
        /// </summary>
        /// <value>Name of view</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Description of view
        /// </summary>
        /// <value>Description of view</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Documentation link
        /// </summary>
        /// <value>Documentation link</value>
        [DataMember(Name = "documentationLink", EmitDefaultValue = true)]
        public string DocumentationLink { get; set; }

        /// <summary>
        /// View parameters
        /// </summary>
        /// <value>View parameters</value>
        [DataMember(Name = "viewParameters", EmitDefaultValue = true)]
        public List<ViewParameter> ViewParameters { get; set; }

        /// <summary>
        /// Other parameters not explicitly handled by the ConvertToView generation.  These will be populated by the \&quot;From SQL\&quot; and should simply be returned by  the web GUI should the user edit / update / regenerate
        /// </summary>
        /// <value>Other parameters not explicitly handled by the ConvertToView generation.  These will be populated by the \&quot;From SQL\&quot; and should simply be returned by  the web GUI should the user edit / update / regenerate</value>
        [DataMember(Name = "otherParameters", EmitDefaultValue = true)]
        public Dictionary<string, string> OtherParameters { get; set; }

        /// <summary>
        /// Which variable the this start with, null if not started from a full Create View Sql Statement.
        /// </summary>
        /// <value>Which variable the this start with, null if not started from a full Create View Sql Statement.</value>
        [DataMember(Name = "startingVariableName", EmitDefaultValue = true)]
        public string StartingVariableName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConvertToViewData {\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DocumentationLink: ").Append(DocumentationLink).Append("\n");
            sb.Append("  ViewParameters: ").Append(ViewParameters).Append("\n");
            sb.Append("  OtherParameters: ").Append(OtherParameters).Append("\n");
            sb.Append("  StartingVariableName: ").Append(StartingVariableName).Append("\n");
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
            return this.Equals(input as ConvertToViewData);
        }

        /// <summary>
        /// Returns true if ConvertToViewData instances are equal
        /// </summary>
        /// <param name="input">Instance of ConvertToViewData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConvertToViewData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DocumentationLink == input.DocumentationLink ||
                    (this.DocumentationLink != null &&
                    this.DocumentationLink.Equals(input.DocumentationLink))
                ) && 
                (
                    this.ViewParameters == input.ViewParameters ||
                    this.ViewParameters != null &&
                    input.ViewParameters != null &&
                    this.ViewParameters.SequenceEqual(input.ViewParameters)
                ) && 
                (
                    this.OtherParameters == input.OtherParameters ||
                    this.OtherParameters != null &&
                    input.OtherParameters != null &&
                    this.OtherParameters.SequenceEqual(input.OtherParameters)
                ) && 
                (
                    this.StartingVariableName == input.StartingVariableName ||
                    (this.StartingVariableName != null &&
                    this.StartingVariableName.Equals(input.StartingVariableName))
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
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DocumentationLink != null)
                    hashCode = hashCode * 59 + this.DocumentationLink.GetHashCode();
                if (this.ViewParameters != null)
                    hashCode = hashCode * 59 + this.ViewParameters.GetHashCode();
                if (this.OtherParameters != null)
                    hashCode = hashCode * 59 + this.OtherParameters.GetHashCode();
                if (this.StartingVariableName != null)
                    hashCode = hashCode * 59 + this.StartingVariableName.GetHashCode();
                return hashCode;
            }
        }

    }
}
