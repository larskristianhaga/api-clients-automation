// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost
// - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

package com.algolia.model.ingestion;

import com.fasterxml.jackson.annotation.*;
import com.fasterxml.jackson.databind.annotation.*;

/** Authentication resource not tied to any ecommerce platform, used for filtering. */
@JsonDeserialize(as = PlatformNone.class)
public enum PlatformNone implements PlatformWithNone {
  NONE("none");

  private final String value;

  PlatformNone(String value) {
    this.value = value;
  }

  @JsonValue
  public String getValue() {
    return value;
  }

  @Override
  public String toString() {
    return String.valueOf(value);
  }

  @JsonCreator
  public static PlatformNone fromValue(String value) {
    for (PlatformNone b : PlatformNone.values()) {
      if (b.value.equals(value)) {
        return b;
      }
    }
    throw new IllegalArgumentException("Unexpected value '" + value + "'");
  }
}
