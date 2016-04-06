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
    public partial class UnregisterDeviceResponse :  IEquatable<UnregisterDeviceResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UnregisterDeviceResponse" /> class.
        /// Initializes a new instance of the <see cref="UnregisterDeviceResponse" />class.
        /// </summary>
        /// <param name="CertificateInfo">Device certificate information..</param>
        /// <param name="CertificateSignature">Certificate&#39;s signature..</param>
        /// <param name="CreatedOn">Device created on date..</param>
        /// <param name="Dtid">Device type id..</param>
        /// <param name="Eid">External ID of the device..</param>
        /// <param name="Id">Device id..</param>
        /// <param name="ManifestVersion">Device manifest version..</param>
        /// <param name="ManifestVersionPolicy">Device manifest version policy..</param>
        /// <param name="Name">Device name..</param>
        /// <param name="NeedProviderAuth">Device need provider auth..</param>
        /// <param name="Uid">User id..</param>

        public UnregisterDeviceResponse(string CertificateInfo = null, string CertificateSignature = null, long? CreatedOn = null, string Dtid = null, string Eid = null, string Id = null, long? ManifestVersion = null, string ManifestVersionPolicy = null, string Name = null, bool? NeedProviderAuth = null, string Uid = null)
        {
            this.CertificateInfo = CertificateInfo;
            this.CertificateSignature = CertificateSignature;
            this.CreatedOn = CreatedOn;
            this.Dtid = Dtid;
            this.Eid = Eid;
            this.Id = Id;
            this.ManifestVersion = ManifestVersion;
            this.ManifestVersionPolicy = ManifestVersionPolicy;
            this.Name = Name;
            this.NeedProviderAuth = NeedProviderAuth;
            this.Uid = Uid;
            
        }
        
    
        /// <summary>
        /// Device certificate information.
        /// </summary>
        /// <value>Device certificate information.</value>
        [DataMember(Name="certificateInfo", EmitDefaultValue=false)]
        public string CertificateInfo { get; set; }
    
        /// <summary>
        /// Certificate&#39;s signature.
        /// </summary>
        /// <value>Certificate&#39;s signature.</value>
        [DataMember(Name="certificateSignature", EmitDefaultValue=false)]
        public string CertificateSignature { get; set; }
    
        /// <summary>
        /// Device created on date.
        /// </summary>
        /// <value>Device created on date.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public long? CreatedOn { get; set; }
    
        /// <summary>
        /// Device type id.
        /// </summary>
        /// <value>Device type id.</value>
        [DataMember(Name="dtid", EmitDefaultValue=false)]
        public string Dtid { get; set; }
    
        /// <summary>
        /// External ID of the device.
        /// </summary>
        /// <value>External ID of the device.</value>
        [DataMember(Name="eid", EmitDefaultValue=false)]
        public string Eid { get; set; }
    
        /// <summary>
        /// Device id.
        /// </summary>
        /// <value>Device id.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Device manifest version.
        /// </summary>
        /// <value>Device manifest version.</value>
        [DataMember(Name="manifestVersion", EmitDefaultValue=false)]
        public long? ManifestVersion { get; set; }
    
        /// <summary>
        /// Device manifest version policy.
        /// </summary>
        /// <value>Device manifest version policy.</value>
        [DataMember(Name="manifestVersionPolicy", EmitDefaultValue=false)]
        public string ManifestVersionPolicy { get; set; }
    
        /// <summary>
        /// Device name.
        /// </summary>
        /// <value>Device name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Device need provider auth.
        /// </summary>
        /// <value>Device need provider auth.</value>
        [DataMember(Name="needProviderAuth", EmitDefaultValue=false)]
        public bool? NeedProviderAuth { get; set; }
    
        /// <summary>
        /// User id.
        /// </summary>
        /// <value>User id.</value>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnregisterDeviceResponse {\n");
            sb.Append("  CertificateInfo: ").Append(CertificateInfo).Append("\n");
            sb.Append("  CertificateSignature: ").Append(CertificateSignature).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Dtid: ").Append(Dtid).Append("\n");
            sb.Append("  Eid: ").Append(Eid).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ManifestVersion: ").Append(ManifestVersion).Append("\n");
            sb.Append("  ManifestVersionPolicy: ").Append(ManifestVersionPolicy).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NeedProviderAuth: ").Append(NeedProviderAuth).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            
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
            return this.Equals(obj as UnregisterDeviceResponse);
        }

        /// <summary>
        /// Returns true if UnregisterDeviceResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of UnregisterDeviceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnregisterDeviceResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CertificateInfo == other.CertificateInfo ||
                    this.CertificateInfo != null &&
                    this.CertificateInfo.Equals(other.CertificateInfo)
                ) && 
                (
                    this.CertificateSignature == other.CertificateSignature ||
                    this.CertificateSignature != null &&
                    this.CertificateSignature.Equals(other.CertificateSignature)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.Dtid == other.Dtid ||
                    this.Dtid != null &&
                    this.Dtid.Equals(other.Dtid)
                ) && 
                (
                    this.Eid == other.Eid ||
                    this.Eid != null &&
                    this.Eid.Equals(other.Eid)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ManifestVersion == other.ManifestVersion ||
                    this.ManifestVersion != null &&
                    this.ManifestVersion.Equals(other.ManifestVersion)
                ) && 
                (
                    this.ManifestVersionPolicy == other.ManifestVersionPolicy ||
                    this.ManifestVersionPolicy != null &&
                    this.ManifestVersionPolicy.Equals(other.ManifestVersionPolicy)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.NeedProviderAuth == other.NeedProviderAuth ||
                    this.NeedProviderAuth != null &&
                    this.NeedProviderAuth.Equals(other.NeedProviderAuth)
                ) && 
                (
                    this.Uid == other.Uid ||
                    this.Uid != null &&
                    this.Uid.Equals(other.Uid)
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
                
                if (this.CertificateInfo != null)
                    hash = hash * 59 + this.CertificateInfo.GetHashCode();
                
                if (this.CertificateSignature != null)
                    hash = hash * 59 + this.CertificateSignature.GetHashCode();
                
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                
                if (this.Dtid != null)
                    hash = hash * 59 + this.Dtid.GetHashCode();
                
                if (this.Eid != null)
                    hash = hash * 59 + this.Eid.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.ManifestVersion != null)
                    hash = hash * 59 + this.ManifestVersion.GetHashCode();
                
                if (this.ManifestVersionPolicy != null)
                    hash = hash * 59 + this.ManifestVersionPolicy.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.NeedProviderAuth != null)
                    hash = hash * 59 + this.NeedProviderAuth.GetHashCode();
                
                if (this.Uid != null)
                    hash = hash * 59 + this.Uid.GetHashCode();
                
                return hash;
            }
        }

    }
}
