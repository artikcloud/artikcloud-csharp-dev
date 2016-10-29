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
    public partial class TaskStatusCounts :  IEquatable<TaskStatusCounts>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskStatusCounts" /> class.
        /// </summary>
        /// <param name="NumFailed">Number failed.</param>
        /// <param name="NumCancelled">Number cancelled.</param>
        /// <param name="TotalDevices">Total devices.</param>
        /// <param name="NumCompleted">Number completed.</param>
        /// <param name="NumSucceeded">Number succeeded.</param>
        public TaskStatusCounts(int? NumFailed = null, int? NumCancelled = null, int? TotalDevices = null, int? NumCompleted = null, int? NumSucceeded = null)
        {
            this.NumFailed = NumFailed;
            this.NumCancelled = NumCancelled;
            this.TotalDevices = TotalDevices;
            this.NumCompleted = NumCompleted;
            this.NumSucceeded = NumSucceeded;
        }
        
        /// <summary>
        /// Number failed
        /// </summary>
        /// <value>Number failed</value>
        [DataMember(Name="numFailed", EmitDefaultValue=false)]
        public int? NumFailed { get; set; }
        /// <summary>
        /// Number cancelled
        /// </summary>
        /// <value>Number cancelled</value>
        [DataMember(Name="numCancelled", EmitDefaultValue=false)]
        public int? NumCancelled { get; set; }
        /// <summary>
        /// Total devices
        /// </summary>
        /// <value>Total devices</value>
        [DataMember(Name="totalDevices", EmitDefaultValue=false)]
        public int? TotalDevices { get; set; }
        /// <summary>
        /// Number completed
        /// </summary>
        /// <value>Number completed</value>
        [DataMember(Name="numCompleted", EmitDefaultValue=false)]
        public int? NumCompleted { get; set; }
        /// <summary>
        /// Number succeeded
        /// </summary>
        /// <value>Number succeeded</value>
        [DataMember(Name="numSucceeded", EmitDefaultValue=false)]
        public int? NumSucceeded { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskStatusCounts {\n");
            sb.Append("  NumFailed: ").Append(NumFailed).Append("\n");
            sb.Append("  NumCancelled: ").Append(NumCancelled).Append("\n");
            sb.Append("  TotalDevices: ").Append(TotalDevices).Append("\n");
            sb.Append("  NumCompleted: ").Append(NumCompleted).Append("\n");
            sb.Append("  NumSucceeded: ").Append(NumSucceeded).Append("\n");
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
            return this.Equals(obj as TaskStatusCounts);
        }

        /// <summary>
        /// Returns true if TaskStatusCounts instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskStatusCounts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskStatusCounts other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NumFailed == other.NumFailed ||
                    this.NumFailed != null &&
                    this.NumFailed.Equals(other.NumFailed)
                ) && 
                (
                    this.NumCancelled == other.NumCancelled ||
                    this.NumCancelled != null &&
                    this.NumCancelled.Equals(other.NumCancelled)
                ) && 
                (
                    this.TotalDevices == other.TotalDevices ||
                    this.TotalDevices != null &&
                    this.TotalDevices.Equals(other.TotalDevices)
                ) && 
                (
                    this.NumCompleted == other.NumCompleted ||
                    this.NumCompleted != null &&
                    this.NumCompleted.Equals(other.NumCompleted)
                ) && 
                (
                    this.NumSucceeded == other.NumSucceeded ||
                    this.NumSucceeded != null &&
                    this.NumSucceeded.Equals(other.NumSucceeded)
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
                if (this.NumFailed != null)
                    hash = hash * 59 + this.NumFailed.GetHashCode();
                if (this.NumCancelled != null)
                    hash = hash * 59 + this.NumCancelled.GetHashCode();
                if (this.TotalDevices != null)
                    hash = hash * 59 + this.TotalDevices.GetHashCode();
                if (this.NumCompleted != null)
                    hash = hash * 59 + this.NumCompleted.GetHashCode();
                if (this.NumSucceeded != null)
                    hash = hash * 59 + this.NumSucceeded.GetHashCode();
                return hash;
            }
        }
    }

}
