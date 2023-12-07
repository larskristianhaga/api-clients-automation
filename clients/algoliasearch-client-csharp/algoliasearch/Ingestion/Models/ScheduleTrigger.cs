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
  /// The trigger information for a task of type &#39;schedule&#39;.
  /// </summary>
  [DataContract(Name = "ScheduleTrigger")]
  public partial class ScheduleTrigger : IEquatable<ScheduleTrigger>, IValidatableObject
  {

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
    public ScheduleTriggerType Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScheduleTrigger" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ScheduleTrigger() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScheduleTrigger" /> class.
    /// </summary>
    /// <param name="type">type (required).</param>
    /// <param name="cron">A cron expression that represent at which regularity the task should run. (required).</param>
    /// <param name="lastRun">The last time the scheduled task ran (RFC3339 format)..</param>
    /// <param name="nextRun">The next scheduled run of the task (RFC3339 format). (required).</param>
    public ScheduleTrigger(ScheduleTriggerType type = default(ScheduleTriggerType), string cron = default(string), string lastRun = default(string), string nextRun = default(string))
    {
      this.Type = type;
      // to ensure "cron" is required (not null)
      if (cron == null)
      {
        throw new ArgumentNullException("cron is a required property for ScheduleTrigger and cannot be null");
      }
      this.Cron = cron;
      // to ensure "nextRun" is required (not null)
      if (nextRun == null)
      {
        throw new ArgumentNullException("nextRun is a required property for ScheduleTrigger and cannot be null");
      }
      this.NextRun = nextRun;
      this.LastRun = lastRun;
    }

    /// <summary>
    /// A cron expression that represent at which regularity the task should run.
    /// </summary>
    /// <value>A cron expression that represent at which regularity the task should run.</value>
    [DataMember(Name = "cron", IsRequired = true, EmitDefaultValue = true)]
    public string Cron { get; set; }

    /// <summary>
    /// The last time the scheduled task ran (RFC3339 format).
    /// </summary>
    /// <value>The last time the scheduled task ran (RFC3339 format).</value>
    [DataMember(Name = "lastRun", EmitDefaultValue = false)]
    public string LastRun { get; set; }

    /// <summary>
    /// The next scheduled run of the task (RFC3339 format).
    /// </summary>
    /// <value>The next scheduled run of the task (RFC3339 format).</value>
    [DataMember(Name = "nextRun", IsRequired = true, EmitDefaultValue = true)]
    public string NextRun { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class ScheduleTrigger {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Cron: ").Append(Cron).Append("\n");
      sb.Append("  LastRun: ").Append(LastRun).Append("\n");
      sb.Append("  NextRun: ").Append(NextRun).Append("\n");
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
      return this.Equals(input as ScheduleTrigger);
    }

    /// <summary>
    /// Returns true if ScheduleTrigger instances are equal
    /// </summary>
    /// <param name="input">Instance of ScheduleTrigger to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScheduleTrigger input)
    {
      if (input == null)
      {
        return false;
      }
      return
          (
              this.Type == input.Type ||
              this.Type.Equals(input.Type)
          ) &&
          (
              this.Cron == input.Cron ||
              (this.Cron != null &&
              this.Cron.Equals(input.Cron))
          ) &&
          (
              this.LastRun == input.LastRun ||
              (this.LastRun != null &&
              this.LastRun.Equals(input.LastRun))
          ) &&
          (
              this.NextRun == input.NextRun ||
              (this.NextRun != null &&
              this.NextRun.Equals(input.NextRun))
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
        hashCode = (hashCode * 59) + this.Type.GetHashCode();
        if (this.Cron != null)
        {
          hashCode = (hashCode * 59) + this.Cron.GetHashCode();
        }
        if (this.LastRun != null)
        {
          hashCode = (hashCode * 59) + this.LastRun.GetHashCode();
        }
        if (this.NextRun != null)
        {
          hashCode = (hashCode * 59) + this.NextRun.GetHashCode();
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