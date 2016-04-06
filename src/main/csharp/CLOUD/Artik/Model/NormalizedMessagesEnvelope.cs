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
    /// Normalized Messages Envelope
    /// </summary>
    [DataContract]
    public partial class NormalizedMessagesEnvelope :  IEquatable<NormalizedMessagesEnvelope>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NormalizedMessagesEnvelope" /> class.
        /// Initializes a new instance of the <see cref="NormalizedMessagesEnvelope" />class.
        /// </summary>
        /// <param name="Sdids">Sdids.</param>
        /// <param name="Sdid">Sdid.</param>
        /// <param name="Uid">Uid.</param>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="EndDate">EndDate.</param>
        /// <param name="Order">Order.</param>
        /// <param name="Next">Next.</param>
        /// <param name="Count">Count (required).</param>
        /// <param name="Size">Size (required).</param>
        /// <param name="Data">Data (required).</param>

        public NormalizedMessagesEnvelope(string Sdids = null, string Sdid = null, string Uid = null, long? StartDate = null, long? EndDate = null, string Order = null, string Next = null, long? Count = null, long? Size = null, List<NormalizedMessage> Data = null)
        {
            // to ensure "Count" is required (not null)
            if (Count == null)
            {
                throw new InvalidDataException("Count is a required property for NormalizedMessagesEnvelope and cannot be null");
            }
            else
            {
                this.Count = Count;
            }
            // to ensure "Size" is required (not null)
            if (Size == null)
            {
                throw new InvalidDataException("Size is a required property for NormalizedMessagesEnvelope and cannot be null");
            }
            else
            {
                this.Size = Size;
            }
            // to ensure "Data" is required (not null)
            if (Data == null)
            {
                throw new InvalidDataException("Data is a required property for NormalizedMessagesEnvelope and cannot be null");
            }
            else
            {
                this.Data = Data;
            }
            this.Sdids = Sdids;
            this.Sdid = Sdid;
            this.Uid = Uid;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Order = Order;
            this.Next = Next;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Sdids
        /// </summary>
        [DataMember(Name="sdids", EmitDefaultValue=false)]
        public string Sdids { get; set; }
    
        /// <summary>
        /// Gets or Sets Sdid
        /// </summary>
        [DataMember(Name="sdid", EmitDefaultValue=false)]
        public string Sdid { get; set; }
    
        /// <summary>
        /// Gets or Sets Uid
        /// </summary>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }
    
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
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }
    
        /// <summary>
        /// Gets or Sets Next
        /// </summary>
        [DataMember(Name="next", EmitDefaultValue=false)]
        public string Next { get; set; }
    
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }
    
        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }
    
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<NormalizedMessage> Data { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NormalizedMessagesEnvelope {\n");
            sb.Append("  Sdids: ").Append(Sdids).Append("\n");
            sb.Append("  Sdid: ").Append(Sdid).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(obj as NormalizedMessagesEnvelope);
        }

        /// <summary>
        /// Returns true if NormalizedMessagesEnvelope instances are equal
        /// </summary>
        /// <param name="other">Instance of NormalizedMessagesEnvelope to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NormalizedMessagesEnvelope other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Sdids == other.Sdids ||
                    this.Sdids != null &&
                    this.Sdids.Equals(other.Sdids)
                ) && 
                (
                    this.Sdid == other.Sdid ||
                    this.Sdid != null &&
                    this.Sdid.Equals(other.Sdid)
                ) && 
                (
                    this.Uid == other.Uid ||
                    this.Uid != null &&
                    this.Uid.Equals(other.Uid)
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
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) && 
                (
                    this.Next == other.Next ||
                    this.Next != null &&
                    this.Next.Equals(other.Next)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
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
                
                if (this.Sdids != null)
                    hash = hash * 59 + this.Sdids.GetHashCode();
                
                if (this.Sdid != null)
                    hash = hash * 59 + this.Sdid.GetHashCode();
                
                if (this.Uid != null)
                    hash = hash * 59 + this.Uid.GetHashCode();
                
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                
                if (this.Next != null)
                    hash = hash * 59 + this.Next.GetHashCode();
                
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                
                return hash;
            }
        }

    }
}
