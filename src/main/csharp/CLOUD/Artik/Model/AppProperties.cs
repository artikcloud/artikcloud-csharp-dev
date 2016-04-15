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
    /// User Application Properties
    /// </summary>
    [DataContract]
    public partial class AppProperties :  IEquatable<AppProperties>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AppProperties" /> class.
        /// Initializes a new instance of the <see cref="AppProperties" />class.
        /// </summary>
        /// <param name="Uid">Uid.</param>
        /// <param name="Aid">Aid.</param>
        /// <param name="Properties">Properties (required).</param>

        public AppProperties(string Uid = null, string Aid = null, string Properties = null)
        {
            // to ensure "Properties" is required (not null)
            if (Properties == null)
            {
                throw new InvalidDataException("Properties is a required property for AppProperties and cannot be null");
            }
            else
            {
                this.Properties = Properties;
            }
            this.Uid = Uid;
            this.Aid = Aid;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Uid
        /// </summary>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }
    
        /// <summary>
        /// Gets or Sets Aid
        /// </summary>
        [DataMember(Name="aid", EmitDefaultValue=false)]
        public string Aid { get; set; }
    
        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public string Properties { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppProperties {\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  Aid: ").Append(Aid).Append("\n");
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
            return this.Equals(obj as AppProperties);
        }

        /// <summary>
        /// Returns true if AppProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of AppProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppProperties other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Uid == other.Uid ||
                    this.Uid != null &&
                    this.Uid.Equals(other.Uid)
                ) && 
                (
                    this.Aid == other.Aid ||
                    this.Aid != null &&
                    this.Aid.Equals(other.Aid)
                ) && 
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
                
                if (this.Uid != null)
                    hash = hash * 59 + this.Uid.GetHashCode();
                
                if (this.Aid != null)
                    hash = hash * 59 + this.Aid.GetHashCode();
                
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                
                return hash;
            }
        }

    }
}