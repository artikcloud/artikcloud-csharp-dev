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
    /// Action details.
    /// </summary>
    [DataContract]
    public partial class ActionDetails :  IEquatable<ActionDetails>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionDetails" /> class.
        /// Initializes a new instance of the <see cref="ActionDetails" />class.
        /// </summary>
        /// <param name="Parameters">Parameters..</param>
        /// <param name="Name">Name..</param>

        public ActionDetails(Dictionary<string, Object> Parameters = null, string Name = null)
        {
            this.Parameters = Parameters;
            this.Name = Name;
            
        }
        
    
        /// <summary>
        /// Parameters.
        /// </summary>
        /// <value>Parameters.</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public Dictionary<string, Object> Parameters { get; set; }
    
        /// <summary>
        /// Name.
        /// </summary>
        /// <value>Name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionDetails {\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            
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
            return this.Equals(obj as ActionDetails);
        }

        /// <summary>
        /// Returns true if ActionDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of ActionDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                
                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                return hash;
            }
        }

    }
}
