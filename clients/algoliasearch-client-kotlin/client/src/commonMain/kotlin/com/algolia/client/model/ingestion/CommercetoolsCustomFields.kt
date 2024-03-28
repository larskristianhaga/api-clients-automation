/** Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT. */
package com.algolia.client.model.ingestion

import kotlinx.serialization.*
import kotlinx.serialization.json.*

/**
 * Custom fields from commercetools to add to the records.  For more information, see [Using Custom Types and Custom Fields](https://docs.commercetools.com/tutorials/custom-types).
 *
 * @param inventory Inventory custom fields.
 * @param price Price custom fields.
 * @param category Category custom fields.
 */
@Serializable
public data class CommercetoolsCustomFields(

  /** Inventory custom fields. */
  @SerialName(value = "inventory") val inventory: List<String>? = null,

  /** Price custom fields. */
  @SerialName(value = "price") val price: List<String>? = null,

  /** Category custom fields. */
  @SerialName(value = "category") val category: List<String>? = null,
)
