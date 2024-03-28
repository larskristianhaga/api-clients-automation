// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on
// https://github.com/algolia/api-clients-automation. DO NOT EDIT.

import Foundation
#if canImport(Core)
    import Core
#endif

/// An event describe a step of the task execution flow..
public struct Event: Codable, JSONEncodable {
    /// Universally unique identifier (UUID) of an event.
    public var eventID: String
    /// Universally unique identifier (UUID) of a task run.
    public var runID: String
    /// The parent event, the cause of this event.
    public var parentID: String?
    public var status: EventStatus
    public var type: EventType
    /// The extracted record batch size.
    public var batchSize: Int
    public var data: [String: AnyCodable]?
    /// Date of publish RFC3339 format.
    public var publishedAt: String

    public init(
        eventID: String,
        runID: String,
        parentID: String? = nil,
        status: EventStatus,
        type: EventType,
        batchSize: Int,
        data: [String: AnyCodable]? = nil,
        publishedAt: String
    ) {
        self.eventID = eventID
        self.runID = runID
        self.parentID = parentID
        self.status = status
        self.type = type
        self.batchSize = batchSize
        self.data = data
        self.publishedAt = publishedAt
    }

    public enum CodingKeys: String, CodingKey, CaseIterable {
        case eventID
        case runID
        case parentID
        case status
        case type
        case batchSize
        case data
        case publishedAt
    }

    // Encodable protocol methods

    public func encode(to encoder: Encoder) throws {
        var container = encoder.container(keyedBy: CodingKeys.self)
        try container.encode(self.eventID, forKey: .eventID)
        try container.encode(self.runID, forKey: .runID)
        try container.encodeIfPresent(self.parentID, forKey: .parentID)
        try container.encode(self.status, forKey: .status)
        try container.encode(self.type, forKey: .type)
        try container.encode(self.batchSize, forKey: .batchSize)
        try container.encodeIfPresent(self.data, forKey: .data)
        try container.encode(self.publishedAt, forKey: .publishedAt)
    }
}
