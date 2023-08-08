// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost
// - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

package com.algolia.model.analytics;

import com.fasterxml.jackson.annotation.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

/** GetAverageClickPositionResponse */
public class GetAverageClickPositionResponse {

  @JsonProperty("average")
  private Double average;

  @JsonProperty("clickCount")
  private Integer clickCount;

  @JsonProperty("dates")
  private List<AverageClickEvent> dates = new ArrayList<>();

  public GetAverageClickPositionResponse setAverage(Double average) {
    this.average = average;
    return this;
  }

  /**
   * Average count of all click events.
   *
   * @return average
   */
  @javax.annotation.Nonnull
  public Double getAverage() {
    return average;
  }

  public GetAverageClickPositionResponse setClickCount(Integer clickCount) {
    this.clickCount = clickCount;
    return this;
  }

  /**
   * Number of click events.
   *
   * @return clickCount
   */
  @javax.annotation.Nonnull
  public Integer getClickCount() {
    return clickCount;
  }

  public GetAverageClickPositionResponse setDates(List<AverageClickEvent> dates) {
    this.dates = dates;
    return this;
  }

  public GetAverageClickPositionResponse addDates(AverageClickEvent datesItem) {
    this.dates.add(datesItem);
    return this;
  }

  /**
   * Average click positions.
   *
   * @return dates
   */
  @javax.annotation.Nonnull
  public List<AverageClickEvent> getDates() {
    return dates;
  }

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    GetAverageClickPositionResponse getAverageClickPositionResponse = (GetAverageClickPositionResponse) o;
    return (
      Objects.equals(this.average, getAverageClickPositionResponse.average) &&
      Objects.equals(this.clickCount, getAverageClickPositionResponse.clickCount) &&
      Objects.equals(this.dates, getAverageClickPositionResponse.dates)
    );
  }

  @Override
  public int hashCode() {
    return Objects.hash(average, clickCount, dates);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class GetAverageClickPositionResponse {\n");
    sb.append("    average: ").append(toIndentedString(average)).append("\n");
    sb.append("    clickCount: ").append(toIndentedString(clickCount)).append("\n");
    sb.append("    dates: ").append(toIndentedString(dates)).append("\n");
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