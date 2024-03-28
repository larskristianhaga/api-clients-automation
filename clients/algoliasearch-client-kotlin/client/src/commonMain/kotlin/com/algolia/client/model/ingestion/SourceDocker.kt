/** Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT. */
package com.algolia.client.model.ingestion

import kotlinx.serialization.*
import kotlinx.serialization.json.*

/**
 * SourceDocker
 *
 * @param imageType
 * @param registry
 * @param image Docker image name.
 * @param configuration Configuration of the spec.
 * @param version Docker image version.
 */
@Serializable
public data class SourceDocker(

  @SerialName(value = "imageType") val imageType: DockerImageType,

  @SerialName(value = "registry") val registry: DockerRegistry,

  /** Docker image name. */
  @SerialName(value = "image") val image: String,

  /** Configuration of the spec. */
  @SerialName(value = "configuration") val configuration: JsonObject,

  /** Docker image version. */
  @SerialName(value = "version") val version: String? = null,
) : SourceInput
