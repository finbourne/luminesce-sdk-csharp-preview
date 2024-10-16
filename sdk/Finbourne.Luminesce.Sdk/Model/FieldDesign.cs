/*
 * FINBOURNE Luminesce Web API
 *
 *  ``` >   __                    _                             / /   __  ______ ___  (_)___  ___  _____________    / /   / / / / __ `__ / / __ / _ / ___/ ___/ _ \\  / /___/ /_/ / / / / / / / / / /  __(__  ) /__/  __/ /_____/\\__,_/_/ /_/ /_/_/_/ /_/\\___/____/\\___/\\___/  ```  ### Introduction to Luminesce   [Luminesce](https://support.lusid.com/knowledgebase/article/KA-01677/) is a data virtualization engine for LUSID and other applications.  It is proprietary technology designed and developed by FINBOURNE Technology Limited.  [Understanding the Luminesce platform architecture.](https://support.lusid.com/knowledgebase/article/KA-01707/)  Luminesce enables you to query multiple sources of business intelligence simultaneously in real-time—including investment management data stored in LUSID itself—and build a consolidated picture for analysis, optionally writing data back into LUSID. Alternatively, you can use Luminesce in a standalone capacity, without interacting with LUSID at all.  ### WebAPI  Allows for running queries and a variety of other functions relating to Luminesce. For example these REST APIs can execute queries, synchronously or better asynchronously, returning results in either Excel, CSV, SqLite, JSON among other formats.  ### Error Codes  | Code|Meaning | | - --|- -- | | <a name=\"233\">233</a>|Query Parser Failure | | <a name=\"850\">850</a>|Required provider not visible; provider may not exist, be temporarily unavailable, or you may not have the necessary permissions | | <a name=\"851\">851</a>|Query reached a timeout period or was cancelled | | <a name=\"852\">852</a>|Query failed during execution | | <a name=\"853\">853</a>|Query failed during execution for an unexpected reason | | <a name=\"854\">854</a>|Query failed during execution for a reason known to be an internal error (e.g. a Lusid provider where a corresponding API would return a 500) | | <a name=\"855\">855</a>|Required column is not in the queried provider(s) | | <a name=\"856\">856</a>|One or more columns are ambiguously referenced in the query | | <a name=\"857\">857</a>|Query failed during execution of a provider (e.g. in a way that might be transient, like an upstream issue) | | <a name=\"858\">858</a>|Query failed during execution within the Query Engine's SQL processing | | <a name=\"859\">859</a>|A variable has been defined more than once | 
 *
 * The version of the OpenAPI document: 1.16.723
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
    /// Treatment of a single field within a QueryDesign
    /// </summary>
    [DataContract(Name = "FieldDesign")]
    public partial class FieldDesign : IEquatable<FieldDesign>
    {

        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name = "dataType", EmitDefaultValue = false)]
        public DataType? DataType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldDesign" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FieldDesign() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldDesign" /> class.
        /// </summary>
        /// <param name="name">Name of the Field (required).</param>
        /// <param name="alias">Alias if any (if none the Name is used).</param>
        /// <param name="dataType">dataType.</param>
        /// <param name="shouldSelect">Should this be selected? False would imply it is only being filtered on.  Ignored when Aggregations are present.</param>
        /// <param name="filters">Filter clauses to apply to this field (And&#39;ed together).</param>
        /// <param name="aggregations">Aggregations to apply (as opposed to simply selecting).</param>
        public FieldDesign(string name = default(string), string alias = default(string), DataType? dataType = default(DataType?), bool shouldSelect = default(bool), List<FilterTermDesign> filters = default(List<FilterTermDesign>), List<Aggregation> aggregations = default(List<Aggregation>))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for FieldDesign and cannot be null");
            this.Alias = alias;
            this.DataType = dataType;
            this.ShouldSelect = shouldSelect;
            this.Filters = filters;
            this.Aggregations = aggregations;
        }

        /// <summary>
        /// Name of the Field
        /// </summary>
        /// <value>Name of the Field</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Alias if any (if none the Name is used)
        /// </summary>
        /// <value>Alias if any (if none the Name is used)</value>
        [DataMember(Name = "alias", EmitDefaultValue = true)]
        public string Alias { get; set; }

        /// <summary>
        /// Should this be selected? False would imply it is only being filtered on.  Ignored when Aggregations are present
        /// </summary>
        /// <value>Should this be selected? False would imply it is only being filtered on.  Ignored when Aggregations are present</value>
        [DataMember(Name = "shouldSelect", EmitDefaultValue = true)]
        public bool ShouldSelect { get; set; }

        /// <summary>
        /// Filter clauses to apply to this field (And&#39;ed together)
        /// </summary>
        /// <value>Filter clauses to apply to this field (And&#39;ed together)</value>
        [DataMember(Name = "filters", EmitDefaultValue = true)]
        public List<FilterTermDesign> Filters { get; set; }

        /// <summary>
        /// Aggregations to apply (as opposed to simply selecting)
        /// </summary>
        /// <value>Aggregations to apply (as opposed to simply selecting)</value>
        [DataMember(Name = "aggregations", EmitDefaultValue = true)]
        public List<Aggregation> Aggregations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldDesign {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  ShouldSelect: ").Append(ShouldSelect).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Aggregations: ").Append(Aggregations).Append("\n");
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
            return this.Equals(input as FieldDesign);
        }

        /// <summary>
        /// Returns true if FieldDesign instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldDesign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldDesign input)
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
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.DataType == input.DataType ||
                    this.DataType.Equals(input.DataType)
                ) && 
                (
                    this.ShouldSelect == input.ShouldSelect ||
                    this.ShouldSelect.Equals(input.ShouldSelect)
                ) && 
                (
                    this.Filters == input.Filters ||
                    this.Filters != null &&
                    input.Filters != null &&
                    this.Filters.SequenceEqual(input.Filters)
                ) && 
                (
                    this.Aggregations == input.Aggregations ||
                    this.Aggregations != null &&
                    input.Aggregations != null &&
                    this.Aggregations.SequenceEqual(input.Aggregations)
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
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                hashCode = hashCode * 59 + this.DataType.GetHashCode();
                hashCode = hashCode * 59 + this.ShouldSelect.GetHashCode();
                if (this.Filters != null)
                    hashCode = hashCode * 59 + this.Filters.GetHashCode();
                if (this.Aggregations != null)
                    hashCode = hashCode * 59 + this.Aggregations.GetHashCode();
                return hashCode;
            }
        }

    }
}
