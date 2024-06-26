// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost
// - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

package com.algolia.model.abtesting;

import com.fasterxml.jackson.annotation.*;
import com.fasterxml.jackson.databind.annotation.*;
import java.util.Objects;

/** Configuration for the smallest difference between test variants you want to detect. */
public class MinimumDetectableEffect {

  @JsonProperty("size")
  private Double size;

  @JsonProperty("effect")
  private Effect effect;

  public MinimumDetectableEffect setSize(Double size) {
    this.size = size;
    return this;
  }

  /**
   * Smallest difference in an observable metric between variants. For example, to detect a 10%
   * difference between variants, set this value to 0.1. minimum: 0 maximum: 1
   */
  @javax.annotation.Nullable
  public Double getSize() {
    return size;
  }

  public MinimumDetectableEffect setEffect(Effect effect) {
    this.effect = effect;
    return this;
  }

  /** Get effect */
  @javax.annotation.Nullable
  public Effect getEffect() {
    return effect;
  }

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    MinimumDetectableEffect minimumDetectableEffect = (MinimumDetectableEffect) o;
    return Objects.equals(this.size, minimumDetectableEffect.size) && Objects.equals(this.effect, minimumDetectableEffect.effect);
  }

  @Override
  public int hashCode() {
    return Objects.hash(size, effect);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class MinimumDetectableEffect {\n");
    sb.append("    size: ").append(toIndentedString(size)).append("\n");
    sb.append("    effect: ").append(toIndentedString(effect)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
}
