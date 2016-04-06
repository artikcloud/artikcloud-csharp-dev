using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CLOUD.Artik.Model
{
    /// <summary>
    /// Export Status Response.
    /// </summary>
    [DataContract]
    public partial class ExportStatusResponse :  IEquatable<ExportStatusResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportStatusResponse" /> class.
        /// Initializes a new instance of the <see cref="ExportStatusResponse" />class.
        /// </summary>
        /// <param name="ExpirationDate">ExpirationDate.</param>
        /// <param name="ExportId">ExportId.</param>
        /// <param name="Md5">Md5.</param>
        /// <param name="Status">Export status.</param>
        /// <param name="Ttl">Ttl.</param>

        public ExportStatusResponse(long? ExpirationDate = null, string ExportId = null, string Md5 = null, string Status = null, string Ttl = null)
        {
            this.ExpirationDate = ExpirationDate;
            this.ExportId = ExportId;
            this.Md5 = Md5;
            this.Status = Status;
            this.Ttl = Ttl;
            
        }
        
    
        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public long? ExpirationDate { get; set; }
    
        /// <summary>
        /// Gets or Sets ExportId
        /// </summary>
        [DataMember(Name="exportId", EmitDefaultValue=false)]
        public string ExportId { get; set; }
    
        /// <summary>
        /// Gets or Sets Md5
        /// </summary>
        [DataMember(Name="md5", EmitDefaultValue=false)]
        public string Md5 { get; set; }
    
        /// <summary>
        /// Export status
        /// </summary>
        /// <value>Export status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or Sets Ttl
        /// </summary>
        [DataMember(Name="ttl", EmitDefaultValue=false)]
        public string Ttl { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportStatusResponse {\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  ExportId: ").Append(ExportId).Append("\n");
            sb.Append("  Md5: ").Append(Md5).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ExportStatusResponse);
        }

        /// <summary>
        /// Returns true if ExportStatusResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ExportStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportStatusResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ExpirationDate == other.ExpirationDate ||
                    this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(other.ExpirationDate)
                ) && 
                (
                    this.ExportId == other.ExportId ||
                    this.ExportId != null &&
                    this.ExportId.Equals(other.ExportId)
                ) && 
                (
                    this.Md5 == other.Md5 ||
                    this.Md5 != null &&
                    this.Md5.Equals(other.Md5)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Ttl == other.Ttl ||
                    this.Ttl != null &&
                    this.Ttl.Equals(other.Ttl)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.ExpirationDate != null)
                    hash = hash * 59 + this.ExpirationDate.GetHashCode();
                
                if (this.ExportId != null)
                    hash = hash * 59 + this.ExportId.GetHashCode();
                
                if (this.Md5 != null)
                    hash = hash * 59 + this.Md5.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Ttl != null)
                    hash = hash * 59 + this.Ttl.GetHashCode();
                
                return hash;
            }
        }

    }
}
