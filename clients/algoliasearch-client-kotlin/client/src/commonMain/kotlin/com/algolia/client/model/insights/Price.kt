/** Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT. */
package com.algolia.client.model.insights

import com.algolia.client.exception.AlgoliaClientException
import com.algolia.client.extensions.internal.*
import kotlinx.serialization.*
import kotlinx.serialization.builtins.*
import kotlinx.serialization.descriptors.*
import kotlinx.serialization.encoding.*
import kotlinx.serialization.json.*
import kotlin.jvm.JvmInline

/**
 * The price of the item. This should be the final price, inclusive of any discounts in effect.
 *
 * Implementations:
 * - [Double] - *[Price.of]*
 * - [String] - *[Price.of]*
 */
@Serializable(PriceSerializer::class)
public sealed interface Price {

  @JvmInline
  public value class DoubleValue(public val value: Double) : Price

  @JvmInline
  public value class StringValue(public val value: String) : Price

  public companion object {

    /** [Price] as [Double] Value. */
    public fun of(value: Double): Price {
      return DoubleValue(value)
    }

    /** [Price] as [String] Value. */
    public fun of(value: String): Price {
      return StringValue(value)
    }
  }
}

internal class PriceSerializer : KSerializer<Price> {

  override val descriptor: SerialDescriptor = buildClassSerialDescriptor("Price")

  override fun serialize(encoder: Encoder, value: Price) {
    when (value) {
      is Price.DoubleValue -> Double.serializer().serialize(encoder, value.value)
      is Price.StringValue -> String.serializer().serialize(encoder, value.value)
    }
  }

  override fun deserialize(decoder: Decoder): Price {
    val codec = decoder.asJsonDecoder()
    val tree = codec.decodeJsonElement()

    // deserialize Double
    if (tree is JsonPrimitive) {
      try {
        val value = codec.json.decodeFromJsonElement(Double.serializer(), tree)
        return Price.of(value)
      } catch (e: Exception) {
        // deserialization failed, continue
        println("Failed to deserialize Double (error: ${e.message})")
      }
    }

    // deserialize String
    if (tree is JsonPrimitive) {
      try {
        val value = codec.json.decodeFromJsonElement(String.serializer(), tree)
        return Price.of(value)
      } catch (e: Exception) {
        // deserialization failed, continue
        println("Failed to deserialize String (error: ${e.message})")
      }
    }

    throw AlgoliaClientException("Failed to deserialize json element: $tree")
  }
}