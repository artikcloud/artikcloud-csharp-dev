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
    /// 
    /// </summary>
    [DataContract]
    public partial class CheckTokenMessage :  IEquatable<CheckTokenMessage>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckTokenMessage" /> class.
        /// Initializes a new instance of the <see cref="CheckTokenMessage" />class.
        /// </summary>
        /// <param name="Message">Message.</param>

        public CheckTokenMessage(string Message = null)
        {
            this.Message = Message;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckTokenMessage {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            
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
            return this.Equals(obj as CheckTokenMessage);
        }

        /// <summary>
        /// Returns true if CheckTokenMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of CheckTokenMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckTokenMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
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
                
                return hash;
            }
        }

    }
}
