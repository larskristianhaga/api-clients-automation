/** Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT. */
package com.algolia.client.model.abtesting

import kotlinx.serialization.*
import kotlinx.serialization.json.*

/**
 * ABTestResponse
 *
 * @param index Index name of the A/B test variant (case-sensitive).
 * @param abTestID Unique A/B test identifier.
 * @param taskID Unique identifier of a task.  A successful API response means that a task was added to a queue. It might not run immediately. You can check the task's progress with the [`task` operation](#tag/Indices/operation/getTask) and this `taskID`.
 */
@Serializable
public data class ABTestResponse(

  /** Index name of the A/B test variant (case-sensitive). */
  @SerialName(value = "index") val index: String,

  /** Unique A/B test identifier. */
  @SerialName(value = "abTestID") val abTestID: Int,

  /** Unique identifier of a task.  A successful API response means that a task was added to a queue. It might not run immediately. You can check the task's progress with the [`task` operation](#tag/Indices/operation/getTask) and this `taskID`.  */
  @SerialName(value = "taskID") val taskID: Long,
)
