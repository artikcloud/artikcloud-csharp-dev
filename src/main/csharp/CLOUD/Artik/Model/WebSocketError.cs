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
    /// WebSocket Error Information
    /// </summary>
    [DataContract]
    public partial class WebSocketError :  IEquatable<WebSocketError>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebSocketError" /> class.
        /// Initializes a new instance of the <see cref="WebSocketError" />class.
        /// </summary>
        /// <param name="Message">Message..</param>
        /// <param name="Code">Code.</param>
        /// <param name="Cid">Confirmation ID.</param>

        public WebSocketError(string Message = null, int? Code = null, string Cid = null)
        {
            this.Message = Message;
            this.Code = Code;
            this.Cid = Cid;
            
        }
        
    
        /// <summary>
        /// Message.
        /// </summary>
        /// <value>Message.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
    
        /// <summary>
        /// Code
        /// </summary>
        /// <value>Code</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public int? Code { get; set; }
    
        /// <summary>
        /// Confirmation ID
        /// </summary>
        /// <value>Confirmation ID</value>
        [DataMember(Name="cid", EmitDefaultValue=false)]
        public string Cid { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebSocketError {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Cid: ").Append(Cid).Append("\n");
            
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
            return this.Equals(obj as WebSocketError);
        }

        /// <summary>
        /// Returns true if WebSocketError instances are equal
        /// </summary>
        /// <param name="other">Instance of WebSocketError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebSocketError other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Cid == other.Cid ||
                    this.Cid != null &&
                    this.Cid.Equals(other.Cid)
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
                
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                
                if (this.Cid != null)
                    hash = hash * 59 + this.Cid.GetHashCode();
                
                return hash;
            }
        }

    }
}
