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
    /// Manifest Properties
    /// </summary>
    [DataContract]
    public partial class ManifestProperties :  IEquatable<ManifestProperties>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ManifestProperties" /> class.
        /// Initializes a new instance of the <see cref="ManifestProperties" />class.
        /// </summary>
        /// <param name="Properties">Properties (required).</param>

        public ManifestProperties(FieldsActions Properties = null)
        {
            // to ensure "Properties" is required (not null)
            if (Properties == null)
            {
                throw new InvalidDataException("Properties is a required property for ManifestProperties and cannot be null");
            }
            else
            {
                this.Properties = Properties;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public FieldsActions Properties { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManifestProperties {\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            
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
            return this.Equals(obj as ManifestProperties);
        }

        /// <summary>
        /// Returns true if ManifestProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of ManifestProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManifestProperties other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.Equals(other.Properties)
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
                
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                
                return hash;
            }
        }

    }
}
