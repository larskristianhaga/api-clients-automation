// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

import Core
import Foundation

#if canImport(AnyCodable)
  import AnyCodable
#endif

typealias Client = RecommendClient

open class RecommendClient {

  private var configuration: Configuration
  private var transporter: Transporter

  var applicationID: String {
    self.configuration.applicationID
  }

  public init(configuration: Configuration, transporter: Transporter) {
    self.configuration = configuration
    self.transporter = transporter
  }

  public convenience init(configuration: Configuration) {
    self.init(configuration: configuration, transporter: Transporter(configuration: configuration))
  }

  public convenience init(applicationID: String, apiKey: String) {
    self.init(configuration: Configuration(applicationID: applicationID, apiKey: apiKey))
  }

  /**
     Send requests to the Algolia REST API.

     - parameter path: (path) Path of the endpoint, anything after \&quot;/1\&quot; must be specified.
     - parameter parameters: (query) Query parameters to apply to the current query. (optional)
     - returns: AnyCodable
     */
  @available(macOS 10.15, iOS 13.0, tvOS 13.0, watchOS 6.0, *)
  open func customDelete(
    path: String, parameters: [String: AnyCodable]? = nil, requestOptions: RequestOptions? = nil
  ) async throws -> AnyCodable {
    return try await customDeleteWithRequestBuilder(
      path: path, parameters: parameters, requestOptions: requestOptions
    ).execute().body
  }

  /**
     Send requests to the Algolia REST API.

     This method allow you to send requests to the Algolia REST API.
     - parameter path: (path) Path of the endpoint, anything after \&quot;/1\&quot; must be specified.
     - parameter parameters: (query) Query parameters to apply to the current query. (optional)
     - returns: RequestBuilder<AnyCodable>
     */
  open func customDeleteWithRequestBuilder(
    path: String, parameters: [String: AnyCodable]? = nil, requestOptions: RequestOptions? = nil
  ) -> RequestBuilder<AnyCodable> {
    var localVariablePath = "/1{path}"
    let pathPreEscape = "\(APIHelper.mapValueToPathItem(path))"
    let pathPostEscape =
      pathPreEscape.addingPercentEncoding(withAllowedCharacters: .urlPathAllowed) ?? ""
    localVariablePath = localVariablePath.replacingOccurrences(
      of: "{path}", with: pathPostEscape, options: .literal, range: nil)
    let localVariableParameters: [String: Any?]? = nil

    let localVariableQueryItems = APIHelper.mapValuesToQueryItems([
      "parameters": (wrappedValue: parameters?.encodeToJSON(), isExplode: true)
    ])

    let localVariableNillableHeaders: [String: Any?] = [:]

    let localVariableHeaderParameters = APIHelper.rejectNilHeaders(localVariableNillableHeaders)

    let localVariableRequestBuilder: RequestBuilder<AnyCodable>.Type = Transporter
      .requestBuilderFactory.getBuilder()

    return localVariableRequestBuilder.init(
      method: "DELETE", path: localVariablePath, queryItems: localVariableQueryItems,
      parameters: localVariableParameters, headers: localVariableHeaderParameters,
      transporter: self.transporter, requestOptions: requestOptions)
  }

  /**
     Send requests to the Algolia REST API.

     - parameter path: (path) Path of the endpoint, anything after \&quot;/1\&quot; must be specified.
     - parameter parameters: (query) Query parameters to apply to the current query. (optional)
     - returns: AnyCodable
     */
  @available(macOS 10.15, iOS 13.0, tvOS 13.0, watchOS 6.0, *)
  open func customGet(
    path: String, parameters: [String: AnyCodable]? = nil, requestOptions: RequestOptions? = nil
  ) async throws -> AnyCodable {
    return try await customGetWithRequestBuilder(
      path: path, parameters: parameters, requestOptions: requestOptions
    ).execute().body
  }

  /**
     Send requests to the Algolia REST API.

     This method allow you to send requests to the Algolia REST API.
     - parameter path: (path) Path of the endpoint, anything after \&quot;/1\&quot; must be specified.
     - parameter parameters: (query) Query parameters to apply to the current query. (optional)
     - returns: RequestBuilder<AnyCodable>
     */
  open func customGetWithRequestBuilder(
    path: String, parameters: [String: AnyCodable]? = nil, requestOptions: RequestOptions? = nil
  ) -> RequestBuilder<AnyCodable> {
    var localVariablePath = "/1{path}"
    let pathPreEscape = "\(APIHelper.mapValueToPathItem(path))"
    let pathPostEscape =
      pathPreEscape.addingPercentEncoding(withAllowedCharacters: .urlPathAllowed) ?? ""
    localVariablePath = localVariablePath.replacingOccurrences(
      of: "{path}", with: pathPostEscape, options: .literal, range: nil)
    let localVariableParameters: [String: Any?]? = nil

    let localVariableQueryItems = APIHelper.mapValuesToQueryItems([
      "parameters": (wrappedValue: parameters?.encodeToJSON(), isExplode: true)
    ])

    let localVariableNillableHeaders: [String: Any?] = [:]

    let localVariableHeaderParameters = APIHelper.rejectNilHeaders(localVariableNillableHeaders)

    let localVariableRequestBuilder: RequestBuilder<AnyCodable>.Type = Transporter
      .requestBuilderFactory.getBuilder()

    return localVariableRequestBuilder.init(
      method: "GET", path: localVariablePath, queryItems: localVariableQueryItems,
      parameters: localVariableParameters, headers: localVariableHeaderParameters,
      transporter: self.transporter, requestOptions: requestOptions)
  }

  /**
     Send requests to the Algolia REST API.

     - parameter path: (path) Path of the endpoint, anything after \&quot;/1\&quot; must be specified.
     - parameter parameters: (query) Query parameters to apply to the current query. (optional)
     - parameter body: (body) Parameters to send with the custom request. (optional)
     - returns: AnyCodable
     */
  @available(macOS 10.15, iOS 13.0, tvOS 13.0, watchOS 6.0, *)
  open func customPost(
    path: String, parameters: [String: AnyCodable]? = nil, body: Encodable? = nil,
    requestOptions: RequestOptions? = nil
  ) async throws -> AnyCodable {
    return try await customPostWithRequestBuilder(
      path: path, parameters: parameters, body: body, requestOptions: requestOptions
    ).execute().body
  }

  /**
     Send requests to the Algolia REST API.

     This method allow you to send requests to the Algolia REST API.
     - parameter path: (path) Path of the endpoint, anything after \&quot;/1\&quot; must be specified.
     - parameter parameters: (query) Query parameters to apply to the current query. (optional)
     - parameter body: (body) Parameters to send with the custom request. (optional)
     - returns: RequestBuilder<AnyCodable>
     */
  open func customPostWithRequestBuilder(
    path: String, parameters: [String: AnyCodable]? = nil, body: Encodable? = nil,
    requestOptions: RequestOptions? = nil
  ) -> RequestBuilder<AnyCodable> {
    var localVariablePath = "/1{path}"
    let pathPreEscape = "\(APIHelper.mapValueToPathItem(path))"
    let pathPostEscape =
      pathPreEscape.addingPercentEncoding(withAllowedCharacters: .urlPathAllowed) ?? ""
    localVariablePath = localVariablePath.replacingOccurrences(
      of: "{path}", with: pathPostEscape, options: .literal, range: nil)
    let localVariableParameters = JSONEncodingHelper.encodingParameters(forEncodableObject: body)

    let localVariableQueryItems = APIHelper.mapValuesToQueryItems([
      "parameters": (wrappedValue: parameters?.encodeToJSON(), isExplode: true)
    ])

    let localVariableNillableHeaders: [String: Any?] = [:]

    let localVariableHeaderParameters = APIHelper.rejectNilHeaders(localVariableNillableHeaders)

    let localVariableRequestBuilder: RequestBuilder<AnyCodable>.Type = Transporter
      .requestBuilderFactory.getBuilder()

    return localVariableRequestBuilder.init(
      method: "POST", path: localVariablePath, queryItems: localVariableQueryItems,
      parameters: localVariableParameters, headers: localVariableHeaderParameters,
      transporter: self.transporter, requestOptions: requestOptions)
  }

  /**
     Send requests to the Algolia REST API.

     - parameter path: (path) Path of the endpoint, anything after \&quot;/1\&quot; must be specified.
     - parameter parameters: (query) Query parameters to apply to the current query. (optional)
     - parameter body: (body) Parameters to send with the custom request. (optional)
     - returns: AnyCodable
     */
  @available(macOS 10.15, iOS 13.0, tvOS 13.0, watchOS 6.0, *)
  open func customPut(
    path: String, parameters: [String: AnyCodable]? = nil, body: Encodable? = nil,
    requestOptions: RequestOptions? = nil
  ) async throws -> AnyCodable {
    return try await customPutWithRequestBuilder(
      path: path, parameters: parameters, body: body, requestOptions: requestOptions
    ).execute().body
  }

  /**
     Send requests to the Algolia REST API.

     This method allow you to send requests to the Algolia REST API.
     - parameter path: (path) Path of the endpoint, anything after \&quot;/1\&quot; must be specified.
     - parameter parameters: (query) Query parameters to apply to the current query. (optional)
     - parameter body: (body) Parameters to send with the custom request. (optional)
     - returns: RequestBuilder<AnyCodable>
     */
  open func customPutWithRequestBuilder(
    path: String, parameters: [String: AnyCodable]? = nil, body: Encodable? = nil,
    requestOptions: RequestOptions? = nil
  ) -> RequestBuilder<AnyCodable> {
    var localVariablePath = "/1{path}"
    let pathPreEscape = "\(APIHelper.mapValueToPathItem(path))"
    let pathPostEscape =
      pathPreEscape.addingPercentEncoding(withAllowedCharacters: .urlPathAllowed) ?? ""
    localVariablePath = localVariablePath.replacingOccurrences(
      of: "{path}", with: pathPostEscape, options: .literal, range: nil)
    let localVariableParameters = JSONEncodingHelper.encodingParameters(forEncodableObject: body)

    let localVariableQueryItems = APIHelper.mapValuesToQueryItems([
      "parameters": (wrappedValue: parameters?.encodeToJSON(), isExplode: true)
    ])

    let localVariableNillableHeaders: [String: Any?] = [:]

    let localVariableHeaderParameters = APIHelper.rejectNilHeaders(localVariableNillableHeaders)

    let localVariableRequestBuilder: RequestBuilder<AnyCodable>.Type = Transporter
      .requestBuilderFactory.getBuilder()

    return localVariableRequestBuilder.init(
      method: "PUT", path: localVariablePath, queryItems: localVariableQueryItems,
      parameters: localVariableParameters, headers: localVariableHeaderParameters,
      transporter: self.transporter, requestOptions: requestOptions)
  }

  /**
     Delete a Recommend rule.

     - parameter indexName: (path) Index on which to perform the request.
     - parameter model: (path) [Recommend models](https://www.algolia.com/doc/guides/algolia-recommend/overview/#recommend-models).
     - parameter objectID: (path) Unique record (object) identifier.
     - returns: DeletedAtResponse
     */
  @available(macOS 10.15, iOS 13.0, tvOS 13.0, watchOS 6.0, *)
  open func deleteRecommendRule(
    indexName: String, model: RecommendModels, objectID: String,
    requestOptions: RequestOptions? = nil
  ) async throws -> DeletedAtResponse {
    return try await deleteRecommendRuleWithRequestBuilder(
      indexName: indexName, model: model, objectID: objectID, requestOptions: requestOptions
    ).execute().body
  }

  /**
     Delete a Recommend rule.

     Delete a [Recommend rule](https://www.algolia.com/doc/guides/algolia-recommend/how-to/rules/).
     - parameter indexName: (path) Index on which to perform the request.
     - parameter model: (path) [Recommend models](https://www.algolia.com/doc/guides/algolia-recommend/overview/#recommend-models).
     - parameter objectID: (path) Unique record (object) identifier.
     - returns: RequestBuilder<DeletedAtResponse>
     */
  open func deleteRecommendRuleWithRequestBuilder(
    indexName: String, model: RecommendModels, objectID: String,
    requestOptions: RequestOptions? = nil
  ) -> RequestBuilder<DeletedAtResponse> {
    var localVariablePath = "/1/indexes/{indexName}/{model}/recommend/rules/{objectID}"
    let indexNamePreEscape = "\(APIHelper.mapValueToPathItem(indexName))"
    let indexNamePostEscape =
      indexNamePreEscape.addingPercentEncoding(withAllowedCharacters: .urlPathAllowed) ?? ""
    localVariablePath = localVariablePath.replacingOccurrences(
      of: "{indexName}", with: indexNamePostEscape, options: .literal, range: nil)
    let modelPreEscape = "\(APIHelper.mapValueToPathItem(model))"
    let modelPostEscape =
      modelPreEscape.addingPercentEncoding(withAllowedCharacters: .urlPathAllowed) ?? ""
    localVariablePath = localVariablePath.replacingOccurrences(
      of: "{model}", with: modelPostEscape, options: .literal, range: nil)
    let objectIDPreEscape = "\(APIHelper.mapValueToPathItem(objectID))"
    let objectIDPostEscape =
      objectIDPreEscape.addingPercentEncoding(withAllowedCharacters: .urlPathAllowed) ?? ""
    localVariablePath = localVariablePath.replacingOccurrences(
      of: "{objectID}", with: objectIDPostEscape, options: .literal, range: nil)
    let localVariableParameters: [String: Any?]? = nil

    let localVariableQueryItems: [URLQueryItem]? = nil

    let localVariableNillableHeaders: [String: Any?] = [:]

    let localVariableHeaderParameters = APIHelper.rejectNilHeaders(localVariableNillableHeaders)

    let localVariableRequestBuilder: RequestBuilder<DeletedAtResponse>.Type = Transporter
      .requestBuilderFactory.getBuilder()

    return localVariableRequestBuilder.init(
      method: "DELETE", path: localVariablePath, queryItems: localVariableQueryItems,
      parameters: localVariableParameters, headers: localVariableHeaderParameters,
      transporter: self.transporter, requestOptions: requestOptions)
  }

  /**
     Get a Recommend rule.

     - parameter indexName: (path) Index on which to perform the request.
     - parameter model: (path) [Recommend models](https://www.algolia.com/doc/guides/algolia-recommend/overview/#recommend-models).
     - parameter objectID: (path) Unique record (object) identifier.
     - returns: RuleResponse
     */
  @available(macOS 10.15, iOS 13.0, tvOS 13.0, watchOS 6.0, *)
  open func getRecommendRule(
    indexName: String, model: RecommendModels, objectID: String,
    requestOptions: RequestOptions? = nil
  ) async throws -> RuleResponse {
    return try await getRecommendRuleWithRequestBuilder(
      indexName: indexName, model: model, objectID: objectID, requestOptions: requestOptions
    ).execute().body
  }

  /**
     Get a Recommend rule.

     Return a [Recommend rule](https://www.algolia.com/doc/guides/algolia-recommend/how-to/rules/).
     - parameter indexName: (path) Index on which to perform the request.
     - parameter model: (path) [Recommend models](https://www.algolia.com/doc/guides/algolia-recommend/overview/#recommend-models).
     - parameter objectID: (path) Unique record (object) identifier.
     - returns: RequestBuilder<RuleResponse>
     */
  open func getRecommendRuleWithRequestBuilder(
    indexName: String, model: RecommendModels, objectID: String,
    requestOptions: RequestOptions? = nil
  ) -> RequestBuilder<RuleResponse> {
    var localVariablePath = "/1/indexes/{indexName}/{model}/recommend/rules/{objectID}"
    let indexNamePreEscape = "\(APIHelper.mapValueToPathItem(indexName))"
    let indexNamePostEscape =
      indexNamePreEscape.addingPercentEncoding(withAllowedCharacters: .urlPathAllowed) ?? ""
    localVariablePath = localVariablePath.replacingOccurrences(
      of: "{indexName}", with: indexNamePostEscape, options: .literal, range: nil)
    let modelPreEscape = "\(APIHelper.mapValueToPathItem(model))"
    let modelPostEscape =
      modelPreEscape.addingPercentEncoding(withAllowedCharacters: .urlPathAllowed) ?? ""
    localVariablePath = localVariablePath.replacingOccurrences(
      of: "{model}", with: modelPostEscape, options: .literal, range: nil)
    let objectIDPreEscape = "\(APIHelper.mapValueToPathItem(objectID))"
    let objectIDPostEscape =
      objectIDPreEscape.addingPercentEncoding(withAllowedCharacters: .urlPathAllowed) ?? ""
    localVariablePath = localVariablePath.replacingOccurrences(
      of: "{objectID}", with: objectIDPostEscape, options: .literal, range: nil)
    let localVariableParameters: [String: Any?]? = nil

    let localVariableQueryItems: [URLQueryItem]? = nil

    let localVariableNillableHeaders: [String: Any?] = [:]

    let localVariableHeaderParameters = APIHelper.rejectNilHeaders(localVariableNillableHeaders)

    let localVariableRequestBuilder: RequestBuilder<RuleResponse>.Type = Transporter
      .requestBuilderFactory.getBuilder()

    return localVariableRequestBuilder.init(
      method: "GET", path: localVariablePath, queryItems: localVariableQueryItems,
      parameters: localVariableParameters, headers: localVariableHeaderParameters,
      transporter: self.transporter, requestOptions: requestOptions)
  }

  /**
     Get a Recommend task's status.

     - parameter indexName: (path) Index on which to perform the request.
     - parameter model: (path) [Recommend models](https://www.algolia.com/doc/guides/algolia-recommend/overview/#recommend-models).
     - parameter taskID: (path) Unique identifier of a task. Numeric value (up to 64bits).
     - returns: GetRecommendTaskResponse
     */
  @available(macOS 10.15, iOS 13.0, tvOS 13.0, watchOS 6.0, *)
  open func getRecommendStatus(
    indexName: String, model: RecommendModels, taskID: Int64, requestOptions: RequestOptions? = nil
  ) async throws -> GetRecommendTaskResponse {
    return try await getRecommendStatusWithRequestBuilder(
      indexName: indexName, model: model, taskID: taskID, requestOptions: requestOptions
    ).execute().body
  }

  /**
     Get a Recommend task's status.

     Some operations, such as deleting a Recommend rule, will respond with a `taskID` value. Use this value here to check the status of that task.
     - parameter indexName: (path) Index on which to perform the request.
     - parameter model: (path) [Recommend models](https://www.algolia.com/doc/guides/algolia-recommend/overview/#recommend-models).
     - parameter taskID: (path) Unique identifier of a task. Numeric value (up to 64bits).
     - returns: RequestBuilder<GetRecommendTaskResponse>
     */
  open func getRecommendStatusWithRequestBuilder(
    indexName: String, model: RecommendModels, taskID: Int64, requestOptions: RequestOptions? = nil
  ) -> RequestBuilder<GetRecommendTaskResponse> {
    var localVariablePath = "/1/indexes/{indexName}/{model}/task/{taskID}"
    let indexNamePreEscape = "\(APIHelper.mapValueToPathItem(indexName))"
    let indexNamePostEscape =
      indexNamePreEscape.addingPercentEncoding(withAllowedCharacters: .urlPathAllowed) ?? ""
    localVariablePath = localVariablePath.replacingOccurrences(
      of: "{indexName}", with: indexNamePostEscape, options: .literal, range: nil)
    let modelPreEscape = "\(APIHelper.mapValueToPathItem(model))"
    let modelPostEscape =
      modelPreEscape.addingPercentEncoding(withAllowedCharacters: .urlPathAllowed) ?? ""
    localVariablePath = localVariablePath.replacingOccurrences(
      of: "{model}", with: modelPostEscape, options: .literal, range: nil)
    let taskIDPreEscape = "\(APIHelper.mapValueToPathItem(taskID))"
    let taskIDPostEscape =
      taskIDPreEscape.addingPercentEncoding(withAllowedCharacters: .urlPathAllowed) ?? ""
    localVariablePath = localVariablePath.replacingOccurrences(
      of: "{taskID}", with: taskIDPostEscape, options: .literal, range: nil)
    let localVariableParameters: [String: Any?]? = nil

    let localVariableQueryItems: [URLQueryItem]? = nil

    let localVariableNillableHeaders: [String: Any?] = [:]

    let localVariableHeaderParameters = APIHelper.rejectNilHeaders(localVariableNillableHeaders)

    let localVariableRequestBuilder: RequestBuilder<GetRecommendTaskResponse>.Type = Transporter
      .requestBuilderFactory.getBuilder()

    return localVariableRequestBuilder.init(
      method: "GET", path: localVariablePath, queryItems: localVariableQueryItems,
      parameters: localVariableParameters, headers: localVariableHeaderParameters,
      transporter: self.transporter, requestOptions: requestOptions)
  }

  /**
     Get recommendations and trending items.

     - parameter getRecommendationsParams: (body)
     - returns: GetRecommendationsResponse
     */
  @available(macOS 10.15, iOS 13.0, tvOS 13.0, watchOS 6.0, *)
  open func getRecommendations(
    getRecommendationsParams: GetRecommendationsParams, requestOptions: RequestOptions? = nil
  ) async throws -> GetRecommendationsResponse {
    return try await getRecommendationsWithRequestBuilder(
      getRecommendationsParams: getRecommendationsParams, requestOptions: requestOptions
    ).execute().body
  }

  /**
     Get recommendations and trending items.

     Returns results from either recommendation or trending models:    - **Recommendations** are provided by the [Related Products](https://www.algolia.com/doc/guides/algolia-recommend/overview/#related-products-and-related-content) and [Frequently Bought Together](https://www.algolia.com/doc/guides/algolia-recommend/overview/#frequently-bought-together) models   - **Trending** models are [Trending Items and Trending Facet Values](https://www.algolia.com/doc/guides/algolia-recommend/overview/#trending-items-and-trending-facet-values).
     - parameter getRecommendationsParams: (body)
     - returns: RequestBuilder<GetRecommendationsResponse>
     */
  open func getRecommendationsWithRequestBuilder(
    getRecommendationsParams: GetRecommendationsParams, requestOptions: RequestOptions? = nil
  ) -> RequestBuilder<GetRecommendationsResponse> {
    let localVariablePath = "/1/indexes/*/recommendations"
    let localVariableParameters = JSONEncodingHelper.encodingParameters(
      forEncodableObject: getRecommendationsParams)

    let localVariableQueryItems: [URLQueryItem]? = nil

    let localVariableNillableHeaders: [String: Any?] = [:]

    let localVariableHeaderParameters = APIHelper.rejectNilHeaders(localVariableNillableHeaders)

    let localVariableRequestBuilder: RequestBuilder<GetRecommendationsResponse>.Type = Transporter
      .requestBuilderFactory.getBuilder()

    return localVariableRequestBuilder.init(
      method: "POST", path: localVariablePath, queryItems: localVariableQueryItems,
      parameters: localVariableParameters, headers: localVariableHeaderParameters,
      transporter: self.transporter, requestOptions: requestOptions)
  }

  /**
     List Recommend rules.

     - parameter indexName: (path) Index on which to perform the request.
     - parameter model: (path) [Recommend models](https://www.algolia.com/doc/guides/algolia-recommend/overview/#recommend-models).
     - parameter searchRecommendRulesParams: (body)  (optional)
     - returns: SearchRecommendRulesResponse
     */
  @available(macOS 10.15, iOS 13.0, tvOS 13.0, watchOS 6.0, *)
  open func searchRecommendRules(
    indexName: String, model: RecommendModels,
    searchRecommendRulesParams: SearchRecommendRulesParams? = nil,
    requestOptions: RequestOptions? = nil
  ) async throws -> SearchRecommendRulesResponse {
    return try await searchRecommendRulesWithRequestBuilder(
      indexName: indexName, model: model, searchRecommendRulesParams: searchRecommendRulesParams,
      requestOptions: requestOptions
    ).execute().body
  }

  /**
     List Recommend rules.

     List [Recommend rules](https://www.algolia.com/doc/guides/algolia-recommend/how-to/rules/).
     - parameter indexName: (path) Index on which to perform the request.
     - parameter model: (path) [Recommend models](https://www.algolia.com/doc/guides/algolia-recommend/overview/#recommend-models).
     - parameter searchRecommendRulesParams: (body)  (optional)
     - returns: RequestBuilder<SearchRecommendRulesResponse>
     */
  open func searchRecommendRulesWithRequestBuilder(
    indexName: String, model: RecommendModels,
    searchRecommendRulesParams: SearchRecommendRulesParams? = nil,
    requestOptions: RequestOptions? = nil
  ) -> RequestBuilder<SearchRecommendRulesResponse> {
    var localVariablePath = "/1/indexes/{indexName}/{model}/recommend/rules/search"
    let indexNamePreEscape = "\(APIHelper.mapValueToPathItem(indexName))"
    let indexNamePostEscape =
      indexNamePreEscape.addingPercentEncoding(withAllowedCharacters: .urlPathAllowed) ?? ""
    localVariablePath = localVariablePath.replacingOccurrences(
      of: "{indexName}", with: indexNamePostEscape, options: .literal, range: nil)
    let modelPreEscape = "\(APIHelper.mapValueToPathItem(model))"
    let modelPostEscape =
      modelPreEscape.addingPercentEncoding(withAllowedCharacters: .urlPathAllowed) ?? ""
    localVariablePath = localVariablePath.replacingOccurrences(
      of: "{model}", with: modelPostEscape, options: .literal, range: nil)
    let localVariableParameters = JSONEncodingHelper.encodingParameters(
      forEncodableObject: searchRecommendRulesParams)

    let localVariableQueryItems: [URLQueryItem]? = nil

    let localVariableNillableHeaders: [String: Any?] = [:]

    let localVariableHeaderParameters = APIHelper.rejectNilHeaders(localVariableNillableHeaders)

    let localVariableRequestBuilder: RequestBuilder<SearchRecommendRulesResponse>.Type = Transporter
      .requestBuilderFactory.getBuilder()

    return localVariableRequestBuilder.init(
      method: "POST", path: localVariablePath, queryItems: localVariableQueryItems,
      parameters: localVariableParameters, headers: localVariableHeaderParameters,
      transporter: self.transporter, requestOptions: requestOptions)
  }
}