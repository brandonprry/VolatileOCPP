/* 
 * MaEVe CSMS
 *
 * Internal API to interact with the MaEVe CSMS, external clients should use OCPI.
 *
 * OpenAPI spec version: 0.0.0
 * Contact: maeve-team@thoughtworks.com
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
using SwaggerDateConverter = ocpp.maeve.Client.SwaggerDateConverter;
namespace ocpp.maeve.Model
{
    /// <summary>
    /// Trigger a charge station action
    /// </summary>
    [DataContract]
        public partial class ChargeStationTrigger :  IEquatable<ChargeStationTrigger>, IValidatableObject
    {
        /// <summary>
        /// Defines Trigger
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TriggerEnum
        {
            /// <summary>
            /// Enum BootNotification for value: BootNotification
            /// </summary>
            [EnumMember(Value = "BootNotification")]
            BootNotification = 1,
            /// <summary>
            /// Enum StatusNotification for value: StatusNotification
            /// </summary>
            [EnumMember(Value = "StatusNotification")]
            StatusNotification = 2,
            /// <summary>
            /// Enum SignV2GCertificate for value: SignV2GCertificate
            /// </summary>
            [EnumMember(Value = "SignV2GCertificate")]
            SignV2GCertificate = 3,
            /// <summary>
            /// Enum SignChargingStationCertificate for value: SignChargingStationCertificate
            /// </summary>
            [EnumMember(Value = "SignChargingStationCertificate")]
            SignChargingStationCertificate = 4,
            /// <summary>
            /// Enum SignCombinedCertificate for value: SignCombinedCertificate
            /// </summary>
            [EnumMember(Value = "SignCombinedCertificate")]
            SignCombinedCertificate = 5        }
        /// <summary>
        /// Gets or Sets Trigger
        /// </summary>
        [DataMember(Name="trigger", EmitDefaultValue=false)]
        public TriggerEnum Trigger { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeStationTrigger" /> class.
        /// </summary>
        /// <param name="trigger">trigger (required).</param>
        public ChargeStationTrigger(TriggerEnum trigger = default(TriggerEnum))
        {
            // to ensure "trigger" is required (not null)
            if (trigger == null)
            {
                throw new InvalidDataException("trigger is a required property for ChargeStationTrigger and cannot be null");
            }
            else
            {
                this.Trigger = trigger;
            }
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChargeStationTrigger {\n");
            sb.Append("  Trigger: ").Append(Trigger).Append("\n");
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
            return this.Equals(input as ChargeStationTrigger);
        }

        /// <summary>
        /// Returns true if ChargeStationTrigger instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargeStationTrigger to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeStationTrigger input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Trigger == input.Trigger ||
                    (this.Trigger != null &&
                    this.Trigger.Equals(input.Trigger))
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
                if (this.Trigger != null)
                    hashCode = hashCode * 59 + this.Trigger.GetHashCode();
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