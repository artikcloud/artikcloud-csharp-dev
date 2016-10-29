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
    public partial class Task :  IEquatable<Task>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        /// <param name="Filter">Filter.</param>
        /// <param name="TaskType">Task type.</param>
        /// <param name="ModifiedOn">Modified on.</param>
        /// <param name="Dtid">Device Type ID.</param>
        /// <param name="StatusCounts">Status counts.</param>
        /// <param name="Property">Property.</param>
        /// <param name="Id">Task ID.</param>
        /// <param name="Dids">Device IDs.</param>
        /// <param name="TaskParameters">Task parameters.</param>
        /// <param name="CreatedOn">Created on.</param>
        /// <param name="Status">Status.</param>
        public Task(string Filter = null, string TaskType = null, long? ModifiedOn = null, string Dtid = null, TaskStatusCounts StatusCounts = null, string Property = null, string Id = null, List<string> Dids = null, TaskParameters TaskParameters = null, long? CreatedOn = null, string Status = null)
        {
            this.Filter = Filter;
            this.TaskType = TaskType;
            this.ModifiedOn = ModifiedOn;
            this.Dtid = Dtid;
            this.StatusCounts = StatusCounts;
            this.Property = Property;
            this.Id = Id;
            this.Dids = Dids;
            this.TaskParameters = TaskParameters;
            this.CreatedOn = CreatedOn;
            this.Status = Status;
        }
        
        /// <summary>
        /// Filter
        /// </summary>
        /// <value>Filter</value>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public string Filter { get; set; }
        /// <summary>
        /// Task type
        /// </summary>
        /// <value>Task type</value>
        [DataMember(Name="taskType", EmitDefaultValue=false)]
        public string TaskType { get; set; }
        /// <summary>
        /// Modified on
        /// </summary>
        /// <value>Modified on</value>
        [DataMember(Name="modifiedOn", EmitDefaultValue=false)]
        public long? ModifiedOn { get; set; }
        /// <summary>
        /// Device Type ID
        /// </summary>
        /// <value>Device Type ID</value>
        [DataMember(Name="dtid", EmitDefaultValue=false)]
        public string Dtid { get; set; }
        /// <summary>
        /// Status counts
        /// </summary>
        /// <value>Status counts</value>
        [DataMember(Name="statusCounts", EmitDefaultValue=false)]
        public TaskStatusCounts StatusCounts { get; set; }
        /// <summary>
        /// Property
        /// </summary>
        /// <value>Property</value>
        [DataMember(Name="property", EmitDefaultValue=false)]
        public string Property { get; set; }
        /// <summary>
        /// Task ID
        /// </summary>
        /// <value>Task ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Device IDs
        /// </summary>
        /// <value>Device IDs</value>
        [DataMember(Name="dids", EmitDefaultValue=false)]
        public List<string> Dids { get; set; }
        /// <summary>
        /// Task parameters
        /// </summary>
        /// <value>Task parameters</value>
        [DataMember(Name="taskParameters", EmitDefaultValue=false)]
        public TaskParameters TaskParameters { get; set; }
        /// <summary>
        /// Created on
        /// </summary>
        /// <value>Created on</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public long? CreatedOn { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        /// <value>Status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Task {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  TaskType: ").Append(TaskType).Append("\n");
            sb.Append("  ModifiedOn: ").Append(ModifiedOn).Append("\n");
            sb.Append("  Dtid: ").Append(Dtid).Append("\n");
            sb.Append("  StatusCounts: ").Append(StatusCounts).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Dids: ").Append(Dids).Append("\n");
            sb.Append("  TaskParameters: ").Append(TaskParameters).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as Task);
        }

        /// <summary>
        /// Returns true if Task instances are equal
        /// </summary>
        /// <param name="other">Instance of Task to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Task other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) && 
                (
                    this.TaskType == other.TaskType ||
                    this.TaskType != null &&
                    this.TaskType.Equals(other.TaskType)
                ) && 
                (
                    this.ModifiedOn == other.ModifiedOn ||
                    this.ModifiedOn != null &&
                    this.ModifiedOn.Equals(other.ModifiedOn)
                ) && 
                (
                    this.Dtid == other.Dtid ||
                    this.Dtid != null &&
                    this.Dtid.Equals(other.Dtid)
                ) && 
                (
                    this.StatusCounts == other.StatusCounts ||
                    this.StatusCounts != null &&
                    this.StatusCounts.Equals(other.StatusCounts)
                ) && 
                (
                    this.Property == other.Property ||
                    this.Property != null &&
                    this.Property.Equals(other.Property)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Dids == other.Dids ||
                    this.Dids != null &&
                    this.Dids.SequenceEqual(other.Dids)
                ) && 
                (
                    this.TaskParameters == other.TaskParameters ||
                    this.TaskParameters != null &&
                    this.TaskParameters.Equals(other.TaskParameters)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();
                if (this.TaskType != null)
                    hash = hash * 59 + this.TaskType.GetHashCode();
                if (this.ModifiedOn != null)
                    hash = hash * 59 + this.ModifiedOn.GetHashCode();
                if (this.Dtid != null)
                    hash = hash * 59 + this.Dtid.GetHashCode();
                if (this.StatusCounts != null)
                    hash = hash * 59 + this.StatusCounts.GetHashCode();
                if (this.Property != null)
                    hash = hash * 59 + this.Property.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Dids != null)
                    hash = hash * 59 + this.Dids.GetHashCode();
                if (this.TaskParameters != null)
                    hash = hash * 59 + this.TaskParameters.GetHashCode();
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                return hash;
            }
        }
    }

}