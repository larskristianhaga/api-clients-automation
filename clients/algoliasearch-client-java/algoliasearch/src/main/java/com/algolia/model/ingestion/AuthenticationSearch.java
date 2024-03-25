// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost
// - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

package com.algolia.model.ingestion;

import com.fasterxml.jackson.annotation.*;
import com.fasterxml.jackson.databind.annotation.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

/** Request body for searching for authentication resources. */
public class AuthenticationSearch {

  @JsonProperty("authenticationIDs")
  private List<String> authenticationIDs = new ArrayList<>();

  public AuthenticationSearch setAuthenticationIDs(List<String> authenticationIDs) {
    this.authenticationIDs = authenticationIDs;
    return this;
  }

  public AuthenticationSearch addAuthenticationIDs(String authenticationIDsItem) {
    this.authenticationIDs.add(authenticationIDsItem);
    return this;
  }

  /** Get authenticationIDs */
  @javax.annotation.Nonnull
  public List<String> getAuthenticationIDs() {
    return authenticationIDs;
  }

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    AuthenticationSearch authenticationSearch = (AuthenticationSearch) o;
    return Objects.equals(this.authenticationIDs, authenticationSearch.authenticationIDs);
  }

  @Override
  public int hashCode() {
    return Objects.hash(authenticationIDs);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class AuthenticationSearch {\n");
    sb.append("    authenticationIDs: ").append(toIndentedString(authenticationIDs)).append("\n");
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
