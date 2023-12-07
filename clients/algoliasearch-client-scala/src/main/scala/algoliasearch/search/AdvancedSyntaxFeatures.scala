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

import org.json4s._

sealed trait AdvancedSyntaxFeatures

/** AdvancedSyntaxFeatures enumeration
  */
object AdvancedSyntaxFeatures {
  case object ExactPhrase extends AdvancedSyntaxFeatures {
    override def toString = "exactPhrase"
  }
  case object ExcludeWords extends AdvancedSyntaxFeatures {
    override def toString = "excludeWords"
  }
  val values: Seq[AdvancedSyntaxFeatures] = Seq(ExactPhrase, ExcludeWords)

  def withName(name: String): AdvancedSyntaxFeatures = AdvancedSyntaxFeatures.values
    .find(_.toString == name)
    .getOrElse(throw new MappingException(s"Unknown AdvancedSyntaxFeatures value: $name"))
}

class AdvancedSyntaxFeaturesSerializer
    extends CustomSerializer[AdvancedSyntaxFeatures](_ =>
      (
        {
          case JString(value) => AdvancedSyntaxFeatures.withName(value)
          case JNull          => null
        },
        { case value: AdvancedSyntaxFeatures =>
          JString(value.toString)
        }
      )
    )