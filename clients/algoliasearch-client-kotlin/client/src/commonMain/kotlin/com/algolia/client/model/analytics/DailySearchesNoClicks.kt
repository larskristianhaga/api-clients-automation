/** Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT. */
package com.algolia.client.model.analytics

import kotlinx.serialization.*
import kotlinx.serialization.json.*

/**
 * DailySearchesNoClicks
 *
 * @param search Search query.
 * @param count Number of tracked searches.
 * @param nbHits Number of results (hits).
 */
@Serializable
public data class DailySearchesNoClicks(

  /** Search query. */
  @SerialName(value = "search") val search: String,

  /** Number of tracked searches. */
  @SerialName(value = "count") val count: Int,

  /** Number of results (hits). */
  @SerialName(value = "nbHits") val nbHits: Int,
)