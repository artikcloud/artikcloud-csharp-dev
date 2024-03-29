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
    /// Export Data.
    /// </summary>
    [DataContract]
    public partial class ExportData :  IEquatable<ExportData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportData" /> class.
        /// </summary>
        /// <param name="ExpirationDate">ExpirationDate.</param>
        /// <param name="ExportId">ExportId.</param>
        /// <param name="FileSize">FileSize.</param>
        /// <param name="Md5">Md5.</param>
        /// <param name="Request">Request.</param>
        /// <param name="Status">Export status.</param>
        /// <param name="TotalMessages">TotalMessages.</param>
        public ExportData(long? ExpirationDate = null, string ExportId = null, long? FileSize = null, string Md5 = null, ExportRequest Request = null, string Status = null, long? TotalMessages = null)
        {
            this.ExpirationDate = ExpirationDate;
            this.ExportId = ExportId;
            this.FileSize = FileSize;
            this.Md5 = Md5;
            this.Request = Request;
            this.Status = Status;
            this.TotalMessages = TotalMessages;
        }
        
        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public long? ExpirationDate { get; set; }
        /// <summary>
        /// Gets or Sets ExportId
        /// </summary>
        [DataMember(Name="exportId", EmitDefaultValue=false)]
        public string ExportId { get; set; }
        /// <summary>
        /// Gets or Sets FileSize
        /// </summary>
        [DataMember(Name="fileSize", EmitDefaultValue=false)]
        public long? FileSize { get; set; }
        /// <summary>
        /// Gets or Sets Md5
        /// </summary>
        [DataMember(Name="md5", EmitDefaultValue=false)]
        public string Md5 { get; set; }
        /// <summary>
        /// Gets or Sets Request
        /// </summary>
        [DataMember(Name="request", EmitDefaultValue=false)]
        public ExportRequest Request { get; set; }
        /// <summary>
        /// Export status
        /// </summary>
        /// <value>Export status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Gets or Sets TotalMessages
        /// </summary>
        [DataMember(Name="totalMessages", EmitDefaultValue=false)]
        public long? TotalMessages { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportData {\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  ExportId: ").Append(ExportId).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  Md5: ").Append(Md5).Append("\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TotalMessages: ").Append(TotalMessages).Append("\n");
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
            return this.Equals(obj as ExportData);
        }

        /// <summary>
        /// Returns true if ExportData instances are equal
        /// </summary>
        /// <param name="other">Instance of ExportData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ExpirationDate == other.ExpirationDate ||
                    this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(other.ExpirationDate)
                ) && 
                (
                    this.ExportId == other.ExportId ||
                    this.ExportId != null &&
                    this.ExportId.Equals(other.ExportId)
                ) && 
                (
                    this.FileSize == other.FileSize ||
                    this.FileSize != null &&
                    this.FileSize.Equals(other.FileSize)
                ) && 
                (
                    this.Md5 == other.Md5 ||
                    this.Md5 != null &&
                    this.Md5.Equals(other.Md5)
                ) && 
                (
                    this.Request == other.Request ||
                    this.Request != null &&
                    this.Request.Equals(other.Request)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.TotalMessages == other.TotalMessages ||
                    this.TotalMessages != null &&
                    this.TotalMessages.Equals(other.TotalMessages)
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
                if (this.ExpirationDate != null)
                    hash = hash * 59 + this.ExpirationDate.GetHashCode();
                if (this.ExportId != null)
                    hash = hash * 59 + this.ExportId.GetHashCode();
                if (this.FileSize != null)
                    hash = hash * 59 + this.FileSize.GetHashCode();
                if (this.Md5 != null)
                    hash = hash * 59 + this.Md5.GetHashCode();
                if (this.Request != null)
                    hash = hash * 59 + this.Request.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.TotalMessages != null)
                    hash = hash * 59 + this.TotalMessages.GetHashCode();
                return hash;
            }
        }
    }

}
