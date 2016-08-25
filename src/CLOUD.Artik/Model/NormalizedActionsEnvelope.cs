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
    /// Normalized Actions Envelope
    /// </summary>
    [DataContract]
    public partial class NormalizedActionsEnvelope :  IEquatable<NormalizedActionsEnvelope>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NormalizedActionsEnvelope" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NormalizedActionsEnvelope() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NormalizedActionsEnvelope" /> class.
        /// </summary>
        /// <param name="Ddids">Ddids.</param>
        /// <param name="Ddid">Ddid.</param>
        /// <param name="Uid">Uid.</param>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="EndDate">EndDate.</param>
        /// <param name="Order">Order.</param>
        /// <param name="Next">Next.</param>
        /// <param name="Count">Count (required).</param>
        /// <param name="Size">Size (required).</param>
        /// <param name="Data">Data (required).</param>
        public NormalizedActionsEnvelope(string Ddids = null, string Ddid = null, string Uid = null, long? StartDate = null, long? EndDate = null, string Order = null, string Next = null, long? Count = null, long? Size = null, List<NormalizedAction> Data = null)
        {
            // to ensure "Count" is required (not null)
            if (Count == null)
            {
                throw new InvalidDataException("Count is a required property for NormalizedActionsEnvelope and cannot be null");
            }
            else
            {
                this.Count = Count;
            }
            // to ensure "Size" is required (not null)
            if (Size == null)
            {
                throw new InvalidDataException("Size is a required property for NormalizedActionsEnvelope and cannot be null");
            }
            else
            {
                this.Size = Size;
            }
            // to ensure "Data" is required (not null)
            if (Data == null)
            {
                throw new InvalidDataException("Data is a required property for NormalizedActionsEnvelope and cannot be null");
            }
            else
            {
                this.Data = Data;
            }
            this.Ddids = Ddids;
            this.Ddid = Ddid;
            this.Uid = Uid;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Order = Order;
            this.Next = Next;
        }
        
        /// <summary>
        /// Gets or Sets Ddids
        /// </summary>
        [DataMember(Name="ddids", EmitDefaultValue=false)]
        public string Ddids { get; set; }
        /// <summary>
        /// Gets or Sets Ddid
        /// </summary>
        [DataMember(Name="ddid", EmitDefaultValue=false)]
        public string Ddid { get; set; }
        /// <summary>
        /// Gets or Sets Uid
        /// </summary>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public long? StartDate { get; set; }
        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public long? EndDate { get; set; }
        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }
        /// <summary>
        /// Gets or Sets Next
        /// </summary>
        [DataMember(Name="next", EmitDefaultValue=false)]
        public string Next { get; set; }
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }
        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<NormalizedAction> Data { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NormalizedActionsEnvelope {\n");
            sb.Append("  Ddids: ").Append(Ddids).Append("\n");
            sb.Append("  Ddid: ").Append(Ddid).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(obj as NormalizedActionsEnvelope);
        }

        /// <summary>
        /// Returns true if NormalizedActionsEnvelope instances are equal
        /// </summary>
        /// <param name="other">Instance of NormalizedActionsEnvelope to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NormalizedActionsEnvelope other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Ddids == other.Ddids ||
                    this.Ddids != null &&
                    this.Ddids.Equals(other.Ddids)
                ) && 
                (
                    this.Ddid == other.Ddid ||
                    this.Ddid != null &&
                    this.Ddid.Equals(other.Ddid)
                ) && 
                (
                    this.Uid == other.Uid ||
                    this.Uid != null &&
                    this.Uid.Equals(other.Uid)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) && 
                (
                    this.Next == other.Next ||
                    this.Next != null &&
                    this.Next.Equals(other.Next)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) && 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
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
                if (this.Ddids != null)
                    hash = hash * 59 + this.Ddids.GetHashCode();
                if (this.Ddid != null)
                    hash = hash * 59 + this.Ddid.GetHashCode();
                if (this.Uid != null)
                    hash = hash * 59 + this.Uid.GetHashCode();
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                if (this.Next != null)
                    hash = hash * 59 + this.Next.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                return hash;
            }
        }
    }

}
