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
    /// Export Data Array.
    /// </summary>
    [DataContract]
    public partial class ExportDataArray :  IEquatable<ExportDataArray>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportDataArray" /> class.
        /// Initializes a new instance of the <see cref="ExportDataArray" />class.
        /// </summary>
        /// <param name="Exports">Exports.</param>

        public ExportDataArray(List<ExportData> Exports = null)
        {
            this.Exports = Exports;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Exports
        /// </summary>
        [DataMember(Name="exports", EmitDefaultValue=false)]
        public List<ExportData> Exports { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportDataArray {\n");
            sb.Append("  Exports: ").Append(Exports).Append("\n");
            
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
            return this.Equals(obj as ExportDataArray);
        }

        /// <summary>
        /// Returns true if ExportDataArray instances are equal
        /// </summary>
        /// <param name="other">Instance of ExportDataArray to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportDataArray other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Exports == other.Exports ||
                    this.Exports != null &&
                    this.Exports.SequenceEqual(other.Exports)
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
                
                if (this.Exports != null)
                    hash = hash * 59 + this.Exports.GetHashCode();
                
                return hash;
            }
        }

    }
}
