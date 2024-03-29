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
    /// Export Request.
    /// </summary>
    [DataContract]
    public partial class ExportRequest :  IEquatable<ExportRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportRequest" /> class.
        /// </summary>
        /// <param name="EndDate">EndDate.</param>
        /// <param name="Format">Format.</param>
        /// <param name="Order">Order.</param>
        /// <param name="Sdids">Sdids.</param>
        /// <param name="Sdtids">Sdtids.</param>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="TrialId">TrialId.</param>
        /// <param name="Uids">Uids.</param>
        public ExportRequest(long? EndDate = null, string Format = null, string Order = null, string Sdids = null, string Sdtids = null, long? StartDate = null, string TrialId = null, string Uids = null)
        {
            this.EndDate = EndDate;
            this.Format = Format;
            this.Order = Order;
            this.Sdids = Sdids;
            this.Sdtids = Sdtids;
            this.StartDate = StartDate;
            this.TrialId = TrialId;
            this.Uids = Uids;
        }
        
        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public long? EndDate { get; set; }
        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }
        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }
        /// <summary>
        /// Gets or Sets Sdids
        /// </summary>
        [DataMember(Name="sdids", EmitDefaultValue=false)]
        public string Sdids { get; set; }
        /// <summary>
        /// Gets or Sets Sdtids
        /// </summary>
        [DataMember(Name="sdtids", EmitDefaultValue=false)]
        public string Sdtids { get; set; }
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public long? StartDate { get; set; }
        /// <summary>
        /// Gets or Sets TrialId
        /// </summary>
        [DataMember(Name="trialId", EmitDefaultValue=false)]
        public string TrialId { get; set; }
        /// <summary>
        /// Gets or Sets Uids
        /// </summary>
        [DataMember(Name="uids", EmitDefaultValue=false)]
        public string Uids { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportRequest {\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Sdids: ").Append(Sdids).Append("\n");
            sb.Append("  Sdtids: ").Append(Sdtids).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  TrialId: ").Append(TrialId).Append("\n");
            sb.Append("  Uids: ").Append(Uids).Append("\n");
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
            return this.Equals(obj as ExportRequest);
        }

        /// <summary>
        /// Returns true if ExportRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ExportRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.Format == other.Format ||
                    this.Format != null &&
                    this.Format.Equals(other.Format)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) && 
                (
                    this.Sdids == other.Sdids ||
                    this.Sdids != null &&
                    this.Sdids.Equals(other.Sdids)
                ) && 
                (
                    this.Sdtids == other.Sdtids ||
                    this.Sdtids != null &&
                    this.Sdtids.Equals(other.Sdtids)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.TrialId == other.TrialId ||
                    this.TrialId != null &&
                    this.TrialId.Equals(other.TrialId)
                ) && 
                (
                    this.Uids == other.Uids ||
                    this.Uids != null &&
                    this.Uids.Equals(other.Uids)
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
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                if (this.Format != null)
                    hash = hash * 59 + this.Format.GetHashCode();
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                if (this.Sdids != null)
                    hash = hash * 59 + this.Sdids.GetHashCode();
                if (this.Sdtids != null)
                    hash = hash * 59 + this.Sdtids.GetHashCode();
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.TrialId != null)
                    hash = hash * 59 + this.TrialId.GetHashCode();
                if (this.Uids != null)
                    hash = hash * 59 + this.Uids.GetHashCode();
                return hash;
            }
        }
    }

}
