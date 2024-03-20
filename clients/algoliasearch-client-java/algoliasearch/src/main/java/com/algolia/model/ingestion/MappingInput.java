// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost
// - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

package com.algolia.model.ingestion;

import com.fasterxml.jackson.annotation.*;
import com.fasterxml.jackson.databind.annotation.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

/** Transformations to apply to source, serialized as a JSON string. */
public class MappingInput {

  @JsonProperty("format")
  private String format;

  @JsonProperty("actions")
  private List<MappingKitAction> actions = new ArrayList<>();

  public MappingInput setFormat(String format) {
    this.format = format;
    return this;
  }

  /** Name of the mapping format schema, `mappingkit/v1` is currently the only supported format. */
  @javax.annotation.Nonnull
  public String getFormat() {
    return format;
  }

  public MappingInput setActions(List<MappingKitAction> actions) {
    this.actions = actions;
    return this;
  }

  public MappingInput addActions(MappingKitAction actionsItem) {
    this.actions.add(actionsItem);
    return this;
  }

  /** Get actions */
  @javax.annotation.Nonnull
  public List<MappingKitAction> getActions() {
    return actions;
  }

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    MappingInput mappingInput = (MappingInput) o;
    return Objects.equals(this.format, mappingInput.format) && Objects.equals(this.actions, mappingInput.actions);
  }

  @Override
  public int hashCode() {
    return Objects.hash(format, actions);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class MappingInput {\n");
    sb.append("    format: ").append(toIndentedString(format)).append("\n");
    sb.append("    actions: ").append(toIndentedString(actions)).append("\n");
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