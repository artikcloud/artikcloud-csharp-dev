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
    /// Manifest Properties Envelope
    /// </summary>
    [DataContract]
    public partial class ManifestPropertiesEnvelope :  IEquatable<ManifestPropertiesEnvelope>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ManifestPropertiesEnvelope" /> class.
        /// Initializes a new instance of the <see cref="ManifestPropertiesEnvelope" />class.
        /// </summary>
        /// <param name="Data">Data (required).</param>

        public ManifestPropertiesEnvelope(ManifestProperties Data = null)
        {
            // to ensure "Data" is required (not null)
            if (Data == null)
            {
                throw new InvalidDataException("Data is a required property for ManifestPropertiesEnvelope and cannot be null");
            }
            else
            {
                this.Data = Data;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public ManifestProperties Data { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManifestPropertiesEnvelope {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            
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
            return this.Equals(obj as ManifestPropertiesEnvelope);
        }

        /// <summary>
        /// Returns true if ManifestPropertiesEnvelope instances are equal
        /// </summary>
        /// <param name="other">Instance of ManifestPropertiesEnvelope to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManifestPropertiesEnvelope other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
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
                
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                
                return hash;
            }
        }

    }
}