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
using System.Reflection;
using Algolia.Search.Models;
using Algolia.Search.Models.Common;
using Algolia.Search.Serializer;

namespace Algolia.Search.Models.Ingestion;

/// <summary>
/// DestinationInput
/// </summary>
[JsonConverter(typeof(DestinationInputJsonConverter))]
[DataContract(Name = "DestinationInput")]
public partial class DestinationInput : AbstractSchema
{
  /// <summary>
  /// Initializes a new instance of the DestinationInput class
  /// with a DestinationIndexPrefix
  /// </summary>
  /// <param name="actualInstance">An instance of DestinationIndexPrefix.</param>
  public DestinationInput(DestinationIndexPrefix actualInstance)
  {
    IsNullable = false;
    SchemaType = "oneOf";
    ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
  }

  /// <summary>
  /// Initializes a new instance of the DestinationInput class
  /// with a DestinationIndexName
  /// </summary>
  /// <param name="actualInstance">An instance of DestinationIndexName.</param>
  public DestinationInput(DestinationIndexName actualInstance)
  {
    IsNullable = false;
    SchemaType = "oneOf";
    ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
  }


  /// <summary>
  /// Gets or Sets ActualInstance
  /// </summary>
  public sealed override object ActualInstance { get; set; }

  /// <summary>
  /// Get the actual instance of `DestinationIndexPrefix`. If the actual instance is not `DestinationIndexPrefix`,
  /// the InvalidClassException will be thrown
  /// </summary>
  /// <returns>An instance of DestinationIndexPrefix</returns>
  public DestinationIndexPrefix AsDestinationIndexPrefix()
  {
    return (DestinationIndexPrefix)ActualInstance;
  }

  /// <summary>
  /// Get the actual instance of `DestinationIndexName`. If the actual instance is not `DestinationIndexName`,
  /// the InvalidClassException will be thrown
  /// </summary>
  /// <returns>An instance of DestinationIndexName</returns>
  public DestinationIndexName AsDestinationIndexName()
  {
    return (DestinationIndexName)ActualInstance;
  }


  /// <summary>
  /// Check if the actual instance is of `DestinationIndexPrefix` type.
  /// </summary>
  /// <returns>Whether or not the instance is the type</returns>
  public bool IsDestinationIndexPrefix()
  {
    return ActualInstance.GetType() == typeof(DestinationIndexPrefix);
  }

  /// <summary>
  /// Check if the actual instance is of `DestinationIndexName` type.
  /// </summary>
  /// <returns>Whether or not the instance is the type</returns>
  public bool IsDestinationIndexName()
  {
    return ActualInstance.GetType() == typeof(DestinationIndexName);
  }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    var sb = new StringBuilder();
    sb.Append("class DestinationInput {\n");
    sb.Append("  ActualInstance: ").Append(ActualInstance).Append("\n");
    sb.Append("}\n");
    return sb.ToString();
  }

  /// <summary>
  /// Returns the JSON string presentation of the object
  /// </summary>
  /// <returns>JSON string presentation of the object</returns>
  public override string ToJson()
  {
    return JsonConvert.SerializeObject(ActualInstance, JsonConfig.AlgoliaJsonSerializerSettings);
  }

  /// <summary>
  /// Converts the JSON string into an instance of DestinationInput
  /// </summary>
  /// <param name="jsonString">JSON string</param>
  /// <returns>An instance of DestinationInput</returns>
  public static DestinationInput FromJson(string jsonString)
  {
    DestinationInput newDestinationInput = null;

    if (string.IsNullOrEmpty(jsonString))
    {
      return newDestinationInput;
    }
    try
    {
      return new DestinationInput(JsonConvert.DeserializeObject<DestinationIndexPrefix>(jsonString, AdditionalPropertiesSerializerSettings));
    }
    catch (Exception exception)
    {
      // deserialization failed, try the next one
      System.Diagnostics.Debug.WriteLine($"Failed to deserialize `{jsonString}` into DestinationIndexPrefix: {exception}");
    }
    try
    {
      return new DestinationInput(JsonConvert.DeserializeObject<DestinationIndexName>(jsonString, AdditionalPropertiesSerializerSettings));
    }
    catch (Exception exception)
    {
      // deserialization failed, try the next one
      System.Diagnostics.Debug.WriteLine($"Failed to deserialize `{jsonString}` into DestinationIndexName: {exception}");
    }

    throw new InvalidDataException($"The JSON string `{jsonString}` cannot be deserialized into any schema defined.");
  }

}

/// <summary>
/// Custom JSON converter for DestinationInput
/// </summary>
public class DestinationInputJsonConverter : JsonConverter
{
  /// <summary>
  /// To write the JSON string
  /// </summary>
  /// <param name="writer">JSON writer</param>
  /// <param name="value">Object to be converted into a JSON string</param>
  /// <param name="serializer">JSON Serializer</param>
  public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
  {
    writer.WriteRawValue((string)(typeof(DestinationInput).GetMethod("ToJson")?.Invoke(value, null)));
  }

  /// <summary>
  /// To convert a JSON string into an object
  /// </summary>
  /// <param name="reader">JSON reader</param>
  /// <param name="objectType">Object type</param>
  /// <param name="existingValue">Existing value</param>
  /// <param name="serializer">JSON Serializer</param>
  /// <returns>The object converted from the JSON string</returns>
  public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
  {
    if (reader.TokenType != JsonToken.Null)
    {
      return objectType.GetMethod("FromJson")?.Invoke(null, new object[] { JObject.Load(reader).ToString(Formatting.None) });
    }
    return null;
  }

  /// <summary>
  /// Check if the object can be converted
  /// </summary>
  /// <param name="objectType">Object type</param>
  /// <returns>True if the object can be converted</returns>
  public override bool CanConvert(Type objectType)
  {
    return false;
  }
}
