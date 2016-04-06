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
    /// Fields and Actions
    /// </summary>
    [DataContract]
    public partial class FieldsActions :  IEquatable<FieldsActions>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldsActions" /> class.
        /// Initializes a new instance of the <see cref="FieldsActions" />class.
        /// </summary>
        /// <param name="Fields">Message Fields.</param>
        /// <param name="Actions">Actions.</param>

        public FieldsActions(Dictionary<string, Object> Fields = null, Dictionary<string, Object> Actions = null)
        {
            this.Fields = Fields;
            this.Actions = Actions;
            
        }
        
    
        /// <summary>
        /// Message Fields
        /// </summary>
        /// <value>Message Fields</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public Dictionary<string, Object> Fields { get; set; }
    
        /// <summary>
        /// Actions
        /// </summary>
        /// <value>Actions</value>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public Dictionary<string, Object> Actions { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldsActions {\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(obj as FieldsActions);
        }

        /// <summary>
        /// Returns true if FieldsActions instances are equal
        /// </summary>
        /// <param name="other">Instance of FieldsActions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldsActions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Fields == other.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(other.Fields)
                ) && 
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
                
                if (this.Fields != null)
                    hash = hash * 59 + this.Fields.GetHashCode();
                
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                
                return hash;
            }
        }

    }
}
