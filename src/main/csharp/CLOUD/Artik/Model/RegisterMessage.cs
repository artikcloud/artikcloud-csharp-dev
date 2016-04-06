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
    /// WebSocket Registration Message
    /// </summary>
    [DataContract]
    public partial class RegisterMessage :  IEquatable<RegisterMessage>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterMessage" /> class.
        /// Initializes a new instance of the <see cref="RegisterMessage" />class.
        /// </summary>
        /// <param name="Cid">Confirmation ID..</param>
        /// <param name="Authorization">Authorization header containing access token (Bearer &lt;access_token&gt;)..</param>
        /// <param name="Sdid">Source Device ID..</param>
        /// <param name="Ts">Timestamp (past, present or future). Defaults to current time if not provided..</param>
        /// <param name="Type">Type. (default to &quot;register&quot;).</param>

        public RegisterMessage(string Cid = null, string Authorization = null, string Sdid = null, long? Ts = null, string Type = null)
        {
            this.Cid = Cid;
            this.Authorization = Authorization;
            this.Sdid = Sdid;
            this.Ts = Ts;
            // use default value if no "Type" provided
            if (Type == null)
            {
                this.Type = "register";
            }
            else
            {
                this.Type = Type;
            }
            
        }
        
    
        /// <summary>
        /// Confirmation ID.
        /// </summary>
        /// <value>Confirmation ID.</value>
        [DataMember(Name="cid", EmitDefaultValue=false)]
        public string Cid { get; set; }
    
        /// <summary>
        /// Authorization header containing access token (Bearer &lt;access_token&gt;).
        /// </summary>
        /// <value>Authorization header containing access token (Bearer &lt;access_token&gt;).</value>
        [DataMember(Name="authorization", EmitDefaultValue=false)]
        public string Authorization { get; set; }
    
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
            sb.Append("class RegisterMessage {\n");
            sb.Append("  Cid: ").Append(Cid).Append("\n");
            sb.Append("  Authorization: ").Append(Authorization).Append("\n");
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
            return this.Equals(obj as RegisterMessage);
        }

        /// <summary>
        /// Returns true if RegisterMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of RegisterMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisterMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Cid == other.Cid ||
                    this.Cid != null &&
                    this.Cid.Equals(other.Cid)
                ) && 
                (
                    this.Authorization == other.Authorization ||
                    this.Authorization != null &&
                    this.Authorization.Equals(other.Authorization)
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
                
                if (this.Cid != null)
                    hash = hash * 59 + this.Cid.GetHashCode();
                
                if (this.Authorization != null)
                    hash = hash * 59 + this.Authorization.GetHashCode();
                
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
