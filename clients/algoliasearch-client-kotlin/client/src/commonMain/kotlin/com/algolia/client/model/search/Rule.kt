/** Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT. */
package com.algolia.client.model.search

import kotlinx.serialization.*
import kotlinx.serialization.json.*

/**
 * Rule object.
 *
 * @param objectID Unique identifier of the object.
 * @param conditions A list of conditions that should apply to activate a Rule. You can use up to 25 conditions per Rule.
 * @param consequence
 * @param description This field is intended for Rule management purposes, in particular to ease searching for Rules and presenting them to human readers. It's not interpreted by the API.
 * @param enabled Whether the Rule is enabled. Disabled Rules remain in the index, but aren't applied at query time.
 * @param validity By default, Rules are permanently valid. When validity periods are specified, the Rule applies only during those periods; it's ignored the rest of the time. The list must not be empty.
 */
@Serializable
public data class Rule(

  /** Unique identifier of the object. */
  @SerialName(value = "objectID") val objectID: String,

  /** A list of conditions that should apply to activate a Rule. You can use up to 25 conditions per Rule. */
  @SerialName(value = "conditions") val conditions: List<Condition>? = null,

  @SerialName(value = "consequence") val consequence: Consequence? = null,

  /** This field is intended for Rule management purposes, in particular to ease searching for Rules and presenting them to human readers. It's not interpreted by the API. */
  @SerialName(value = "description") val description: String? = null,

  /** Whether the Rule is enabled. Disabled Rules remain in the index, but aren't applied at query time. */
  @SerialName(value = "enabled") val enabled: Boolean? = null,

  /** By default, Rules are permanently valid. When validity periods are specified, the Rule applies only during those periods; it's ignored the rest of the time. The list must not be empty. */
  @SerialName(value = "validity") val validity: List<TimeRange>? = null,
)