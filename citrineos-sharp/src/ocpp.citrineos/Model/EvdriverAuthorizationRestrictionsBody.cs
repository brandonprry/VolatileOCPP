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
    /// EvdriverAuthorizationRestrictionsBody
    /// </summary>
    [DataContract]
        public partial class EvdriverAuthorizationRestrictionsBody :  IEquatable<EvdriverAuthorizationRestrictionsBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvdriverAuthorizationRestrictionsBody" /> class.
        /// </summary>
        /// <param name="allowedConnectorTypes">allowedConnectorTypes.</param>
        /// <param name="disallowedEvseIdPrefixes">disallowedEvseIdPrefixes.</param>
        public EvdriverAuthorizationRestrictionsBody(List<string> allowedConnectorTypes = default(List<string>), List<string> disallowedEvseIdPrefixes = default(List<string>))
        {
            this.AllowedConnectorTypes = allowedConnectorTypes;
            this.DisallowedEvseIdPrefixes = disallowedEvseIdPrefixes;
        }
        
        /// <summary>
        /// Gets or Sets AllowedConnectorTypes
        /// </summary>
        [DataMember(Name="allowedConnectorTypes", EmitDefaultValue=false)]
        public List<string> AllowedConnectorTypes { get; set; }

        /// <summary>
        /// Gets or Sets DisallowedEvseIdPrefixes
        /// </summary>
        [DataMember(Name="disallowedEvseIdPrefixes", EmitDefaultValue=false)]
        public List<string> DisallowedEvseIdPrefixes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvdriverAuthorizationRestrictionsBody {\n");
            sb.Append("  AllowedConnectorTypes: ").Append(AllowedConnectorTypes).Append("\n");
            sb.Append("  DisallowedEvseIdPrefixes: ").Append(DisallowedEvseIdPrefixes).Append("\n");
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
            return this.Equals(input as EvdriverAuthorizationRestrictionsBody);
        }

        /// <summary>
        /// Returns true if EvdriverAuthorizationRestrictionsBody instances are equal
        /// </summary>
        /// <param name="input">Instance of EvdriverAuthorizationRestrictionsBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvdriverAuthorizationRestrictionsBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowedConnectorTypes == input.AllowedConnectorTypes ||
                    this.AllowedConnectorTypes != null &&
                    input.AllowedConnectorTypes != null &&
                    this.AllowedConnectorTypes.SequenceEqual(input.AllowedConnectorTypes)
                ) && 
                (
                    this.DisallowedEvseIdPrefixes == input.DisallowedEvseIdPrefixes ||
                    this.DisallowedEvseIdPrefixes != null &&
                    input.DisallowedEvseIdPrefixes != null &&
                    this.DisallowedEvseIdPrefixes.SequenceEqual(input.DisallowedEvseIdPrefixes)
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
                if (this.AllowedConnectorTypes != null)
                    hashCode = hashCode * 59 + this.AllowedConnectorTypes.GetHashCode();
                if (this.DisallowedEvseIdPrefixes != null)
                    hashCode = hashCode * 59 + this.DisallowedEvseIdPrefixes.GetHashCode();
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
