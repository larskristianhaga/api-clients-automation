// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost
// - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

package com.algolia.model.ingestion;

import com.fasterxml.jackson.annotation.*;
import com.fasterxml.jackson.databind.annotation.*;
import java.util.Objects;

/** SourceGA4BigQueryExport */
@JsonDeserialize(as = SourceGA4BigQueryExport.class)
public class SourceGA4BigQueryExport implements SourceInput, SourceUpdateInput {

  @JsonProperty("projectID")
  private String projectID;

  @JsonProperty("datasetID")
  private String datasetID;

  @JsonProperty("tablePrefix")
  private String tablePrefix;

  public SourceGA4BigQueryExport setProjectID(String projectID) {
    this.projectID = projectID;
    return this;
  }

  /** GCP project ID that the BigQuery Export writes to. */
  @javax.annotation.Nonnull
  public String getProjectID() {
    return projectID;
  }

  public SourceGA4BigQueryExport setDatasetID(String datasetID) {
    this.datasetID = datasetID;
    return this;
  }

  /** BigQuery dataset ID that the BigQuery Export writes to. */
  @javax.annotation.Nonnull
  public String getDatasetID() {
    return datasetID;
  }

  public SourceGA4BigQueryExport setTablePrefix(String tablePrefix) {
    this.tablePrefix = tablePrefix;
    return this;
  }

  /**
   * Prefix of the tables that the BigQuery Export writes to (i.e. events_intraday_ for streaming,
   * events_ for daily).
   */
  @javax.annotation.Nonnull
  public String getTablePrefix() {
    return tablePrefix;
  }

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SourceGA4BigQueryExport sourceGA4BigQueryExport = (SourceGA4BigQueryExport) o;
    return (
      Objects.equals(this.projectID, sourceGA4BigQueryExport.projectID) &&
      Objects.equals(this.datasetID, sourceGA4BigQueryExport.datasetID) &&
      Objects.equals(this.tablePrefix, sourceGA4BigQueryExport.tablePrefix)
    );
  }

  @Override
  public int hashCode() {
    return Objects.hash(projectID, datasetID, tablePrefix);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SourceGA4BigQueryExport {\n");
    sb.append("    projectID: ").append(toIndentedString(projectID)).append("\n");
    sb.append("    datasetID: ").append(toIndentedString(datasetID)).append("\n");
    sb.append("    tablePrefix: ").append(toIndentedString(tablePrefix)).append("\n");
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