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
using FileParameter = Algolia.Search.Monitoring.Client.FileParameter;
using OpenAPIDateConverter = Algolia.Search.Monitoring.Client.OpenAPIDateConverter;

namespace Algolia.Search.Monitoring.Models
{
  /// <summary>
  /// TimeInner
  /// </summary>
  [DataContract(Name = "Time_inner")]
  public partial class TimeInner : IEquatable<TimeInner>, IValidatableObject
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="TimeInner" /> class.
    /// </summary>
    /// <param name="t">Timestamp in [Unix epoch time](https://wikipedia.org/wiki/Unix_time) in milliseconds..</param>
    /// <param name="v">Time in ms..</param>
    public TimeInner(long t = default(long), int v = default(int))
    {
      this.T = t;
      this.V = v;
    }

    /// <summary>
    /// Timestamp in [Unix epoch time](https://wikipedia.org/wiki/Unix_time) in milliseconds.
    /// </summary>
    /// <value>Timestamp in [Unix epoch time](https://wikipedia.org/wiki/Unix_time) in milliseconds.</value>
    [DataMember(Name = "t", EmitDefaultValue = false)]
    public long T { get; set; }

    /// <summary>
    /// Time in ms.
    /// </summary>
    /// <value>Time in ms.</value>
    [DataMember(Name = "v", EmitDefaultValue = false)]
    public int V { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class TimeInner {\n");
      sb.Append("  T: ").Append(T).Append("\n");
      sb.Append("  V: ").Append(V).Append("\n");
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
      return this.Equals(input as TimeInner);
    }

    /// <summary>
    /// Returns true if TimeInner instances are equal
    /// </summary>
    /// <param name="input">Instance of TimeInner to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TimeInner input)
    {
      if (input == null)
      {
        return false;
      }
      return
          (
              this.T == input.T ||
              this.T.Equals(input.T)
          ) &&
          (
              this.V == input.V ||
              this.V.Equals(input.V)
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
        hashCode = (hashCode * 59) + this.T.GetHashCode();
        hashCode = (hashCode * 59) + this.V.GetHashCode();
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