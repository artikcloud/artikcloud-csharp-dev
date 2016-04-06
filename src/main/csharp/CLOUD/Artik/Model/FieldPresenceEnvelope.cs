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
    /// Field Presence Envelope
    /// </summary>
    [DataContract]
    public partial class FieldPresenceEnvelope :  IEquatable<FieldPresenceEnvelope>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldPresenceEnvelope" /> class.
        /// Initializes a new instance of the <see cref="FieldPresenceEnvelope" />class.
        /// </summary>
        /// <param name="Sdid">Sdid (required).</param>
        /// <param name="FieldPresence">FieldPresence (required).</param>
        /// <param name="StartDate">StartDate (required).</param>
        /// <param name="EndDate">EndDate (required).</param>
        /// <param name="Interval">Interval (required).</param>
        /// <param name="Size">Size (required).</param>
        /// <param name="Data">Data (required).</param>

        public FieldPresenceEnvelope(string Sdid = null, string FieldPresence = null, long? StartDate = null, long? EndDate = null, string Interval = null, long? Size = null, List<FieldPresence> Data = null)
        {
            // to ensure "Sdid" is required (not null)
            if (Sdid == null)
            {
                throw new InvalidDataException("Sdid is a required property for FieldPresenceEnvelope and cannot be null");
            }
            else
            {
                this.Sdid = Sdid;
            }
            // to ensure "FieldPresence" is required (not null)
            if (FieldPresence == null)
            {
                throw new InvalidDataException("FieldPresence is a required property for FieldPresenceEnvelope and cannot be null");
            }
            else
            {
                this.FieldPresence = FieldPresence;
            }
            // to ensure "StartDate" is required (not null)
            if (StartDate == null)
            {
                throw new InvalidDataException("StartDate is a required property for FieldPresenceEnvelope and cannot be null");
            }
            else
            {
                this.StartDate = StartDate;
            }
            // to ensure "EndDate" is required (not null)
            if (EndDate == null)
            {
                throw new InvalidDataException("EndDate is a required property for FieldPresenceEnvelope and cannot be null");
            }
            else
            {
                this.EndDate = EndDate;
            }
            // to ensure "Interval" is required (not null)
            if (Interval == null)
            {
                throw new InvalidDataException("Interval is a required property for FieldPresenceEnvelope and cannot be null");
            }
            else
            {
                this.Interval = Interval;
            }
            // to ensure "Size" is required (not null)
            if (Size == null)
            {
                throw new InvalidDataException("Size is a required property for FieldPresenceEnvelope and cannot be null");
            }
            else
            {
                this.Size = Size;
            }
            // to ensure "Data" is required (not null)
            if (Data == null)
            {
                throw new InvalidDataException("Data is a required property for FieldPresenceEnvelope and cannot be null");
            }
            else
            {
                this.Data = Data;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Sdid
        /// </summary>
        [DataMember(Name="sdid", EmitDefaultValue=false)]
        public string Sdid { get; set; }
    
        /// <summary>
        /// Gets or Sets FieldPresence
        /// </summary>
        [DataMember(Name="fieldPresence", EmitDefaultValue=false)]
        public string FieldPresence { get; set; }
    
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public long? StartDate { get; set; }
    
        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public long? EndDate { get; set; }
    
        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public string Interval { get; set; }
    
        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }
    
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<FieldPresence> Data { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldPresenceEnvelope {\n");
            sb.Append("  Sdid: ").Append(Sdid).Append("\n");
            sb.Append("  FieldPresence: ").Append(FieldPresence).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            
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
            return this.Equals(obj as FieldPresenceEnvelope);
        }

        /// <summary>
        /// Returns true if FieldPresenceEnvelope instances are equal
        /// </summary>
        /// <param name="other">Instance of FieldPresenceEnvelope to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldPresenceEnvelope other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Sdid == other.Sdid ||
                    this.Sdid != null &&
                    this.Sdid.Equals(other.Sdid)
                ) && 
                (
                    this.FieldPresence == other.FieldPresence ||
                    this.FieldPresence != null &&
                    this.FieldPresence.Equals(other.FieldPresence)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) && 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) && 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
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
                
                if (this.Sdid != null)
                    hash = hash * 59 + this.Sdid.GetHashCode();
                
                if (this.FieldPresence != null)
                    hash = hash * 59 + this.FieldPresence.GetHashCode();
                
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                
                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();
                
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                
                return hash;
            }
        }

    }
}
