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

namespace Algolia.Search.Models.Recommend;

/// <summary>
/// Looking similar model.  This model recommends items that look similar to the item with the ID `objectID` based on image attributes in your index. 
/// </summary>
/// <value>Looking similar model.  This model recommends items that look similar to the item with the ID `objectID` based on image attributes in your index. </value>
public enum LookingSimilarModel
{
  /// <summary>
  /// Enum LookingSimilar for value: looking-similar
  /// </summary>
  [JsonPropertyName("looking-similar")]
  LookingSimilar = 1
}
