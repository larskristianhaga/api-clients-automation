//
// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
//
using System;
using System.Text;
using System.Linq;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using Algolia.Search.Serializer;
using System.Text.Json;

namespace Algolia.Search.Models.Ingestion;

/// <summary>
/// Time window by which to filter the observability data.
/// </summary>
public partial class Window
{
  /// <summary>
  /// Initializes a new instance of the Window class.
  /// </summary>
  [JsonConstructor]
  public Window() { }
  /// <summary>
  /// Initializes a new instance of the Window class.
  /// </summary>
  /// <param name="startDate">Date in RFC3339 format representing the oldest data in the time window. (required).</param>
  /// <param name="endDate">Date in RFC3339 format representing the newest data in the time window. (required).</param>
  public Window(string startDate, string endDate)
  {
    StartDate = startDate ?? throw new ArgumentNullException(nameof(startDate));
    EndDate = endDate ?? throw new ArgumentNullException(nameof(endDate));
  }

  /// <summary>
  /// Date in RFC3339 format representing the oldest data in the time window.
  /// </summary>
  /// <value>Date in RFC3339 format representing the oldest data in the time window.</value>
  [JsonPropertyName("startDate")]
  public string StartDate { get; set; }

  /// <summary>
  /// Date in RFC3339 format representing the newest data in the time window.
  /// </summary>
  /// <value>Date in RFC3339 format representing the newest data in the time window.</value>
  [JsonPropertyName("endDate")]
  public string EndDate { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class Window {\n");
    sb.Append("  StartDate: ").Append(StartDate).Append("\n");
    sb.Append("  EndDate: ").Append(EndDate).Append("\n");
    sb.Append("}\n");
    return sb.ToString();
  }

  /// <summary>
  /// Returns the JSON string presentation of the object
  /// </summary>
  /// <returns>JSON string presentation of the object</returns>
  public virtual string ToJson()
  {
    return JsonSerializer.Serialize(this, JsonConfig.Options);
  }

  /// <summary>
  /// Returns true if objects are equal
  /// </summary>
  /// <param name="obj">Object to be compared</param>
  /// <returns>Boolean</returns>
  public override bool Equals(object obj)
  {
    if (obj is not Window input)
    {
      return false;
    }

    return
        (StartDate == input.StartDate || (StartDate != null && StartDate.Equals(input.StartDate))) &&
        (EndDate == input.EndDate || (EndDate != null && EndDate.Equals(input.EndDate)));
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
      if (StartDate != null)
      {
        hashCode = (hashCode * 59) + StartDate.GetHashCode();
      }
      if (EndDate != null)
      {
        hashCode = (hashCode * 59) + EndDate.GetHashCode();
      }
      return hashCode;
    }
  }

}

