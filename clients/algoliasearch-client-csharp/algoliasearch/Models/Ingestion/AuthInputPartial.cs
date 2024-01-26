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
/// AuthInputPartial
/// </summary>
[JsonConverter(typeof(AuthInputPartialJsonConverter))]
[DataContract(Name = "AuthInputPartial")]
public partial class AuthInputPartial : AbstractSchema
{
  /// <summary>
  /// Initializes a new instance of the AuthInputPartial class
  /// with a AuthGoogleServiceAccountPartial
  /// </summary>
  /// <param name="actualInstance">An instance of AuthGoogleServiceAccountPartial.</param>
  public AuthInputPartial(AuthGoogleServiceAccountPartial actualInstance)
  {
    IsNullable = false;
    SchemaType = "oneOf";
    ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
  }

  /// <summary>
  /// Initializes a new instance of the AuthInputPartial class
  /// with a AuthBasicPartial
  /// </summary>
  /// <param name="actualInstance">An instance of AuthBasicPartial.</param>
  public AuthInputPartial(AuthBasicPartial actualInstance)
  {
    IsNullable = false;
    SchemaType = "oneOf";
    ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
  }

  /// <summary>
  /// Initializes a new instance of the AuthInputPartial class
  /// with a AuthAPIKeyPartial
  /// </summary>
  /// <param name="actualInstance">An instance of AuthAPIKeyPartial.</param>
  public AuthInputPartial(AuthAPIKeyPartial actualInstance)
  {
    IsNullable = false;
    SchemaType = "oneOf";
    ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
  }

  /// <summary>
  /// Initializes a new instance of the AuthInputPartial class
  /// with a AuthOAuthPartial
  /// </summary>
  /// <param name="actualInstance">An instance of AuthOAuthPartial.</param>
  public AuthInputPartial(AuthOAuthPartial actualInstance)
  {
    IsNullable = false;
    SchemaType = "oneOf";
    ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
  }

  /// <summary>
  /// Initializes a new instance of the AuthInputPartial class
  /// with a AuthAlgoliaPartial
  /// </summary>
  /// <param name="actualInstance">An instance of AuthAlgoliaPartial.</param>
  public AuthInputPartial(AuthAlgoliaPartial actualInstance)
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
  /// Get the actual instance of `AuthGoogleServiceAccountPartial`. If the actual instance is not `AuthGoogleServiceAccountPartial`,
  /// the InvalidClassException will be thrown
  /// </summary>
  /// <returns>An instance of AuthGoogleServiceAccountPartial</returns>
  public AuthGoogleServiceAccountPartial AsAuthGoogleServiceAccountPartial()
  {
    return (AuthGoogleServiceAccountPartial)ActualInstance;
  }

  /// <summary>
  /// Get the actual instance of `AuthBasicPartial`. If the actual instance is not `AuthBasicPartial`,
  /// the InvalidClassException will be thrown
  /// </summary>
  /// <returns>An instance of AuthBasicPartial</returns>
  public AuthBasicPartial AsAuthBasicPartial()
  {
    return (AuthBasicPartial)ActualInstance;
  }

  /// <summary>
  /// Get the actual instance of `AuthAPIKeyPartial`. If the actual instance is not `AuthAPIKeyPartial`,
  /// the InvalidClassException will be thrown
  /// </summary>
  /// <returns>An instance of AuthAPIKeyPartial</returns>
  public AuthAPIKeyPartial AsAuthAPIKeyPartial()
  {
    return (AuthAPIKeyPartial)ActualInstance;
  }

  /// <summary>
  /// Get the actual instance of `AuthOAuthPartial`. If the actual instance is not `AuthOAuthPartial`,
  /// the InvalidClassException will be thrown
  /// </summary>
  /// <returns>An instance of AuthOAuthPartial</returns>
  public AuthOAuthPartial AsAuthOAuthPartial()
  {
    return (AuthOAuthPartial)ActualInstance;
  }

  /// <summary>
  /// Get the actual instance of `AuthAlgoliaPartial`. If the actual instance is not `AuthAlgoliaPartial`,
  /// the InvalidClassException will be thrown
  /// </summary>
  /// <returns>An instance of AuthAlgoliaPartial</returns>
  public AuthAlgoliaPartial AsAuthAlgoliaPartial()
  {
    return (AuthAlgoliaPartial)ActualInstance;
  }


  /// <summary>
  /// Check if the actual instance is of `AuthGoogleServiceAccountPartial` type.
  /// </summary>
  /// <returns>Whether or not the instance is the type</returns>
  public bool IsAuthGoogleServiceAccountPartial()
  {
    return ActualInstance.GetType() == typeof(AuthGoogleServiceAccountPartial);
  }

  /// <summary>
  /// Check if the actual instance is of `AuthBasicPartial` type.
  /// </summary>
  /// <returns>Whether or not the instance is the type</returns>
  public bool IsAuthBasicPartial()
  {
    return ActualInstance.GetType() == typeof(AuthBasicPartial);
  }

  /// <summary>
  /// Check if the actual instance is of `AuthAPIKeyPartial` type.
  /// </summary>
  /// <returns>Whether or not the instance is the type</returns>
  public bool IsAuthAPIKeyPartial()
  {
    return ActualInstance.GetType() == typeof(AuthAPIKeyPartial);
  }

  /// <summary>
  /// Check if the actual instance is of `AuthOAuthPartial` type.
  /// </summary>
  /// <returns>Whether or not the instance is the type</returns>
  public bool IsAuthOAuthPartial()
  {
    return ActualInstance.GetType() == typeof(AuthOAuthPartial);
  }

  /// <summary>
  /// Check if the actual instance is of `AuthAlgoliaPartial` type.
  /// </summary>
  /// <returns>Whether or not the instance is the type</returns>
  public bool IsAuthAlgoliaPartial()
  {
    return ActualInstance.GetType() == typeof(AuthAlgoliaPartial);
  }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    var sb = new StringBuilder();
    sb.Append("class AuthInputPartial {\n");
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
  /// Converts the JSON string into an instance of AuthInputPartial
  /// </summary>
  /// <param name="jsonString">JSON string</param>
  /// <returns>An instance of AuthInputPartial</returns>
  public static AuthInputPartial FromJson(string jsonString)
  {
    AuthInputPartial newAuthInputPartial = null;

    if (string.IsNullOrEmpty(jsonString))
    {
      return newAuthInputPartial;
    }
    try
    {
      return new AuthInputPartial(JsonConvert.DeserializeObject<AuthGoogleServiceAccountPartial>(jsonString, AdditionalPropertiesSerializerSettings));
    }
    catch (Exception exception)
    {
      // deserialization failed, try the next one
      System.Diagnostics.Debug.WriteLine($"Failed to deserialize `{jsonString}` into AuthGoogleServiceAccountPartial: {exception}");
    }
    try
    {
      return new AuthInputPartial(JsonConvert.DeserializeObject<AuthBasicPartial>(jsonString, AdditionalPropertiesSerializerSettings));
    }
    catch (Exception exception)
    {
      // deserialization failed, try the next one
      System.Diagnostics.Debug.WriteLine($"Failed to deserialize `{jsonString}` into AuthBasicPartial: {exception}");
    }
    try
    {
      return new AuthInputPartial(JsonConvert.DeserializeObject<AuthAPIKeyPartial>(jsonString, AdditionalPropertiesSerializerSettings));
    }
    catch (Exception exception)
    {
      // deserialization failed, try the next one
      System.Diagnostics.Debug.WriteLine($"Failed to deserialize `{jsonString}` into AuthAPIKeyPartial: {exception}");
    }
    try
    {
      return new AuthInputPartial(JsonConvert.DeserializeObject<AuthOAuthPartial>(jsonString, AdditionalPropertiesSerializerSettings));
    }
    catch (Exception exception)
    {
      // deserialization failed, try the next one
      System.Diagnostics.Debug.WriteLine($"Failed to deserialize `{jsonString}` into AuthOAuthPartial: {exception}");
    }
    try
    {
      return new AuthInputPartial(JsonConvert.DeserializeObject<AuthAlgoliaPartial>(jsonString, AdditionalPropertiesSerializerSettings));
    }
    catch (Exception exception)
    {
      // deserialization failed, try the next one
      System.Diagnostics.Debug.WriteLine($"Failed to deserialize `{jsonString}` into AuthAlgoliaPartial: {exception}");
    }

    throw new InvalidDataException($"The JSON string `{jsonString}` cannot be deserialized into any schema defined.");
  }

}

/// <summary>
/// Custom JSON converter for AuthInputPartial
/// </summary>
public class AuthInputPartialJsonConverter : JsonConverter
{
  /// <summary>
  /// To write the JSON string
  /// </summary>
  /// <param name="writer">JSON writer</param>
  /// <param name="value">Object to be converted into a JSON string</param>
  /// <param name="serializer">JSON Serializer</param>
  public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
  {
    writer.WriteRawValue((string)(typeof(AuthInputPartial).GetMethod("ToJson")?.Invoke(value, null)));
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
