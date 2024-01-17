// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

import Core
import Foundation

#if canImport(AnyCodable)
  import AnyCodable
#endif

/// Type of batch operation.
public enum Action: String, Codable, CaseIterable {
  case addobject = "addObject"
  case updateobject = "updateObject"
  case partialupdateobject = "partialUpdateObject"
  case partialupdateobjectnocreate = "partialUpdateObjectNoCreate"
  case deleteobject = "deleteObject"
  case delete = "delete"
  case clear = "clear"
}