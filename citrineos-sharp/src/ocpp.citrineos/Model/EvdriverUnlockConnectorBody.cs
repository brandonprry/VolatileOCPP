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
    /// EvdriverUnlockConnectorBody
    /// </summary>
    [DataContract]
        public partial class EvdriverUnlockConnectorBody :  IEquatable<EvdriverUnlockConnectorBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvdriverUnlockConnectorBody" /> class.
        /// </summary>
        /// <param name="customData">customData.</param>
        /// <param name="evseId">This contains the identifier of the EVSE for which a connector needs to be unlocked.   (required).</param>
        /// <param name="connectorId">This contains the identifier of the connector that needs to be unlocked.   (required).</param>
        public EvdriverUnlockConnectorBody(CustomDataType customData = default(CustomDataType), int? evseId = default(int?), int? connectorId = default(int?))
        {
            // to ensure "evseId" is required (not null)
            if (evseId == null)
            {
                throw new InvalidDataException("evseId is a required property for EvdriverUnlockConnectorBody and cannot be null");
            }
            else
            {
                this.EvseId = evseId;
            }
            // to ensure "connectorId" is required (not null)
            if (connectorId == null)
            {
                throw new InvalidDataException("connectorId is a required property for EvdriverUnlockConnectorBody and cannot be null");
            }
            else
            {
                this.ConnectorId = connectorId;
            }
            this.CustomData = customData;
        }
        
        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public CustomDataType CustomData { get; set; }

        /// <summary>
        /// This contains the identifier of the EVSE for which a connector needs to be unlocked.  
        /// </summary>
        /// <value>This contains the identifier of the EVSE for which a connector needs to be unlocked.  </value>
        [DataMember(Name="evseId", EmitDefaultValue=false)]
        public int? EvseId { get; set; }

        /// <summary>
        /// This contains the identifier of the connector that needs to be unlocked.  
        /// </summary>
        /// <value>This contains the identifier of the connector that needs to be unlocked.  </value>
        [DataMember(Name="connectorId", EmitDefaultValue=false)]
        public int? ConnectorId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvdriverUnlockConnectorBody {\n");
            sb.Append("  CustomData: ").Append(CustomData).Append("\n");
            sb.Append("  EvseId: ").Append(EvseId).Append("\n");
            sb.Append("  ConnectorId: ").Append(ConnectorId).Append("\n");
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
            return this.Equals(input as EvdriverUnlockConnectorBody);
        }

        /// <summary>
        /// Returns true if EvdriverUnlockConnectorBody instances are equal
        /// </summary>
        /// <param name="input">Instance of EvdriverUnlockConnectorBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvdriverUnlockConnectorBody input)
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
                    this.EvseId == input.EvseId ||
                    (this.EvseId != null &&
                    this.EvseId.Equals(input.EvseId))
                ) && 
                (
                    this.ConnectorId == input.ConnectorId ||
                    (this.ConnectorId != null &&
                    this.ConnectorId.Equals(input.ConnectorId))
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
                if (this.EvseId != null)
                    hashCode = hashCode * 59 + this.EvseId.GetHashCode();
                if (this.ConnectorId != null)
                    hashCode = hashCode * 59 + this.ConnectorId.GetHashCode();
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
