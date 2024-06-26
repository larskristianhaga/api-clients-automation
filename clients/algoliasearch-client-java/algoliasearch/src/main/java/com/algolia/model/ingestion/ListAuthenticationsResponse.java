// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost
// - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

package com.algolia.model.ingestion;

import com.fasterxml.jackson.annotation.*;
import com.fasterxml.jackson.databind.annotation.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

/** ListAuthenticationsResponse */
public class ListAuthenticationsResponse {

  @JsonProperty("authentications")
  private List<Authentication> authentications = new ArrayList<>();

  @JsonProperty("pagination")
  private Pagination pagination;

  public ListAuthenticationsResponse setAuthentications(List<Authentication> authentications) {
    this.authentications = authentications;
    return this;
  }

  public ListAuthenticationsResponse addAuthentications(Authentication authenticationsItem) {
    this.authentications.add(authenticationsItem);
    return this;
  }

  /** Get authentications */
  @javax.annotation.Nonnull
  public List<Authentication> getAuthentications() {
    return authentications;
  }

  public ListAuthenticationsResponse setPagination(Pagination pagination) {
    this.pagination = pagination;
    return this;
  }

  /** Get pagination */
  @javax.annotation.Nonnull
  public Pagination getPagination() {
    return pagination;
  }

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ListAuthenticationsResponse listAuthenticationsResponse = (ListAuthenticationsResponse) o;
    return (
      Objects.equals(this.authentications, listAuthenticationsResponse.authentications) &&
      Objects.equals(this.pagination, listAuthenticationsResponse.pagination)
    );
  }

  @Override
  public int hashCode() {
    return Objects.hash(authentications, pagination);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ListAuthenticationsResponse {\n");
    sb.append("    authentications: ").append(toIndentedString(authentications)).append("\n");
    sb.append("    pagination: ").append(toIndentedString(pagination)).append("\n");
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
