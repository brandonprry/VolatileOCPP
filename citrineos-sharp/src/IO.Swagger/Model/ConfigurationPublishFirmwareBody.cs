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
    /// ConfigurationPublishFirmwareBody
    /// </summary>
    [DataContract]
        public partial class ConfigurationPublishFirmwareBody :  IEquatable<ConfigurationPublishFirmwareBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationPublishFirmwareBody" /> class.
        /// </summary>
        /// <param name="customData">customData.</param>
        /// <param name="location">This contains a string containing a URI pointing to a  location from which to retrieve the firmware.   (required).</param>
        /// <param name="retries">This specifies how many times Charging Station must try  to download the firmware before giving up. If this field is not  present, it is left to Charging Station to decide how many times it wants to retry.  .</param>
        /// <param name="checksum">The MD5 checksum over the entire firmware file as a hexadecimal string of length 32.    (required).</param>
        /// <param name="requestId">The Id of the request.   (required).</param>
        /// <param name="retryInterval">The interval in seconds  after which a retry may be  attempted. If this field is not  present, it is left to Charging  Station to decide how long to wait  between attempts.  .</param>
        public ConfigurationPublishFirmwareBody(CustomDataType customData = default(CustomDataType), string location = default(string), int? retries = default(int?), string checksum = default(string), int? requestId = default(int?), int? retryInterval = default(int?))
        {
            // to ensure "location" is required (not null)
            if (location == null)
            {
                throw new InvalidDataException("location is a required property for ConfigurationPublishFirmwareBody and cannot be null");
            }
            else
            {
                this.Location = location;
            }
            // to ensure "checksum" is required (not null)
            if (checksum == null)
            {
                throw new InvalidDataException("checksum is a required property for ConfigurationPublishFirmwareBody and cannot be null");
            }
            else
            {
                this.Checksum = checksum;
            }
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new InvalidDataException("requestId is a required property for ConfigurationPublishFirmwareBody and cannot be null");
            }
            else
            {
                this.RequestId = requestId;
            }
            this.CustomData = customData;
            this.Retries = retries;
            this.RetryInterval = retryInterval;
        }
        
        /// <summary>
        /// Gets or Sets CustomData
        /// </summary>
        [DataMember(Name="customData", EmitDefaultValue=false)]
        public CustomDataType CustomData { get; set; }

        /// <summary>
        /// This contains a string containing a URI pointing to a  location from which to retrieve the firmware.  
        /// </summary>
        /// <value>This contains a string containing a URI pointing to a  location from which to retrieve the firmware.  </value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// This specifies how many times Charging Station must try  to download the firmware before giving up. If this field is not  present, it is left to Charging Station to decide how many times it wants to retry.  
        /// </summary>
        /// <value>This specifies how many times Charging Station must try  to download the firmware before giving up. If this field is not  present, it is left to Charging Station to decide how many times it wants to retry.  </value>
        [DataMember(Name="retries", EmitDefaultValue=false)]
        public int? Retries { get; set; }

        /// <summary>
        /// The MD5 checksum over the entire firmware file as a hexadecimal string of length 32.   
        /// </summary>
        /// <value>The MD5 checksum over the entire firmware file as a hexadecimal string of length 32.   </value>
        [DataMember(Name="checksum", EmitDefaultValue=false)]
        public string Checksum { get; set; }

        /// <summary>
        /// The Id of the request.  
        /// </summary>
        /// <value>The Id of the request.  </value>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public int? RequestId { get; set; }

        /// <summary>
        /// The interval in seconds  after which a retry may be  attempted. If this field is not  present, it is left to Charging  Station to decide how long to wait  between attempts.  
        /// </summary>
        /// <value>The interval in seconds  after which a retry may be  attempted. If this field is not  present, it is left to Charging  Station to decide how long to wait  between attempts.  </value>
        [DataMember(Name="retryInterval", EmitDefaultValue=false)]
        public int? RetryInterval { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurationPublishFirmwareBody {\n");
            sb.Append("  CustomData: ").Append(CustomData).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Retries: ").Append(Retries).Append("\n");
            sb.Append("  Checksum: ").Append(Checksum).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  RetryInterval: ").Append(RetryInterval).Append("\n");
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
            return this.Equals(input as ConfigurationPublishFirmwareBody);
        }

        /// <summary>
        /// Returns true if ConfigurationPublishFirmwareBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigurationPublishFirmwareBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigurationPublishFirmwareBody input)
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
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Retries == input.Retries ||
                    (this.Retries != null &&
                    this.Retries.Equals(input.Retries))
                ) && 
                (
                    this.Checksum == input.Checksum ||
                    (this.Checksum != null &&
                    this.Checksum.Equals(input.Checksum))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.RetryInterval == input.RetryInterval ||
                    (this.RetryInterval != null &&
                    this.RetryInterval.Equals(input.RetryInterval))
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
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Retries != null)
                    hashCode = hashCode * 59 + this.Retries.GetHashCode();
                if (this.Checksum != null)
                    hashCode = hashCode * 59 + this.Checksum.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.RetryInterval != null)
                    hashCode = hashCode * 59 + this.RetryInterval.GetHashCode();
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