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
    /// Device Token
    /// </summary>
    [DataContract]
    public partial class DeviceToken :  IEquatable<DeviceToken>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceToken" /> class.
        /// Initializes a new instance of the <see cref="DeviceToken" />class.
        /// </summary>
        /// <param name="AccessToken">AccessToken (required).</param>
        /// <param name="Uid">Uid (required).</param>
        /// <param name="Did">Did (required).</param>
        /// <param name="Cid">Cid (required).</param>

        public DeviceToken(string AccessToken = null, string Uid = null, string Did = null, string Cid = null)
        {
            // to ensure "AccessToken" is required (not null)
            if (AccessToken == null)
            {
                throw new InvalidDataException("AccessToken is a required property for DeviceToken and cannot be null");
            }
            else
            {
                this.AccessToken = AccessToken;
            }
            // to ensure "Uid" is required (not null)
            if (Uid == null)
            {
                throw new InvalidDataException("Uid is a required property for DeviceToken and cannot be null");
            }
            else
            {
                this.Uid = Uid;
            }
            // to ensure "Did" is required (not null)
            if (Did == null)
            {
                throw new InvalidDataException("Did is a required property for DeviceToken and cannot be null");
            }
            else
            {
                this.Did = Did;
            }
            // to ensure "Cid" is required (not null)
            if (Cid == null)
            {
                throw new InvalidDataException("Cid is a required property for DeviceToken and cannot be null");
            }
            else
            {
                this.Cid = Cid;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name="accessToken", EmitDefaultValue=false)]
        public string AccessToken { get; set; }
    
        /// <summary>
        /// Gets or Sets Uid
        /// </summary>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }
    
        /// <summary>
        /// Gets or Sets Did
        /// </summary>
        [DataMember(Name="did", EmitDefaultValue=false)]
        public string Did { get; set; }
    
        /// <summary>
        /// Gets or Sets Cid
        /// </summary>
        [DataMember(Name="cid", EmitDefaultValue=false)]
        public string Cid { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceToken {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  Did: ").Append(Did).Append("\n");
            sb.Append("  Cid: ").Append(Cid).Append("\n");
            
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
            return this.Equals(obj as DeviceToken);
        }

        /// <summary>
        /// Returns true if DeviceToken instances are equal
        /// </summary>
        /// <param name="other">Instance of DeviceToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceToken other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccessToken == other.AccessToken ||
                    this.AccessToken != null &&
                    this.AccessToken.Equals(other.AccessToken)
                ) && 
                (
                    this.Uid == other.Uid ||
                    this.Uid != null &&
                    this.Uid.Equals(other.Uid)
                ) && 
                (
                    this.Did == other.Did ||
                    this.Did != null &&
                    this.Did.Equals(other.Did)
                ) && 
                (
                    this.Cid == other.Cid ||
                    this.Cid != null &&
                    this.Cid.Equals(other.Cid)
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
                
                if (this.AccessToken != null)
                    hash = hash * 59 + this.AccessToken.GetHashCode();
                
                if (this.Uid != null)
                    hash = hash * 59 + this.Uid.GetHashCode();
                
                if (this.Did != null)
                    hash = hash * 59 + this.Did.GetHashCode();
                
                if (this.Cid != null)
                    hash = hash * 59 + this.Cid.GetHashCode();
                
                return hash;
            }
        }

    }
}
