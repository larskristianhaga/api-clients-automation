/** Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT. */
package com.algolia.client.model.analytics

import kotlinx.serialization.*
import kotlinx.serialization.json.*

/**
 * GetTopFiltersNoResultsValues
 *
 * @param count The number of occurrences.
 * @param values A list of filters without results.
 */
@Serializable
public data class GetTopFiltersNoResultsValues(

  /** The number of occurrences. */
  @SerialName(value = "count") val count: Int,

  /** A list of filters without results. */
  @SerialName(value = "values") val values: List<GetTopFiltersNoResultsValue>,
)