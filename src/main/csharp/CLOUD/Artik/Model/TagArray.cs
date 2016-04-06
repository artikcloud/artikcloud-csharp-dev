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
    /// Contains the arry of Tags.
    /// </summary>
    [DataContract]
    public partial class TagArray :  IEquatable<TagArray>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TagArray" /> class.
        /// Initializes a new instance of the <see cref="TagArray" />class.
        /// </summary>
        /// <param name="Tags">Tags.</param>

        public TagArray(List<Tag> Tags = null)
        {
            this.Tags = Tags;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<Tag> Tags { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagArray {\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            
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
            return this.Equals(obj as TagArray);
        }

        /// <summary>
        /// Returns true if TagArray instances are equal
        /// </summary>
        /// <param name="other">Instance of TagArray to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagArray other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
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
                
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                
                return hash;
            }
        }

    }
}
