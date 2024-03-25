/** Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT. */
package com.algolia.client.model.analytics

import kotlinx.serialization.*
import kotlinx.serialization.json.*

/**
 * DailySearchesNoResults
 *
 * @param search Search query.
 * @param count Number of occurrences.
 * @param withFilterCount Number of searches for this term with applied filters.
 */
@Serializable
public data class DailySearchesNoResults(

  /** Search query. */
  @SerialName(value = "search") val search: String,

  /** Number of occurrences. */
  @SerialName(value = "count") val count: Int,

  /** Number of searches for this term with applied filters. */
  @SerialName(value = "withFilterCount") val withFilterCount: Int,
)