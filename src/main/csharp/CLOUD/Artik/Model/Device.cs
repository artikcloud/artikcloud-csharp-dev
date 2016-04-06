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
    /// Device information.
    /// </summary>
    [DataContract]
    public partial class Device :  IEquatable<Device>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Device" /> class.
        /// Initializes a new instance of the <see cref="Device" />class.
        /// </summary>
        /// <param name="Id">Device ID.</param>
        /// <param name="Uid">User ID.</param>
        /// <param name="Dtid">Device Type ID.</param>
        /// <param name="Name">Name.</param>
        /// <param name="ManifestVersion">Manifest Version.</param>
        /// <param name="ManifestVersionPolicy">Manifest Version Policy (LATEST, DEVICE).</param>
        /// <param name="NeedProviderAuth">Needs Provider Authentication.</param>
        /// <param name="Properties">Properties.</param>
        /// <param name="CreatedOn">Created On (milliseconds since epoch).</param>
        /// <param name="Connected">Is Connected.</param>
        /// <param name="CertificateInfo">Certificate Info (if any).</param>
        /// <param name="CertificateSignature">Certificate Signature (if any).</param>
        /// <param name="Eid">External ID (if any).</param>
        /// <param name="ProviderCredentials">ProviderCredentials.</param>

        public Device(string Id = null, string Uid = null, string Dtid = null, string Name = null, int? ManifestVersion = null, string ManifestVersionPolicy = null, bool? NeedProviderAuth = null, Dictionary<string, Object> Properties = null, long? CreatedOn = null, bool? Connected = null, string CertificateInfo = null, string CertificateSignature = null, string Eid = null, Dictionary<string, Object> ProviderCredentials = null)
        {
            this.Id = Id;
            this.Uid = Uid;
            this.Dtid = Dtid;
            this.Name = Name;
            this.ManifestVersion = ManifestVersion;
            this.ManifestVersionPolicy = ManifestVersionPolicy;
            this.NeedProviderAuth = NeedProviderAuth;
            this.Properties = Properties;
            this.CreatedOn = CreatedOn;
            this.Connected = Connected;
            this.CertificateInfo = CertificateInfo;
            this.CertificateSignature = CertificateSignature;
            this.Eid = Eid;
            this.ProviderCredentials = ProviderCredentials;
            
        }
        
    
        /// <summary>
        /// Device ID
        /// </summary>
        /// <value>Device ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// User ID
        /// </summary>
        /// <value>User ID</value>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }
    
        /// <summary>
        /// Device Type ID
        /// </summary>
        /// <value>Device Type ID</value>
        [DataMember(Name="dtid", EmitDefaultValue=false)]
        public string Dtid { get; set; }
    
        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Manifest Version
        /// </summary>
        /// <value>Manifest Version</value>
        [DataMember(Name="manifestVersion", EmitDefaultValue=false)]
        public int? ManifestVersion { get; set; }
    
        /// <summary>
        /// Manifest Version Policy (LATEST, DEVICE)
        /// </summary>
        /// <value>Manifest Version Policy (LATEST, DEVICE)</value>
        [DataMember(Name="manifestVersionPolicy", EmitDefaultValue=false)]
        public string ManifestVersionPolicy { get; set; }
    
        /// <summary>
        /// Needs Provider Authentication
        /// </summary>
        /// <value>Needs Provider Authentication</value>
        [DataMember(Name="needProviderAuth", EmitDefaultValue=false)]
        public bool? NeedProviderAuth { get; set; }
    
        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, Object> Properties { get; set; }
    
        /// <summary>
        /// Created On (milliseconds since epoch)
        /// </summary>
        /// <value>Created On (milliseconds since epoch)</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public long? CreatedOn { get; set; }
    
        /// <summary>
        /// Is Connected
        /// </summary>
        /// <value>Is Connected</value>
        [DataMember(Name="connected", EmitDefaultValue=false)]
        public bool? Connected { get; set; }
    
        /// <summary>
        /// Certificate Info (if any)
        /// </summary>
        /// <value>Certificate Info (if any)</value>
        [DataMember(Name="certificateInfo", EmitDefaultValue=false)]
        public string CertificateInfo { get; set; }
    
        /// <summary>
        /// Certificate Signature (if any)
        /// </summary>
        /// <value>Certificate Signature (if any)</value>
        [DataMember(Name="certificateSignature", EmitDefaultValue=false)]
        public string CertificateSignature { get; set; }
    
        /// <summary>
        /// External ID (if any)
        /// </summary>
        /// <value>External ID (if any)</value>
        [DataMember(Name="eid", EmitDefaultValue=false)]
        public string Eid { get; set; }
    
        /// <summary>
        /// Gets or Sets ProviderCredentials
        /// </summary>
        [DataMember(Name="providerCredentials", EmitDefaultValue=false)]
        public Dictionary<string, Object> ProviderCredentials { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Device {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  Dtid: ").Append(Dtid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ManifestVersion: ").Append(ManifestVersion).Append("\n");
            sb.Append("  ManifestVersionPolicy: ").Append(ManifestVersionPolicy).Append("\n");
            sb.Append("  NeedProviderAuth: ").Append(NeedProviderAuth).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Connected: ").Append(Connected).Append("\n");
            sb.Append("  CertificateInfo: ").Append(CertificateInfo).Append("\n");
            sb.Append("  CertificateSignature: ").Append(CertificateSignature).Append("\n");
            sb.Append("  Eid: ").Append(Eid).Append("\n");
            sb.Append("  ProviderCredentials: ").Append(ProviderCredentials).Append("\n");
            
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
            return this.Equals(obj as Device);
        }

        /// <summary>
        /// Returns true if Device instances are equal
        /// </summary>
        /// <param name="other">Instance of Device to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Device other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Uid == other.Uid ||
                    this.Uid != null &&
                    this.Uid.Equals(other.Uid)
                ) && 
                (
                    this.Dtid == other.Dtid ||
                    this.Dtid != null &&
                    this.Dtid.Equals(other.Dtid)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                    this.NeedProviderAuth == other.NeedProviderAuth ||
                    this.NeedProviderAuth != null &&
                    this.NeedProviderAuth.Equals(other.NeedProviderAuth)
                ) && 
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.Connected == other.Connected ||
                    this.Connected != null &&
                    this.Connected.Equals(other.Connected)
                ) && 
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
                    this.Eid == other.Eid ||
                    this.Eid != null &&
                    this.Eid.Equals(other.Eid)
                ) && 
                (
                    this.ProviderCredentials == other.ProviderCredentials ||
                    this.ProviderCredentials != null &&
                    this.ProviderCredentials.SequenceEqual(other.ProviderCredentials)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Uid != null)
                    hash = hash * 59 + this.Uid.GetHashCode();
                
                if (this.Dtid != null)
                    hash = hash * 59 + this.Dtid.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.ManifestVersion != null)
                    hash = hash * 59 + this.ManifestVersion.GetHashCode();
                
                if (this.ManifestVersionPolicy != null)
                    hash = hash * 59 + this.ManifestVersionPolicy.GetHashCode();
                
                if (this.NeedProviderAuth != null)
                    hash = hash * 59 + this.NeedProviderAuth.GetHashCode();
                
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                
                if (this.Connected != null)
                    hash = hash * 59 + this.Connected.GetHashCode();
                
                if (this.CertificateInfo != null)
                    hash = hash * 59 + this.CertificateInfo.GetHashCode();
                
                if (this.CertificateSignature != null)
                    hash = hash * 59 + this.CertificateSignature.GetHashCode();
                
                if (this.Eid != null)
                    hash = hash * 59 + this.Eid.GetHashCode();
                
                if (this.ProviderCredentials != null)
                    hash = hash * 59 + this.ProviderCredentials.GetHashCode();
                
                return hash;
            }
        }

    }
}
