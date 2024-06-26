/** Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT. */
package com.algolia.client.model.ingestion

import kotlinx.serialization.*
import kotlinx.serialization.json.*

/**
 * Input for a manually-triggered task whose source is of type `bigquery` and for which extracted data spans a given time range.
 *
 * @param startDate Earliest date in RFC3339 format of the extracted data from Big Query.
 * @param endDate Latest date in RFC3339 format of the extracted data from Big Query.
 * @param mapping
 */
@Serializable
public data class OnDemandDateUtilsInput(

  /** Earliest date in RFC3339 format of the extracted data from Big Query. */
  @SerialName(value = "startDate") val startDate: String,

  /** Latest date in RFC3339 format of the extracted data from Big Query. */
  @SerialName(value = "endDate") val endDate: String,

  @SerialName(value = "mapping") val mapping: MappingInput? = null,
) : TaskInput
