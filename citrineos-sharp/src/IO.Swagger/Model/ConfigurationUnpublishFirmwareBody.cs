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
    /// ConfigurationUnpublishFirmwareBody
    /// </summary>
    [DataContract]
        public partial class ConfigurationUnpublishFirmwareBody :  IEquatable<ConfigurationUnpublishFirmwareBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationUnpublishFirmwareBody" /> class.
        /// </summary>
        /// <param name="customData">customData.</param>
        /// <param name="checksum">The MD5 checksum over the entire firmware file as a hexadecimal string of length 32.    (required).</param>
        public ConfigurationUnpublishFirmwareBody(CustomDataType customData = default(CustomDataType), string checksum = default(string))
        {
            // to ensure "checksum" is required (not null)
            if (checksum == null)
            {
                throw new InvalidDataException("checksum is a required property for ConfigurationUnpublishFirmwareBody and cannot be null");
            }
            else
            {
                this.Checksum = checksum;
            }
            this.CustomData = customData;
        }
        
        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public CustomDataType CustomData { get; set; }

        /// <summary>
        /// The MD5 checksum over the entire firmware file as a hexadecimal string of length 32.   
        /// </summary>
        /// <value>The MD5 checksum over the entire firmware file as a hexadecimal string of length 32.   </value>
        [DataMember(Name="checksum", EmitDefaultValue=false)]
        public string Checksum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurationUnpublishFirmwareBody {\n");
            sb.Append("  CustomData: ").Append(CustomData).Append("\n");
            sb.Append("  Checksum: ").Append(Checksum).Append("\n");
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
            return this.Equals(input as ConfigurationUnpublishFirmwareBody);
        }

        /// <summary>
        /// Returns true if ConfigurationUnpublishFirmwareBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigurationUnpublishFirmwareBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigurationUnpublishFirmwareBody input)
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
                    this.Checksum == input.Checksum ||
                    (this.Checksum != null &&
                    this.Checksum.Equals(input.Checksum))
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
                if (this.Checksum != null)
                    hashCode = hashCode * 59 + this.Checksum.GetHashCode();
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