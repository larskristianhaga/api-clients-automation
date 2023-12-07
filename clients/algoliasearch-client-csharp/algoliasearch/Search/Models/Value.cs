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
using FileParameter = Algolia.Search.Search.Client.FileParameter;
using OpenAPIDateConverter = Algolia.Search.Search.Client.OpenAPIDateConverter;

namespace Algolia.Search.Search.Models
{
  /// <summary>
  /// Value
  /// </summary>
  [DataContract(Name = "value")]
  public partial class Value : IEquatable<Value>, IValidatableObject
  {

    /// <summary>
    /// Gets or Sets SortRemainingBy
    /// </summary>
    [DataMember(Name = "sortRemainingBy", EmitDefaultValue = false)]
    public SortRemainingBy? SortRemainingBy { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Value" /> class.
    /// </summary>
    /// <param name="order">Pinned order of facet lists..</param>
    /// <param name="sortRemainingBy">sortRemainingBy.</param>
    public Value(List<string> order = default(List<string>), SortRemainingBy? sortRemainingBy = default(SortRemainingBy?))
    {
      this.Order = order;
      this.SortRemainingBy = sortRemainingBy;
    }

    /// <summary>
    /// Pinned order of facet lists.
    /// </summary>
    /// <value>Pinned order of facet lists.</value>
    [DataMember(Name = "order", EmitDefaultValue = false)]
    public List<string> Order { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class Value {\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
      sb.Append("  SortRemainingBy: ").Append(SortRemainingBy).Append("\n");
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
      return this.Equals(input as Value);
    }

    /// <summary>
    /// Returns true if Value instances are equal
    /// </summary>
    /// <param name="input">Instance of Value to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Value input)
    {
      if (input == null)
      {
        return false;
      }
      return
          (
              this.Order == input.Order ||
              this.Order != null &&
              input.Order != null &&
              this.Order.SequenceEqual(input.Order)
          ) &&
          (
              this.SortRemainingBy == input.SortRemainingBy ||
              this.SortRemainingBy.Equals(input.SortRemainingBy)
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
        if (this.Order != null)
        {
          hashCode = (hashCode * 59) + this.Order.GetHashCode();
        }
        hashCode = (hashCode * 59) + this.SortRemainingBy.GetHashCode();
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