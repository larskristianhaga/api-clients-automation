/** Algolia Monitoring API The Monitoring API lets you check the status of your Algolia infrastructure. ## Base URLs The
  * base URL for requests to the Monitoring API is: - `https://status.algolia.com` **All requests must use HTTPS.** ##
  * Availability and authentication Access to the [Infrastructure](#tag/infrastructure) endpoints is available as part
  * of the [Premium or Elevate plans](https://www.algolia.com/pricing). To authenticate requests to the Infrastructure
  * endpoints, add these headers: - `x-algolia-application-id`. Your Algolia application ID. - `x-algolia-api-key`. Your
  * Monitoring API key. You can find your application ID and API key in the [Algolia
  * dashboard](https://dashboard.algolia.com/account). Other endpoints don't require authentication. ## Response status
  * and errors The Monitoring API returns JSON responses. Since JSON doesn't guarantee any specific ordering, don't rely
  * on the order of attributes in the API response. Successful responses return a `2xx` status. Client errors return a
  * `4xx` status. Server errors are indicated by a `5xx` status. Error responses have a `message` property with more
  * information. ## Version The current version of the Monitoring API is version 1, as indicated by the `/1/` in each
  * endpoint's URL.
  *
  * The version of the OpenAPI document: 1.0.0
  *
  * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
  * https://openapi-generator.tech Do not edit the class manually.
  */
package algoliasearch.monitoring

import org.json4s._

sealed trait Region

/** Region where the cluster is located.
  */
object Region {
  case object Au extends Region {
    override def toString = "au"
  }
  case object Br extends Region {
    override def toString = "br"
  }
  case object Ca extends Region {
    override def toString = "ca"
  }
  case object De extends Region {
    override def toString = "de"
  }
  case object Eu extends Region {
    override def toString = "eu"
  }
  case object Hk extends Region {
    override def toString = "hk"
  }
  case object In extends Region {
    override def toString = "in"
  }
  case object Jp extends Region {
    override def toString = "jp"
  }
  case object Sg extends Region {
    override def toString = "sg"
  }
  case object Uae extends Region {
    override def toString = "uae"
  }
  case object Uk extends Region {
    override def toString = "uk"
  }
  case object Usc extends Region {
    override def toString = "usc"
  }
  case object Use extends Region {
    override def toString = "use"
  }
  case object Usw extends Region {
    override def toString = "usw"
  }
  case object Za extends Region {
    override def toString = "za"
  }
  val values: Seq[Region] = Seq(Au, Br, Ca, De, Eu, Hk, In, Jp, Sg, Uae, Uk, Usc, Use, Usw, Za)

  def withName(name: String): Region = Region.values
    .find(_.toString == name)
    .getOrElse(throw new MappingException(s"Unknown Region value: $name"))
}

class RegionSerializer
    extends CustomSerializer[Region](_ =>
      (
        {
          case JString(value) => Region.withName(value)
          case JNull          => null
        },
        { case value: Region =>
          JString(value.toString)
        }
      )
    )
