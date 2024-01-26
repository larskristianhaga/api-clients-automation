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
/// A destination describe how the data is indexed on the Algolia side.
/// </summary>
[DataContract(Name = "Destination")]
[JsonObject(MemberSerialization.OptOut)]
public partial class Destination
{

  /// <summary>
  /// Gets or Sets Type
  /// </summary>
  [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
  public DestinationType Type { get; set; }
  /// <summary>
  /// Initializes a new instance of the Destination class.
  /// </summary>
  [JsonConstructor]
  public Destination() { }
  /// <summary>
  /// Initializes a new instance of the Destination class.
  /// </summary>
  /// <param name="destinationID">The destination UUID. (required).</param>
  /// <param name="type">type (required).</param>
  /// <param name="name">An human readable name describing the object. (required).</param>
  /// <param name="input">input (required).</param>
  /// <param name="createdAt">Date of creation (RFC3339 format). (required).</param>
  public Destination(string destinationID, DestinationType type, string name, DestinationInput input, string createdAt)
  {
    DestinationID = destinationID ?? throw new ArgumentNullException(nameof(destinationID));
    Type = type;
    Name = name ?? throw new ArgumentNullException(nameof(name));
    Input = input ?? throw new ArgumentNullException(nameof(input));
    CreatedAt = createdAt ?? throw new ArgumentNullException(nameof(createdAt));
  }

  /// <summary>
  /// The destination UUID.
  /// </summary>
  /// <value>The destination UUID.</value>
  [DataMember(Name = "destinationID", IsRequired = true, EmitDefaultValue = false)]
  public string DestinationID { get; set; }

  /// <summary>
  /// An human readable name describing the object.
  /// </summary>
  /// <value>An human readable name describing the object.</value>
  [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
  public string Name { get; set; }

  /// <summary>
  /// Gets or Sets Input
  /// </summary>
  [DataMember(Name = "input", IsRequired = true, EmitDefaultValue = false)]
  public DestinationInput Input { get; set; }

  /// <summary>
  /// Date of creation (RFC3339 format).
  /// </summary>
  /// <value>Date of creation (RFC3339 format).</value>
  [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
  public string CreatedAt { get; set; }

  /// <summary>
  /// Date of last update (RFC3339 format).
  /// </summary>
  /// <value>Date of last update (RFC3339 format).</value>
  [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
  public string UpdatedAt { get; set; }

  /// <summary>
  /// Gets or Sets AuthenticationID
  /// </summary>
  [DataMember(Name = "authenticationID", EmitDefaultValue = false)]
  public string AuthenticationID { get; set; }

  /// <summary>
  /// Returns the string presentation of the object
  /// </summary>
  /// <returns>String presentation of the object</returns>
  public override string ToString()
  {
    StringBuilder sb = new StringBuilder();
    sb.Append("class Destination {\n");
    sb.Append("  DestinationID: ").Append(DestinationID).Append("\n");
    sb.Append("  Type: ").Append(Type).Append("\n");
    sb.Append("  Name: ").Append(Name).Append("\n");
    sb.Append("  Input: ").Append(Input).Append("\n");
    sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
    sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
    sb.Append("  AuthenticationID: ").Append(AuthenticationID).Append("\n");
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
