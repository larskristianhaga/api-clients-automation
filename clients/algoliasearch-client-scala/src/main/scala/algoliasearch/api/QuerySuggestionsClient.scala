/** Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on
  * https://github.com/algolia/api-clients-automation. DO NOT EDIT.
  */
package algoliasearch.api

import algoliasearch.querysuggestions.BaseResponse
import algoliasearch.querysuggestions.ErrorBase
import algoliasearch.querysuggestions.GetConfigStatus200Response
import algoliasearch.querysuggestions.GetLogFile200Response
import algoliasearch.querysuggestions.QuerySuggestionsConfiguration
import algoliasearch.querysuggestions.QuerySuggestionsConfigurationResponse
import algoliasearch.querysuggestions.QuerySuggestionsConfigurationWithIndex
import algoliasearch.querysuggestions._
import algoliasearch.ApiClient
import algoliasearch.api.QuerySuggestionsClient.hosts
import algoliasearch.config._
import algoliasearch.internal.util._

import scala.concurrent.{ExecutionContext, Future}
import scala.util.Random

object QuerySuggestionsClient {

  /** Creates a new SearchApi instance using default hosts.
    *
    * @param appId
    *   application ID
    * @param apiKey
    *   api key
    * @param region
    *   region
    * @param clientOptions
    *   client options
    */
  def apply(
      appId: String,
      apiKey: String,
      region: String,
      clientOptions: ClientOptions = ClientOptions()
  ) = new QuerySuggestionsClient(
    appId = appId,
    apiKey = apiKey,
    region = region,
    clientOptions = clientOptions
  )

  private def hosts(region: String): Seq[Host] = {
    val allowedRegions = Seq("eu", "us")
    if (!allowedRegions.contains(region)) {
      throw new IllegalArgumentException(
        s"`region` is required and must be one of the following: ${allowedRegions.mkString(", ")}"
      )
    }
    val url = "query-suggestions.{region}.algolia.com".replace("{region}", region)
    Seq(Host(url = url, callTypes = Set(CallType.Read, CallType.Write)))
  }
}

class QuerySuggestionsClient(
    appId: String,
    apiKey: String,
    region: String,
    clientOptions: ClientOptions = ClientOptions()
) extends ApiClient(
      appId = appId,
      apiKey = apiKey,
      clientName = "QuerySuggestions",
      defaultHosts = hosts(region),
      formats = JsonSupport.format,
      options = clientOptions
    ) {

  /** Create a new Query Suggestions configuration. You can have up to 100 configurations per Algolia application.
    */
  def createConfig(
      querySuggestionsConfigurationWithIndex: QuerySuggestionsConfigurationWithIndex,
      requestOptions: Option[RequestOptions] = None
  )(implicit ec: ExecutionContext): Future[BaseResponse] = Future {
    requireNotNull(
      querySuggestionsConfigurationWithIndex,
      "Parameter `querySuggestionsConfigurationWithIndex` is required when calling `createConfig`."
    )

    val request = HttpRequest
      .builder()
      .withMethod("POST")
      .withPath(s"/1/configs")
      .withBody(querySuggestionsConfigurationWithIndex)
      .build()
    execute[BaseResponse](request, requestOptions)
  }

  /** This method allow you to send requests to the Algolia REST API.
    *
    * @param path
    *   Path of the endpoint, anything after \"/1\" must be specified.
    * @param parameters
    *   Query parameters to apply to the current query.
    */
  def del[T: Manifest](
      path: String,
      parameters: Option[Map[String, Any]] = None,
      requestOptions: Option[RequestOptions] = None
  )(implicit ec: ExecutionContext): Future[T] = Future {
    requireNotNull(path, "Parameter `path` is required when calling `del`.")

    val request = HttpRequest
      .builder()
      .withMethod("DELETE")
      .withPath(s"/1${path}")
      .withQueryParameters(parameters)
      .build()
    execute[T](request, requestOptions)
  }

  /** Delete a Query Suggestions configuration. Deleting only removes the configuration and stops updates to the Query
    * Suggestions index. The Query Suggestions index itself is not deleted.
    *
    * @param indexName
    *   Query Suggestions index name.
    */
  def deleteConfig(indexName: String, requestOptions: Option[RequestOptions] = None)(implicit
      ec: ExecutionContext
  ): Future[BaseResponse] = Future {
    requireNotNull(indexName, "Parameter `indexName` is required when calling `deleteConfig`.")

    val request = HttpRequest
      .builder()
      .withMethod("DELETE")
      .withPath(s"/1/configs/${escape(indexName)}")
      .build()
    execute[BaseResponse](request, requestOptions)
  }

  /** This method allow you to send requests to the Algolia REST API.
    *
    * @param path
    *   Path of the endpoint, anything after \"/1\" must be specified.
    * @param parameters
    *   Query parameters to apply to the current query.
    */
  def get[T: Manifest](
      path: String,
      parameters: Option[Map[String, Any]] = None,
      requestOptions: Option[RequestOptions] = None
  )(implicit ec: ExecutionContext): Future[T] = Future {
    requireNotNull(path, "Parameter `path` is required when calling `get`.")

    val request = HttpRequest
      .builder()
      .withMethod("GET")
      .withPath(s"/1${path}")
      .withQueryParameters(parameters)
      .build()
    execute[T](request, requestOptions)
  }

  /** List all Query Suggestions configurations of your Algolia application.
    */
  def getAllConfigs(
      requestOptions: Option[RequestOptions] = None
  )(implicit ec: ExecutionContext): Future[Seq[QuerySuggestionsConfigurationResponse]] = Future {

    val request = HttpRequest
      .builder()
      .withMethod("GET")
      .withPath(s"/1/configs")
      .build()
    execute[Seq[QuerySuggestionsConfigurationResponse]](request, requestOptions)
  }

  /** Get a single Query Suggestions configuration.
    *
    * @param indexName
    *   Query Suggestions index name.
    */
  def getConfig(indexName: String, requestOptions: Option[RequestOptions] = None)(implicit
      ec: ExecutionContext
  ): Future[QuerySuggestionsConfigurationResponse] = Future {
    requireNotNull(indexName, "Parameter `indexName` is required when calling `getConfig`.")

    val request = HttpRequest
      .builder()
      .withMethod("GET")
      .withPath(s"/1/configs/${escape(indexName)}")
      .build()
    execute[QuerySuggestionsConfigurationResponse](request, requestOptions)
  }

  /** Report the status of a Query Suggestions index.
    *
    * @param indexName
    *   Query Suggestions index name.
    */
  def getConfigStatus(indexName: String, requestOptions: Option[RequestOptions] = None)(implicit
      ec: ExecutionContext
  ): Future[GetConfigStatus200Response] = Future {
    requireNotNull(indexName, "Parameter `indexName` is required when calling `getConfigStatus`.")

    val request = HttpRequest
      .builder()
      .withMethod("GET")
      .withPath(s"/1/configs/${escape(indexName)}/status")
      .build()
    execute[GetConfigStatus200Response](request, requestOptions)
  }

  /** Get the logs for a single Query Suggestions index.
    *
    * @param indexName
    *   Query Suggestions index name.
    */
  def getLogFile(indexName: String, requestOptions: Option[RequestOptions] = None)(implicit
      ec: ExecutionContext
  ): Future[GetLogFile200Response] = Future {
    requireNotNull(indexName, "Parameter `indexName` is required when calling `getLogFile`.")

    val request = HttpRequest
      .builder()
      .withMethod("GET")
      .withPath(s"/1/logs/${escape(indexName)}")
      .build()
    execute[GetLogFile200Response](request, requestOptions)
  }

  /** This method allow you to send requests to the Algolia REST API.
    *
    * @param path
    *   Path of the endpoint, anything after \"/1\" must be specified.
    * @param parameters
    *   Query parameters to apply to the current query.
    * @param body
    *   Parameters to send with the custom request.
    */
  def post[T: Manifest](
      path: String,
      parameters: Option[Map[String, Any]] = None,
      body: Option[Any] = None,
      requestOptions: Option[RequestOptions] = None
  )(implicit ec: ExecutionContext): Future[T] = Future {
    requireNotNull(path, "Parameter `path` is required when calling `post`.")

    val request = HttpRequest
      .builder()
      .withMethod("POST")
      .withPath(s"/1${path}")
      .withBody(body)
      .withQueryParameters(parameters)
      .build()
    execute[T](request, requestOptions)
  }

  /** This method allow you to send requests to the Algolia REST API.
    *
    * @param path
    *   Path of the endpoint, anything after \"/1\" must be specified.
    * @param parameters
    *   Query parameters to apply to the current query.
    * @param body
    *   Parameters to send with the custom request.
    */
  def put[T: Manifest](
      path: String,
      parameters: Option[Map[String, Any]] = None,
      body: Option[Any] = None,
      requestOptions: Option[RequestOptions] = None
  )(implicit ec: ExecutionContext): Future[T] = Future {
    requireNotNull(path, "Parameter `path` is required when calling `put`.")

    val request = HttpRequest
      .builder()
      .withMethod("PUT")
      .withPath(s"/1${path}")
      .withBody(body)
      .withQueryParameters(parameters)
      .build()
    execute[T](request, requestOptions)
  }

  /** Update a QuerySuggestions configuration.
    *
    * @param indexName
    *   Query Suggestions index name.
    */
  def updateConfig(
      indexName: String,
      querySuggestionsConfiguration: QuerySuggestionsConfiguration,
      requestOptions: Option[RequestOptions] = None
  )(implicit ec: ExecutionContext): Future[BaseResponse] = Future {
    requireNotNull(indexName, "Parameter `indexName` is required when calling `updateConfig`.")
    requireNotNull(
      querySuggestionsConfiguration,
      "Parameter `querySuggestionsConfiguration` is required when calling `updateConfig`."
    )

    val request = HttpRequest
      .builder()
      .withMethod("PUT")
      .withPath(s"/1/configs/${escape(indexName)}")
      .withBody(querySuggestionsConfiguration)
      .build()
    execute[BaseResponse](request, requestOptions)
  }

}