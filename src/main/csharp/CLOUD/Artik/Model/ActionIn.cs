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
    /// Action sent to a WebSocket.
    /// </summary>
    [DataContract]
    public partial class ActionIn :  IEquatable<ActionIn>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionIn" /> class.
        /// Initializes a new instance of the <see cref="ActionIn" />class.
        /// </summary>
        /// <param name="Data">Data.</param>
        /// <param name="Cid">Confirmation ID..</param>
        /// <param name="Ddid">Destination Device ID..</param>
        /// <param name="Sdid">Source Device ID..</param>
        /// <param name="Ts">Timestamp (past, present or future). Defaults to current time if not provided..</param>
        /// <param name="Type">Type. (default to &quot;action&quot;).</param>

        public ActionIn(ActionDetailsArray Data = null, string Cid = null, string Ddid = null, string Sdid = null, long? Ts = null, string Type = null)
        {
            this.Data = Data;
            this.Cid = Cid;
            this.Ddid = Ddid;
            this.Sdid = Sdid;
            this.Ts = Ts;
            // use default value if no "Type" provided
            if (Type == null)
            {
                this.Type = "action";
            }
            else
            {
                this.Type = Type;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public ActionDetailsArray Data { get; set; }
    
        /// <summary>
        /// Confirmation ID.
        /// </summary>
        /// <value>Confirmation ID.</value>
        [DataMember(Name="cid", EmitDefaultValue=false)]
        public string Cid { get; set; }
    
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
            sb.Append("class ActionIn {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Cid: ").Append(Cid).Append("\n");
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
            return this.Equals(obj as ActionIn);
        }

        /// <summary>
        /// Returns true if ActionIn instances are equal
        /// </summary>
        /// <param name="other">Instance of ActionIn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionIn other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
                ) && 
                (
                    this.Cid == other.Cid ||
                    this.Cid != null &&
                    this.Cid.Equals(other.Cid)
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
                
                if (this.Cid != null)
                    hash = hash * 59 + this.Cid.GetHashCode();
                
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
