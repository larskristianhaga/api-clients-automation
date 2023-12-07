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
using FileParameter = Algolia.Search.Personalization.Client.FileParameter;
using OpenAPIDateConverter = Algolia.Search.Personalization.Client.OpenAPIDateConverter;

namespace Algolia.Search.Personalization.Models
{
  /// <summary>
  /// FacetScoring
  /// </summary>
  [DataContract(Name = "facetScoring")]
  public partial class FacetScoring : IEquatable<FacetScoring>, IValidatableObject
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="FacetScoring" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected FacetScoring() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="FacetScoring" /> class.
    /// </summary>
    /// <param name="score">The score for the event. (required).</param>
    /// <param name="facetName">The name of the facet. (required).</param>
    public FacetScoring(int score = default(int), string facetName = default(string))
    {
      this.Score = score;
      // to ensure "facetName" is required (not null)
      if (facetName == null)
      {
        throw new ArgumentNullException("facetName is a required property for FacetScoring and cannot be null");
      }
      this.FacetName = facetName;
    }

    /// <summary>
    /// The score for the event.
    /// </summary>
    /// <value>The score for the event.</value>
    [DataMember(Name = "score", IsRequired = true, EmitDefaultValue = true)]
    public int Score { get; set; }

    /// <summary>
    /// The name of the facet.
    /// </summary>
    /// <value>The name of the facet.</value>
    [DataMember(Name = "facetName", IsRequired = true, EmitDefaultValue = true)]
    public string FacetName { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class FacetScoring {\n");
      sb.Append("  Score: ").Append(Score).Append("\n");
      sb.Append("  FacetName: ").Append(FacetName).Append("\n");
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
      return this.Equals(input as FacetScoring);
    }

    /// <summary>
    /// Returns true if FacetScoring instances are equal
    /// </summary>
    /// <param name="input">Instance of FacetScoring to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FacetScoring input)
    {
      if (input == null)
      {
        return false;
      }
      return
          (
              this.Score == input.Score ||
              this.Score.Equals(input.Score)
          ) &&
          (
              this.FacetName == input.FacetName ||
              (this.FacetName != null &&
              this.FacetName.Equals(input.FacetName))
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
        hashCode = (hashCode * 59) + this.Score.GetHashCode();
        if (this.FacetName != null)
        {
          hashCode = (hashCode * 59) + this.FacetName.GetHashCode();
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