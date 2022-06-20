package com.algolia.model.analytics;

import com.google.gson.annotations.SerializedName;
import java.util.Objects;

/** SearchNoClickEvent */
public class SearchNoClickEvent {

  @SerializedName("search")
  private String search;

  @SerializedName("count")
  private Integer count;

  @SerializedName("withFilterCount")
  private Integer withFilterCount;

  public SearchNoClickEvent setSearch(String search) {
    this.search = search;
    return this;
  }

  /**
   * The search query.
   *
   * @return search
   */
  @javax.annotation.Nonnull
  public String getSearch() {
    return search;
  }

  public SearchNoClickEvent setCount(Integer count) {
    this.count = count;
    return this;
  }

  /**
   * The number of occurrences.
   *
   * @return count
   */
  @javax.annotation.Nonnull
  public Integer getCount() {
    return count;
  }

  public SearchNoClickEvent setWithFilterCount(Integer withFilterCount) {
    this.withFilterCount = withFilterCount;
    return this;
  }

  /**
   * The number of occurrences.
   *
   * @return withFilterCount
   */
  @javax.annotation.Nonnull
  public Integer getWithFilterCount() {
    return withFilterCount;
  }

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SearchNoClickEvent searchNoClickEvent = (SearchNoClickEvent) o;
    return (
      Objects.equals(this.search, searchNoClickEvent.search) &&
      Objects.equals(this.count, searchNoClickEvent.count) &&
      Objects.equals(this.withFilterCount, searchNoClickEvent.withFilterCount)
    );
  }

  @Override
  public int hashCode() {
    return Objects.hash(search, count, withFilterCount);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SearchNoClickEvent {\n");
    sb.append("    search: ").append(toIndentedString(search)).append("\n");
    sb.append("    count: ").append(toIndentedString(count)).append("\n");
    sb.append("    withFilterCount: ").append(toIndentedString(withFilterCount)).append("\n");
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