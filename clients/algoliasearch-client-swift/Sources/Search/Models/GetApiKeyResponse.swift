// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

import Core
import Foundation

#if canImport(AnyCodable)
  import AnyCodable
#endif

public struct GetApiKeyResponse: Codable, JSONEncodable, Hashable {

  /** API key. */
  public var value: String?
  /** Timestamp of creation in milliseconds in [Unix epoch time](https://wikipedia.org/wiki/Unix_time). */
  public var createdAt: Int64
  /** [Permissions](https://www.algolia.com/doc/guides/security/api-keys/#access-control-list-acl) associated with the key.  */
  public var acl: [Acl]
  /** Description of an API key for you and your team members. */
  public var description: String? = ""
  /** Restricts this API key to a list of indices or index patterns. If the list is empty, all indices are allowed. Specify either an exact index name or a pattern with a leading or trailing wildcard character (or both). For example: - `dev_*` matches all indices starting with \"dev_\" - `*_dev` matches all indices ending with \"_dev\" - `*_products_*` matches all indices containing \"_products_\".  */
  public var indexes: [String]?
  /** Maximum number of hits this API key can retrieve in one query. If zero, no limit is enforced. > **Note**: Use this parameter to protect you from third-party attempts to retrieve your entire content by massively querying the index.  */
  public var maxHitsPerQuery: Int? = 0
  /** Maximum number of API calls per hour allowed from a given IP address or [user token](https://www.algolia.com/doc/guides/sending-events/concepts/usertoken/). Each time an API call is performed with this key, a check is performed. If there were more than the specified number of calls within the last hour, the API returns an error with the status code `429` (Too Many Requests).  > **Note**: Use this parameter to protect you from third-party attempts to retrieve your entire content by massively querying the index.  */
  public var maxQueriesPerIPPerHour: Int? = 0
  /** Force some [query parameters](https://www.algolia.com/doc/api-reference/api-parameters/) to be applied for each query made with this API key. It's a URL-encoded query string.  */
  public var queryParameters: String? = ""
  /** Restrict this API key to specific [referrers](https://www.algolia.com/doc/guides/security/api-keys/in-depth/api-key-restrictions/#http-referrers). If empty, all referrers are allowed. For example: - `https://algolia.com/_*` matches all referrers starting with \"https://algolia.com/\" - `*.algolia.com` matches all referrers ending with \".algolia.com\" - `*algolia.com*` allows everything in the domain \"algolia.com\".  */
  public var referers: [String]?
  /** Validity duration of a key (in seconds).  The key will automatically be removed after this time has expired. The default value of 0 never expires. Short-lived API keys are useful to grant temporary access to your data. For example, in mobile apps, you can't [control when users update your app](https://www.algolia.com/doc/guides/security/security-best-practices/#use-secured-api-keys-in-mobile-apps). So instead of encoding keys into your app as you would for a web app, you should dynamically fetch them from your mobile app's backend.  */
  public var validity: Int? = 0

  public init(
    value: String? = nil, createdAt: Int64, acl: [Acl], description: String? = "",
    indexes: [String]? = nil, maxHitsPerQuery: Int? = 0, maxQueriesPerIPPerHour: Int? = 0,
    queryParameters: String? = "", referers: [String]? = nil, validity: Int? = 0
  ) {
    self.value = value
    self.createdAt = createdAt
    self.acl = acl
    self.description = description
    self.indexes = indexes
    self.maxHitsPerQuery = maxHitsPerQuery
    self.maxQueriesPerIPPerHour = maxQueriesPerIPPerHour
    self.queryParameters = queryParameters
    self.referers = referers
    self.validity = validity
  }

  public enum CodingKeys: String, CodingKey, CaseIterable {
    case value
    case createdAt
    case acl
    case description
    case indexes
    case maxHitsPerQuery
    case maxQueriesPerIPPerHour
    case queryParameters
    case referers
    case validity
  }

  // Encodable protocol methods

  public func encode(to encoder: Encoder) throws {
    var container = encoder.container(keyedBy: CodingKeys.self)
    try container.encodeIfPresent(value, forKey: .value)
    try container.encode(createdAt, forKey: .createdAt)
    try container.encode(acl, forKey: .acl)
    try container.encodeIfPresent(description, forKey: .description)
    try container.encodeIfPresent(indexes, forKey: .indexes)
    try container.encodeIfPresent(maxHitsPerQuery, forKey: .maxHitsPerQuery)
    try container.encodeIfPresent(maxQueriesPerIPPerHour, forKey: .maxQueriesPerIPPerHour)
    try container.encodeIfPresent(queryParameters, forKey: .queryParameters)
    try container.encodeIfPresent(referers, forKey: .referers)
    try container.encodeIfPresent(validity, forKey: .validity)
  }
}