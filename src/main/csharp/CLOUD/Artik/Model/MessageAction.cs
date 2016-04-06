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
    /// Message or Action Information.
    /// </summary>
    [DataContract]
    public partial class MessageAction :  IEquatable<MessageAction>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageAction" /> class.
        /// Initializes a new instance of the <see cref="MessageAction" />class.
        /// </summary>
        /// <param name="Data">Data.</param>
        /// <param name="Ddid">Destination Device ID..</param>
        /// <param name="Sdid">Source Device ID..</param>
        /// <param name="Ts">Timestamp (past, present or future). Defaults to current time if not provided..</param>
        /// <param name="Type">Type..</param>

        public MessageAction(Dictionary<string, Object> Data = null, string Ddid = null, string Sdid = null, long? Ts = null, string Type = null)
        {
            this.Data = Data;
            this.Ddid = Ddid;
            this.Sdid = Sdid;
            this.Ts = Ts;
            this.Type = Type;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public Dictionary<string, Object> Data { get; set; }
    
        /// <summary>
        /// Destination Device ID.
        /// </summary>
        /// <value>Destination Device ID.</value>
        [DataMember(Name="ddid", EmitDefaultValue=false)]
        public string Ddid { get; set; }
    
        /// <summary>
        /// Source Device ID.
        /// </summary>
        /// <value>Source Device ID.</value>
        [DataMember(Name="sdid", EmitDefaultValue=false)]
        public string Sdid { get; set; }
    
        /// <summary>
        /// Timestamp (past, present or future). Defaults to current time if not provided.
        /// </summary>
        /// <value>Timestamp (past, present or future). Defaults to current time if not provided.</value>
        [DataMember(Name="ts", EmitDefaultValue=false)]
        public long? Ts { get; set; }
    
        /// <summary>
        /// Type.
        /// </summary>
        /// <value>Type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageAction {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Ddid: ").Append(Ddid).Append("\n");
            sb.Append("  Sdid: ").Append(Sdid).Append("\n");
            sb.Append("  Ts: ").Append(Ts).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            
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
            return this.Equals(obj as MessageAction);
        }

        /// <summary>
        /// Returns true if MessageAction instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageAction other)
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
                    this.Ddid == other.Ddid ||
                    this.Ddid != null &&
                    this.Ddid.Equals(other.Ddid)
                ) && 
                (
                    this.Sdid == other.Sdid ||
                    this.Sdid != null &&
                    this.Sdid.Equals(other.Sdid)
                ) && 
                (
                    this.Ts == other.Ts ||
                    this.Ts != null &&
                    this.Ts.Equals(other.Ts)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                
                if (this.Ddid != null)
                    hash = hash * 59 + this.Ddid.GetHashCode();
                
                if (this.Sdid != null)
                    hash = hash * 59 + this.Sdid.GetHashCode();
                
                if (this.Ts != null)
                    hash = hash * 59 + this.Ts.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                return hash;
            }
        }

    }
}
