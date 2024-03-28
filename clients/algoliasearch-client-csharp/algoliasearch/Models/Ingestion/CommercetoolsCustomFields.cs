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
/// Custom fields from commercetools to add to the records.  For more information, see [Using Custom Types and Custom Fields](https://docs.commercetools.com/tutorials/custom-types). 
/// </summary>
public partial class CommercetoolsCustomFields
{
  /// <summary>
  /// Initializes a new instance of the CommercetoolsCustomFields class.
  /// </summary>
  public CommercetoolsCustomFields()
  {
  }

  /// <summary>
  /// Inventory custom fields.
  /// </summary>
  /// <value>Inventory custom fields.</value>
  [JsonPropertyName("inventory")]
  public List<string> Inventory { get; set; }

  /// <summary>
  /// Price custom fields.
  /// </summary>
  /// <value>Price custom fields.</value>
  [JsonPropertyName("price")]
  public List<string> Price { get; set; }

  /// <summary>
  /// Category custom fields.
  /// </summary>
  /// <value>Category custom fields.</value>
  [JsonPropertyName("category")]
  public List<string> Category { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class CommercetoolsCustomFields {\n");
    sb.Append("  Inventory: ").Append(Inventory).Append("\n");
    sb.Append("  Price: ").Append(Price).Append("\n");
    sb.Append("  Category: ").Append(Category).Append("\n");
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
    if (obj is not CommercetoolsCustomFields input)
    {
      return false;
    }

    return
        (Inventory == input.Inventory || Inventory != null && input.Inventory != null && Inventory.SequenceEqual(input.Inventory)) &&
        (Price == input.Price || Price != null && input.Price != null && Price.SequenceEqual(input.Price)) &&
        (Category == input.Category || Category != null && input.Category != null && Category.SequenceEqual(input.Category));
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
      if (Inventory != null)
      {
        hashCode = (hashCode * 59) + Inventory.GetHashCode();
      }
      if (Price != null)
      {
        hashCode = (hashCode * 59) + Price.GetHashCode();
      }
      if (Category != null)
      {
        hashCode = (hashCode * 59) + Category.GetHashCode();
      }
      return hashCode;
    }
  }

}

