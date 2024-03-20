// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on
// https://github.com/algolia/api-clients-automation. DO NOT EDIT.

import Foundation
#if canImport(Core)
    import Core
#endif

public struct RecommendRedirectRuleIndexMetadata: Codable, JSONEncodable, Hashable {
    /// Source index for the redirect rule.
    public var source: String
    /// Destination index for the redirect rule.
    public var dest: String
    /// Reason for the redirect rule.
    public var reason: String
    /// Redirect rule status.
    public var succeed: Bool
    public var data: RecommendRedirectRuleIndexMetadataData

    public init(
        source: String,
        dest: String,
        reason: String,
        succeed: Bool,
        data: RecommendRedirectRuleIndexMetadataData
    ) {
        self.source = source
        self.dest = dest
        self.reason = reason
        self.succeed = succeed
        self.data = data
    }

    public enum CodingKeys: String, CodingKey, CaseIterable {
        case source
        case dest
        case reason
        case succeed
        case data
    }

    // Encodable protocol methods

    public func encode(to encoder: Encoder) throws {
        var container = encoder.container(keyedBy: CodingKeys.self)
        try container.encode(self.source, forKey: .source)
        try container.encode(self.dest, forKey: .dest)
        try container.encode(self.reason, forKey: .reason)
        try container.encode(self.succeed, forKey: .succeed)
        try container.encode(self.data, forKey: .data)
    }
}