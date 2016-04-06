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
    /// Action received in a WebSocket.
    /// </summary>
    [DataContract]
    public partial class ActionOut :  IEquatable<ActionOut>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionOut" /> class.
        /// Initializes a new instance of the <see cref="ActionOut" />class.
        /// </summary>
        /// <param name="Mid">Message ID..</param>
        /// <param name="Uid">User ID..</param>
        /// <param name="Sdtid">Source Device Type ID..</param>
        /// <param name="Cts">Created Timestamp (past, present or future). Defaults to current time if not provided..</param>
        /// <param name="Mv">Manifest Version..</param>

        public ActionOut(string Mid = null, string Uid = null, string Sdtid = null, long? Cts = null, int? Mv = null)
        {
            this.Mid = Mid;
            this.Uid = Uid;
            this.Sdtid = Sdtid;
            this.Cts = Cts;
            this.Mv = Mv;
            
        }
        
    
        /// <summary>
        /// Message ID.
        /// </summary>
        /// <value>Message ID.</value>
        [DataMember(Name="mid", EmitDefaultValue=false)]
        public string Mid { get; set; }
    
        /// <summary>
        /// User ID.
        /// </summary>
        /// <value>User ID.</value>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }
    
        /// <summary>
        /// Source Device Type ID.
        /// </summary>
        /// <value>Source Device Type ID.</value>
        [DataMember(Name="sdtid", EmitDefaultValue=false)]
        public string Sdtid { get; set; }
    
        /// <summary>
        /// Created Timestamp (past, present or future). Defaults to current time if not provided.
        /// </summary>
        /// <value>Created Timestamp (past, present or future). Defaults to current time if not provided.</value>
        [DataMember(Name="cts", EmitDefaultValue=false)]
        public long? Cts { get; set; }
    
        /// <summary>
        /// Manifest Version.
        /// </summary>
        /// <value>Manifest Version.</value>
        [DataMember(Name="mv", EmitDefaultValue=false)]
        public int? Mv { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionOut {\n");
            sb.Append("  Mid: ").Append(Mid).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  Sdtid: ").Append(Sdtid).Append("\n");
            sb.Append("  Cts: ").Append(Cts).Append("\n");
            sb.Append("  Mv: ").Append(Mv).Append("\n");
            
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
            return this.Equals(obj as ActionOut);
        }

        /// <summary>
        /// Returns true if ActionOut instances are equal
        /// </summary>
        /// <param name="other">Instance of ActionOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionOut other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Mid == other.Mid ||
                    this.Mid != null &&
                    this.Mid.Equals(other.Mid)
                ) && 
                (
                    this.Uid == other.Uid ||
                    this.Uid != null &&
                    this.Uid.Equals(other.Uid)
                ) && 
                (
                    this.Sdtid == other.Sdtid ||
                    this.Sdtid != null &&
                    this.Sdtid.Equals(other.Sdtid)
                ) && 
                (
                    this.Cts == other.Cts ||
                    this.Cts != null &&
                    this.Cts.Equals(other.Cts)
                ) && 
                (
                    this.Mv == other.Mv ||
                    this.Mv != null &&
                    this.Mv.Equals(other.Mv)
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
                
                if (this.Mid != null)
                    hash = hash * 59 + this.Mid.GetHashCode();
                
                if (this.Uid != null)
                    hash = hash * 59 + this.Uid.GetHashCode();
                
                if (this.Sdtid != null)
                    hash = hash * 59 + this.Sdtid.GetHashCode();
                
                if (this.Cts != null)
                    hash = hash * 59 + this.Cts.GetHashCode();
                
                if (this.Mv != null)
                    hash = hash * 59 + this.Mv.GetHashCode();
                
                return hash;
            }
        }

    }
}
