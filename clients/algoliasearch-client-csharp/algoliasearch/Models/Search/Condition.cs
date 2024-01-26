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
/// Condition
/// </summary>
[DataContract(Name = "condition")]
[JsonObject(MemberSerialization.OptOut)]
public partial class Condition
{

  /// <summary>
  /// Gets or Sets Anchoring
  /// </summary>
  [DataMember(Name = "anchoring", EmitDefaultValue = false)]
  public Anchoring Anchoring { get; set; }
  /// <summary>
  /// Initializes a new instance of the Condition class.
  /// </summary>
  public Condition()
  {
  }

  /// <summary>
  /// Query pattern syntax.
  /// </summary>
  /// <value>Query pattern syntax.</value>
  [DataMember(Name = "pattern", EmitDefaultValue = false)]
  public string Pattern { get; set; }

  /// <summary>
  /// Whether the pattern matches on plurals, synonyms, and typos.
  /// </summary>
  /// <value>Whether the pattern matches on plurals, synonyms, and typos.</value>
  [DataMember(Name = "alternatives", EmitDefaultValue = false)]
  public bool? Alternatives { get; set; }

  /// <summary>
  /// Rule context format: [A-Za-z0-9_-]+).
  /// </summary>
  /// <value>Rule context format: [A-Za-z0-9_-]+).</value>
  [DataMember(Name = "context", EmitDefaultValue = false)]
  public string Context { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class Condition {\n");
    sb.Append("  Pattern: ").Append(Pattern).Append("\n");
    sb.Append("  Anchoring: ").Append(Anchoring).Append("\n");
    sb.Append("  Alternatives: ").Append(Alternatives).Append("\n");
    sb.Append("  Context: ").Append(Context).Append("\n");
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
