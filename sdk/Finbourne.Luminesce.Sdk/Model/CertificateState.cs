/*
 * FINBOURNE Luminesce Web API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.16.301
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
    /// Information held about the minting / revoking of a certificate.  It does *not* contain the certificate itself
    /// </summary>
    [DataContract(Name = "CertificateState")]
    public partial class CertificateState : IEquatable<CertificateState>
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public CertificateType? Type { get; set; }

        /// <summary>
        /// Gets or Sets CreationStatus
        /// </summary>
        [DataMember(Name = "creationStatus", EmitDefaultValue = false)]
        public CertificateStatus? CreationStatus { get; set; }

        /// <summary>
        /// Gets or Sets RevocationStatus
        /// </summary>
        [DataMember(Name = "revocationStatus", EmitDefaultValue = false)]
        public CertificateStatus? RevocationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateState" /> class.
        /// </summary>
        /// <param name="key">The \&quot;key\&quot; to which this belongs in the dictionary,  basically the CN without any version information.</param>
        /// <param name="version">The version of this certificate.</param>
        /// <param name="commonName">The common Name of the Certificate.</param>
        /// <param name="type">type.</param>
        /// <param name="creationStatus">creationStatus.</param>
        /// <param name="revocationStatus">revocationStatus.</param>
        /// <param name="validityStart">The earliest point at which a certificate can be used.</param>
        /// <param name="validityEnd">The latest point at which a certificate can be used.</param>
        /// <param name="revokedAt">The point at which this was revoked, if any.</param>
        /// <param name="revokedBy">The user which revoked this, if any.</param>
        /// <param name="createdAt">The point at which this was created.</param>
        /// <param name="createdBy">The user which created this.</param>
        /// <param name="serialNumber">The Vault-issued serial number of the certificate, if any - used for revocation.</param>
        /// <param name="links">The location within Configuration Store that this is saved to.</param>
        public CertificateState(string key = default(string), int version = default(int), string commonName = default(string), CertificateType? type = default(CertificateType?), CertificateStatus? creationStatus = default(CertificateStatus?), CertificateStatus? revocationStatus = default(CertificateStatus?), DateTimeOffset? validityStart = default(DateTimeOffset?), DateTimeOffset? validityEnd = default(DateTimeOffset?), DateTimeOffset? revokedAt = default(DateTimeOffset?), string revokedBy = default(string), DateTimeOffset? createdAt = default(DateTimeOffset?), string createdBy = default(string), string serialNumber = default(string), List<Link> links = default(List<Link>))
        {
            this.Key = key;
            this.Version = version;
            this.CommonName = commonName;
            this.Type = type;
            this.CreationStatus = creationStatus;
            this.RevocationStatus = revocationStatus;
            this.ValidityStart = validityStart;
            this.ValidityEnd = validityEnd;
            this.RevokedAt = revokedAt;
            this.RevokedBy = revokedBy;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.SerialNumber = serialNumber;
            this.Links = links;
        }

        /// <summary>
        /// The \&quot;key\&quot; to which this belongs in the dictionary,  basically the CN without any version information
        /// </summary>
        /// <value>The \&quot;key\&quot; to which this belongs in the dictionary,  basically the CN without any version information</value>
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The version of this certificate
        /// </summary>
        /// <value>The version of this certificate</value>
        [DataMember(Name = "version", EmitDefaultValue = true)]
        public int Version { get; set; }

        /// <summary>
        /// The common Name of the Certificate
        /// </summary>
        /// <value>The common Name of the Certificate</value>
        [DataMember(Name = "commonName", EmitDefaultValue = true)]
        public string CommonName { get; set; }

        /// <summary>
        /// The earliest point at which a certificate can be used
        /// </summary>
        /// <value>The earliest point at which a certificate can be used</value>
        [DataMember(Name = "validityStart", EmitDefaultValue = true)]
        public DateTimeOffset? ValidityStart { get; set; }

        /// <summary>
        /// The latest point at which a certificate can be used
        /// </summary>
        /// <value>The latest point at which a certificate can be used</value>
        [DataMember(Name = "validityEnd", EmitDefaultValue = true)]
        public DateTimeOffset? ValidityEnd { get; set; }

        /// <summary>
        /// The point at which this was revoked, if any
        /// </summary>
        /// <value>The point at which this was revoked, if any</value>
        [DataMember(Name = "revokedAt", EmitDefaultValue = true)]
        public DateTimeOffset? RevokedAt { get; set; }

        /// <summary>
        /// The user which revoked this, if any
        /// </summary>
        /// <value>The user which revoked this, if any</value>
        [DataMember(Name = "revokedBy", EmitDefaultValue = true)]
        public string RevokedBy { get; set; }

        /// <summary>
        /// The point at which this was created
        /// </summary>
        /// <value>The point at which this was created</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = true)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The user which created this
        /// </summary>
        /// <value>The user which created this</value>
        [DataMember(Name = "createdBy", EmitDefaultValue = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// The Vault-issued serial number of the certificate, if any - used for revocation
        /// </summary>
        /// <value>The Vault-issued serial number of the certificate, if any - used for revocation</value>
        [DataMember(Name = "serialNumber", EmitDefaultValue = true)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// The location within Configuration Store that this is saved to
        /// </summary>
        /// <value>The location within Configuration Store that this is saved to</value>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CertificateState {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  CommonName: ").Append(CommonName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CreationStatus: ").Append(CreationStatus).Append("\n");
            sb.Append("  RevocationStatus: ").Append(RevocationStatus).Append("\n");
            sb.Append("  ValidityStart: ").Append(ValidityStart).Append("\n");
            sb.Append("  ValidityEnd: ").Append(ValidityEnd).Append("\n");
            sb.Append("  RevokedAt: ").Append(RevokedAt).Append("\n");
            sb.Append("  RevokedBy: ").Append(RevokedBy).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as CertificateState);
        }

        /// <summary>
        /// Returns true if CertificateState instances are equal
        /// </summary>
        /// <param name="input">Instance of CertificateState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CertificateState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Version == input.Version ||
                    this.Version.Equals(input.Version)
                ) && 
                (
                    this.CommonName == input.CommonName ||
                    (this.CommonName != null &&
                    this.CommonName.Equals(input.CommonName))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.CreationStatus == input.CreationStatus ||
                    this.CreationStatus.Equals(input.CreationStatus)
                ) && 
                (
                    this.RevocationStatus == input.RevocationStatus ||
                    this.RevocationStatus.Equals(input.RevocationStatus)
                ) && 
                (
                    this.ValidityStart == input.ValidityStart ||
                    (this.ValidityStart != null &&
                    this.ValidityStart.Equals(input.ValidityStart))
                ) && 
                (
                    this.ValidityEnd == input.ValidityEnd ||
                    (this.ValidityEnd != null &&
                    this.ValidityEnd.Equals(input.ValidityEnd))
                ) && 
                (
                    this.RevokedAt == input.RevokedAt ||
                    (this.RevokedAt != null &&
                    this.RevokedAt.Equals(input.RevokedAt))
                ) && 
                (
                    this.RevokedBy == input.RevokedBy ||
                    (this.RevokedBy != null &&
                    this.RevokedBy.Equals(input.RevokedBy))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.CommonName != null)
                    hashCode = hashCode * 59 + this.CommonName.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.CreationStatus.GetHashCode();
                hashCode = hashCode * 59 + this.RevocationStatus.GetHashCode();
                if (this.ValidityStart != null)
                    hashCode = hashCode * 59 + this.ValidityStart.GetHashCode();
                if (this.ValidityEnd != null)
                    hashCode = hashCode * 59 + this.ValidityEnd.GetHashCode();
                if (this.RevokedAt != null)
                    hashCode = hashCode * 59 + this.RevokedAt.GetHashCode();
                if (this.RevokedBy != null)
                    hashCode = hashCode * 59 + this.RevokedBy.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
