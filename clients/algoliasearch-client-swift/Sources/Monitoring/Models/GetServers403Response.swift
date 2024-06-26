// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on
// https://github.com/algolia/api-clients-automation. DO NOT EDIT.

import Foundation
#if canImport(Core)
    import Core
#endif

public struct GetServers403Response: Codable, JSONEncodable {
    public var reason: String?

    public init(reason: String? = nil) {
        self.reason = reason
    }

    public enum CodingKeys: String, CodingKey, CaseIterable {
        case reason
    }

    // Encodable protocol methods

    public func encode(to encoder: Encoder) throws {
        var container = encoder.container(keyedBy: CodingKeys.self)
        try container.encodeIfPresent(self.reason, forKey: .reason)
    }
}

extension GetServers403Response: Equatable {
    public static func ==(lhs: GetServers403Response, rhs: GetServers403Response) -> Bool {
        lhs.reason == rhs.reason
    }
}

extension GetServers403Response: Hashable {
    public func hash(into hasher: inout Hasher) {
        hasher.combine(self.reason?.hashValue)
    }
}
