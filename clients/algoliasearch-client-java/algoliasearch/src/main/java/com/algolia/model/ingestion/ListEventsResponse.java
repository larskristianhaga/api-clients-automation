// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost
// - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

package com.algolia.model.ingestion;

import com.fasterxml.jackson.annotation.*;
import com.fasterxml.jackson.databind.annotation.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

/** ListEventsResponse */
public class ListEventsResponse {

  @JsonProperty("events")
  private List<Event> events = new ArrayList<>();

  @JsonProperty("pagination")
  private Pagination pagination;

  @JsonProperty("window")
  private Window window;

  public ListEventsResponse setEvents(List<Event> events) {
    this.events = events;
    return this;
  }

  public ListEventsResponse addEvents(Event eventsItem) {
    this.events.add(eventsItem);
    return this;
  }

  /** Get events */
  @javax.annotation.Nonnull
  public List<Event> getEvents() {
    return events;
  }

  public ListEventsResponse setPagination(Pagination pagination) {
    this.pagination = pagination;
    return this;
  }

  /** Get pagination */
  @javax.annotation.Nonnull
  public Pagination getPagination() {
    return pagination;
  }

  public ListEventsResponse setWindow(Window window) {
    this.window = window;
    return this;
  }

  /** Get window */
  @javax.annotation.Nonnull
  public Window getWindow() {
    return window;
  }

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ListEventsResponse listEventsResponse = (ListEventsResponse) o;
    return (
      Objects.equals(this.events, listEventsResponse.events) &&
      Objects.equals(this.pagination, listEventsResponse.pagination) &&
      Objects.equals(this.window, listEventsResponse.window)
    );
  }

  @Override
  public int hashCode() {
    return Objects.hash(events, pagination, window);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ListEventsResponse {\n");
    sb.append("    events: ").append(toIndentedString(events)).append("\n");
    sb.append("    pagination: ").append(toIndentedString(pagination)).append("\n");
    sb.append("    window: ").append(toIndentedString(window)).append("\n");
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
