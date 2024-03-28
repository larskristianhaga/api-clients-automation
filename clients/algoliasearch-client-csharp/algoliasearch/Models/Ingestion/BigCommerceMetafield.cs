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
/// BigCommerceMetafield
/// </summary>
public partial class BigCommerceMetafield
{
  /// <summary>
  /// Initializes a new instance of the BigCommerceMetafield class.
  /// </summary>
  [JsonConstructor]
  public BigCommerceMetafield() { }
  /// <summary>
  /// Initializes a new instance of the BigCommerceMetafield class.
  /// </summary>
  /// <param name="varNamespace">Namespace of the metafield. (required).</param>
  /// <param name="key">Key identifier of the metafield. (required).</param>
  public BigCommerceMetafield(string varNamespace, string key)
  {
    VarNamespace = varNamespace ?? throw new ArgumentNullException(nameof(varNamespace));
    Key = key ?? throw new ArgumentNullException(nameof(key));
  }

  /// <summary>
  /// Namespace of the metafield.
  /// </summary>
  /// <value>Namespace of the metafield.</value>
  [JsonPropertyName("namespace")]
  public string VarNamespace { get; set; }

  /// <summary>
  /// Key identifier of the metafield.
  /// </summary>
  /// <value>Key identifier of the metafield.</value>
  [JsonPropertyName("key")]
  public string Key { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class BigCommerceMetafield {\n");
    sb.Append("  VarNamespace: ").Append(VarNamespace).Append("\n");
    sb.Append("  Key: ").Append(Key).Append("\n");
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
    if (obj is not BigCommerceMetafield input)
    {
      return false;
    }

    return
        (VarNamespace == input.VarNamespace || (VarNamespace != null && VarNamespace.Equals(input.VarNamespace))) &&
        (Key == input.Key || (Key != null && Key.Equals(input.Key)));
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
      if (VarNamespace != null)
      {
        hashCode = (hashCode * 59) + VarNamespace.GetHashCode();
      }
      if (Key != null)
      {
        hashCode = (hashCode * 59) + Key.GetHashCode();
      }
      return hashCode;
    }
  }

}

