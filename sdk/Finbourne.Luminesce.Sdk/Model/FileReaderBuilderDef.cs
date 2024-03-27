/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.14.841
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
    /// Information on how to construct a file-read sql query
    /// </summary>
    [DataContract(Name = "FileReaderBuilderDef")]
    public partial class FileReaderBuilderDef : IEquatable<FileReaderBuilderDef>
    {

        /// <summary>
        /// Gets or Sets AutoDetect
        /// </summary>
        [DataMember(Name = "autoDetect", EmitDefaultValue = false)]
        public AutoDetectType? AutoDetect { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileReaderBuilderDef" /> class.
        /// </summary>
        /// <param name="autoDetect">autoDetect.</param>
        /// <param name="columns">Column information for the results.</param>
        /// <param name="limit">What limit be added to the load query?  Less than or equal to zero means none.</param>
        /// <param name="source">source.</param>
        /// <param name="availableSources">The source locations the user has access to.  The provider in essence..</param>
        /// <param name="variableName">The name of the variable for the &#x60;use&#x60; statement.</param>
        /// <param name="filePath">The file (or folder) path.</param>
        /// <param name="folderFilter">The filter to apply to a folder (all matching files then being read) a RegExp.</param>
        /// <param name="zipFilter">The filter to apply to folder structures with zip archives (all matching files then being read) a RegExp.</param>
        /// <param name="addFileName">Should a file name column be added to the output?.</param>
        /// <param name="csv">csv.</param>
        /// <param name="excel">excel.</param>
        /// <param name="sqLite">sqLite.</param>
        /// <param name="xml">xml.</param>
        /// <param name="parquet">parquet.</param>
        public FileReaderBuilderDef(AutoDetectType? autoDetect = default(AutoDetectType?), List<ColumnInfo> columns = default(List<ColumnInfo>), int limit = default(int), Source source = default(Source), List<Source> availableSources = default(List<Source>), string variableName = default(string), string filePath = default(string), string folderFilter = default(string), string zipFilter = default(string), bool addFileName = default(bool), OptionsCsv csv = default(OptionsCsv), OptionsExcel excel = default(OptionsExcel), OptionsSqLite sqLite = default(OptionsSqLite), OptionsXml xml = default(OptionsXml), OptionsParquet parquet = default(OptionsParquet))
        {
            this.AutoDetect = autoDetect;
            this.Columns = columns;
            this.Limit = limit;
            this.Source = source;
            this.AvailableSources = availableSources;
            this.VariableName = variableName;
            this.FilePath = filePath;
            this.FolderFilter = folderFilter;
            this.ZipFilter = zipFilter;
            this.AddFileName = addFileName;
            this.Csv = csv;
            this.Excel = excel;
            this.SqLite = sqLite;
            this.Xml = xml;
            this.Parquet = parquet;
        }

        /// <summary>
        /// Column information for the results
        /// </summary>
        /// <value>Column information for the results</value>
        [DataMember(Name = "columns", EmitDefaultValue = true)]
        public List<ColumnInfo> Columns { get; set; }

        /// <summary>
        /// What limit be added to the load query?  Less than or equal to zero means none
        /// </summary>
        /// <value>What limit be added to the load query?  Less than or equal to zero means none</value>
        [DataMember(Name = "limit", EmitDefaultValue = true)]
        public int Limit { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public Source Source { get; set; }

        /// <summary>
        /// The source locations the user has access to.  The provider in essence.
        /// </summary>
        /// <value>The source locations the user has access to.  The provider in essence.</value>
        [DataMember(Name = "availableSources", EmitDefaultValue = true)]
        public List<Source> AvailableSources { get; set; }

        /// <summary>
        /// The name of the variable for the &#x60;use&#x60; statement
        /// </summary>
        /// <value>The name of the variable for the &#x60;use&#x60; statement</value>
        [DataMember(Name = "variableName", EmitDefaultValue = true)]
        public string VariableName { get; set; }

        /// <summary>
        /// The file (or folder) path
        /// </summary>
        /// <value>The file (or folder) path</value>
        [DataMember(Name = "filePath", EmitDefaultValue = true)]
        public string FilePath { get; set; }

        /// <summary>
        /// The filter to apply to a folder (all matching files then being read) a RegExp
        /// </summary>
        /// <value>The filter to apply to a folder (all matching files then being read) a RegExp</value>
        [DataMember(Name = "folderFilter", EmitDefaultValue = true)]
        public string FolderFilter { get; set; }

        /// <summary>
        /// The filter to apply to folder structures with zip archives (all matching files then being read) a RegExp
        /// </summary>
        /// <value>The filter to apply to folder structures with zip archives (all matching files then being read) a RegExp</value>
        [DataMember(Name = "zipFilter", EmitDefaultValue = true)]
        public string ZipFilter { get; set; }

        /// <summary>
        /// Should a file name column be added to the output?
        /// </summary>
        /// <value>Should a file name column be added to the output?</value>
        [DataMember(Name = "addFileName", EmitDefaultValue = true)]
        public bool AddFileName { get; set; }

        /// <summary>
        /// Gets or Sets Csv
        /// </summary>
        [DataMember(Name = "csv", EmitDefaultValue = false)]
        public OptionsCsv Csv { get; set; }

        /// <summary>
        /// Gets or Sets Excel
        /// </summary>
        [DataMember(Name = "excel", EmitDefaultValue = false)]
        public OptionsExcel Excel { get; set; }

        /// <summary>
        /// Gets or Sets SqLite
        /// </summary>
        [DataMember(Name = "sqLite", EmitDefaultValue = false)]
        public OptionsSqLite SqLite { get; set; }

        /// <summary>
        /// Gets or Sets Xml
        /// </summary>
        [DataMember(Name = "xml", EmitDefaultValue = false)]
        public OptionsXml Xml { get; set; }

        /// <summary>
        /// Gets or Sets Parquet
        /// </summary>
        [DataMember(Name = "parquet", EmitDefaultValue = false)]
        public OptionsParquet Parquet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileReaderBuilderDef {\n");
            sb.Append("  AutoDetect: ").Append(AutoDetect).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  AvailableSources: ").Append(AvailableSources).Append("\n");
            sb.Append("  VariableName: ").Append(VariableName).Append("\n");
            sb.Append("  FilePath: ").Append(FilePath).Append("\n");
            sb.Append("  FolderFilter: ").Append(FolderFilter).Append("\n");
            sb.Append("  ZipFilter: ").Append(ZipFilter).Append("\n");
            sb.Append("  AddFileName: ").Append(AddFileName).Append("\n");
            sb.Append("  Csv: ").Append(Csv).Append("\n");
            sb.Append("  Excel: ").Append(Excel).Append("\n");
            sb.Append("  SqLite: ").Append(SqLite).Append("\n");
            sb.Append("  Xml: ").Append(Xml).Append("\n");
            sb.Append("  Parquet: ").Append(Parquet).Append("\n");
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
            return this.Equals(input as FileReaderBuilderDef);
        }

        /// <summary>
        /// Returns true if FileReaderBuilderDef instances are equal
        /// </summary>
        /// <param name="input">Instance of FileReaderBuilderDef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileReaderBuilderDef input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoDetect == input.AutoDetect ||
                    this.AutoDetect.Equals(input.AutoDetect)
                ) && 
                (
                    this.Columns == input.Columns ||
                    this.Columns != null &&
                    input.Columns != null &&
                    this.Columns.SequenceEqual(input.Columns)
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.AvailableSources == input.AvailableSources ||
                    this.AvailableSources != null &&
                    input.AvailableSources != null &&
                    this.AvailableSources.SequenceEqual(input.AvailableSources)
                ) && 
                (
                    this.VariableName == input.VariableName ||
                    (this.VariableName != null &&
                    this.VariableName.Equals(input.VariableName))
                ) && 
                (
                    this.FilePath == input.FilePath ||
                    (this.FilePath != null &&
                    this.FilePath.Equals(input.FilePath))
                ) && 
                (
                    this.FolderFilter == input.FolderFilter ||
                    (this.FolderFilter != null &&
                    this.FolderFilter.Equals(input.FolderFilter))
                ) && 
                (
                    this.ZipFilter == input.ZipFilter ||
                    (this.ZipFilter != null &&
                    this.ZipFilter.Equals(input.ZipFilter))
                ) && 
                (
                    this.AddFileName == input.AddFileName ||
                    this.AddFileName.Equals(input.AddFileName)
                ) && 
                (
                    this.Csv == input.Csv ||
                    (this.Csv != null &&
                    this.Csv.Equals(input.Csv))
                ) && 
                (
                    this.Excel == input.Excel ||
                    (this.Excel != null &&
                    this.Excel.Equals(input.Excel))
                ) && 
                (
                    this.SqLite == input.SqLite ||
                    (this.SqLite != null &&
                    this.SqLite.Equals(input.SqLite))
                ) && 
                (
                    this.Xml == input.Xml ||
                    (this.Xml != null &&
                    this.Xml.Equals(input.Xml))
                ) && 
                (
                    this.Parquet == input.Parquet ||
                    (this.Parquet != null &&
                    this.Parquet.Equals(input.Parquet))
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
                hashCode = hashCode * 59 + this.AutoDetect.GetHashCode();
                if (this.Columns != null)
                    hashCode = hashCode * 59 + this.Columns.GetHashCode();
                hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.AvailableSources != null)
                    hashCode = hashCode * 59 + this.AvailableSources.GetHashCode();
                if (this.VariableName != null)
                    hashCode = hashCode * 59 + this.VariableName.GetHashCode();
                if (this.FilePath != null)
                    hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.FolderFilter != null)
                    hashCode = hashCode * 59 + this.FolderFilter.GetHashCode();
                if (this.ZipFilter != null)
                    hashCode = hashCode * 59 + this.ZipFilter.GetHashCode();
                hashCode = hashCode * 59 + this.AddFileName.GetHashCode();
                if (this.Csv != null)
                    hashCode = hashCode * 59 + this.Csv.GetHashCode();
                if (this.Excel != null)
                    hashCode = hashCode * 59 + this.Excel.GetHashCode();
                if (this.SqLite != null)
                    hashCode = hashCode * 59 + this.SqLite.GetHashCode();
                if (this.Xml != null)
                    hashCode = hashCode * 59 + this.Xml.GetHashCode();
                if (this.Parquet != null)
                    hashCode = hashCode * 59 + this.Parquet.GetHashCode();
                return hashCode;
            }
        }

    }
}
