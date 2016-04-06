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
    /// Mesage ID.
    /// </summary>
    [DataContract]
    public partial class MessageID :  IEquatable<MessageID>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageID" /> class.
        /// Initializes a new instance of the <see cref="MessageID" />class.
        /// </summary>
        /// <param name="Mid">Message ID..</param>

        public MessageID(string Mid = null)
        {
            this.Mid = Mid;
            
        }
        
    
        /// <summary>
        /// Message ID.
        /// </summary>
        /// <value>Message ID.</value>
        [DataMember(Name="mid", EmitDefaultValue=false)]
        public string Mid { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageID {\n");
            sb.Append("  Mid: ").Append(Mid).Append("\n");
            
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
            return this.Equals(obj as MessageID);
        }

        /// <summary>
        /// Returns true if MessageID instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageID to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageID other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Mid == other.Mid ||
                    this.Mid != null &&
                    this.Mid.Equals(other.Mid)
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
                
                return hash;
            }
        }

    }
}
