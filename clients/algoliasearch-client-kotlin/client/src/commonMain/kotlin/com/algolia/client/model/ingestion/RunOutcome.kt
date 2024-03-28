/** Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT. */
package com.algolia.client.model.ingestion

import kotlinx.serialization.*

/**
 * Task run outcome.
 */
@Serializable
public enum class RunOutcome(public val value: kotlin.String) {

  @SerialName(value = "success")
  Success("success"),

  @SerialName(value = "failure")
  Failure("failure"),

  @SerialName(value = "processing")
  Processing("processing");

  override fun toString(): kotlin.String = value
}
