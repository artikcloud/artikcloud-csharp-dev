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
    /// Export Request Data.
    /// </summary>
    [DataContract]
    public partial class ExportRequestData :  IEquatable<ExportRequestData>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportRequestData" /> class.
        /// Initializes a new instance of the <see cref="ExportRequestData" />class.
        /// </summary>
        /// <param name="CsvHeaders">Add header to csv format.</param>
        /// <param name="EndDate">Timestamp of latest message (in milliseconds since epoch)..</param>
        /// <param name="ExportId">Returned Export ID that should be used to check status and get the export result..</param>
        /// <param name="Format">Format of the export..</param>
        /// <param name="Order">Ascending or descending sort order..</param>
        /// <param name="Sdids">Source Device IDs being searched for messages (Comma-separated for multiple Device IDs)..</param>
        /// <param name="Sdtids">Source Device Type IDs being searched for messages (Comma-separated for multiple Device Type IDs)..</param>
        /// <param name="StartDate">Timestamp of earliest message (in milliseconds since epoch)..</param>
        /// <param name="TrialId">Trial ID being searched for messages..</param>
        /// <param name="Uids">Owner&#39;s user IDs being searched for messages (Comma-separated for multiple User IDs)..</param>
        /// <param name="Url">URL added to successful email message..</param>

        public ExportRequestData(bool? CsvHeaders = null, long? EndDate = null, string ExportId = null, string Format = null, string Order = null, string Sdids = null, string Sdtids = null, long? StartDate = null, string TrialId = null, string Uids = null, string Url = null)
        {
            this.CsvHeaders = CsvHeaders;
            this.EndDate = EndDate;
            this.ExportId = ExportId;
            this.Format = Format;
            this.Order = Order;
            this.Sdids = Sdids;
            this.Sdtids = Sdtids;
            this.StartDate = StartDate;
            this.TrialId = TrialId;
            this.Uids = Uids;
            this.Url = Url;
            
        }
        
    
        /// <summary>
        /// Add header to csv format
        /// </summary>
        /// <value>Add header to csv format</value>
        [DataMember(Name="csvHeaders", EmitDefaultValue=false)]
        public bool? CsvHeaders { get; set; }
    
        /// <summary>
        /// Timestamp of latest message (in milliseconds since epoch).
        /// </summary>
        /// <value>Timestamp of latest message (in milliseconds since epoch).</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public long? EndDate { get; set; }
    
        /// <summary>
        /// Returned Export ID that should be used to check status and get the export result.
        /// </summary>
        /// <value>Returned Export ID that should be used to check status and get the export result.</value>
        [DataMember(Name="exportId", EmitDefaultValue=false)]
        public string ExportId { get; set; }
    
        /// <summary>
        /// Format of the export.
        /// </summary>
        /// <value>Format of the export.</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }
    
        /// <summary>
        /// Ascending or descending sort order.
        /// </summary>
        /// <value>Ascending or descending sort order.</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }
    
        /// <summary>
        /// Source Device IDs being searched for messages (Comma-separated for multiple Device IDs).
        /// </summary>
        /// <value>Source Device IDs being searched for messages (Comma-separated for multiple Device IDs).</value>
        [DataMember(Name="sdids", EmitDefaultValue=false)]
        public string Sdids { get; set; }
    
        /// <summary>
        /// Source Device Type IDs being searched for messages (Comma-separated for multiple Device Type IDs).
        /// </summary>
        /// <value>Source Device Type IDs being searched for messages (Comma-separated for multiple Device Type IDs).</value>
        [DataMember(Name="sdtids", EmitDefaultValue=false)]
        public string Sdtids { get; set; }
    
        /// <summary>
        /// Timestamp of earliest message (in milliseconds since epoch).
        /// </summary>
        /// <value>Timestamp of earliest message (in milliseconds since epoch).</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public long? StartDate { get; set; }
    
        /// <summary>
        /// Trial ID being searched for messages.
        /// </summary>
        /// <value>Trial ID being searched for messages.</value>
        [DataMember(Name="trialId", EmitDefaultValue=false)]
        public string TrialId { get; set; }
    
        /// <summary>
        /// Owner&#39;s user IDs being searched for messages (Comma-separated for multiple User IDs).
        /// </summary>
        /// <value>Owner&#39;s user IDs being searched for messages (Comma-separated for multiple User IDs).</value>
        [DataMember(Name="uids", EmitDefaultValue=false)]
        public string Uids { get; set; }
    
        /// <summary>
        /// URL added to successful email message.
        /// </summary>
        /// <value>URL added to successful email message.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportRequestData {\n");
            sb.Append("  CsvHeaders: ").Append(CsvHeaders).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ExportId: ").Append(ExportId).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Sdids: ").Append(Sdids).Append("\n");
            sb.Append("  Sdtids: ").Append(Sdtids).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  TrialId: ").Append(TrialId).Append("\n");
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
            return this.Equals(obj as ExportRequestData);
        }

        /// <summary>
        /// Returns true if ExportRequestData instances are equal
        /// </summary>
        /// <param name="other">Instance of ExportRequestData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportRequestData other)
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
                    this.Sdids == other.Sdids ||
                    this.Sdids != null &&
                    this.Sdids.Equals(other.Sdids)
                ) && 
                (
                    this.Sdtids == other.Sdtids ||
                    this.Sdtids != null &&
                    this.Sdtids.Equals(other.Sdtids)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.TrialId == other.TrialId ||
                    this.TrialId != null &&
                    this.TrialId.Equals(other.TrialId)
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
                
                if (this.Sdids != null)
                    hash = hash * 59 + this.Sdids.GetHashCode();
                
                if (this.Sdtids != null)
                    hash = hash * 59 + this.Sdtids.GetHashCode();
                
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                
                if (this.TrialId != null)
                    hash = hash * 59 + this.TrialId.GetHashCode();
                
                if (this.Uids != null)
                    hash = hash * 59 + this.Uids.GetHashCode();
                
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                
                return hash;
            }
        }

    }
}
