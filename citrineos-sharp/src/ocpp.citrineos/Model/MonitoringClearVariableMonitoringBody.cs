/* 
 * CitrineOS Central System API
 *
 * Central System API for OCPP 2.0.1 messaging.
 *
 * OpenAPI spec version: 1.4.3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = ocpp.citrineos.Client.SwaggerDateConverter;
namespace ocpp.citrineos.Model
{
    /// <summary>
    /// MonitoringClearVariableMonitoringBody
    /// </summary>
    [DataContract]
        public partial class MonitoringClearVariableMonitoringBody :  IEquatable<MonitoringClearVariableMonitoringBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonitoringClearVariableMonitoringBody" /> class.
        /// </summary>
        /// <param name="customData">customData.</param>
        /// <param name="id">List of the monitors to be cleared, identified by there Id.   (required).</param>
        public MonitoringClearVariableMonitoringBody(CustomDataType customData = default(CustomDataType), List<int?> id = default(List<int?>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for MonitoringClearVariableMonitoringBody and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            this.CustomData = customData;
        }
        
        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public CustomDataType CustomData { get; set; }

        /// <summary>
        /// List of the monitors to be cleared, identified by there Id.  
        /// </summary>
        /// <value>List of the monitors to be cleared, identified by there Id.  </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public List<int?> Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MonitoringClearVariableMonitoringBody {\n");
            sb.Append("  CustomData: ").Append(CustomData).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MonitoringClearVariableMonitoringBody);
        }

        /// <summary>
        /// Returns true if MonitoringClearVariableMonitoringBody instances are equal
        /// </summary>
        /// <param name="input">Instance of MonitoringClearVariableMonitoringBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MonitoringClearVariableMonitoringBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomData == input.CustomData ||
                    (this.CustomData != null &&
                    this.CustomData.Equals(input.CustomData))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id != null &&
                    input.Id != null &&
                    this.Id.SequenceEqual(input.Id)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CustomData != null)
                    hashCode = hashCode * 59 + this.CustomData.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}