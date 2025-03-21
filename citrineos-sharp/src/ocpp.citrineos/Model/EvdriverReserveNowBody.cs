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
    /// EvdriverReserveNowBody
    /// </summary>
    [DataContract]
        public partial class EvdriverReserveNowBody :  IEquatable<EvdriverReserveNowBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvdriverReserveNowBody" /> class.
        /// </summary>
        /// <param name="customData">customData.</param>
        /// <param name="id">Id of reservation.   (required).</param>
        /// <param name="expiryDateTime">Date and time at which the reservation expires.   (required).</param>
        /// <param name="connectorType">connectorType.</param>
        /// <param name="idToken">idToken (required).</param>
        /// <param name="evseId">This contains ID of the evse to be reserved.  .</param>
        /// <param name="groupIdToken">groupIdToken.</param>
        public EvdriverReserveNowBody(CustomDataType customData = default(CustomDataType), int? id = default(int?), DateTime? expiryDateTime = default(DateTime?), ConnectorEnumType connectorType = default(ConnectorEnumType), IdTokenType idToken = default(IdTokenType), int? evseId = default(int?), IdTokenType groupIdToken = default(IdTokenType))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for EvdriverReserveNowBody and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "expiryDateTime" is required (not null)
            if (expiryDateTime == null)
            {
                throw new InvalidDataException("expiryDateTime is a required property for EvdriverReserveNowBody and cannot be null");
            }
            else
            {
                this.ExpiryDateTime = expiryDateTime;
            }
            // to ensure "idToken" is required (not null)
            if (idToken == null)
            {
                throw new InvalidDataException("idToken is a required property for EvdriverReserveNowBody and cannot be null");
            }
            else
            {
                this.IdToken = idToken;
            }
            this.CustomData = customData;
            this.ConnectorType = connectorType;
            this.EvseId = evseId;
            this.GroupIdToken = groupIdToken;
        }
        
        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public CustomDataType CustomData { get; set; }

        /// <summary>
        /// Id of reservation.  
        /// </summary>
        /// <value>Id of reservation.  </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Date and time at which the reservation expires.  
        /// </summary>
        /// <value>Date and time at which the reservation expires.  </value>
        [DataMember(Name="expiryDateTime", EmitDefaultValue=false)]
        public DateTime? ExpiryDateTime { get; set; }

        /// <summary>
        /// Gets or Sets ConnectorType
        /// </summary>
        [DataMember(Name="connectorType", EmitDefaultValue=false)]
        public ConnectorEnumType ConnectorType { get; set; }

        /// <summary>
        /// Gets or Sets IdToken
        /// </summary>
        [DataMember(Name="idToken", EmitDefaultValue=false)]
        public IdTokenType IdToken { get; set; }

        /// <summary>
        /// This contains ID of the evse to be reserved.  
        /// </summary>
        /// <value>This contains ID of the evse to be reserved.  </value>
        [DataMember(Name="evseId", EmitDefaultValue=false)]
        public int? EvseId { get; set; }

        /// <summary>
        /// Gets or Sets GroupIdToken
        /// </summary>
        [DataMember(Name="groupIdToken", EmitDefaultValue=false)]
        public IdTokenType GroupIdToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvdriverReserveNowBody {\n");
            sb.Append("  CustomData: ").Append(CustomData).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExpiryDateTime: ").Append(ExpiryDateTime).Append("\n");
            sb.Append("  ConnectorType: ").Append(ConnectorType).Append("\n");
            sb.Append("  IdToken: ").Append(IdToken).Append("\n");
            sb.Append("  EvseId: ").Append(EvseId).Append("\n");
            sb.Append("  GroupIdToken: ").Append(GroupIdToken).Append("\n");
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
            return this.Equals(input as EvdriverReserveNowBody);
        }

        /// <summary>
        /// Returns true if EvdriverReserveNowBody instances are equal
        /// </summary>
        /// <param name="input">Instance of EvdriverReserveNowBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvdriverReserveNowBody input)
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
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ExpiryDateTime == input.ExpiryDateTime ||
                    (this.ExpiryDateTime != null &&
                    this.ExpiryDateTime.Equals(input.ExpiryDateTime))
                ) && 
                (
                    this.ConnectorType == input.ConnectorType ||
                    (this.ConnectorType != null &&
                    this.ConnectorType.Equals(input.ConnectorType))
                ) && 
                (
                    this.IdToken == input.IdToken ||
                    (this.IdToken != null &&
                    this.IdToken.Equals(input.IdToken))
                ) && 
                (
                    this.EvseId == input.EvseId ||
                    (this.EvseId != null &&
                    this.EvseId.Equals(input.EvseId))
                ) && 
                (
                    this.GroupIdToken == input.GroupIdToken ||
                    (this.GroupIdToken != null &&
                    this.GroupIdToken.Equals(input.GroupIdToken))
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
                if (this.ExpiryDateTime != null)
                    hashCode = hashCode * 59 + this.ExpiryDateTime.GetHashCode();
                if (this.ConnectorType != null)
                    hashCode = hashCode * 59 + this.ConnectorType.GetHashCode();
                if (this.IdToken != null)
                    hashCode = hashCode * 59 + this.IdToken.GetHashCode();
                if (this.EvseId != null)
                    hashCode = hashCode * 59 + this.EvseId.GetHashCode();
                if (this.GroupIdToken != null)
                    hashCode = hashCode * 59 + this.GroupIdToken.GetHashCode();
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
