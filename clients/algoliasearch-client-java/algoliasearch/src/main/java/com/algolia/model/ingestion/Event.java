// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost
// - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

package com.algolia.model.ingestion;

import com.fasterxml.jackson.annotation.*;
import com.fasterxml.jackson.databind.annotation.*;
import java.util.HashMap;
import java.util.Map;
import java.util.Objects;

/** An event describe a step of the task execution flow.. */
public class Event {

  @JsonProperty("eventID")
  private String eventID;

  @JsonProperty("runID")
  private String runID;

  @JsonProperty("parentID")
  private String parentID;

  @JsonProperty("status")
  private EventStatus status;

  @JsonProperty("type")
  private EventType type;

  @JsonProperty("batchSize")
  private Integer batchSize;

  @JsonProperty("data")
  private Map<String, Object> data;

  @JsonProperty("publishedAt")
  private String publishedAt;

  public Event setEventID(String eventID) {
    this.eventID = eventID;
    return this;
  }

  /** Universally unique identifier (UUID) of an event. */
  @javax.annotation.Nonnull
  public String getEventID() {
    return eventID;
  }

  public Event setRunID(String runID) {
    this.runID = runID;
    return this;
  }

  /** Universally unique identifier (UUID) of a task run. */
  @javax.annotation.Nonnull
  public String getRunID() {
    return runID;
  }

  public Event setParentID(String parentID) {
    this.parentID = parentID;
    return this;
  }

  /** The parent event, the cause of this event. */
  @javax.annotation.Nullable
  public String getParentID() {
    return parentID;
  }

  public Event setStatus(EventStatus status) {
    this.status = status;
    return this;
  }

  /** Get status */
  @javax.annotation.Nonnull
  public EventStatus getStatus() {
    return status;
  }

  public Event setType(EventType type) {
    this.type = type;
    return this;
  }

  /** Get type */
  @javax.annotation.Nonnull
  public EventType getType() {
    return type;
  }

  public Event setBatchSize(Integer batchSize) {
    this.batchSize = batchSize;
    return this;
  }

  /** The extracted record batch size. minimum: 0 */
  @javax.annotation.Nonnull
  public Integer getBatchSize() {
    return batchSize;
  }

  public Event setData(Map<String, Object> data) {
    this.data = data;
    return this;
  }

  public Event putData(String key, Object dataItem) {
    if (this.data == null) {
      this.data = new HashMap<>();
    }
    this.data.put(key, dataItem);
    return this;
  }

  /** Get data */
  @javax.annotation.Nullable
  public Map<String, Object> getData() {
    return data;
  }

  public Event setPublishedAt(String publishedAt) {
    this.publishedAt = publishedAt;
    return this;
  }

  /** Date of publish RFC3339 format. */
  @javax.annotation.Nonnull
  public String getPublishedAt() {
    return publishedAt;
  }

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Event event = (Event) o;
    return (
      Objects.equals(this.eventID, event.eventID) &&
      Objects.equals(this.runID, event.runID) &&
      Objects.equals(this.parentID, event.parentID) &&
      Objects.equals(this.status, event.status) &&
      Objects.equals(this.type, event.type) &&
      Objects.equals(this.batchSize, event.batchSize) &&
      Objects.equals(this.data, event.data) &&
      Objects.equals(this.publishedAt, event.publishedAt)
    );
  }

  @Override
  public int hashCode() {
    return Objects.hash(eventID, runID, parentID, status, type, batchSize, data, publishedAt);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Event {\n");
    sb.append("    eventID: ").append(toIndentedString(eventID)).append("\n");
    sb.append("    runID: ").append(toIndentedString(runID)).append("\n");
    sb.append("    parentID: ").append(toIndentedString(parentID)).append("\n");
    sb.append("    status: ").append(toIndentedString(status)).append("\n");
    sb.append("    type: ").append(toIndentedString(type)).append("\n");
    sb.append("    batchSize: ").append(toIndentedString(batchSize)).append("\n");
    sb.append("    data: ").append(toIndentedString(data)).append("\n");
    sb.append("    publishedAt: ").append(toIndentedString(publishedAt)).append("\n");
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
