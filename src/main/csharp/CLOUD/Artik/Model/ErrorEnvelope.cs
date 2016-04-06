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
    /// WebSocket Error Envelope
    /// </summary>
    [DataContract]
    public partial class ErrorEnvelope :  IEquatable<ErrorEnvelope>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorEnvelope" /> class.
        /// Initializes a new instance of the <see cref="ErrorEnvelope" />class.
        /// </summary>
        /// <param name="Error">Error Data.</param>

        public ErrorEnvelope(WebSocketError Error = null)
        {
            this.Error = Error;
            
        }
        
    
        /// <summary>
        /// Error Data
        /// </summary>
        /// <value>Error Data</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public WebSocketError Error { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorEnvelope {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            
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
            return this.Equals(obj as ErrorEnvelope);
        }

        /// <summary>
        /// Returns true if ErrorEnvelope instances are equal
        /// </summary>
        /// <param name="other">Instance of ErrorEnvelope to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorEnvelope other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
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
                
                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();
                
                return hash;
            }
        }

    }
}
