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
    /// Rule Error.
    /// </summary>
    [DataContract]
    public partial class RuleError :  IEquatable<RuleError>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleError" /> class.
        /// Initializes a new instance of the <see cref="RuleError" />class.
        /// </summary>
        /// <param name="ErrorCode">ErrorCode.</param>
        /// <param name="FieldPath">FieldPath.</param>
        /// <param name="MessageArgs">MessageArgs.</param>
        /// <param name="MessageKey">MessageKey.</param>

        public RuleError(int? ErrorCode = null, FieldPath FieldPath = null, List<string> MessageArgs = null, string MessageKey = null)
        {
            this.ErrorCode = ErrorCode;
            this.FieldPath = FieldPath;
            this.MessageArgs = MessageArgs;
            this.MessageKey = MessageKey;
            
        }
        
    
        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public int? ErrorCode { get; set; }
    
        /// <summary>
        /// Gets or Sets FieldPath
        /// </summary>
        [DataMember(Name="fieldPath", EmitDefaultValue=false)]
        public FieldPath FieldPath { get; set; }
    
        /// <summary>
        /// Gets or Sets MessageArgs
        /// </summary>
        [DataMember(Name="messageArgs", EmitDefaultValue=false)]
        public List<string> MessageArgs { get; set; }
    
        /// <summary>
        /// Gets or Sets MessageKey
        /// </summary>
        [DataMember(Name="messageKey", EmitDefaultValue=false)]
        public string MessageKey { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleError {\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  FieldPath: ").Append(FieldPath).Append("\n");
            sb.Append("  MessageArgs: ").Append(MessageArgs).Append("\n");
            sb.Append("  MessageKey: ").Append(MessageKey).Append("\n");
            
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
            return this.Equals(obj as RuleError);
        }

        /// <summary>
        /// Returns true if RuleError instances are equal
        /// </summary>
        /// <param name="other">Instance of RuleError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleError other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) && 
                (
                    this.FieldPath == other.FieldPath ||
                    this.FieldPath != null &&
                    this.FieldPath.Equals(other.FieldPath)
                ) && 
                (
                    this.MessageArgs == other.MessageArgs ||
                    this.MessageArgs != null &&
                    this.MessageArgs.SequenceEqual(other.MessageArgs)
                ) && 
                (
                    this.MessageKey == other.MessageKey ||
                    this.MessageKey != null &&
                    this.MessageKey.Equals(other.MessageKey)
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
                
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();
                
                if (this.FieldPath != null)
                    hash = hash * 59 + this.FieldPath.GetHashCode();
                
                if (this.MessageArgs != null)
                    hash = hash * 59 + this.MessageArgs.GetHashCode();
                
                if (this.MessageKey != null)
                    hash = hash * 59 + this.MessageKey.GetHashCode();
                
                return hash;
            }
        }

    }
}
