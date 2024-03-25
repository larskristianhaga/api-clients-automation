/** Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT. */
package com.algolia.client.model.ingestion

import kotlinx.serialization.*
import kotlinx.serialization.json.*

/**
 * API response for creating a task.
 *
 * @param taskID Universally unique identifier (UUID) of a task.
 * @param createdAt Date of creation in RFC3339 format.
 */
@Serializable
public data class TaskCreateResponse(

  /** Universally unique identifier (UUID) of a task. */
  @SerialName(value = "taskID") val taskID: String,

  /** Date of creation in RFC3339 format. */
  @SerialName(value = "createdAt") val createdAt: String,
)
