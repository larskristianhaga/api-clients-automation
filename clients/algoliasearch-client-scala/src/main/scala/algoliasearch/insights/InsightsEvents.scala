/** Insights API The Algolia Insights API lets you collect events related to your search and discovery experience.
  * Events represent actions that users take on your app or website. They unlock powerful features, such as
  * recommendations, personalization, smarter search results, and analytics that help you optimize your user experience.
  *
  * The version of the OpenAPI document: 1.0.0
  *
  * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
  * https://openapi-generator.tech Do not edit the class manually.
  */
package algoliasearch.insights

/** InsightsEvents
  *
  * @param events
  *   List of click and conversion events. An event is an object representing a user interaction. Events have attributes
  *   that describe the interaction, such as an event name, a type, or a user token. Some attributes require other
  *   attributes to be declared, and some attributes can't be declared at the same time. **All** events must be valid,
  *   otherwise the API returns an error.
  */
case class InsightsEvents(
    events: Seq[EventsItems]
)