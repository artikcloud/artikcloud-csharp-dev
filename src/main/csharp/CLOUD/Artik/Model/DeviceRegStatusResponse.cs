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
    /// 
    /// </summary>
    [DataContract]
    public partial class DeviceRegStatusResponse :  IEquatable<DeviceRegStatusResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceRegStatusResponse" /> class.
        /// Initializes a new instance of the <see cref="DeviceRegStatusResponse" />class.
        /// </summary>
        /// <param name="Did">The created or existing device id..</param>
        /// <param name="Status">Status of the ongoing device registration request..</param>

        public DeviceRegStatusResponse(string Did = null, string Status = null)
        {
            this.Did = Did;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// The created or existing device id.
        /// </summary>
        /// <value>The created or existing device id.</value>
        [DataMember(Name="did", EmitDefaultValue=false)]
        public string Did { get; set; }
    
        /// <summary>
        /// Status of the ongoing device registration request.
        /// </summary>
        /// <value>Status of the ongoing device registration request.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceRegStatusResponse {\n");
            sb.Append("  Did: ").Append(Did).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            
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
            return this.Equals(obj as DeviceRegStatusResponse);
        }

        /// <summary>
        /// Returns true if DeviceRegStatusResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DeviceRegStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceRegStatusResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Did == other.Did ||
                    this.Did != null &&
                    this.Did.Equals(other.Did)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.Did != null)
                    hash = hash * 59 + this.Did.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
