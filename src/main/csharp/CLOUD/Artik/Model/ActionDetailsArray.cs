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
    /// Contains the array of Action Details
    /// </summary>
    [DataContract]
    public partial class ActionDetailsArray :  IEquatable<ActionDetailsArray>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionDetailsArray" /> class.
        /// Initializes a new instance of the <see cref="ActionDetailsArray" />class.
        /// </summary>
        /// <param name="Actions">Actions.</param>

        public ActionDetailsArray(List<ActionDetails> Actions = null)
        {
            this.Actions = Actions;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<ActionDetails> Actions { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionDetailsArray {\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            
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
            return this.Equals(obj as ActionDetailsArray);
        }

        /// <summary>
        /// Returns true if ActionDetailsArray instances are equal
        /// </summary>
        /// <param name="other">Instance of ActionDetailsArray to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionDetailsArray other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
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
                
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                
                return hash;
            }
        }

    }
}
