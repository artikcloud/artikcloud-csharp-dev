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
    /// Rule information.
    /// </summary>
    [DataContract]
    public partial class OutputRule :  IEquatable<OutputRule>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputRule" /> class.
        /// Initializes a new instance of the <see cref="OutputRule" />class.
        /// </summary>
        /// <param name="Aid">Aid.</param>
        /// <param name="CreatedOn">CreatedOn.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Enabled">Enabled.</param>
        /// <param name="Error">Error.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Index">Index.</param>
        /// <param name="InvalidatedOn">InvalidatedOn.</param>
        /// <param name="LanguageVersion">LanguageVersion.</param>
        /// <param name="ModifiedOn">ModifiedOn.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Rule">Rule.</param>
        /// <param name="Uid">Uid.</param>
        /// <param name="Warning">Warning.</param>

        public OutputRule(string Aid = null, long? CreatedOn = null, string Description = null, bool? Enabled = null, RuleError Error = null, string Id = null, int? Index = null, long? InvalidatedOn = null, int? LanguageVersion = null, long? ModifiedOn = null, string Name = null, Dictionary<string, Object> Rule = null, string Uid = null, RuleWarningOutput Warning = null)
        {
            this.Aid = Aid;
            this.CreatedOn = CreatedOn;
            this.Description = Description;
            this.Enabled = Enabled;
            this.Error = Error;
            this.Id = Id;
            this.Index = Index;
            this.InvalidatedOn = InvalidatedOn;
            this.LanguageVersion = LanguageVersion;
            this.ModifiedOn = ModifiedOn;
            this.Name = Name;
            this.Rule = Rule;
            this.Uid = Uid;
            this.Warning = Warning;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Aid
        /// </summary>
        [DataMember(Name="aid", EmitDefaultValue=false)]
        public string Aid { get; set; }
    
        /// <summary>
        /// Gets or Sets CreatedOn
        /// </summary>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public long? CreatedOn { get; set; }
    
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
    
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public RuleError Error { get; set; }
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int? Index { get; set; }
    
        /// <summary>
        /// Gets or Sets InvalidatedOn
        /// </summary>
        [DataMember(Name="invalidatedOn", EmitDefaultValue=false)]
        public long? InvalidatedOn { get; set; }
    
        /// <summary>
        /// Gets or Sets LanguageVersion
        /// </summary>
        [DataMember(Name="languageVersion", EmitDefaultValue=false)]
        public int? LanguageVersion { get; set; }
    
        /// <summary>
        /// Gets or Sets ModifiedOn
        /// </summary>
        [DataMember(Name="modifiedOn", EmitDefaultValue=false)]
        public long? ModifiedOn { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Rule
        /// </summary>
        [DataMember(Name="rule", EmitDefaultValue=false)]
        public Dictionary<string, Object> Rule { get; set; }
    
        /// <summary>
        /// Gets or Sets Uid
        /// </summary>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }
    
        /// <summary>
        /// Gets or Sets Warning
        /// </summary>
        [DataMember(Name="warning", EmitDefaultValue=false)]
        public RuleWarningOutput Warning { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputRule {\n");
            sb.Append("  Aid: ").Append(Aid).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  InvalidatedOn: ").Append(InvalidatedOn).Append("\n");
            sb.Append("  LanguageVersion: ").Append(LanguageVersion).Append("\n");
            sb.Append("  ModifiedOn: ").Append(ModifiedOn).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rule: ").Append(Rule).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  Warning: ").Append(Warning).Append("\n");
            
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
            return this.Equals(obj as OutputRule);
        }

        /// <summary>
        /// Returns true if OutputRule instances are equal
        /// </summary>
        /// <param name="other">Instance of OutputRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutputRule other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Aid == other.Aid ||
                    this.Aid != null &&
                    this.Aid.Equals(other.Aid)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
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
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Index == other.Index ||
                    this.Index != null &&
                    this.Index.Equals(other.Index)
                ) && 
                (
                    this.InvalidatedOn == other.InvalidatedOn ||
                    this.InvalidatedOn != null &&
                    this.InvalidatedOn.Equals(other.InvalidatedOn)
                ) && 
                (
                    this.LanguageVersion == other.LanguageVersion ||
                    this.LanguageVersion != null &&
                    this.LanguageVersion.Equals(other.LanguageVersion)
                ) && 
                (
                    this.ModifiedOn == other.ModifiedOn ||
                    this.ModifiedOn != null &&
                    this.ModifiedOn.Equals(other.ModifiedOn)
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
                ) && 
                (
                    this.Uid == other.Uid ||
                    this.Uid != null &&
                    this.Uid.Equals(other.Uid)
                ) && 
                (
                    this.Warning == other.Warning ||
                    this.Warning != null &&
                    this.Warning.Equals(other.Warning)
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
                
                if (this.Aid != null)
                    hash = hash * 59 + this.Aid.GetHashCode();
                
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Index != null)
                    hash = hash * 59 + this.Index.GetHashCode();
                
                if (this.InvalidatedOn != null)
                    hash = hash * 59 + this.InvalidatedOn.GetHashCode();
                
                if (this.LanguageVersion != null)
                    hash = hash * 59 + this.LanguageVersion.GetHashCode();
                
                if (this.ModifiedOn != null)
                    hash = hash * 59 + this.ModifiedOn.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Rule != null)
                    hash = hash * 59 + this.Rule.GetHashCode();
                
                if (this.Uid != null)
                    hash = hash * 59 + this.Uid.GetHashCode();
                
                if (this.Warning != null)
                    hash = hash * 59 + this.Warning.GetHashCode();
                
                return hash;
            }
        }

    }
}
