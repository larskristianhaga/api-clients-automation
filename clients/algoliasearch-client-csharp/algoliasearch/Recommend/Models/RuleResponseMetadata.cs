//
// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Algolia.Search.Recommend.Client.FileParameter;
using OpenAPIDateConverter = Algolia.Search.Recommend.Client.OpenAPIDateConverter;

namespace Algolia.Search.Recommend.Models
{
  /// <summary>
  /// RuleResponseMetadata
  /// </summary>
  [DataContract(Name = "ruleResponse__metadata")]
  public partial class RuleResponseMetadata : IEquatable<RuleResponseMetadata>, IValidatableObject
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="RuleResponseMetadata" /> class.
    /// </summary>
    /// <param name="lastUpdate">Timestamp of the last update in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format..</param>
    public RuleResponseMetadata(string lastUpdate = default(string))
    {
      this.LastUpdate = lastUpdate;
    }

    /// <summary>
    /// Timestamp of the last update in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format.
    /// </summary>
    /// <value>Timestamp of the last update in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format.</value>
    [DataMember(Name = "lastUpdate", EmitDefaultValue = false)]
    public string LastUpdate { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class RuleResponseMetadata {\n");
      sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson()
    {
      return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
    }

    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="input">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object input)
    {
      return this.Equals(input as RuleResponseMetadata);
    }

    /// <summary>
    /// Returns true if RuleResponseMetadata instances are equal
    /// </summary>
    /// <param name="input">Instance of RuleResponseMetadata to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RuleResponseMetadata input)
    {
      if (input == null)
      {
        return false;
      }
      return
          (
              this.LastUpdate == input.LastUpdate ||
              (this.LastUpdate != null &&
              this.LastUpdate.Equals(input.LastUpdate))
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
        if (this.LastUpdate != null)
        {
          hashCode = (hashCode * 59) + this.LastUpdate.GetHashCode();
        }
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