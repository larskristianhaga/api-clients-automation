/** Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT. */
package com.algolia.client.model.analytics

import kotlinx.serialization.*
import kotlinx.serialization.json.*

/**
 * TopHitWithAnalytics
 *
 * @param hit The hit.
 * @param count The number of occurrences.
 * @param clickThroughRate The click-through rate.
 * @param conversionRate The conversion rate.
 * @param trackedSearchCount The number of tracked search click.
 * @param clickCount The number of click event.
 * @param conversionCount The number of converted clicks.
 */
@Serializable
public data class TopHitWithAnalytics(

  /** The hit. */
  @SerialName(value = "hit") val hit: String,

  /** The number of occurrences. */
  @SerialName(value = "count") val count: Int,

  /** The click-through rate. */
  @SerialName(value = "clickThroughRate") val clickThroughRate: Double,

  /** The conversion rate. */
  @SerialName(value = "conversionRate") val conversionRate: Double,

  /** The number of tracked search click. */
  @SerialName(value = "trackedSearchCount") val trackedSearchCount: Int,

  /** The number of click event. */
  @SerialName(value = "clickCount") val clickCount: Int,

  /** The number of converted clicks. */
  @SerialName(value = "conversionCount") val conversionCount: Int,
)