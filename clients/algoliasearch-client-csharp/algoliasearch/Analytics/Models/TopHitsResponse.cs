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
using FileParameter = Algolia.Search.Analytics.Client.FileParameter;
using OpenAPIDateConverter = Algolia.Search.Analytics.Client.OpenAPIDateConverter;

namespace Algolia.Search.Analytics.Models
{
  /// <summary>
  /// TopHitsResponse
  /// </summary>
  [DataContract(Name = "topHitsResponse")]
  public partial class TopHitsResponse : IEquatable<TopHitsResponse>, IValidatableObject
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="TopHitsResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TopHitsResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TopHitsResponse" /> class.
    /// </summary>
    /// <param name="hits">Top hits. (required).</param>
    public TopHitsResponse(List<TopHit> hits = default(List<TopHit>))
    {
      // to ensure "hits" is required (not null)
      if (hits == null)
      {
        throw new ArgumentNullException("hits is a required property for TopHitsResponse and cannot be null");
      }
      this.Hits = hits;
    }

    /// <summary>
    /// Top hits.
    /// </summary>
    /// <value>Top hits.</value>
    [DataMember(Name = "hits", IsRequired = true, EmitDefaultValue = true)]
    public List<TopHit> Hits { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class TopHitsResponse {\n");
      sb.Append("  Hits: ").Append(Hits).Append("\n");
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
      return this.Equals(input as TopHitsResponse);
    }

    /// <summary>
    /// Returns true if TopHitsResponse instances are equal
    /// </summary>
    /// <param name="input">Instance of TopHitsResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TopHitsResponse input)
    {
      if (input == null)
      {
        return false;
      }
      return
          (
              this.Hits == input.Hits ||
              this.Hits != null &&
              input.Hits != null &&
              this.Hits.SequenceEqual(input.Hits)
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
        if (this.Hits != null)
        {
          hashCode = (hashCode * 59) + this.Hits.GetHashCode();
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