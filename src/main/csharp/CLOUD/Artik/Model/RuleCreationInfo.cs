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
    /// Class to create a new Rule.
    /// </summary>
    [DataContract]
    public partial class RuleCreationInfo :  IEquatable<RuleCreationInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleCreationInfo" /> class.
        /// Initializes a new instance of the <see cref="RuleCreationInfo" />class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="Enabled">Is Enabled.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Rule">Rule.</param>

        public RuleCreationInfo(string Description = null, bool? Enabled = null, string Name = null, Dictionary<string, Object> Rule = null)
        {
            this.Description = Description;
            this.Enabled = Enabled;
            this.Name = Name;
            this.Rule = Rule;
            
        }
        
    
        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Is Enabled
        /// </summary>
        /// <value>Is Enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
    
        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Rule
        /// </summary>
        /// <value>Rule</value>
        [DataMember(Name="rule", EmitDefaultValue=false)]
        public Dictionary<string, Object> Rule { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleCreationInfo {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rule: ").Append(Rule).Append("\n");
            
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
            return this.Equals(obj as RuleCreationInfo);
        }

        /// <summary>
        /// Returns true if RuleCreationInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of RuleCreationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleCreationInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Rule == other.Rule ||
                    this.Rule != null &&
                    this.Rule.SequenceEqual(other.Rule)
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
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Rule != null)
                    hash = hash * 59 + this.Rule.GetHashCode();
                
                return hash;
            }
        }

    }
}
