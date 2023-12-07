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
  /// Search mode the index will use to query for results.
  /// </summary>
  /// <value>Search mode the index will use to query for results.</value>
  [JsonConverter(typeof(StringEnumConverter))]
  public enum Mode
  {
    /// <summary>
    /// Enum NeuralSearch for value: neuralSearch
    /// </summary>
    [EnumMember(Value = "neuralSearch")]
    NeuralSearch = 1,

    /// <summary>
    /// Enum KeywordSearch for value: keywordSearch
    /// </summary>
    [EnumMember(Value = "keywordSearch")]
    KeywordSearch = 2
  }

}