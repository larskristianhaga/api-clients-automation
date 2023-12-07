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

sealed trait SynonymType

/** Synonym type.
  */
object SynonymType {
  case object Synonym extends SynonymType {
    override def toString = "synonym"
  }
  case object Onewaysynonym extends SynonymType {
    override def toString = "onewaysynonym"
  }
  case object Altcorrection1 extends SynonymType {
    override def toString = "altcorrection1"
  }
  case object Altcorrection2 extends SynonymType {
    override def toString = "altcorrection2"
  }
  case object Placeholder extends SynonymType {
    override def toString = "placeholder"
  }
  val values: Seq[SynonymType] = Seq(Synonym, Onewaysynonym, Altcorrection1, Altcorrection2, Placeholder)

  def withName(name: String): SynonymType = SynonymType.values
    .find(_.toString == name)
    .getOrElse(throw new MappingException(s"Unknown SynonymType value: $name"))
}

class SynonymTypeSerializer
    extends CustomSerializer[SynonymType](_ =>
      (
        {
          case JString(value) => SynonymType.withName(value)
          case JNull          => null
        },
        { case value: SynonymType =>
          JString(value.toString)
        }
      )
    )