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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;
namespace IO.Swagger.Model
{
    /// <summary>
    /// SmartchargingGetChargingProfilesBody
    /// </summary>
    [DataContract]
        public partial class SmartchargingGetChargingProfilesBody :  IEquatable<SmartchargingGetChargingProfilesBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmartchargingGetChargingProfilesBody" /> class.
        /// </summary>
        /// <param name="customData">customData.</param>
        /// <param name="requestId">Reference identification that is to be used by the Charging Station in the &amp;lt;&amp;lt;reportchargingprofilesrequest, ReportChargingProfilesRequest&amp;gt;&amp;gt; when provided.   (required).</param>
        /// <param name="evseId">For which EVSE installed charging profiles SHALL be reported. If 0, only charging profiles installed on the Charging Station itself (the grid connection) SHALL be reported. If omitted, all installed charging profiles SHALL be reported.  .</param>
        /// <param name="chargingProfile">chargingProfile (required).</param>
        public SmartchargingGetChargingProfilesBody(CustomDataType customData = default(CustomDataType), int? requestId = default(int?), int? evseId = default(int?), ChargingProfileCriterionType chargingProfile = default(ChargingProfileCriterionType))
        {
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new InvalidDataException("requestId is a required property for SmartchargingGetChargingProfilesBody and cannot be null");
            }
            else
            {
                this.RequestId = requestId;
            }
            // to ensure "chargingProfile" is required (not null)
            if (chargingProfile == null)
            {
                throw new InvalidDataException("chargingProfile is a required property for SmartchargingGetChargingProfilesBody and cannot be null");
            }
            else
            {
                this.ChargingProfile = chargingProfile;
            }
            this.CustomData = customData;
            this.EvseId = evseId;
        }
        
        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public CustomDataType CustomData { get; set; }

        /// <summary>
        /// Reference identification that is to be used by the Charging Station in the &amp;lt;&amp;lt;reportchargingprofilesrequest, ReportChargingProfilesRequest&amp;gt;&amp;gt; when provided.  
        /// </summary>
        /// <value>Reference identification that is to be used by the Charging Station in the &amp;lt;&amp;lt;reportchargingprofilesrequest, ReportChargingProfilesRequest&amp;gt;&amp;gt; when provided.  </value>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public int? RequestId { get; set; }

        /// <summary>
        /// For which EVSE installed charging profiles SHALL be reported. If 0, only charging profiles installed on the Charging Station itself (the grid connection) SHALL be reported. If omitted, all installed charging profiles SHALL be reported.  
        /// </summary>
        /// <value>For which EVSE installed charging profiles SHALL be reported. If 0, only charging profiles installed on the Charging Station itself (the grid connection) SHALL be reported. If omitted, all installed charging profiles SHALL be reported.  </value>
        [DataMember(Name="evseId", EmitDefaultValue=false)]
        public int? EvseId { get; set; }

        /// <summary>
        /// Gets or Sets ChargingProfile
        /// </summary>
        [DataMember(Name="chargingProfile", EmitDefaultValue=false)]
        public ChargingProfileCriterionType ChargingProfile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartchargingGetChargingProfilesBody {\n");
            sb.Append("  CustomData: ").Append(CustomData).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  EvseId: ").Append(EvseId).Append("\n");
            sb.Append("  ChargingProfile: ").Append(ChargingProfile).Append("\n");
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
            return this.Equals(input as SmartchargingGetChargingProfilesBody);
        }

        /// <summary>
        /// Returns true if SmartchargingGetChargingProfilesBody instances are equal
        /// </summary>
        /// <param name="input">Instance of SmartchargingGetChargingProfilesBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmartchargingGetChargingProfilesBody input)
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
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.EvseId == input.EvseId ||
                    (this.EvseId != null &&
                    this.EvseId.Equals(input.EvseId))
                ) && 
                (
                    this.ChargingProfile == input.ChargingProfile ||
                    (this.ChargingProfile != null &&
                    this.ChargingProfile.Equals(input.ChargingProfile))
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.EvseId != null)
                    hashCode = hashCode * 59 + this.EvseId.GetHashCode();
                if (this.ChargingProfile != null)
                    hashCode = hashCode * 59 + this.ChargingProfile.GetHashCode();
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