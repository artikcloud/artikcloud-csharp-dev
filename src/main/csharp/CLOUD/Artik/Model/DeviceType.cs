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
    /// Device Type Information
    /// </summary>
    [DataContract]
    public partial class DeviceType :  IEquatable<DeviceType>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceType" /> class.
        /// Initializes a new instance of the <see cref="DeviceType" />class.
        /// </summary>
        /// <param name="Id">Device Type ID..</param>
        /// <param name="UniqueName">Unique Name..</param>
        /// <param name="LatestVersion">Latest Manifest version..</param>
        /// <param name="LastUpdated">LastUpdated.</param>
        /// <param name="Name">Name..</param>
        /// <param name="Description">Description..</param>
        /// <param name="Uid">User ID..</param>
        /// <param name="Oid">Organization ID..</param>
        /// <param name="HasCloudConnector">Uses Cloud Connectors SDK.</param>
        /// <param name="Approved">Approval status..</param>
        /// <param name="Published">Published status..</param>
        /// <param name="_Protected">Protected status..</param>
        /// <param name="InStore">In Store..</param>
        /// <param name="OwnedByCurrentUser">Does the current user own a device of this device type.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="Rsp">Require Secure Device Registration (SDR) Protocol..</param>
        /// <param name="IssuerDn">Issuer Distinguished Name (Used in SDR).</param>
        /// <param name="Vid">Vendor ID. (Used in SDR).</param>

        public DeviceType(string Id = null, string UniqueName = null, int? LatestVersion = null, long? LastUpdated = null, string Name = null, string Description = null, string Uid = null, string Oid = null, bool? HasCloudConnector = null, bool? Approved = null, bool? Published = null, bool? _Protected = null, bool? InStore = null, bool? OwnedByCurrentUser = null, List<Tag> Tags = null, bool? Rsp = null, string IssuerDn = null, string Vid = null)
        {
            this.Id = Id;
            this.UniqueName = UniqueName;
            this.LatestVersion = LatestVersion;
            this.LastUpdated = LastUpdated;
            this.Name = Name;
            this.Description = Description;
            this.Uid = Uid;
            this.Oid = Oid;
            this.HasCloudConnector = HasCloudConnector;
            this.Approved = Approved;
            this.Published = Published;
            this._Protected = _Protected;
            this.InStore = InStore;
            this.OwnedByCurrentUser = OwnedByCurrentUser;
            this.Tags = Tags;
            this.Rsp = Rsp;
            this.IssuerDn = IssuerDn;
            this.Vid = Vid;
            
        }
        
    
        /// <summary>
        /// Device Type ID.
        /// </summary>
        /// <value>Device Type ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Unique Name.
        /// </summary>
        /// <value>Unique Name.</value>
        [DataMember(Name="uniqueName", EmitDefaultValue=false)]
        public string UniqueName { get; set; }
    
        /// <summary>
        /// Latest Manifest version.
        /// </summary>
        /// <value>Latest Manifest version.</value>
        [DataMember(Name="latestVersion", EmitDefaultValue=false)]
        public int? LatestVersion { get; set; }
    
        /// <summary>
        /// Gets or Sets LastUpdated
        /// </summary>
        [DataMember(Name="lastUpdated", EmitDefaultValue=false)]
        public long? LastUpdated { get; set; }
    
        /// <summary>
        /// Name.
        /// </summary>
        /// <value>Name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Description.
        /// </summary>
        /// <value>Description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// User ID.
        /// </summary>
        /// <value>User ID.</value>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }
    
        /// <summary>
        /// Organization ID.
        /// </summary>
        /// <value>Organization ID.</value>
        [DataMember(Name="oid", EmitDefaultValue=false)]
        public string Oid { get; set; }
    
        /// <summary>
        /// Uses Cloud Connectors SDK
        /// </summary>
        /// <value>Uses Cloud Connectors SDK</value>
        [DataMember(Name="hasCloudConnector", EmitDefaultValue=false)]
        public bool? HasCloudConnector { get; set; }
    
        /// <summary>
        /// Approval status.
        /// </summary>
        /// <value>Approval status.</value>
        [DataMember(Name="approved", EmitDefaultValue=false)]
        public bool? Approved { get; set; }
    
        /// <summary>
        /// Published status.
        /// </summary>
        /// <value>Published status.</value>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; set; }
    
        /// <summary>
        /// Protected status.
        /// </summary>
        /// <value>Protected status.</value>
        [DataMember(Name="protected", EmitDefaultValue=false)]
        public bool? _Protected { get; set; }
    
        /// <summary>
        /// In Store.
        /// </summary>
        /// <value>In Store.</value>
        [DataMember(Name="inStore", EmitDefaultValue=false)]
        public bool? InStore { get; set; }
    
        /// <summary>
        /// Does the current user own a device of this device type
        /// </summary>
        /// <value>Does the current user own a device of this device type</value>
        [DataMember(Name="ownedByCurrentUser", EmitDefaultValue=false)]
        public bool? OwnedByCurrentUser { get; set; }
    
        /// <summary>
        /// Tags
        /// </summary>
        /// <value>Tags</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<Tag> Tags { get; set; }
    
        /// <summary>
        /// Require Secure Device Registration (SDR) Protocol.
        /// </summary>
        /// <value>Require Secure Device Registration (SDR) Protocol.</value>
        [DataMember(Name="rsp", EmitDefaultValue=false)]
        public bool? Rsp { get; set; }
    
        /// <summary>
        /// Issuer Distinguished Name (Used in SDR)
        /// </summary>
        /// <value>Issuer Distinguished Name (Used in SDR)</value>
        [DataMember(Name="issuerDn", EmitDefaultValue=false)]
        public string IssuerDn { get; set; }
    
        /// <summary>
        /// Vendor ID. (Used in SDR)
        /// </summary>
        /// <value>Vendor ID. (Used in SDR)</value>
        [DataMember(Name="vid", EmitDefaultValue=false)]
        public string Vid { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceType {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UniqueName: ").Append(UniqueName).Append("\n");
            sb.Append("  LatestVersion: ").Append(LatestVersion).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  Oid: ").Append(Oid).Append("\n");
            sb.Append("  HasCloudConnector: ").Append(HasCloudConnector).Append("\n");
            sb.Append("  Approved: ").Append(Approved).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  _Protected: ").Append(_Protected).Append("\n");
            sb.Append("  InStore: ").Append(InStore).Append("\n");
            sb.Append("  OwnedByCurrentUser: ").Append(OwnedByCurrentUser).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Rsp: ").Append(Rsp).Append("\n");
            sb.Append("  IssuerDn: ").Append(IssuerDn).Append("\n");
            sb.Append("  Vid: ").Append(Vid).Append("\n");
            
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
            return this.Equals(obj as DeviceType);
        }

        /// <summary>
        /// Returns true if DeviceType instances are equal
        /// </summary>
        /// <param name="other">Instance of DeviceType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceType other)
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
                    this.UniqueName == other.UniqueName ||
                    this.UniqueName != null &&
                    this.UniqueName.Equals(other.UniqueName)
                ) && 
                (
                    this.LatestVersion == other.LatestVersion ||
                    this.LatestVersion != null &&
                    this.LatestVersion.Equals(other.LatestVersion)
                ) && 
                (
                    this.LastUpdated == other.LastUpdated ||
                    this.LastUpdated != null &&
                    this.LastUpdated.Equals(other.LastUpdated)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Uid == other.Uid ||
                    this.Uid != null &&
                    this.Uid.Equals(other.Uid)
                ) && 
                (
                    this.Oid == other.Oid ||
                    this.Oid != null &&
                    this.Oid.Equals(other.Oid)
                ) && 
                (
                    this.HasCloudConnector == other.HasCloudConnector ||
                    this.HasCloudConnector != null &&
                    this.HasCloudConnector.Equals(other.HasCloudConnector)
                ) && 
                (
                    this.Approved == other.Approved ||
                    this.Approved != null &&
                    this.Approved.Equals(other.Approved)
                ) && 
                (
                    this.Published == other.Published ||
                    this.Published != null &&
                    this.Published.Equals(other.Published)
                ) && 
                (
                    this._Protected == other._Protected ||
                    this._Protected != null &&
                    this._Protected.Equals(other._Protected)
                ) && 
                (
                    this.InStore == other.InStore ||
                    this.InStore != null &&
                    this.InStore.Equals(other.InStore)
                ) && 
                (
                    this.OwnedByCurrentUser == other.OwnedByCurrentUser ||
                    this.OwnedByCurrentUser != null &&
                    this.OwnedByCurrentUser.Equals(other.OwnedByCurrentUser)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    this.Rsp == other.Rsp ||
                    this.Rsp != null &&
                    this.Rsp.Equals(other.Rsp)
                ) && 
                (
                    this.IssuerDn == other.IssuerDn ||
                    this.IssuerDn != null &&
                    this.IssuerDn.Equals(other.IssuerDn)
                ) && 
                (
                    this.Vid == other.Vid ||
                    this.Vid != null &&
                    this.Vid.Equals(other.Vid)
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
                
                if (this.UniqueName != null)
                    hash = hash * 59 + this.UniqueName.GetHashCode();
                
                if (this.LatestVersion != null)
                    hash = hash * 59 + this.LatestVersion.GetHashCode();
                
                if (this.LastUpdated != null)
                    hash = hash * 59 + this.LastUpdated.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Uid != null)
                    hash = hash * 59 + this.Uid.GetHashCode();
                
                if (this.Oid != null)
                    hash = hash * 59 + this.Oid.GetHashCode();
                
                if (this.HasCloudConnector != null)
                    hash = hash * 59 + this.HasCloudConnector.GetHashCode();
                
                if (this.Approved != null)
                    hash = hash * 59 + this.Approved.GetHashCode();
                
                if (this.Published != null)
                    hash = hash * 59 + this.Published.GetHashCode();
                
                if (this._Protected != null)
                    hash = hash * 59 + this._Protected.GetHashCode();
                
                if (this.InStore != null)
                    hash = hash * 59 + this.InStore.GetHashCode();
                
                if (this.OwnedByCurrentUser != null)
                    hash = hash * 59 + this.OwnedByCurrentUser.GetHashCode();
                
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                
                if (this.Rsp != null)
                    hash = hash * 59 + this.Rsp.GetHashCode();
                
                if (this.IssuerDn != null)
                    hash = hash * 59 + this.IssuerDn.GetHashCode();
                
                if (this.Vid != null)
                    hash = hash * 59 + this.Vid.GetHashCode();
                
                return hash;
            }
        }

    }
}
