// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost
// - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

package com.algolia.model.ingestion;

import com.fasterxml.jackson.annotation.*;
import com.fasterxml.jackson.databind.annotation.*;
import java.util.HashMap;
import java.util.Map;
import java.util.Objects;

/** SourceCSV */
@JsonDeserialize(as = SourceCSV.class)
public class SourceCSV implements SourceInput, SourceUpdateInput {

  @JsonProperty("url")
  private String url;

  @JsonProperty("uniqueIDColumn")
  private String uniqueIDColumn;

  @JsonProperty("mapping")
  private Map<String, MappingTypeCSV> mapping;

  @JsonProperty("method")
  private MethodType method;

  @JsonProperty("delimiter")
  private String delimiter;

  public SourceCSV setUrl(String url) {
    this.url = url;
    return this;
  }

  /** URL of the file. */
  @javax.annotation.Nonnull
  public String getUrl() {
    return url;
  }

  public SourceCSV setUniqueIDColumn(String uniqueIDColumn) {
    this.uniqueIDColumn = uniqueIDColumn;
    return this;
  }

  /** Name of a column that contains a unique ID which will be used as `objectID` in Algolia. */
  @javax.annotation.Nullable
  public String getUniqueIDColumn() {
    return uniqueIDColumn;
  }

  public SourceCSV setMapping(Map<String, MappingTypeCSV> mapping) {
    this.mapping = mapping;
    return this;
  }

  public SourceCSV putMapping(String key, MappingTypeCSV mappingItem) {
    if (this.mapping == null) {
      this.mapping = new HashMap<>();
    }
    this.mapping.put(key, mappingItem);
    return this;
  }

  /** Key-value pairs of column names and their expected types. */
  @javax.annotation.Nullable
  public Map<String, MappingTypeCSV> getMapping() {
    return mapping;
  }

  public SourceCSV setMethod(MethodType method) {
    this.method = method;
    return this;
  }

  /** Get method */
  @javax.annotation.Nullable
  public MethodType getMethod() {
    return method;
  }

  public SourceCSV setDelimiter(String delimiter) {
    this.delimiter = delimiter;
    return this;
  }

  /**
   * The character used to split the value on each line, default to a comma (\\r, \\n, 0xFFFD, and
   * space are forbidden).
   */
  @javax.annotation.Nullable
  public String getDelimiter() {
    return delimiter;
  }

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SourceCSV sourceCSV = (SourceCSV) o;
    return (
      Objects.equals(this.url, sourceCSV.url) &&
      Objects.equals(this.uniqueIDColumn, sourceCSV.uniqueIDColumn) &&
      Objects.equals(this.mapping, sourceCSV.mapping) &&
      Objects.equals(this.method, sourceCSV.method) &&
      Objects.equals(this.delimiter, sourceCSV.delimiter)
    );
  }

  @Override
  public int hashCode() {
    return Objects.hash(url, uniqueIDColumn, mapping, method, delimiter);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SourceCSV {\n");
    sb.append("    url: ").append(toIndentedString(url)).append("\n");
    sb.append("    uniqueIDColumn: ").append(toIndentedString(uniqueIDColumn)).append("\n");
    sb.append("    mapping: ").append(toIndentedString(mapping)).append("\n");
    sb.append("    method: ").append(toIndentedString(method)).append("\n");
    sb.append("    delimiter: ").append(toIndentedString(delimiter)).append("\n");
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
