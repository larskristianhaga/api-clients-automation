/** Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT. */
package com.algolia.client.model.abtesting

import kotlinx.serialization.*
import kotlinx.serialization.json.*

/**
 * Configuration for handling outliers.
 *
 * @param exclude Whether to exclude outliers when calculating A/B test results.
 */
@Serializable
public data class Outliers(

  /** Whether to exclude outliers when calculating A/B test results. */
  @SerialName(value = "exclude") val exclude: Boolean? = null,
)
