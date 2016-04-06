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
    /// Aggregates Histogram Data
    /// </summary>
    [DataContract]
    public partial class AggregatesHistogramData :  IEquatable<AggregatesHistogramData>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatesHistogramData" /> class.
        /// Initializes a new instance of the <see cref="AggregatesHistogramData" />class.
        /// </summary>
        /// <param name="Count">Count.</param>
        /// <param name="Max">Max.</param>
        /// <param name="Mean">Mean.</param>
        /// <param name="Min">Min.</param>
        /// <param name="Sum">Sum.</param>
        /// <param name="Ts">Ts.</param>
        /// <param name="Variance">Variance.</param>

        public AggregatesHistogramData(long? Count = null, float? Max = null, float? Mean = null, float? Min = null, float? Sum = null, long? Ts = null, float? Variance = null)
        {
            this.Count = Count;
            this.Max = Max;
            this.Mean = Mean;
            this.Min = Min;
            this.Sum = Sum;
            this.Ts = Ts;
            this.Variance = Variance;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }
    
        /// <summary>
        /// Gets or Sets Max
        /// </summary>
        [DataMember(Name="max", EmitDefaultValue=false)]
        public float? Max { get; set; }
    
        /// <summary>
        /// Gets or Sets Mean
        /// </summary>
        [DataMember(Name="mean", EmitDefaultValue=false)]
        public float? Mean { get; set; }
    
        /// <summary>
        /// Gets or Sets Min
        /// </summary>
        [DataMember(Name="min", EmitDefaultValue=false)]
        public float? Min { get; set; }
    
        /// <summary>
        /// Gets or Sets Sum
        /// </summary>
        [DataMember(Name="sum", EmitDefaultValue=false)]
        public float? Sum { get; set; }
    
        /// <summary>
        /// Gets or Sets Ts
        /// </summary>
        [DataMember(Name="ts", EmitDefaultValue=false)]
        public long? Ts { get; set; }
    
        /// <summary>
        /// Gets or Sets Variance
        /// </summary>
        [DataMember(Name="variance", EmitDefaultValue=false)]
        public float? Variance { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregatesHistogramData {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Mean: ").Append(Mean).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Sum: ").Append(Sum).Append("\n");
            sb.Append("  Ts: ").Append(Ts).Append("\n");
            sb.Append("  Variance: ").Append(Variance).Append("\n");
            
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
            return this.Equals(obj as AggregatesHistogramData);
        }

        /// <summary>
        /// Returns true if AggregatesHistogramData instances are equal
        /// </summary>
        /// <param name="other">Instance of AggregatesHistogramData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregatesHistogramData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.Max == other.Max ||
                    this.Max != null &&
                    this.Max.Equals(other.Max)
                ) && 
                (
                    this.Mean == other.Mean ||
                    this.Mean != null &&
                    this.Mean.Equals(other.Mean)
                ) && 
                (
                    this.Min == other.Min ||
                    this.Min != null &&
                    this.Min.Equals(other.Min)
                ) && 
                (
                    this.Sum == other.Sum ||
                    this.Sum != null &&
                    this.Sum.Equals(other.Sum)
                ) && 
                (
                    this.Ts == other.Ts ||
                    this.Ts != null &&
                    this.Ts.Equals(other.Ts)
                ) && 
                (
                    this.Variance == other.Variance ||
                    this.Variance != null &&
                    this.Variance.Equals(other.Variance)
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
                
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                
                if (this.Max != null)
                    hash = hash * 59 + this.Max.GetHashCode();
                
                if (this.Mean != null)
                    hash = hash * 59 + this.Mean.GetHashCode();
                
                if (this.Min != null)
                    hash = hash * 59 + this.Min.GetHashCode();
                
                if (this.Sum != null)
                    hash = hash * 59 + this.Sum.GetHashCode();
                
                if (this.Ts != null)
                    hash = hash * 59 + this.Ts.GetHashCode();
                
                if (this.Variance != null)
                    hash = hash * 59 + this.Variance.GetHashCode();
                
                return hash;
            }
        }

    }
}
