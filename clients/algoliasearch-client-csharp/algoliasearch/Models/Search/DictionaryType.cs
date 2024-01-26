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
/// Defines dictionaryType
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DictionaryType
{
  /// <summary>
  /// Enum Plurals for value: plurals
  /// </summary>
  [EnumMember(Value = "plurals")]
  Plurals = 1,

  /// <summary>
  /// Enum Stopwords for value: stopwords
  /// </summary>
  [EnumMember(Value = "stopwords")]
  Stopwords = 2,

  /// <summary>
  /// Enum Compounds for value: compounds
  /// </summary>
  [EnumMember(Value = "compounds")]
  Compounds = 3
}
