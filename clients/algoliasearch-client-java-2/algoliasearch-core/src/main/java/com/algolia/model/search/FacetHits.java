// This file is generated, manual changes will be lost - read more on
// https://github.com/algolia/api-clients-automation.

package com.algolia.model.search;

import com.fasterxml.jackson.annotation.*;
import java.util.Objects;

/** FacetHits */
public class FacetHits {

  @JsonProperty("value")
  private String value;

  @JsonProperty("highlighted")
  private String highlighted;

  @JsonProperty("count")
  private Integer count;

  public FacetHits setValue(String value) {
    this.value = value;
    return this;
  }

  /**
   * Raw value of the facet.
   *
   * @return value
   */
  @javax.annotation.Nonnull
  public String getValue() {
    return value;
  }

  public FacetHits setHighlighted(String highlighted) {
    this.highlighted = highlighted;
    return this;
  }

  /**
   * Markup text with occurrences highlighted.
   *
   * @return highlighted
   */
  @javax.annotation.Nonnull
  public String getHighlighted() {
    return highlighted;
  }

  public FacetHits setCount(Integer count) {
    this.count = count;
    return this;
  }

  /**
   * How many objects contain this facet value. This takes into account the extra search parameters
   * specified in the query. Like for a regular search query, the counts may not be exhaustive.
   *
   * @return count
   */
  @javax.annotation.Nonnull
  public Integer getCount() {
    return count;
  }

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    FacetHits facetHits = (FacetHits) o;
    return (
      Objects.equals(this.value, facetHits.value) &&
      Objects.equals(this.highlighted, facetHits.highlighted) &&
      Objects.equals(this.count, facetHits.count)
    );
  }

  @Override
  public int hashCode() {
    return Objects.hash(value, highlighted, count);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class FacetHits {\n");
    sb.append("    value: ").append(toIndentedString(value)).append("\n");
    sb.append("    highlighted: ").append(toIndentedString(highlighted)).append("\n");
    sb.append("    count: ").append(toIndentedString(count)).append("\n");
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
