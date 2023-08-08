// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost
// - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

package com.algolia.model.recommend;

import com.fasterxml.jackson.annotation.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

/** SearchRecommendRulesResponse */
public class SearchRecommendRulesResponse {

  @JsonProperty("hits")
  private List<RuleResponse> hits = new ArrayList<>();

  @JsonProperty("nbHits")
  private Integer nbHits;

  @JsonProperty("page")
  private Integer page;

  @JsonProperty("nbPages")
  private Integer nbPages;

  public SearchRecommendRulesResponse setHits(List<RuleResponse> hits) {
    this.hits = hits;
    return this;
  }

  public SearchRecommendRulesResponse addHits(RuleResponse hitsItem) {
    this.hits.add(hitsItem);
    return this;
  }

  /**
   * Fetched rules.
   *
   * @return hits
   */
  @javax.annotation.Nonnull
  public List<RuleResponse> getHits() {
    return hits;
  }

  public SearchRecommendRulesResponse setNbHits(Integer nbHits) {
    this.nbHits = nbHits;
    return this;
  }

  /**
   * Number of fetched rules.
   *
   * @return nbHits
   */
  @javax.annotation.Nonnull
  public Integer getNbHits() {
    return nbHits;
  }

  public SearchRecommendRulesResponse setPage(Integer page) {
    this.page = page;
    return this;
  }

  /**
   * Current page.
   *
   * @return page
   */
  @javax.annotation.Nonnull
  public Integer getPage() {
    return page;
  }

  public SearchRecommendRulesResponse setNbPages(Integer nbPages) {
    this.nbPages = nbPages;
    return this;
  }

  /**
   * Number of pages.
   *
   * @return nbPages
   */
  @javax.annotation.Nonnull
  public Integer getNbPages() {
    return nbPages;
  }

  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SearchRecommendRulesResponse searchRecommendRulesResponse = (SearchRecommendRulesResponse) o;
    return (
      Objects.equals(this.hits, searchRecommendRulesResponse.hits) &&
      Objects.equals(this.nbHits, searchRecommendRulesResponse.nbHits) &&
      Objects.equals(this.page, searchRecommendRulesResponse.page) &&
      Objects.equals(this.nbPages, searchRecommendRulesResponse.nbPages)
    );
  }

  @Override
  public int hashCode() {
    return Objects.hash(hits, nbHits, page, nbPages);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SearchRecommendRulesResponse {\n");
    sb.append("    hits: ").append(toIndentedString(hits)).append("\n");
    sb.append("    nbHits: ").append(toIndentedString(nbHits)).append("\n");
    sb.append("    page: ").append(toIndentedString(page)).append("\n");
    sb.append("    nbPages: ").append(toIndentedString(nbPages)).append("\n");
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