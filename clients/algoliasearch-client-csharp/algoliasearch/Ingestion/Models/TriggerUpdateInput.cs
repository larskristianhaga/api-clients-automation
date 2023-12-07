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
using FileParameter = Algolia.Search.Ingestion.Client.FileParameter;
using OpenAPIDateConverter = Algolia.Search.Ingestion.Client.OpenAPIDateConverter;

namespace Algolia.Search.Ingestion.Models
{
  /// <summary>
  /// The trigger input for a task update.
  /// </summary>
  [DataContract(Name = "TriggerUpdateInput")]
  public partial class TriggerUpdateInput : IEquatable<TriggerUpdateInput>, IValidatableObject
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="TriggerUpdateInput" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TriggerUpdateInput() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TriggerUpdateInput" /> class.
    /// </summary>
    /// <param name="cron">A cron expression that represent at which regularity the task should run. (required).</param>
    public TriggerUpdateInput(string cron = default(string))
    {
      // to ensure "cron" is required (not null)
      if (cron == null)
      {
        throw new ArgumentNullException("cron is a required property for TriggerUpdateInput and cannot be null");
      }
      this.Cron = cron;
    }

    /// <summary>
    /// A cron expression that represent at which regularity the task should run.
    /// </summary>
    /// <value>A cron expression that represent at which regularity the task should run.</value>
    [DataMember(Name = "cron", IsRequired = true, EmitDefaultValue = true)]
    public string Cron { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class TriggerUpdateInput {\n");
      sb.Append("  Cron: ").Append(Cron).Append("\n");
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
      return this.Equals(input as TriggerUpdateInput);
    }

    /// <summary>
    /// Returns true if TriggerUpdateInput instances are equal
    /// </summary>
    /// <param name="input">Instance of TriggerUpdateInput to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TriggerUpdateInput input)
    {
      if (input == null)
      {
        return false;
      }
      return
          (
              this.Cron == input.Cron ||
              (this.Cron != null &&
              this.Cron.Equals(input.Cron))
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
        if (this.Cron != null)
        {
          hashCode = (hashCode * 59) + this.Cron.GetHashCode();
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