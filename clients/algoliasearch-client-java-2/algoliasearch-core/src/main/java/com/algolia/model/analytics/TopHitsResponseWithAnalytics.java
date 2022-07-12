// This file is generated, manual changes will be lost - read more on
// https://github.com/algolia/api-clients-automation.

package com.algolia.model.analytics;

import com.fasterxml.jackson.annotation.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

/** TopHitsResponseWithAnalytics */
public class TopHitsResponseWithAnalytics {

  @JsonProperty("hits")
  private List<TopHitWithAnalytics> hits = new ArrayList<>();

  public TopHitsResponseWithAnalytics setHits(List<TopHitWithAnalytics> hits) {
    this.hits = hits;
    return this;
  }

  public TopHitsResponseWithAnalytics addHits(TopHitWithAnalytics hitsItem) {
    this.hits.add(hitsItem);
    return this;
  }

  /**
   * A list of top hits with their count and analytics.
   *
   * @return hits
   */
  @javax.annotation.Nonnull
  public List<TopHitWithAnalytics> getHits() {
    return hits;
  }

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    TopHitsResponseWithAnalytics topHitsResponseWithAnalytics = (TopHitsResponseWithAnalytics) o;
    return Objects.equals(this.hits, topHitsResponseWithAnalytics.hits);
  }

  @Override
  public int hashCode() {
    return Objects.hash(hits);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class TopHitsResponseWithAnalytics {\n");
    sb.append("    hits: ").append(toIndentedString(hits)).append("\n");
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
