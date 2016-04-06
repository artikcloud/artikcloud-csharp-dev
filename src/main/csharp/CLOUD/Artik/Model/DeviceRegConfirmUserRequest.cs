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
    public partial class DeviceRegConfirmUserRequest :  IEquatable<DeviceRegConfirmUserRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceRegConfirmUserRequest" /> class.
        /// Initializes a new instance of the <see cref="DeviceRegConfirmUserRequest" />class.
        /// </summary>
        /// <param name="DeviceId">Device ID. Optional if deviceName is present.</param>
        /// <param name="DeviceName">Device Name. Optional if deviceId is present.</param>
        /// <param name="Pin">Pin obtained in the registrations call..</param>

        public DeviceRegConfirmUserRequest(string DeviceId = null, string DeviceName = null, string Pin = null)
        {
            this.DeviceId = DeviceId;
            this.DeviceName = DeviceName;
            this.Pin = Pin;
            
        }
        
    
        /// <summary>
        /// Device ID. Optional if deviceName is present
        /// </summary>
        /// <value>Device ID. Optional if deviceName is present</value>
        [DataMember(Name="deviceId", EmitDefaultValue=false)]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Device Name. Optional if deviceId is present
        /// </summary>
        /// <value>Device Name. Optional if deviceId is present</value>
        [DataMember(Name="deviceName", EmitDefaultValue=false)]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Pin obtained in the registrations call.
        /// </summary>
        /// <value>Pin obtained in the registrations call.</value>
        [DataMember(Name="pin", EmitDefaultValue=false)]
        public string Pin { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceRegConfirmUserRequest {\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
            sb.Append("  Pin: ").Append(Pin).Append("\n");
            
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
            return this.Equals(obj as DeviceRegConfirmUserRequest);
        }

        /// <summary>
        /// Returns true if DeviceRegConfirmUserRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of DeviceRegConfirmUserRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceRegConfirmUserRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeviceId == other.DeviceId ||
                    this.DeviceId != null &&
                    this.DeviceId.Equals(other.DeviceId)
                ) && 
                (
                    this.DeviceName == other.DeviceName ||
                    this.DeviceName != null &&
                    this.DeviceName.Equals(other.DeviceName)
                ) && 
                (
                    this.Pin == other.Pin ||
                    this.Pin != null &&
                    this.Pin.Equals(other.Pin)
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
                
                if (this.DeviceId != null)
                    hash = hash * 59 + this.DeviceId.GetHashCode();
                
                if (this.DeviceName != null)
                    hash = hash * 59 + this.DeviceName.GetHashCode();
                
                if (this.Pin != null)
                    hash = hash * 59 + this.Pin.GetHashCode();
                
                return hash;
            }
        }

    }
}
