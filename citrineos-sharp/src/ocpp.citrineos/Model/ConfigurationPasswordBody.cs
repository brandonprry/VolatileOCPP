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
    /// ConfigurationPasswordBody
    /// </summary>
    [DataContract]
        public partial class ConfigurationPasswordBody :  IEquatable<ConfigurationPasswordBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationPasswordBody" /> class.
        /// </summary>
        /// <param name="stationId">stationId (required).</param>
        /// <param name="password">password.</param>
        /// <param name="setOnCharger">setOnCharger (default to false).</param>
        public ConfigurationPasswordBody(string stationId = default(string), string password = default(string), bool? setOnCharger = false)
        {
            // to ensure "stationId" is required (not null)
            if (stationId == null)
            {
                throw new InvalidDataException("stationId is a required property for ConfigurationPasswordBody and cannot be null");
            }
            else
            {
                this.StationId = stationId;
            }
            this.Password = password;
            // use default value if no "setOnCharger" provided
            if (setOnCharger == null)
            {
                this.SetOnCharger = false;
            }
            else
            {
                this.SetOnCharger = setOnCharger;
            }
        }
        
        /// <summary>
        /// Gets or Sets StationId
        /// </summary>
        [DataMember(Name="stationId", EmitDefaultValue=false)]
        public string StationId { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets SetOnCharger
        /// </summary>
        [DataMember(Name="setOnCharger", EmitDefaultValue=false)]
        public bool? SetOnCharger { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurationPasswordBody {\n");
            sb.Append("  StationId: ").Append(StationId).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  SetOnCharger: ").Append(SetOnCharger).Append("\n");
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
            return this.Equals(input as ConfigurationPasswordBody);
        }

        /// <summary>
        /// Returns true if ConfigurationPasswordBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigurationPasswordBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigurationPasswordBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StationId == input.StationId ||
                    (this.StationId != null &&
                    this.StationId.Equals(input.StationId))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.SetOnCharger == input.SetOnCharger ||
                    (this.SetOnCharger != null &&
                    this.SetOnCharger.Equals(input.SetOnCharger))
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
                if (this.StationId != null)
                    hashCode = hashCode * 59 + this.StationId.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.SetOnCharger != null)
                    hashCode = hashCode * 59 + this.SetOnCharger.GetHashCode();
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
