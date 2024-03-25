/** Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT. */
package com.algolia.client.model.ingestion

import kotlinx.serialization.*
import kotlinx.serialization.json.*

/**
 * Trigger input for subscription tasks.
 *
 * @param type
 */
@Serializable
public data class SubscriptionTrigger(

  @SerialName(value = "type") val type: SubscriptionTriggerType,
) : Trigger, TaskCreateTrigger
