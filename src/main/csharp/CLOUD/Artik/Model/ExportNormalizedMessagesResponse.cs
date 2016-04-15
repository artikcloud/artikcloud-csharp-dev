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
    /// Export Normalized Messages Response.
    /// </summary>
    [DataContract]
    public partial class ExportNormalizedMessagesResponse :  IEquatable<ExportNormalizedMessagesResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportNormalizedMessagesResponse" /> class.
        /// Initializes a new instance of the <see cref="ExportNormalizedMessagesResponse" />class.
        /// </summary>
        /// <param name="CsvHeaders">CsvHeaders.</param>
        /// <param name="EndDate">EndDate.</param>
        /// <param name="ExportId">ExportId.</param>
        /// <param name="Format">Format.</param>
        /// <param name="Order">Order.</param>
        /// <param name="Sdid">Sdid.</param>
        /// <param name="Sdids">Sdids.</param>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="Stdids">Stdids.</param>
        /// <param name="TrialId">TrialId.</param>
        /// <param name="Uid">Uid.</param>
        /// <param name="Uids">Uids.</param>
        /// <param name="Url">Url.</param>

        public ExportNormalizedMessagesResponse(bool? CsvHeaders = null, long? EndDate = null, string ExportId = null, string Format = null, string Order = null, string Sdid = null, string Sdids = null, long? StartDate = null, string Stdids = null, string TrialId = null, string Uid = null, string Uids = null, string Url = null)
        {
            this.CsvHeaders = CsvHeaders;
            this.EndDate = EndDate;
            this.ExportId = ExportId;
            this.Format = Format;
            this.Order = Order;
            this.Sdid = Sdid;
            this.Sdids = Sdids;
            this.StartDate = StartDate;
            this.Stdids = Stdids;
            this.TrialId = TrialId;
            this.Uid = Uid;
            this.Uids = Uids;
            this.Url = Url;
            
        }
        
    
        /// <summary>
        /// Gets or Sets CsvHeaders
        /// </summary>
        [DataMember(Name="csvHeaders", EmitDefaultValue=false)]
        public bool? CsvHeaders { get; set; }
    
        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public long? EndDate { get; set; }
    
        /// <summary>
        /// Gets or Sets ExportId
        /// </summary>
        [DataMember(Name="exportId", EmitDefaultValue=false)]
        public string ExportId { get; set; }
    
        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }
    
        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }
    
        /// <summary>
        /// Gets or Sets Sdid
        /// </summary>
        [DataMember(Name="sdid", EmitDefaultValue=false)]
        public string Sdid { get; set; }
    
        /// <summary>
        /// Gets or Sets Sdids
        /// </summary>
        [DataMember(Name="sdids", EmitDefaultValue=false)]
        public string Sdids { get; set; }
    
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public long? StartDate { get; set; }
    
        /// <summary>
        /// Gets or Sets Stdids
        /// </summary>
        [DataMember(Name="stdids", EmitDefaultValue=false)]
        public string Stdids { get; set; }
    
        /// <summary>
        /// Gets or Sets TrialId
        /// </summary>
        [DataMember(Name="trialId", EmitDefaultValue=false)]
        public string TrialId { get; set; }
    
        /// <summary>
        /// Gets or Sets Uid
        /// </summary>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }
    
        /// <summary>
        /// Gets or Sets Uids
        /// </summary>
        [DataMember(Name="uids", EmitDefaultValue=false)]
        public string Uids { get; set; }
    
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportNormalizedMessagesResponse {\n");
            sb.Append("  CsvHeaders: ").Append(CsvHeaders).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ExportId: ").Append(ExportId).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Sdid: ").Append(Sdid).Append("\n");
            sb.Append("  Sdids: ").Append(Sdids).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Stdids: ").Append(Stdids).Append("\n");
            sb.Append("  TrialId: ").Append(TrialId).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  Uids: ").Append(Uids).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            
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
            return this.Equals(obj as ExportNormalizedMessagesResponse);
        }

        /// <summary>
        /// Returns true if ExportNormalizedMessagesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ExportNormalizedMessagesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportNormalizedMessagesResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CsvHeaders == other.CsvHeaders ||
                    this.CsvHeaders != null &&
                    this.CsvHeaders.Equals(other.CsvHeaders)
                ) && 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.ExportId == other.ExportId ||
                    this.ExportId != null &&
                    this.ExportId.Equals(other.ExportId)
                ) && 
                (
                    this.Format == other.Format ||
                    this.Format != null &&
                    this.Format.Equals(other.Format)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) && 
                (
                    this.Sdid == other.Sdid ||
                    this.Sdid != null &&
                    this.Sdid.Equals(other.Sdid)
                ) && 
                (
                    this.Sdids == other.Sdids ||
                    this.Sdids != null &&
                    this.Sdids.Equals(other.Sdids)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.Stdids == other.Stdids ||
                    this.Stdids != null &&
                    this.Stdids.Equals(other.Stdids)
                ) && 
                (
                    this.TrialId == other.TrialId ||
                    this.TrialId != null &&
                    this.TrialId.Equals(other.TrialId)
                ) && 
                (
                    this.Uid == other.Uid ||
                    this.Uid != null &&
                    this.Uid.Equals(other.Uid)
                ) && 
                (
                    this.Uids == other.Uids ||
                    this.Uids != null &&
                    this.Uids.Equals(other.Uids)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
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
                
                if (this.CsvHeaders != null)
                    hash = hash * 59 + this.CsvHeaders.GetHashCode();
                
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                
                if (this.ExportId != null)
                    hash = hash * 59 + this.ExportId.GetHashCode();
                
                if (this.Format != null)
                    hash = hash * 59 + this.Format.GetHashCode();
                
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                
                if (this.Sdid != null)
                    hash = hash * 59 + this.Sdid.GetHashCode();
                
                if (this.Sdids != null)
                    hash = hash * 59 + this.Sdids.GetHashCode();
                
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                
                if (this.Stdids != null)
                    hash = hash * 59 + this.Stdids.GetHashCode();
                
                if (this.TrialId != null)
                    hash = hash * 59 + this.TrialId.GetHashCode();
                
                if (this.Uid != null)
                    hash = hash * 59 + this.Uid.GetHashCode();
                
                if (this.Uids != null)
                    hash = hash * 59 + this.Uids.GetHashCode();
                
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                
                return hash;
            }
        }

    }
}