/** Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT. */
package com.algolia.client.model.personalization

import kotlinx.serialization.*
import kotlinx.serialization.json.*

/**
 * SetPersonalizationStrategyResponse
 *
 * @param message A message confirming the strategy update.
 */
@Serializable
public data class SetPersonalizationStrategyResponse(

  /** A message confirming the strategy update. */
  @SerialName(value = "message") val message: String,
)
