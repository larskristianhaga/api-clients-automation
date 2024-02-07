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

namespace Algolia.Search.Models.Ingestion;

/// <summary>
/// Authentication input for OAuth login.
/// </summary>
[DataContract(Name = "AuthOAuthPartial")]
[JsonObject(MemberSerialization.OptOut)]
public partial class AuthOAuthPartial
{
  /// <summary>
  /// Initializes a new instance of the AuthOAuthPartial class.
  /// </summary>
  public AuthOAuthPartial()
  {
  }

  /// <summary>
  /// The OAuth endpoint URL.
  /// </summary>
  /// <value>The OAuth endpoint URL.</value>
  [DataMember(Name = "url")]
  public string? Url { get; set; }

  /// <summary>
  /// The clientID.
  /// </summary>
  /// <value>The clientID.</value>
  [DataMember(Name = "client_id")]
  public string? ClientId { get; set; }

  /// <summary>
  /// The secret.
  /// </summary>
  /// <value>The secret.</value>
  [DataMember(Name = "client_secret")]
  public string? ClientSecret { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class AuthOAuthPartial {\n");
    sb.Append("  Url: ").Append(Url).Append("\n");
    sb.Append("  ClientId: ").Append(ClientId).Append("\n");
    sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
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

