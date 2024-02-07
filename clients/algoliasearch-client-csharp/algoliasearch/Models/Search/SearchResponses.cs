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
using Algolia.Search.Models;
using Algolia.Search.Models.Common;
using Algolia.Search.Serializer;

namespace Algolia.Search.Models.Search;

/// <summary>
/// SearchResponses
/// </summary>
[DataContract(Name = "searchResponses")]
[JsonObject(MemberSerialization.OptOut)]
public partial class SearchResponses<T>
{
  /// <summary>
  /// Initializes a new instance of the SearchResponses class.
  /// </summary>
  [JsonConstructor]
  public SearchResponses() { }
  /// <summary>
  /// Initializes a new instance of the SearchResponses class.
  /// </summary>
  /// <param name="results">results (required).</param>
  public SearchResponses(List<SearchResult<T>> results)
  {
    Results = results ?? throw new ArgumentNullException(nameof(results));
  }

  /// <summary>
  /// Gets or Sets Results
  /// </summary>
  [DataMember(Name = "results")]
  public List<SearchResult<T>> Results { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class SearchResponses {\n");
    sb.Append("  Results: ").Append(Results).Append("\n");
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

}

