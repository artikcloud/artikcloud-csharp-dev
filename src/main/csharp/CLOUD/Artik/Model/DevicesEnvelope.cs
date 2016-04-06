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
    /// Devices Envelope
    /// </summary>
    [DataContract]
    public partial class DevicesEnvelope :  IEquatable<DevicesEnvelope>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DevicesEnvelope" /> class.
        /// Initializes a new instance of the <see cref="DevicesEnvelope" />class.
        /// </summary>
        /// <param name="Total">Total (required).</param>
        /// <param name="Count">Count (required).</param>
        /// <param name="Offset">Offset (required).</param>
        /// <param name="Data">Data.</param>

        public DevicesEnvelope(int? Total = null, int? Count = null, int? Offset = null, DeviceArray Data = null)
        {
            // to ensure "Total" is required (not null)
            if (Total == null)
            {
                throw new InvalidDataException("Total is a required property for DevicesEnvelope and cannot be null");
            }
            else
            {
                this.Total = Total;
            }
            // to ensure "Count" is required (not null)
            if (Count == null)
            {
                throw new InvalidDataException("Count is a required property for DevicesEnvelope and cannot be null");
            }
            else
            {
                this.Count = Count;
            }
            // to ensure "Offset" is required (not null)
            if (Offset == null)
            {
                throw new InvalidDataException("Offset is a required property for DevicesEnvelope and cannot be null");
            }
            else
            {
                this.Offset = Offset;
            }
            this.Data = Data;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }
    
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
    
        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public int? Offset { get; set; }
    
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public DeviceArray Data { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DevicesEnvelope {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
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
            return this.Equals(obj as DevicesEnvelope);
        }

        /// <summary>
        /// Returns true if DevicesEnvelope instances are equal
        /// </summary>
        /// <param name="other">Instance of DevicesEnvelope to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DevicesEnvelope other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.Offset == other.Offset ||
                    this.Offset != null &&
                    this.Offset.Equals(other.Offset)
                ) && 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
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
                
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                
                if (this.Offset != null)
                    hash = hash * 59 + this.Offset.GetHashCode();
                
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                
                return hash;
            }
        }

    }
}
