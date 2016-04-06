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
    /// Holds an array of DeviceTypes
    /// </summary>
    [DataContract]
    public partial class DeviceTypeArray :  IEquatable<DeviceTypeArray>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceTypeArray" /> class.
        /// Initializes a new instance of the <see cref="DeviceTypeArray" />class.
        /// </summary>
        /// <param name="DeviceTypes">DeviceTypes.</param>

        public DeviceTypeArray(List<DeviceType> DeviceTypes = null)
        {
            this.DeviceTypes = DeviceTypes;
            
        }
        
    
        /// <summary>
        /// Gets or Sets DeviceTypes
        /// </summary>
        [DataMember(Name="deviceTypes", EmitDefaultValue=false)]
        public List<DeviceType> DeviceTypes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceTypeArray {\n");
            sb.Append("  DeviceTypes: ").Append(DeviceTypes).Append("\n");
            
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
            return this.Equals(obj as DeviceTypeArray);
        }

        /// <summary>
        /// Returns true if DeviceTypeArray instances are equal
        /// </summary>
        /// <param name="other">Instance of DeviceTypeArray to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceTypeArray other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeviceTypes == other.DeviceTypes ||
                    this.DeviceTypes != null &&
                    this.DeviceTypes.SequenceEqual(other.DeviceTypes)
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
                
                if (this.DeviceTypes != null)
                    hash = hash * 59 + this.DeviceTypes.GetHashCode();
                
                return hash;
            }
        }

    }
}
