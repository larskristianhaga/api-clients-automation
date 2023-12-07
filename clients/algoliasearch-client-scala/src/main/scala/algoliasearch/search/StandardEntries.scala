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

/** Key-value pairs of [supported language ISO
  * codes](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/supported-languages/)
  * and boolean values.
  *
  * @param plurals
  *   Key-value pair of a language ISO code and a boolean value.
  * @param stopwords
  *   Key-value pair of a language ISO code and a boolean value.
  * @param compounds
  *   Key-value pair of a language ISO code and a boolean value.
  */
case class StandardEntries(
    plurals: Option[Map[String, Boolean]] = scala.None,
    stopwords: Option[Map[String, Boolean]] = scala.None,
    compounds: Option[Map[String, Boolean]] = scala.None
)