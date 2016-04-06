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
    /// Normalized Message
    /// </summary>
    [DataContract]
    public partial class NormalizedMessage :  IEquatable<NormalizedMessage>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NormalizedMessage" /> class.
        /// Initializes a new instance of the <see cref="NormalizedMessage" />class.
        /// </summary>
        /// <param name="Cts">Cts (required).</param>
        /// <param name="Ts">Ts (required).</param>
        /// <param name="Mid">Mid (required).</param>
        /// <param name="Sdid">Sdid (required).</param>
        /// <param name="Sdtid">Sdtid (required).</param>
        /// <param name="Uid">Uid (required).</param>
        /// <param name="Mv">Mv (required).</param>
        /// <param name="Data">Data (required).</param>

        public NormalizedMessage(long? Cts = null, long? Ts = null, string Mid = null, string Sdid = null, string Sdtid = null, string Uid = null, int? Mv = null, Dictionary<string, Object> Data = null)
        {
            // to ensure "Cts" is required (not null)
            if (Cts == null)
            {
                throw new InvalidDataException("Cts is a required property for NormalizedMessage and cannot be null");
            }
            else
            {
                this.Cts = Cts;
            }
            // to ensure "Ts" is required (not null)
            if (Ts == null)
            {
                throw new InvalidDataException("Ts is a required property for NormalizedMessage and cannot be null");
            }
            else
            {
                this.Ts = Ts;
            }
            // to ensure "Mid" is required (not null)
            if (Mid == null)
            {
                throw new InvalidDataException("Mid is a required property for NormalizedMessage and cannot be null");
            }
            else
            {
                this.Mid = Mid;
            }
            // to ensure "Sdid" is required (not null)
            if (Sdid == null)
            {
                throw new InvalidDataException("Sdid is a required property for NormalizedMessage and cannot be null");
            }
            else
            {
                this.Sdid = Sdid;
            }
            // to ensure "Sdtid" is required (not null)
            if (Sdtid == null)
            {
                throw new InvalidDataException("Sdtid is a required property for NormalizedMessage and cannot be null");
            }
            else
            {
                this.Sdtid = Sdtid;
            }
            // to ensure "Uid" is required (not null)
            if (Uid == null)
            {
                throw new InvalidDataException("Uid is a required property for NormalizedMessage and cannot be null");
            }
            else
            {
                this.Uid = Uid;
            }
            // to ensure "Mv" is required (not null)
            if (Mv == null)
            {
                throw new InvalidDataException("Mv is a required property for NormalizedMessage and cannot be null");
            }
            else
            {
                this.Mv = Mv;
            }
            // to ensure "Data" is required (not null)
            if (Data == null)
            {
                throw new InvalidDataException("Data is a required property for NormalizedMessage and cannot be null");
            }
            else
            {
                this.Data = Data;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Cts
        /// </summary>
        [DataMember(Name="cts", EmitDefaultValue=false)]
        public long? Cts { get; set; }
    
        /// <summary>
        /// Gets or Sets Ts
        /// </summary>
        [DataMember(Name="ts", EmitDefaultValue=false)]
        public long? Ts { get; set; }
    
        /// <summary>
        /// Gets or Sets Mid
        /// </summary>
        [DataMember(Name="mid", EmitDefaultValue=false)]
        public string Mid { get; set; }
    
        /// <summary>
        /// Gets or Sets Sdid
        /// </summary>
        [DataMember(Name="sdid", EmitDefaultValue=false)]
        public string Sdid { get; set; }
    
        /// <summary>
        /// Gets or Sets Sdtid
        /// </summary>
        [DataMember(Name="sdtid", EmitDefaultValue=false)]
        public string Sdtid { get; set; }
    
        /// <summary>
        /// Gets or Sets Uid
        /// </summary>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }
    
        /// <summary>
        /// Gets or Sets Mv
        /// </summary>
        [DataMember(Name="mv", EmitDefaultValue=false)]
        public int? Mv { get; set; }
    
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public Dictionary<string, Object> Data { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NormalizedMessage {\n");
            sb.Append("  Cts: ").Append(Cts).Append("\n");
            sb.Append("  Ts: ").Append(Ts).Append("\n");
            sb.Append("  Mid: ").Append(Mid).Append("\n");
            sb.Append("  Sdid: ").Append(Sdid).Append("\n");
            sb.Append("  Sdtid: ").Append(Sdtid).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  Mv: ").Append(Mv).Append("\n");
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
            return this.Equals(obj as NormalizedMessage);
        }

        /// <summary>
        /// Returns true if NormalizedMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of NormalizedMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NormalizedMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Cts == other.Cts ||
                    this.Cts != null &&
                    this.Cts.Equals(other.Cts)
                ) && 
                (
                    this.Ts == other.Ts ||
                    this.Ts != null &&
                    this.Ts.Equals(other.Ts)
                ) && 
                (
                    this.Mid == other.Mid ||
                    this.Mid != null &&
                    this.Mid.Equals(other.Mid)
                ) && 
                (
                    this.Sdid == other.Sdid ||
                    this.Sdid != null &&
                    this.Sdid.Equals(other.Sdid)
                ) && 
                (
                    this.Sdtid == other.Sdtid ||
                    this.Sdtid != null &&
                    this.Sdtid.Equals(other.Sdtid)
                ) && 
                (
                    this.Uid == other.Uid ||
                    this.Uid != null &&
                    this.Uid.Equals(other.Uid)
                ) && 
                (
                    this.Mv == other.Mv ||
                    this.Mv != null &&
                    this.Mv.Equals(other.Mv)
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
                
                if (this.Cts != null)
                    hash = hash * 59 + this.Cts.GetHashCode();
                
                if (this.Ts != null)
                    hash = hash * 59 + this.Ts.GetHashCode();
                
                if (this.Mid != null)
                    hash = hash * 59 + this.Mid.GetHashCode();
                
                if (this.Sdid != null)
                    hash = hash * 59 + this.Sdid.GetHashCode();
                
                if (this.Sdtid != null)
                    hash = hash * 59 + this.Sdtid.GetHashCode();
                
                if (this.Uid != null)
                    hash = hash * 59 + this.Uid.GetHashCode();
                
                if (this.Mv != null)
                    hash = hash * 59 + this.Mv.GetHashCode();
                
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                
                return hash;
            }
        }

    }
}
