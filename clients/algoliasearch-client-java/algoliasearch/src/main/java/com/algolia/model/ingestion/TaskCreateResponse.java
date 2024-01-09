// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost
// - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

package com.algolia.model.ingestion;

import com.fasterxml.jackson.annotation.*;
import com.fasterxml.jackson.databind.annotation.*;
import java.util.Objects;

/** The response from the API after a task creation. */
public class TaskCreateResponse {

  @JsonProperty("taskID")
  private String taskID;

  @JsonProperty("createdAt")
  private String createdAt;

  public TaskCreateResponse setTaskID(String taskID) {
    this.taskID = taskID;
    return this;
  }

  /** The task UUID. */
  @javax.annotation.Nonnull
  public String getTaskID() {
    return taskID;
  }

  public TaskCreateResponse setCreatedAt(String createdAt) {
    this.createdAt = createdAt;
    return this;
  }

  /** Date of creation (RFC3339 format). */
  @javax.annotation.Nonnull
  public String getCreatedAt() {
    return createdAt;
  }

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    TaskCreateResponse taskCreateResponse = (TaskCreateResponse) o;
    return Objects.equals(this.taskID, taskCreateResponse.taskID) && Objects.equals(this.createdAt, taskCreateResponse.createdAt);
  }

  @Override
  public int hashCode() {
    return Objects.hash(taskID, createdAt);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class TaskCreateResponse {\n");
    sb.append("    taskID: ").append(toIndentedString(taskID)).append("\n");
    sb.append("    createdAt: ").append(toIndentedString(createdAt)).append("\n");
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