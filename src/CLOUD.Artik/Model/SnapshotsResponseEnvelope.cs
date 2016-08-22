/* 
 * ARTIK Cloud API
 *
 * No descripton provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

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
    public partial class SnapshotsResponseEnvelope :  IEquatable<SnapshotsResponseEnvelope>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotsResponseEnvelope" /> class.
        /// </summary>
        /// <param name="Data">Data.</param>
        /// <param name="Sdid">Sdid.</param>
        public SnapshotsResponseEnvelope(SnapshotResponses Data = null, string Sdid = null)
        {
            this.Data = Data;
            this.Sdid = Sdid;
        }
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public SnapshotResponses Data { get; set; }
        /// <summary>
        /// Gets or Sets Sdid
        /// </summary>
        [DataMember(Name="sdid", EmitDefaultValue=false)]
        public string Sdid { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SnapshotsResponseEnvelope {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Sdid: ").Append(Sdid).Append("\n");
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
            return this.Equals(obj as SnapshotsResponseEnvelope);
        }

        /// <summary>
        /// Returns true if SnapshotsResponseEnvelope instances are equal
        /// </summary>
        /// <param name="other">Instance of SnapshotsResponseEnvelope to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnapshotsResponseEnvelope other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
                ) && 
                (
                    this.Sdid == other.Sdid ||
                    this.Sdid != null &&
                    this.Sdid.Equals(other.Sdid)
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
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                if (this.Sdid != null)
                    hash = hash * 59 + this.Sdid.GetHashCode();
                return hash;
            }
        }
    }

}
