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
    /// Manifest Versions
    /// </summary>
    [DataContract]
    public partial class ManifestVersions :  IEquatable<ManifestVersions>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ManifestVersions" /> class.
        /// Initializes a new instance of the <see cref="ManifestVersions" />class.
        /// </summary>
        /// <param name="Versions">Versions (required).</param>

        public ManifestVersions(List<string> Versions = null)
        {
            // to ensure "Versions" is required (not null)
            if (Versions == null)
            {
                throw new InvalidDataException("Versions is a required property for ManifestVersions and cannot be null");
            }
            else
            {
                this.Versions = Versions;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Versions
        /// </summary>
        [DataMember(Name="versions", EmitDefaultValue=false)]
        public List<string> Versions { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManifestVersions {\n");
            sb.Append("  Versions: ").Append(Versions).Append("\n");
            
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
            return this.Equals(obj as ManifestVersions);
        }

        /// <summary>
        /// Returns true if ManifestVersions instances are equal
        /// </summary>
        /// <param name="other">Instance of ManifestVersions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManifestVersions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Versions == other.Versions ||
                    this.Versions != null &&
                    this.Versions.SequenceEqual(other.Versions)
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
                
                if (this.Versions != null)
                    hash = hash * 59 + this.Versions.GetHashCode();
                
                return hash;
            }
        }

    }
}
