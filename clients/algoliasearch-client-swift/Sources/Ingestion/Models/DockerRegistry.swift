// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on
// https://github.com/algolia/api-clients-automation. DO NOT EDIT.

import Foundation
#if canImport(Core)
    import Core
#endif

/// Container registry name from where to pull the image.
public enum DockerRegistry: String, Codable, CaseIterable {
    case dockerhub
    case ghcr
}
