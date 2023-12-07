/** Search API Use the Search REST API to manage your data (indices and records), implement search, and improve
  * relevance (with Rules, synonyms, and language dictionaries). Although Algolia provides a REST API, you should use
  * the official open source API [clients, libraries, and
  * tools](https://www.algolia.com/doc/guides/getting-started/how-algolia-works/in-depth/ecosystem/) instead. There's no
  * [SLA](https://www.algolia.com/policies/sla/) if you use the REST API directly.
  *
  * The version of the OpenAPI document: 1.0.0
  *
  * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
  * https://openapi-generator.tech Do not edit the class manually.
  */
package algoliasearch.search

/** RankingInfo
  *
  * @param filters
  *   This field is reserved for advanced usage.
  * @param firstMatchedWord
  *   Position of the most important matched attribute in the attributes to index list.
  * @param geoDistance
  *   Distance between the geo location in the search query and the best matching geo location in the record, divided by
  *   the geo precision (in meters).
  * @param geoPrecision
  *   Precision used when computing the geo distance, in meters.
  * @param nbExactWords
  *   Number of exactly matched words.
  * @param nbTypos
  *   Number of typos encountered when matching the record.
  * @param promoted
  *   Present and set to true if a Rule promoted the hit.
  * @param proximityDistance
  *   When the query contains more than one word, the sum of the distances between matched words (in meters).
  * @param userScore
  *   Custom ranking for the object, expressed as a single integer value.
  * @param words
  *   Number of matched words, including prefixes and typos.
  * @param promotedByReRanking
  *   Wether the record are promoted by the re-ranking strategy.
  */
case class RankingInfo(
    filters: Int,
    firstMatchedWord: Int,
    geoDistance: Int,
    geoPrecision: Option[Int] = scala.None,
    matchedGeoLocation: Option[MatchedGeoLocation] = scala.None,
    personalization: Option[Personalization] = scala.None,
    nbExactWords: Int,
    nbTypos: Int,
    promoted: Boolean,
    proximityDistance: Option[Int] = scala.None,
    userScore: Int,
    words: Int,
    promotedByReRanking: Option[Boolean] = scala.None
)