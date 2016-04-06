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
    /// Aggregates Histogram Response
    /// </summary>
    [DataContract]
    public partial class AggregatesHistogramResponse :  IEquatable<AggregatesHistogramResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatesHistogramResponse" /> class.
        /// Initializes a new instance of the <see cref="AggregatesHistogramResponse" />class.
        /// </summary>
        /// <param name="Data">Data.</param>
        /// <param name="EndDate">EndDate.</param>
        /// <param name="Field">Field.</param>
        /// <param name="Interval">Interval.</param>
        /// <param name="Sdid">Sdid.</param>
        /// <param name="Size">Size.</param>
        /// <param name="StartDate">StartDate.</param>

        public AggregatesHistogramResponse(List<AggregatesHistogramData> Data = null, long? EndDate = null, string Field = null, string Interval = null, string Sdid = null, long? Size = null, long? StartDate = null)
        {
            this.Data = Data;
            this.EndDate = EndDate;
            this.Field = Field;
            this.Interval = Interval;
            this.Sdid = Sdid;
            this.Size = Size;
            this.StartDate = StartDate;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<AggregatesHistogramData> Data { get; set; }
    
        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public long? EndDate { get; set; }
    
        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public string Field { get; set; }
    
        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public string Interval { get; set; }
    
        /// <summary>
        /// Gets or Sets Sdid
        /// </summary>
        [DataMember(Name="sdid", EmitDefaultValue=false)]
        public string Sdid { get; set; }
    
        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }
    
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public long? StartDate { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregatesHistogramResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Sdid: ").Append(Sdid).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            
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
            return this.Equals(obj as AggregatesHistogramResponse);
        }

        /// <summary>
        /// Returns true if AggregatesHistogramResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AggregatesHistogramResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregatesHistogramResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
                ) && 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.Field == other.Field ||
                    this.Field != null &&
                    this.Field.Equals(other.Field)
                ) && 
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) && 
                (
                    this.Sdid == other.Sdid ||
                    this.Sdid != null &&
                    this.Sdid.Equals(other.Sdid)
                ) && 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
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
                
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                
                if (this.Field != null)
                    hash = hash * 59 + this.Field.GetHashCode();
                
                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();
                
                if (this.Sdid != null)
                    hash = hash * 59 + this.Sdid.GetHashCode();
                
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                
                return hash;
            }
        }

    }
}
