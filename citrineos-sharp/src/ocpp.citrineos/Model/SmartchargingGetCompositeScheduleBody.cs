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
    /// SmartchargingGetCompositeScheduleBody
    /// </summary>
    [DataContract]
        public partial class SmartchargingGetCompositeScheduleBody :  IEquatable<SmartchargingGetCompositeScheduleBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmartchargingGetCompositeScheduleBody" /> class.
        /// </summary>
        /// <param name="customData">customData.</param>
        /// <param name="duration">Length of the requested schedule in seconds.     (required).</param>
        /// <param name="chargingRateUnit">chargingRateUnit.</param>
        /// <param name="evseId">The ID of the EVSE for which the schedule is requested. When evseid&#x3D;0, the Charging Station will calculate the expected consumption for the grid connection.   (required).</param>
        public SmartchargingGetCompositeScheduleBody(CustomDataType customData = default(CustomDataType), int? duration = default(int?), ChargingRateUnitEnumType chargingRateUnit = default(ChargingRateUnitEnumType), int? evseId = default(int?))
        {
            // to ensure "duration" is required (not null)
            if (duration == null)
            {
                throw new InvalidDataException("duration is a required property for SmartchargingGetCompositeScheduleBody and cannot be null");
            }
            else
            {
                this.Duration = duration;
            }
            // to ensure "evseId" is required (not null)
            if (evseId == null)
            {
                throw new InvalidDataException("evseId is a required property for SmartchargingGetCompositeScheduleBody and cannot be null");
            }
            else
            {
                this.EvseId = evseId;
            }
            this.CustomData = customData;
            this.ChargingRateUnit = chargingRateUnit;
        }
        
        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public CustomDataType CustomData { get; set; }

        /// <summary>
        /// Length of the requested schedule in seconds.    
        /// </summary>
        /// <value>Length of the requested schedule in seconds.    </value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// Gets or Sets ChargingRateUnit
        /// </summary>
        [DataMember(Name="chargingRateUnit", EmitDefaultValue=false)]
        public ChargingRateUnitEnumType ChargingRateUnit { get; set; }

        /// <summary>
        /// The ID of the EVSE for which the schedule is requested. When evseid&#x3D;0, the Charging Station will calculate the expected consumption for the grid connection.  
        /// </summary>
        /// <value>The ID of the EVSE for which the schedule is requested. When evseid&#x3D;0, the Charging Station will calculate the expected consumption for the grid connection.  </value>
        [DataMember(Name="evseId", EmitDefaultValue=false)]
        public int? EvseId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartchargingGetCompositeScheduleBody {\n");
            sb.Append("  CustomData: ").Append(CustomData).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  ChargingRateUnit: ").Append(ChargingRateUnit).Append("\n");
            sb.Append("  EvseId: ").Append(EvseId).Append("\n");
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
            return this.Equals(input as SmartchargingGetCompositeScheduleBody);
        }

        /// <summary>
        /// Returns true if SmartchargingGetCompositeScheduleBody instances are equal
        /// </summary>
        /// <param name="input">Instance of SmartchargingGetCompositeScheduleBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmartchargingGetCompositeScheduleBody input)
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
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.ChargingRateUnit == input.ChargingRateUnit ||
                    (this.ChargingRateUnit != null &&
                    this.ChargingRateUnit.Equals(input.ChargingRateUnit))
                ) && 
                (
                    this.EvseId == input.EvseId ||
                    (this.EvseId != null &&
                    this.EvseId.Equals(input.EvseId))
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
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.ChargingRateUnit != null)
                    hashCode = hashCode * 59 + this.ChargingRateUnit.GetHashCode();
                if (this.EvseId != null)
                    hashCode = hashCode * 59 + this.EvseId.GetHashCode();
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