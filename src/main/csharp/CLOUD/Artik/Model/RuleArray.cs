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
    /// Holds an array of Rules.
    /// </summary>
    [DataContract]
    public partial class RuleArray :  IEquatable<RuleArray>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleArray" /> class.
        /// Initializes a new instance of the <see cref="RuleArray" />class.
        /// </summary>
        /// <param name="Rules">Rules.</param>

        public RuleArray(List<OutputRule> Rules = null)
        {
            this.Rules = Rules;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Rules
        /// </summary>
        [DataMember(Name="rules", EmitDefaultValue=false)]
        public List<OutputRule> Rules { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleArray {\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
            
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
            return this.Equals(obj as RuleArray);
        }

        /// <summary>
        /// Returns true if RuleArray instances are equal
        /// </summary>
        /// <param name="other">Instance of RuleArray to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleArray other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Rules == other.Rules ||
                    this.Rules != null &&
                    this.Rules.SequenceEqual(other.Rules)
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
                
                if (this.Rules != null)
                    hash = hash * 59 + this.Rules.GetHashCode();
                
                return hash;
            }
        }

    }
}
