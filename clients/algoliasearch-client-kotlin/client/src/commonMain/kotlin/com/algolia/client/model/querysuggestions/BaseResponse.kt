/** Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT. */
package com.algolia.client.model.querysuggestions

import kotlinx.serialization.*
import kotlinx.serialization.json.*

/**
 * BaseResponse
 *
 * @param status HTTP status code.
 * @param message Details about the response, such as error messages.
 */
@Serializable
public data class BaseResponse(

  /** HTTP status code. */
  @SerialName(value = "status") val status: Int? = null,

  /** Details about the response, such as error messages. */
  @SerialName(value = "message") val message: String? = null,
)
