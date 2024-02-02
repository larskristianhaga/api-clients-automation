using Algolia.Search.Clients;
using Algolia.Search.Http;
using Algolia.Search.Models.Search;
using dotenv.net;
using Newtonsoft.Json;
using Quibble.Xunit;
using Xunit;
using Action = Algolia.Search.Models.Search.Action;

public class SearchClientRequestTests
{
  private readonly SearchClient _client,
    _e2eClient;
  private readonly EchoHttpRequester _echo;

  public SearchClientRequestTests()
  {
    _echo = new EchoHttpRequester();
    _client = new SearchClient(new SearchConfig("appId", "apiKey"), _echo);

    DotEnv.Load();
    var e2EAppId = Environment.GetEnvironmentVariable("ALGOLIA_APPLICATION_ID");
    if (e2EAppId == null)
    {
      throw new Exception("please provide an `ALGOLIA_APPLICATION_ID` env var for e2e tests");
    }

    var e2EApiKey = Environment.GetEnvironmentVariable("ALGOLIA_ADMIN_KEY");
    if (e2EApiKey == null)
    {
      throw new Exception("please provide an `ALGOLIA_ADMIN_KEY` env var for e2e tests");
    }

    _e2eClient = new SearchClient(new SearchConfig(e2EAppId, e2EApiKey));
  }

  [Fact]
  public void Dispose() { }

  [Fact(DisplayName = "addApiKey0")]
  public async Task AddApiKeyTest0()
  {
    await _client.AddApiKeyAsync(
      new ApiKey
      {
        Acl = new List<Acl> { Enum.Parse<Acl>("Search"), Enum.Parse<Acl>("AddObject") },
        Description = "my new api key",
        Validity = 300,
        MaxQueriesPerIPPerHour = 100,
        MaxHitsPerQuery = 20,
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/keys", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"acl\":[\"search\",\"addObject\"],\"description\":\"my new api key\",\"validity\":300,\"maxQueriesPerIPPerHour\":100,\"maxHitsPerQuery\":20}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "addOrUpdateObject0")]
  public async Task AddOrUpdateObjectTest0()
  {
    await _client.AddOrUpdateObjectAsync(
      "indexName",
      "uniqueID",
      new Dictionary<string, string> { { "key", "value" } }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/uniqueID", req.Path);
    Assert.Equal("PUT", req.Method.ToString());
    JsonAssert.EqualOverrideDefault("{\"key\":\"value\"}", req.Body, new JsonDiffConfig(false));
  }

  [Fact(DisplayName = "appendSource0")]
  public async Task AppendSourceTest0()
  {
    await _client.AppendSourceAsync(
      new Source { VarSource = "theSource", Description = "theDescription", }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/security/sources/append", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"source\":\"theSource\",\"description\":\"theDescription\"}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "assignUserId0")]
  public async Task AssignUserIdTest0()
  {
    await _client.AssignUserIdAsync("userID", new AssignUserIdParams { Cluster = "theCluster", });

    var req = _echo.LastResponse;
    Assert.Equal("/1/clusters/mapping", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"cluster\":\"theCluster\"}",
      req.Body,
      new JsonDiffConfig(false)
    );
    var expectedHeaders = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"x-algolia-user-id\":\"userID\"}"
    );
    var actualHeaders = req.Headers;
    foreach (var expectedHeader in expectedHeaders)
    {
      string actualHeaderValue;
      actualHeaders.TryGetValue(expectedHeader.Key, out actualHeaderValue);
      Assert.Equal(expectedHeader.Value, actualHeaderValue);
    }
  }

  [Fact(DisplayName = "allows batch method with `addObject` action")]
  public async Task BatchTest0()
  {
    await _client.BatchAsync(
      "theIndexName",
      new BatchWriteParams
      {
        Requests = new List<BatchRequest>
        {
          new BatchRequest
          {
            Action = Enum.Parse<Action>("AddObject"),
            Body = new Dictionary<string, string> { { "key", "value" } },
          }
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/batch", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"requests\":[{\"action\":\"addObject\",\"body\":{\"key\":\"value\"}}]}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "allows batch method with `clear` action")]
  public async Task BatchTest1()
  {
    await _client.BatchAsync(
      "theIndexName",
      new BatchWriteParams
      {
        Requests = new List<BatchRequest>
        {
          new BatchRequest
          {
            Action = Enum.Parse<Action>("Clear"),
            Body = new Dictionary<string, string> { { "key", "value" } },
          }
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/batch", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"requests\":[{\"action\":\"clear\",\"body\":{\"key\":\"value\"}}]}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "allows batch method with `delete` action")]
  public async Task BatchTest2()
  {
    await _client.BatchAsync(
      "theIndexName",
      new BatchWriteParams
      {
        Requests = new List<BatchRequest>
        {
          new BatchRequest
          {
            Action = Enum.Parse<Action>("Delete"),
            Body = new Dictionary<string, string> { { "key", "value" } },
          }
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/batch", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"requests\":[{\"action\":\"delete\",\"body\":{\"key\":\"value\"}}]}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "allows batch method with `deleteObject` action")]
  public async Task BatchTest3()
  {
    await _client.BatchAsync(
      "theIndexName",
      new BatchWriteParams
      {
        Requests = new List<BatchRequest>
        {
          new BatchRequest
          {
            Action = Enum.Parse<Action>("DeleteObject"),
            Body = new Dictionary<string, string> { { "key", "value" } },
          }
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/batch", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"requests\":[{\"action\":\"deleteObject\",\"body\":{\"key\":\"value\"}}]}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "allows batch method with `partialUpdateObject` action")]
  public async Task BatchTest4()
  {
    await _client.BatchAsync(
      "theIndexName",
      new BatchWriteParams
      {
        Requests = new List<BatchRequest>
        {
          new BatchRequest
          {
            Action = Enum.Parse<Action>("PartialUpdateObject"),
            Body = new Dictionary<string, string> { { "key", "value" } },
          }
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/batch", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"requests\":[{\"action\":\"partialUpdateObject\",\"body\":{\"key\":\"value\"}}]}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "allows batch method with `partialUpdateObjectNoCreate` action")]
  public async Task BatchTest5()
  {
    await _client.BatchAsync(
      "theIndexName",
      new BatchWriteParams
      {
        Requests = new List<BatchRequest>
        {
          new BatchRequest
          {
            Action = Enum.Parse<Action>("PartialUpdateObjectNoCreate"),
            Body = new Dictionary<string, string> { { "key", "value" } },
          }
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/batch", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"requests\":[{\"action\":\"partialUpdateObjectNoCreate\",\"body\":{\"key\":\"value\"}}]}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "allows batch method with `updateObject` action")]
  public async Task BatchTest6()
  {
    await _client.BatchAsync(
      "theIndexName",
      new BatchWriteParams
      {
        Requests = new List<BatchRequest>
        {
          new BatchRequest
          {
            Action = Enum.Parse<Action>("UpdateObject"),
            Body = new Dictionary<string, string> { { "key", "value" } },
          }
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/batch", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"requests\":[{\"action\":\"updateObject\",\"body\":{\"key\":\"value\"}}]}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "batchAssignUserIds0")]
  public async Task BatchAssignUserIdsTest0()
  {
    await _client.BatchAssignUserIdsAsync(
      "userID",
      new BatchAssignUserIdsParams
      {
        Cluster = "theCluster",
        Users = new List<string> { "user1", "user2" },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/clusters/mapping/batch", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"cluster\":\"theCluster\",\"users\":[\"user1\",\"user2\"]}",
      req.Body,
      new JsonDiffConfig(false)
    );
    var expectedHeaders = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"x-algolia-user-id\":\"userID\"}"
    );
    var actualHeaders = req.Headers;
    foreach (var expectedHeader in expectedHeaders)
    {
      string actualHeaderValue;
      actualHeaders.TryGetValue(expectedHeader.Key, out actualHeaderValue);
      Assert.Equal(expectedHeader.Value, actualHeaderValue);
    }
  }

  [Fact(DisplayName = "get batchDictionaryEntries results with minimal parameters")]
  public async Task BatchDictionaryEntriesTest0()
  {
    await _client.BatchDictionaryEntriesAsync(
      Enum.Parse<DictionaryType>("Compounds"),
      new BatchDictionaryEntriesParams
      {
        Requests = new List<BatchDictionaryEntriesRequest>
        {
          new BatchDictionaryEntriesRequest
          {
            Action = Enum.Parse<DictionaryAction>("AddEntry"),
            Body = new DictionaryEntry { ObjectID = "1", Language = "en", },
          },
          new BatchDictionaryEntriesRequest
          {
            Action = Enum.Parse<DictionaryAction>("DeleteEntry"),
            Body = new DictionaryEntry { ObjectID = "2", Language = "fr", },
          }
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/dictionaries/compounds/batch", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"requests\":[{\"action\":\"addEntry\",\"body\":{\"objectID\":\"1\",\"language\":\"en\"}},{\"action\":\"deleteEntry\",\"body\":{\"objectID\":\"2\",\"language\":\"fr\"}}]}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "get batchDictionaryEntries results with all parameters")]
  public async Task BatchDictionaryEntriesTest1()
  {
    await _client.BatchDictionaryEntriesAsync(
      Enum.Parse<DictionaryType>("Compounds"),
      new BatchDictionaryEntriesParams
      {
        ClearExistingDictionaryEntries = false,
        Requests = new List<BatchDictionaryEntriesRequest>
        {
          new BatchDictionaryEntriesRequest
          {
            Action = Enum.Parse<DictionaryAction>("AddEntry"),
            Body = new DictionaryEntry
            {
              ObjectID = "1",
              Language = "en",
              Word = "fancy",
              Words = new List<string> { "believe", "algolia" },
              Decomposition = new List<string> { "trust", "algolia" },
              State = Enum.Parse<DictionaryEntryState>("Enabled"),
            },
          },
          new BatchDictionaryEntriesRequest
          {
            Action = Enum.Parse<DictionaryAction>("DeleteEntry"),
            Body = new DictionaryEntry
            {
              ObjectID = "2",
              Language = "fr",
              Word = "humility",
              Words = new List<string> { "candor", "algolia" },
              Decomposition = new List<string> { "grit", "algolia" },
              State = Enum.Parse<DictionaryEntryState>("Enabled"),
            },
          }
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/dictionaries/compounds/batch", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"clearExistingDictionaryEntries\":false,\"requests\":[{\"action\":\"addEntry\",\"body\":{\"objectID\":\"1\",\"language\":\"en\",\"word\":\"fancy\",\"words\":[\"believe\",\"algolia\"],\"decomposition\":[\"trust\",\"algolia\"],\"state\":\"enabled\"}},{\"action\":\"deleteEntry\",\"body\":{\"objectID\":\"2\",\"language\":\"fr\",\"word\":\"humility\",\"words\":[\"candor\",\"algolia\"],\"decomposition\":[\"grit\",\"algolia\"],\"state\":\"enabled\"}}]}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "get batchDictionaryEntries results additional properties")]
  public async Task BatchDictionaryEntriesTest2()
  {
    await _client.BatchDictionaryEntriesAsync(
      Enum.Parse<DictionaryType>("Compounds"),
      new BatchDictionaryEntriesParams
      {
        Requests = new List<BatchDictionaryEntriesRequest>
        {
          new BatchDictionaryEntriesRequest
          {
            Action = Enum.Parse<DictionaryAction>("AddEntry"),
            Body = new DictionaryEntry
            {
              ObjectID = "1",
              Language = "en",
              AdditionalProperties = new Dictionary<string, object> { { "additional", "try me" } }
            },
          }
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/dictionaries/compounds/batch", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"requests\":[{\"action\":\"addEntry\",\"body\":{\"objectID\":\"1\",\"language\":\"en\",\"additional\":\"try me\"}}]}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "browse with minimal parameters")]
  public async Task BrowseTest0()
  {
    await _client.BrowseAsync<Object>("cts_e2e_browse");

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/cts_e2e_browse/browse", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault("{}", req.Body, new JsonDiffConfig(false));

    // e2e
    try
    {
      var resp = await _e2eClient.BrowseAsync<Object>("cts_e2e_browse");
      // Check status code 200
      Assert.NotNull(resp);

      JsonAssert.EqualOverrideDefault(
        "{\"page\":0,\"nbHits\":33191,\"nbPages\":34,\"hitsPerPage\":1000,\"query\":\"\",\"params\":\"\"}",
        JsonConvert.SerializeObject(resp),
        new JsonDiffConfig(true)
      );
    }
    catch (Exception e)
    {
      Assert.Fail("An exception was thrown: " + e.Message);
    }
  }

  [Fact(DisplayName = "browse with search parameters")]
  public async Task BrowseTest1()
  {
    await _client.BrowseAsync<Object>(
      "indexName",
      new BrowseParams(
        new BrowseParamsObject
        {
          Query = "myQuery",
          FacetFilters = new FacetFilters(
            new List<MixedSearchFilters> { new MixedSearchFilters("tags:algolia") }
          ),
        }
      )
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/browse", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"query\":\"myQuery\",\"facetFilters\":[\"tags:algolia\"]}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "browse allow a cursor in parameters")]
  public async Task BrowseTest2()
  {
    await _client.BrowseAsync<Object>(
      "indexName",
      new BrowseParams(new BrowseParamsObject { Cursor = "test", })
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/browse", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault("{\"cursor\":\"test\"}", req.Body, new JsonDiffConfig(false));
  }

  [Fact(DisplayName = "clearObjects0")]
  public async Task ClearObjectsTest0()
  {
    await _client.ClearObjectsAsync("theIndexName");

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/clear", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    Assert.Equal("{}", req.Body);
  }

  [Fact(DisplayName = "clearRules0")]
  public async Task ClearRulesTest0()
  {
    await _client.ClearRulesAsync("indexName");

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/rules/clear", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    Assert.Equal("{}", req.Body);
  }

  [Fact(DisplayName = "clearSynonyms0")]
  public async Task ClearSynonymsTest0()
  {
    await _client.ClearSynonymsAsync("indexName");

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/synonyms/clear", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    Assert.Equal("{}", req.Body);
  }

  [Fact(DisplayName = "allow del method for a custom path with minimal parameters")]
  public async Task CustomDeleteTest0()
  {
    await _client.CustomDeleteAsync("/test/minimal");

    var req = _echo.LastResponse;
    Assert.Equal("/1/test/minimal", req.Path);
    Assert.Equal("DELETE", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "allow del method for a custom path with all parameters")]
  public async Task CustomDeleteTest1()
  {
    await _client.CustomDeleteAsync(
      "/test/all",
      new Dictionary<string, object> { { "query", "parameters" } }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/test/all", req.Path);
    Assert.Equal("DELETE", req.Method.ToString());
    Assert.Null(req.Body);
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"query\":\"parameters\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "allow get method for a custom path with minimal parameters")]
  public async Task CustomGetTest0()
  {
    await _client.CustomGetAsync("/test/minimal");

    var req = _echo.LastResponse;
    Assert.Equal("/1/test/minimal", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "allow get method for a custom path with all parameters")]
  public async Task CustomGetTest1()
  {
    await _client.CustomGetAsync(
      "/test/all",
      new Dictionary<string, object> { { "query", "parameters" } }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/test/all", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"query\":\"parameters\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "allow post method for a custom path with minimal parameters")]
  public async Task CustomPostTest0()
  {
    await _client.CustomPostAsync("/test/minimal");

    var req = _echo.LastResponse;
    Assert.Equal("/1/test/minimal", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault("{}", req.Body, new JsonDiffConfig(false));
  }

  [Fact(DisplayName = "allow post method for a custom path with all parameters")]
  public async Task CustomPostTest1()
  {
    await _client.CustomPostAsync(
      "/test/all",
      new Dictionary<string, object> { { "query", "parameters" } },
      new Dictionary<string, string> { { "body", "parameters" } }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/test/all", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"body\":\"parameters\"}",
      req.Body,
      new JsonDiffConfig(false)
    );
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"query\":\"parameters\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "requestOptions can override default query parameters")]
  public async Task CustomPostTest2()
  {
    await _client.CustomPostAsync(
      "/test/requestOptions",
      new Dictionary<string, object> { { "query", "parameters" } },
      new Dictionary<string, string> { { "facet", "filters" } },
      new RequestOptions()
      {
        QueryParameters = new Dictionary<string, object>() { { "query", "myQueryParameter" } },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/test/requestOptions", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault("{\"facet\":\"filters\"}", req.Body, new JsonDiffConfig(false));
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"query\":\"myQueryParameter\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "requestOptions merges query parameters with default ones")]
  public async Task CustomPostTest3()
  {
    await _client.CustomPostAsync(
      "/test/requestOptions",
      new Dictionary<string, object> { { "query", "parameters" } },
      new Dictionary<string, string> { { "facet", "filters" } },
      new RequestOptions()
      {
        QueryParameters = new Dictionary<string, object>() { { "query2", "myQueryParameter" } },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/test/requestOptions", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault("{\"facet\":\"filters\"}", req.Body, new JsonDiffConfig(false));
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"query\":\"parameters\",\"query2\":\"myQueryParameter\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "requestOptions can override default headers")]
  public async Task CustomPostTest4()
  {
    await _client.CustomPostAsync(
      "/test/requestOptions",
      new Dictionary<string, object> { { "query", "parameters" } },
      new Dictionary<string, string> { { "facet", "filters" } },
      new RequestOptions()
      {
        Headers = new Dictionary<string, string>() { { "x-algolia-api-key", "myApiKey" } },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/test/requestOptions", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault("{\"facet\":\"filters\"}", req.Body, new JsonDiffConfig(false));
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"query\":\"parameters\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
    var expectedHeaders = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"x-algolia-api-key\":\"myApiKey\"}"
    );
    var actualHeaders = req.Headers;
    foreach (var expectedHeader in expectedHeaders)
    {
      string actualHeaderValue;
      actualHeaders.TryGetValue(expectedHeader.Key, out actualHeaderValue);
      Assert.Equal(expectedHeader.Value, actualHeaderValue);
    }
  }

  [Fact(DisplayName = "requestOptions merges headers with default ones")]
  public async Task CustomPostTest5()
  {
    await _client.CustomPostAsync(
      "/test/requestOptions",
      new Dictionary<string, object> { { "query", "parameters" } },
      new Dictionary<string, string> { { "facet", "filters" } },
      new RequestOptions()
      {
        Headers = new Dictionary<string, string>() { { "x-algolia-api-key", "myApiKey" } },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/test/requestOptions", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault("{\"facet\":\"filters\"}", req.Body, new JsonDiffConfig(false));
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"query\":\"parameters\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
    var expectedHeaders = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"x-algolia-api-key\":\"myApiKey\"}"
    );
    var actualHeaders = req.Headers;
    foreach (var expectedHeader in expectedHeaders)
    {
      string actualHeaderValue;
      actualHeaders.TryGetValue(expectedHeader.Key, out actualHeaderValue);
      Assert.Equal(expectedHeader.Value, actualHeaderValue);
    }
  }

  [Fact(DisplayName = "requestOptions queryParameters accepts booleans")]
  public async Task CustomPostTest6()
  {
    await _client.CustomPostAsync(
      "/test/requestOptions",
      new Dictionary<string, object> { { "query", "parameters" } },
      new Dictionary<string, string> { { "facet", "filters" } },
      new RequestOptions()
      {
        QueryParameters = new Dictionary<string, object>() { { "isItWorking", true } },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/test/requestOptions", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault("{\"facet\":\"filters\"}", req.Body, new JsonDiffConfig(false));
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"query\":\"parameters\",\"isItWorking\":\"true\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "requestOptions queryParameters accepts integers")]
  public async Task CustomPostTest7()
  {
    await _client.CustomPostAsync(
      "/test/requestOptions",
      new Dictionary<string, object> { { "query", "parameters" } },
      new Dictionary<string, string> { { "facet", "filters" } },
      new RequestOptions()
      {
        QueryParameters = new Dictionary<string, object>() { { "myParam", 2 } },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/test/requestOptions", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault("{\"facet\":\"filters\"}", req.Body, new JsonDiffConfig(false));
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"query\":\"parameters\",\"myParam\":\"2\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "requestOptions queryParameters accepts list of string")]
  public async Task CustomPostTest8()
  {
    await _client.CustomPostAsync(
      "/test/requestOptions",
      new Dictionary<string, object> { { "query", "parameters" } },
      new Dictionary<string, string> { { "facet", "filters" } },
      new RequestOptions()
      {
        QueryParameters = new Dictionary<string, object>()
        {
          {
            "myParam",
            new List<object> { "c", "d" }
          }
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/test/requestOptions", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault("{\"facet\":\"filters\"}", req.Body, new JsonDiffConfig(false));
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"query\":\"parameters\",\"myParam\":\"c,d\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "requestOptions queryParameters accepts list of booleans")]
  public async Task CustomPostTest9()
  {
    await _client.CustomPostAsync(
      "/test/requestOptions",
      new Dictionary<string, object> { { "query", "parameters" } },
      new Dictionary<string, string> { { "facet", "filters" } },
      new RequestOptions()
      {
        QueryParameters = new Dictionary<string, object>()
        {
          {
            "myParam",
            new List<object> { true, true, false }
          }
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/test/requestOptions", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault("{\"facet\":\"filters\"}", req.Body, new JsonDiffConfig(false));
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"query\":\"parameters\",\"myParam\":\"true,true,false\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "requestOptions queryParameters accepts list of integers")]
  public async Task CustomPostTest10()
  {
    await _client.CustomPostAsync(
      "/test/requestOptions",
      new Dictionary<string, object> { { "query", "parameters" } },
      new Dictionary<string, string> { { "facet", "filters" } },
      new RequestOptions()
      {
        QueryParameters = new Dictionary<string, object>()
        {
          {
            "myParam",
            new List<object> { 1, 2 }
          }
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/test/requestOptions", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault("{\"facet\":\"filters\"}", req.Body, new JsonDiffConfig(false));
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"query\":\"parameters\",\"myParam\":\"1,2\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "allow put method for a custom path with minimal parameters")]
  public async Task CustomPutTest0()
  {
    await _client.CustomPutAsync("/test/minimal");

    var req = _echo.LastResponse;
    Assert.Equal("/1/test/minimal", req.Path);
    Assert.Equal("PUT", req.Method.ToString());
    JsonAssert.EqualOverrideDefault("{}", req.Body, new JsonDiffConfig(false));
  }

  [Fact(DisplayName = "allow put method for a custom path with all parameters")]
  public async Task CustomPutTest1()
  {
    await _client.CustomPutAsync(
      "/test/all",
      new Dictionary<string, object> { { "query", "parameters" } },
      new Dictionary<string, string> { { "body", "parameters" } }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/test/all", req.Path);
    Assert.Equal("PUT", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"body\":\"parameters\"}",
      req.Body,
      new JsonDiffConfig(false)
    );
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"query\":\"parameters\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "deleteApiKey0")]
  public async Task DeleteApiKeyTest0()
  {
    await _client.DeleteApiKeyAsync("myTestApiKey");

    var req = _echo.LastResponse;
    Assert.Equal("/1/keys/myTestApiKey", req.Path);
    Assert.Equal("DELETE", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "deleteBy0")]
  public async Task DeleteByTest0()
  {
    await _client.DeleteByAsync(
      "theIndexName",
      new DeleteByParams { Filters = "brand:brandName", }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/deleteByQuery", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"filters\":\"brand:brandName\"}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "deleteIndex0")]
  public async Task DeleteIndexTest0()
  {
    await _client.DeleteIndexAsync("theIndexName");

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName", req.Path);
    Assert.Equal("DELETE", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "deleteObject0")]
  public async Task DeleteObjectTest0()
  {
    await _client.DeleteObjectAsync("theIndexName", "uniqueID");

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/uniqueID", req.Path);
    Assert.Equal("DELETE", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "delete rule simple case")]
  public async Task DeleteRuleTest0()
  {
    await _client.DeleteRuleAsync("indexName", "id1");

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/rules/id1", req.Path);
    Assert.Equal("DELETE", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "delete rule with simple characters to encode in objectID")]
  public async Task DeleteRuleTest1()
  {
    await _client.DeleteRuleAsync("indexName", "test/with/slash");

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/rules/test%2Fwith%2Fslash", req.Path);
    Assert.Equal("DELETE", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "deleteSource0")]
  public async Task DeleteSourceTest0()
  {
    await _client.DeleteSourceAsync("theSource");

    var req = _echo.LastResponse;
    Assert.Equal("/1/security/sources/theSource", req.Path);
    Assert.Equal("DELETE", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "deleteSynonym0")]
  public async Task DeleteSynonymTest0()
  {
    await _client.DeleteSynonymAsync("indexName", "id1");

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/synonyms/id1", req.Path);
    Assert.Equal("DELETE", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "getApiKey0")]
  public async Task GetApiKeyTest0()
  {
    await _client.GetApiKeyAsync("myTestApiKey");

    var req = _echo.LastResponse;
    Assert.Equal("/1/keys/myTestApiKey", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "get getDictionaryLanguages")]
  public async Task GetDictionaryLanguagesTest0()
  {
    await _client.GetDictionaryLanguagesAsync();

    var req = _echo.LastResponse;
    Assert.Equal("/1/dictionaries/*/languages", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "get getDictionarySettings results")]
  public async Task GetDictionarySettingsTest0()
  {
    await _client.GetDictionarySettingsAsync();

    var req = _echo.LastResponse;
    Assert.Equal("/1/dictionaries/*/settings", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "getLogs with minimal parameters")]
  public async Task GetLogsTest0()
  {
    await _client.GetLogsAsync();

    var req = _echo.LastResponse;
    Assert.Equal("/1/logs", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "getLogs with parameters")]
  public async Task GetLogsTest1()
  {
    await _client.GetLogsAsync(5, 10, "theIndexName", Enum.Parse<LogType>("All"));

    var req = _echo.LastResponse;
    Assert.Equal("/1/logs", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"offset\":\"5\",\"length\":\"10\",\"indexName\":\"theIndexName\",\"type\":\"all\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "getObject0")]
  public async Task GetObjectTest0()
  {
    await _client.GetObjectAsync("theIndexName", "uniqueID", new List<string> { "attr1", "attr2" });

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/uniqueID", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"attributesToRetrieve\":\"attr1,attr2\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "getObjects0")]
  public async Task GetObjectsTest0()
  {
    await _client.GetObjectsAsync<Object>(
      new GetObjectsParams
      {
        Requests = new List<GetObjectsRequest>
        {
          new GetObjectsRequest
          {
            AttributesToRetrieve = new List<string> { "attr1", "attr2" },
            ObjectID = "uniqueID",
            IndexName = "theIndexName",
          }
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/*/objects", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"requests\":[{\"attributesToRetrieve\":[\"attr1\",\"attr2\"],\"objectID\":\"uniqueID\",\"indexName\":\"theIndexName\"}]}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "getRule0")]
  public async Task GetRuleTest0()
  {
    await _client.GetRuleAsync("indexName", "id1");

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/rules/id1", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "getSettings0")]
  public async Task GetSettingsTest0()
  {
    await _client.GetSettingsAsync("cts_e2e_settings");

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/cts_e2e_settings/settings", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);

    // e2e
    try
    {
      var resp = await _e2eClient.GetSettingsAsync("cts_e2e_settings");
      // Check status code 200
      Assert.NotNull(resp);

      JsonAssert.EqualOverrideDefault(
        "{\"minWordSizefor1Typo\":4,\"minWordSizefor2Typos\":8,\"hitsPerPage\":20,\"maxValuesPerFacet\":100,\"paginationLimitedTo\":10,\"exactOnSingleWordQuery\":\"attribute\",\"ranking\":[\"typo\",\"geo\",\"words\",\"filters\",\"proximity\",\"attribute\",\"exact\",\"custom\"],\"separatorsToIndex\":\"\",\"removeWordsIfNoResults\":\"none\",\"queryType\":\"prefixLast\",\"highlightPreTag\":\"<em>\",\"highlightPostTag\":\"</em>\",\"alternativesAsExact\":[\"ignorePlurals\",\"singleWordSynonym\"]}",
        JsonConvert.SerializeObject(resp),
        new JsonDiffConfig(true)
      );
    }
    catch (Exception e)
    {
      Assert.Fail("An exception was thrown: " + e.Message);
    }
  }

  [Fact(DisplayName = "getSources0")]
  public async Task GetSourcesTest0()
  {
    await _client.GetSourcesAsync();

    var req = _echo.LastResponse;
    Assert.Equal("/1/security/sources", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "getSynonym0")]
  public async Task GetSynonymTest0()
  {
    await _client.GetSynonymAsync("indexName", "id1");

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/synonyms/id1", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "getTask0")]
  public async Task GetTaskTest0()
  {
    await _client.GetTaskAsync("theIndexName", 123L);

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/task/123", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "getTopUserIds0")]
  public async Task GetTopUserIdsTest0()
  {
    await _client.GetTopUserIdsAsync();

    var req = _echo.LastResponse;
    Assert.Equal("/1/clusters/mapping/top", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "getUserId0")]
  public async Task GetUserIdTest0()
  {
    await _client.GetUserIdAsync("uniqueID");

    var req = _echo.LastResponse;
    Assert.Equal("/1/clusters/mapping/uniqueID", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "hasPendingMappings with minimal parameters")]
  public async Task HasPendingMappingsTest0()
  {
    await _client.HasPendingMappingsAsync();

    var req = _echo.LastResponse;
    Assert.Equal("/1/clusters/mapping/pending", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "hasPendingMappings with parameters")]
  public async Task HasPendingMappingsTest1()
  {
    await _client.HasPendingMappingsAsync(true);

    var req = _echo.LastResponse;
    Assert.Equal("/1/clusters/mapping/pending", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"getClusters\":\"true\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "listApiKeys0")]
  public async Task ListApiKeysTest0()
  {
    await _client.ListApiKeysAsync();

    var req = _echo.LastResponse;
    Assert.Equal("/1/keys", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "listClusters0")]
  public async Task ListClustersTest0()
  {
    await _client.ListClustersAsync();

    var req = _echo.LastResponse;
    Assert.Equal("/1/clusters", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "listIndices with minimal parameters")]
  public async Task ListIndicesTest0()
  {
    await _client.ListIndicesAsync();

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "listIndices with parameters")]
  public async Task ListIndicesTest1()
  {
    await _client.ListIndicesAsync(8, 3);

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"page\":\"8\",\"hitsPerPage\":\"3\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "listUserIds with minimal parameters")]
  public async Task ListUserIdsTest0()
  {
    await _client.ListUserIdsAsync();

    var req = _echo.LastResponse;
    Assert.Equal("/1/clusters/mapping", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "listUserIds with parameters")]
  public async Task ListUserIdsTest1()
  {
    await _client.ListUserIdsAsync(8, 100);

    var req = _echo.LastResponse;
    Assert.Equal("/1/clusters/mapping", req.Path);
    Assert.Equal("GET", req.Method.ToString());
    Assert.Null(req.Body);
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"page\":\"8\",\"hitsPerPage\":\"100\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "multipleBatch0")]
  public async Task MultipleBatchTest0()
  {
    await _client.MultipleBatchAsync(
      new BatchParams
      {
        Requests = new List<MultipleBatchRequest>
        {
          new MultipleBatchRequest
          {
            Action = Enum.Parse<Action>("AddObject"),
            Body = new Dictionary<string, string> { { "key", "value" } },
            IndexName = "theIndexName",
          }
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/*/batch", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"requests\":[{\"action\":\"addObject\",\"body\":{\"key\":\"value\"},\"indexName\":\"theIndexName\"}]}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "operationIndex0")]
  public async Task OperationIndexTest0()
  {
    await _client.OperationIndexAsync(
      "theIndexName",
      new OperationIndexParams
      {
        Operation = Enum.Parse<OperationType>("Copy"),
        Destination = "dest",
        Scope = new List<ScopeType>
        {
          Enum.Parse<ScopeType>("Rules"),
          Enum.Parse<ScopeType>("Settings")
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/operation", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"operation\":\"copy\",\"destination\":\"dest\",\"scope\":[\"rules\",\"settings\"]}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "partialUpdateObject0")]
  public async Task PartialUpdateObjectTest0()
  {
    await _client.PartialUpdateObjectAsync(
      "theIndexName",
      "uniqueID",
      new Dictionary<string, AttributeToUpdate>
      {
        { "id1", new AttributeToUpdate("test") },
        {
          "id2",
          new AttributeToUpdate(
            new BuiltInOperation
            {
              Operation = Enum.Parse<BuiltInOperationType>("AddUnique"),
              Value = "test2",
            }
          )
        }
      },
      true
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/uniqueID/partial", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"id1\":\"test\",\"id2\":{\"_operation\":\"AddUnique\",\"value\":\"test2\"}}",
      req.Body,
      new JsonDiffConfig(false)
    );
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"createIfNotExists\":\"true\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "removeUserId0")]
  public async Task RemoveUserIdTest0()
  {
    await _client.RemoveUserIdAsync("uniqueID");

    var req = _echo.LastResponse;
    Assert.Equal("/1/clusters/mapping/uniqueID", req.Path);
    Assert.Equal("DELETE", req.Method.ToString());
    Assert.Null(req.Body);
  }

  [Fact(DisplayName = "replaceSources0")]
  public async Task ReplaceSourcesTest0()
  {
    await _client.ReplaceSourcesAsync(
      new List<Source>
      {
        new Source { VarSource = "theSource", Description = "theDescription", }
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/security/sources", req.Path);
    Assert.Equal("PUT", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "[{\"source\":\"theSource\",\"description\":\"theDescription\"}]",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "restoreApiKey0")]
  public async Task RestoreApiKeyTest0()
  {
    await _client.RestoreApiKeyAsync("myApiKey");

    var req = _echo.LastResponse;
    Assert.Equal("/1/keys/myApiKey/restore", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    Assert.Equal("{}", req.Body);
  }

  [Fact(DisplayName = "saveObject0")]
  public async Task SaveObjectTest0()
  {
    await _client.SaveObjectAsync(
      "theIndexName",
      new Dictionary<string, string> { { "objectID", "id" }, { "test", "val" } }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"objectID\":\"id\",\"test\":\"val\"}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "saveRule with minimal parameters")]
  public async Task SaveRuleTest0()
  {
    await _client.SaveRuleAsync(
      "indexName",
      "id1",
      new Rule
      {
        ObjectID = "id1",
        Conditions = new List<Condition>
        {
          new Condition { Pattern = "apple", Anchoring = Enum.Parse<Anchoring>("Contains"), }
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/rules/id1", req.Path);
    Assert.Equal("PUT", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"objectID\":\"id1\",\"conditions\":[{\"pattern\":\"apple\",\"anchoring\":\"contains\"}]}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "saveRule with all parameters")]
  public async Task SaveRuleTest1()
  {
    await _client.SaveRuleAsync(
      "indexName",
      "id1",
      new Rule
      {
        ObjectID = "id1",
        Conditions = new List<Condition>
        {
          new Condition
          {
            Pattern = "apple",
            Anchoring = Enum.Parse<Anchoring>("Contains"),
            Alternatives = false,
            Context = "search",
          }
        },
        Consequence = new Consequence
        {
          VarParams = new ConsequenceParams
          {
            Filters = "brand:apple",
            Query = new ConsequenceQuery(
              new ConsequenceQueryObject
              {
                Remove = new List<string> { "algolia" },
                Edits = new List<Edit>
                {
                  new Edit
                  {
                    Type = Enum.Parse<EditType>("Remove"),
                    Delete = "abc",
                    Insert = "cde",
                  },
                  new Edit
                  {
                    Type = Enum.Parse<EditType>("Replace"),
                    Delete = "abc",
                    Insert = "cde",
                  }
                },
              }
            ),
          },
          Hide = new List<ConsequenceHide> { new ConsequenceHide { ObjectID = "321", } },
          FilterPromotes = false,
          UserData = new Dictionary<string, string> { { "algolia", "aloglia" } },
          Promote = new List<Promote>
          {
            new Promote(new PromoteObjectID { ObjectID = "abc", Position = 3, }),
            new Promote(
              new PromoteObjectIDs
              {
                ObjectIDs = new List<string> { "abc", "def" },
                Position = 1,
              }
            )
          },
        },
        Description = "test",
        Enabled = true,
        Validity = new List<TimeRange>
        {
          new TimeRange { From = 1656670273, Until = 1656670277, }
        },
      },
      true
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/rules/id1", req.Path);
    Assert.Equal("PUT", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"objectID\":\"id1\",\"conditions\":[{\"pattern\":\"apple\",\"anchoring\":\"contains\",\"alternatives\":false,\"context\":\"search\"}],\"consequence\":{\"params\":{\"filters\":\"brand:apple\",\"query\":{\"remove\":[\"algolia\"],\"edits\":[{\"type\":\"remove\",\"delete\":\"abc\",\"insert\":\"cde\"},{\"type\":\"replace\",\"delete\":\"abc\",\"insert\":\"cde\"}]}},\"hide\":[{\"objectID\":\"321\"}],\"filterPromotes\":false,\"userData\":{\"algolia\":\"aloglia\"},\"promote\":[{\"objectID\":\"abc\",\"position\":3},{\"objectIDs\":[\"abc\",\"def\"],\"position\":1}]},\"description\":\"test\",\"enabled\":true,\"validity\":[{\"from\":1656670273,\"until\":1656670277}]}",
      req.Body,
      new JsonDiffConfig(false)
    );
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"forwardToReplicas\":\"true\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "saveRules with minimal parameters")]
  public async Task SaveRulesTest0()
  {
    await _client.SaveRulesAsync(
      "indexName",
      new List<Rule>
      {
        new Rule
        {
          ObjectID = "a-rule-id",
          Conditions = new List<Condition>
          {
            new Condition { Pattern = "smartphone", Anchoring = Enum.Parse<Anchoring>("Contains"), }
          },
        },
        new Rule
        {
          ObjectID = "a-second-rule-id",
          Conditions = new List<Condition>
          {
            new Condition { Pattern = "apple", Anchoring = Enum.Parse<Anchoring>("Contains"), }
          },
        }
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/rules/batch", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "[{\"objectID\":\"a-rule-id\",\"conditions\":[{\"pattern\":\"smartphone\",\"anchoring\":\"contains\"}]},{\"objectID\":\"a-second-rule-id\",\"conditions\":[{\"pattern\":\"apple\",\"anchoring\":\"contains\"}]}]",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "saveRules with all parameters")]
  public async Task SaveRulesTest1()
  {
    await _client.SaveRulesAsync(
      "indexName",
      new List<Rule>
      {
        new Rule
        {
          ObjectID = "id1",
          Conditions = new List<Condition>
          {
            new Condition
            {
              Pattern = "apple",
              Anchoring = Enum.Parse<Anchoring>("Contains"),
              Alternatives = false,
              Context = "search",
            }
          },
          Consequence = new Consequence
          {
            VarParams = new ConsequenceParams
            {
              Filters = "brand:apple",
              Query = new ConsequenceQuery(
                new ConsequenceQueryObject
                {
                  Remove = new List<string> { "algolia" },
                  Edits = new List<Edit>
                  {
                    new Edit
                    {
                      Type = Enum.Parse<EditType>("Remove"),
                      Delete = "abc",
                      Insert = "cde",
                    },
                    new Edit
                    {
                      Type = Enum.Parse<EditType>("Replace"),
                      Delete = "abc",
                      Insert = "cde",
                    }
                  },
                }
              ),
            },
            Hide = new List<ConsequenceHide> { new ConsequenceHide { ObjectID = "321", } },
            FilterPromotes = false,
            UserData = new Dictionary<string, string> { { "algolia", "aloglia" } },
            Promote = new List<Promote>
            {
              new Promote(new PromoteObjectID { ObjectID = "abc", Position = 3, }),
              new Promote(
                new PromoteObjectIDs
                {
                  ObjectIDs = new List<string> { "abc", "def" },
                  Position = 1,
                }
              )
            },
          },
          Description = "test",
          Enabled = true,
          Validity = new List<TimeRange>
          {
            new TimeRange { From = 1656670273, Until = 1656670277, }
          },
        }
      },
      true,
      true
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/rules/batch", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "[{\"objectID\":\"id1\",\"conditions\":[{\"pattern\":\"apple\",\"anchoring\":\"contains\",\"alternatives\":false,\"context\":\"search\"}],\"consequence\":{\"params\":{\"filters\":\"brand:apple\",\"query\":{\"remove\":[\"algolia\"],\"edits\":[{\"type\":\"remove\",\"delete\":\"abc\",\"insert\":\"cde\"},{\"type\":\"replace\",\"delete\":\"abc\",\"insert\":\"cde\"}]}},\"hide\":[{\"objectID\":\"321\"}],\"filterPromotes\":false,\"userData\":{\"algolia\":\"aloglia\"},\"promote\":[{\"objectID\":\"abc\",\"position\":3},{\"objectIDs\":[\"abc\",\"def\"],\"position\":1}]},\"description\":\"test\",\"enabled\":true,\"validity\":[{\"from\":1656670273,\"until\":1656670277}]}]",
      req.Body,
      new JsonDiffConfig(false)
    );
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"forwardToReplicas\":\"true\",\"clearExistingRules\":\"true\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "saveSynonym0")]
  public async Task SaveSynonymTest0()
  {
    await _client.SaveSynonymAsync(
      "indexName",
      "id1",
      new SynonymHit
      {
        ObjectID = "id1",
        Type = Enum.Parse<SynonymType>("Synonym"),
        Synonyms = new List<string> { "car", "vehicule", "auto" },
      },
      true
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/synonyms/id1", req.Path);
    Assert.Equal("PUT", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"objectID\":\"id1\",\"type\":\"synonym\",\"synonyms\":[\"car\",\"vehicule\",\"auto\"]}",
      req.Body,
      new JsonDiffConfig(false)
    );
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"forwardToReplicas\":\"true\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "saveSynonyms0")]
  public async Task SaveSynonymsTest0()
  {
    await _client.SaveSynonymsAsync(
      "indexName",
      new List<SynonymHit>
      {
        new SynonymHit
        {
          ObjectID = "id1",
          Type = Enum.Parse<SynonymType>("Synonym"),
          Synonyms = new List<string> { "car", "vehicule", "auto" },
        },
        new SynonymHit
        {
          ObjectID = "id2",
          Type = Enum.Parse<SynonymType>("Onewaysynonym"),
          Input = "iphone",
          Synonyms = new List<string> { "ephone", "aphone", "yphone" },
        }
      },
      true,
      false
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/synonyms/batch", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "[{\"objectID\":\"id1\",\"type\":\"synonym\",\"synonyms\":[\"car\",\"vehicule\",\"auto\"]},{\"objectID\":\"id2\",\"type\":\"onewaysynonym\",\"input\":\"iphone\",\"synonyms\":[\"ephone\",\"aphone\",\"yphone\"]}]",
      req.Body,
      new JsonDiffConfig(false)
    );
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"forwardToReplicas\":\"true\",\"replaceExistingSynonyms\":\"false\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "search for a single hits request with minimal parameters")]
  public async Task SearchTest0()
  {
    await _client.SearchAsync<Object>(
      new SearchMethodParams
      {
        Requests = new List<SearchQuery>
        {
          new SearchQuery(new SearchForHits { IndexName = "cts_e2e_search_empty_index", })
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/*/queries", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"requests\":[{\"indexName\":\"cts_e2e_search_empty_index\"}]}",
      req.Body,
      new JsonDiffConfig(false)
    );

    // e2e
    try
    {
      var resp = await _e2eClient.SearchAsync<Object>(
        new SearchMethodParams
        {
          Requests = new List<SearchQuery>
          {
            new SearchQuery(new SearchForHits { IndexName = "cts_e2e_search_empty_index", })
          },
        }
      );
      // Check status code 200
      Assert.NotNull(resp);

      JsonAssert.EqualOverrideDefault(
        "{\"results\":[{\"hits\":[],\"page\":0,\"nbHits\":0,\"nbPages\":0,\"hitsPerPage\":20,\"exhaustiveNbHits\":true,\"exhaustiveTypo\":true,\"exhaustive\":{\"nbHits\":true,\"typo\":true},\"query\":\"\",\"params\":\"\",\"index\":\"cts_e2e_search_empty_index\",\"renderingContent\":{}}]}",
        JsonConvert.SerializeObject(resp),
        new JsonDiffConfig(true)
      );
    }
    catch (Exception e)
    {
      Assert.Fail("An exception was thrown: " + e.Message);
    }
  }

  [Fact(DisplayName = "search for a single facet request with minimal parameters")]
  public async Task SearchTest1()
  {
    await _client.SearchAsync<Object>(
      new SearchMethodParams
      {
        Requests = new List<SearchQuery>
        {
          new SearchQuery(
            new SearchForFacets
            {
              IndexName = "cts_e2e_search_facet",
              Type = Enum.Parse<SearchTypeFacet>("Facet"),
              Facet = "editor",
            }
          )
        },
        Strategy = Enum.Parse<SearchStrategy>("StopIfEnoughMatches"),
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/*/queries", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"requests\":[{\"indexName\":\"cts_e2e_search_facet\",\"type\":\"facet\",\"facet\":\"editor\"}],\"strategy\":\"stopIfEnoughMatches\"}",
      req.Body,
      new JsonDiffConfig(false)
    );

    // e2e
    try
    {
      var resp = await _e2eClient.SearchAsync<Object>(
        new SearchMethodParams
        {
          Requests = new List<SearchQuery>
          {
            new SearchQuery(
              new SearchForFacets
              {
                IndexName = "cts_e2e_search_facet",
                Type = Enum.Parse<SearchTypeFacet>("Facet"),
                Facet = "editor",
              }
            )
          },
          Strategy = Enum.Parse<SearchStrategy>("StopIfEnoughMatches"),
        }
      );
      // Check status code 200
      Assert.NotNull(resp);

      JsonAssert.EqualOverrideDefault(
        "{\"results\":[{\"exhaustiveFacetsCount\":true,\"facetHits\":[{\"count\":1,\"highlighted\":\"goland\",\"value\":\"goland\"},{\"count\":1,\"highlighted\":\"neovim\",\"value\":\"neovim\"},{\"count\":1,\"highlighted\":\"vscode\",\"value\":\"vscode\"}]}]}",
        JsonConvert.SerializeObject(resp),
        new JsonDiffConfig(true)
      );
    }
    catch (Exception e)
    {
      Assert.Fail("An exception was thrown: " + e.Message);
    }
  }

  [Fact(DisplayName = "search for a single hits request with all parameters")]
  public async Task SearchTest2()
  {
    await _client.SearchAsync<Object>(
      new SearchMethodParams
      {
        Requests = new List<SearchQuery>
        {
          new SearchQuery(
            new SearchForHits
            {
              IndexName = "theIndexName",
              Query = "myQuery",
              HitsPerPage = 50,
              Type = Enum.Parse<SearchTypeDefault>("Default"),
            }
          )
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/*/queries", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"requests\":[{\"indexName\":\"theIndexName\",\"query\":\"myQuery\",\"hitsPerPage\":50,\"type\":\"default\"}]}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "search for a single facet request with all parameters")]
  public async Task SearchTest3()
  {
    await _client.SearchAsync<Object>(
      new SearchMethodParams
      {
        Requests = new List<SearchQuery>
        {
          new SearchQuery(
            new SearchForFacets
            {
              IndexName = "theIndexName",
              Type = Enum.Parse<SearchTypeFacet>("Facet"),
              Facet = "theFacet",
              FacetQuery = "theFacetQuery",
              Query = "theQuery",
              MaxFacetHits = 50,
            }
          )
        },
        Strategy = Enum.Parse<SearchStrategy>("StopIfEnoughMatches"),
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/*/queries", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"requests\":[{\"indexName\":\"theIndexName\",\"type\":\"facet\",\"facet\":\"theFacet\",\"facetQuery\":\"theFacetQuery\",\"query\":\"theQuery\",\"maxFacetHits\":50}],\"strategy\":\"stopIfEnoughMatches\"}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(
    DisplayName = "search for multiple mixed requests in multiple indices with minimal parameters"
  )]
  public async Task SearchTest4()
  {
    await _client.SearchAsync<Object>(
      new SearchMethodParams
      {
        Requests = new List<SearchQuery>
        {
          new SearchQuery(new SearchForHits { IndexName = "theIndexName", }),
          new SearchQuery(
            new SearchForFacets
            {
              IndexName = "theIndexName2",
              Type = Enum.Parse<SearchTypeFacet>("Facet"),
              Facet = "theFacet",
            }
          ),
          new SearchQuery(
            new SearchForHits
            {
              IndexName = "theIndexName",
              Type = Enum.Parse<SearchTypeDefault>("Default"),
            }
          )
        },
        Strategy = Enum.Parse<SearchStrategy>("StopIfEnoughMatches"),
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/*/queries", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"requests\":[{\"indexName\":\"theIndexName\"},{\"indexName\":\"theIndexName2\",\"type\":\"facet\",\"facet\":\"theFacet\"},{\"indexName\":\"theIndexName\",\"type\":\"default\"}],\"strategy\":\"stopIfEnoughMatches\"}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "search for multiple mixed requests in multiple indices with all parameters")]
  public async Task SearchTest5()
  {
    await _client.SearchAsync<Object>(
      new SearchMethodParams
      {
        Requests = new List<SearchQuery>
        {
          new SearchQuery(
            new SearchForFacets
            {
              IndexName = "theIndexName",
              Type = Enum.Parse<SearchTypeFacet>("Facet"),
              Facet = "theFacet",
              FacetQuery = "theFacetQuery",
              Query = "theQuery",
              MaxFacetHits = 50,
            }
          ),
          new SearchQuery(
            new SearchForHits
            {
              IndexName = "theIndexName",
              Query = "myQuery",
              HitsPerPage = 50,
              Type = Enum.Parse<SearchTypeDefault>("Default"),
            }
          )
        },
        Strategy = Enum.Parse<SearchStrategy>("StopIfEnoughMatches"),
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/*/queries", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"requests\":[{\"indexName\":\"theIndexName\",\"type\":\"facet\",\"facet\":\"theFacet\",\"facetQuery\":\"theFacetQuery\",\"query\":\"theQuery\",\"maxFacetHits\":50},{\"indexName\":\"theIndexName\",\"query\":\"myQuery\",\"hitsPerPage\":50,\"type\":\"default\"}],\"strategy\":\"stopIfEnoughMatches\"}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "search filters accept all of the possible shapes")]
  public async Task SearchTest6()
  {
    await _client.SearchAsync<Object>(
      new SearchMethodParams
      {
        Requests = new List<SearchQuery>
        {
          new SearchQuery(
            new SearchForHits
            {
              IndexName = "theIndexName",
              FacetFilters = new FacetFilters("mySearch:filters"),
              ReRankingApplyFilter = new ReRankingApplyFilter("mySearch:filters"),
              TagFilters = new TagFilters("mySearch:filters"),
              NumericFilters = new NumericFilters("mySearch:filters"),
              OptionalFilters = new OptionalFilters("mySearch:filters"),
            }
          ),
          new SearchQuery(
            new SearchForHits
            {
              IndexName = "theIndexName",
              FacetFilters = new FacetFilters(
                new List<MixedSearchFilters>
                {
                  new MixedSearchFilters("mySearch:filters"),
                  new MixedSearchFilters(new List<string> { "mySearch:filters" })
                }
              ),
              ReRankingApplyFilter = new ReRankingApplyFilter(
                new List<MixedSearchFilters>
                {
                  new MixedSearchFilters("mySearch:filters"),
                  new MixedSearchFilters(new List<string> { "mySearch:filters" })
                }
              ),
              TagFilters = new TagFilters(
                new List<MixedSearchFilters>
                {
                  new MixedSearchFilters("mySearch:filters"),
                  new MixedSearchFilters(new List<string> { "mySearch:filters" })
                }
              ),
              NumericFilters = new NumericFilters(
                new List<MixedSearchFilters>
                {
                  new MixedSearchFilters("mySearch:filters"),
                  new MixedSearchFilters(new List<string> { "mySearch:filters" })
                }
              ),
              OptionalFilters = new OptionalFilters(
                new List<MixedSearchFilters>
                {
                  new MixedSearchFilters("mySearch:filters"),
                  new MixedSearchFilters(new List<string> { "mySearch:filters" })
                }
              ),
            }
          )
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/*/queries", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"requests\":[{\"indexName\":\"theIndexName\",\"facetFilters\":\"mySearch:filters\",\"reRankingApplyFilter\":\"mySearch:filters\",\"tagFilters\":\"mySearch:filters\",\"numericFilters\":\"mySearch:filters\",\"optionalFilters\":\"mySearch:filters\"},{\"indexName\":\"theIndexName\",\"facetFilters\":[\"mySearch:filters\",[\"mySearch:filters\"]],\"reRankingApplyFilter\":[\"mySearch:filters\",[\"mySearch:filters\"]],\"tagFilters\":[\"mySearch:filters\",[\"mySearch:filters\"]],\"numericFilters\":[\"mySearch:filters\",[\"mySearch:filters\"]],\"optionalFilters\":[\"mySearch:filters\",[\"mySearch:filters\"]]}]}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "search with all search parameters")]
  public async Task SearchTest7()
  {
    await _client.SearchAsync<Object>(
      new SearchMethodParams
      {
        Requests = new List<SearchQuery>
        {
          new SearchQuery(
            new SearchForHits
            {
              AdvancedSyntax = true,
              AdvancedSyntaxFeatures = new List<AdvancedSyntaxFeatures>
              {
                Enum.Parse<AdvancedSyntaxFeatures>("ExactPhrase")
              },
              AllowTyposOnNumericTokens = true,
              AlternativesAsExact = new List<AlternativesAsExact>
              {
                Enum.Parse<AlternativesAsExact>("MultiWordsSynonym")
              },
              Analytics = true,
              AnalyticsTags = new List<string> { "" },
              AroundLatLng = "",
              AroundLatLngViaIP = true,
              AroundPrecision = new AroundPrecision(0),
              AroundRadius = new AroundRadius(Enum.Parse<AroundRadiusAll>("All")),
              AttributeCriteriaComputedByMinProximity = true,
              AttributesForFaceting = new List<string> { "" },
              AttributesToHighlight = new List<string> { "" },
              AttributesToRetrieve = new List<string> { "" },
              AttributesToSnippet = new List<string> { "" },
              ClickAnalytics = true,
              CustomRanking = new List<string> { "" },
              DecompoundQuery = true,
              DisableExactOnAttributes = new List<string> { "" },
              DisableTypoToleranceOnAttributes = new List<string> { "" },
              Distinct = new Distinct(0),
              EnableABTest = true,
              EnablePersonalization = true,
              EnableReRanking = true,
              EnableRules = true,
              ExactOnSingleWordQuery = Enum.Parse<ExactOnSingleWordQuery>("Attribute"),
              Explain = new List<string> { "foo", "bar" },
              FacetFilters = new FacetFilters(
                new List<MixedSearchFilters> { new MixedSearchFilters("") }
              ),
              FacetingAfterDistinct = true,
              Facets = new List<string> { "" },
              Filters = "",
              GetRankingInfo = true,
              HighlightPostTag = "",
              HighlightPreTag = "",
              HitsPerPage = 1,
              IgnorePlurals = new IgnorePlurals(false),
              IndexName = "theIndexName",
              InsideBoundingBox = new List<List<Double>>
              {
                new List<Double> { 47.3165, 4.9665, 47.3424, 5.0201 },
                new List<Double> { 40.9234, 2.1185, 38.643, 1.9916 }
              },
              InsidePolygon = new List<List<Double>>
              {
                new List<Double> { 47.3165, 4.9665, 47.3424, 5.0201, 47.32, 4.9 },
                new List<Double> { 40.9234, 2.1185, 38.643, 1.9916, 39.2587, 2.0104 }
              },
              KeepDiacriticsOnCharacters = "",
              Length = 1,
              MaxValuesPerFacet = 0,
              MinProximity = 1,
              MinWordSizefor1Typo = 0,
              MinWordSizefor2Typos = 0,
              MinimumAroundRadius = 1,
              NaturalLanguages = new List<string> { "" },
              NumericFilters = new NumericFilters(
                new List<MixedSearchFilters> { new MixedSearchFilters("") }
              ),
              Offset = 0,
              OptionalFilters = new OptionalFilters(
                new List<MixedSearchFilters> { new MixedSearchFilters("") }
              ),
              OptionalWords = new List<string> { "" },
              Page = 0,
              PercentileComputation = true,
              PersonalizationImpact = 0,
              Query = "",
              QueryLanguages = new List<string> { "" },
              QueryType = Enum.Parse<QueryType>("PrefixAll"),
              Ranking = new List<string> { "" },
              ReRankingApplyFilter = new ReRankingApplyFilter(
                new List<MixedSearchFilters> { new MixedSearchFilters("") }
              ),
              RelevancyStrictness = 0,
              RemoveStopWords = new RemoveStopWords(true),
              RemoveWordsIfNoResults = Enum.Parse<RemoveWordsIfNoResults>("AllOptional"),
              RenderingContent = new RenderingContent
              {
                FacetOrdering = new FacetOrdering
                {
                  Facets = new Facets
                  {
                    Order = new List<string> { "a", "b" },
                  },
                  Values = new Dictionary<string, Value>
                  {
                    {
                      "a",
                      new Value
                      {
                        Order = new List<string> { "b" },
                        SortRemainingBy = Enum.Parse<SortRemainingBy>("Count"),
                      }
                    }
                  },
                },
              },
              ReplaceSynonymsInHighlight = true,
              ResponseFields = new List<string> { "" },
              RestrictHighlightAndSnippetArrays = true,
              RestrictSearchableAttributes = new List<string> { "" },
              RuleContexts = new List<string> { "" },
              SimilarQuery = "",
              SnippetEllipsisText = "",
              SortFacetValuesBy = "",
              SumOrFiltersScores = true,
              Synonyms = true,
              TagFilters = new TagFilters(
                new List<MixedSearchFilters> { new MixedSearchFilters("") }
              ),
              Type = Enum.Parse<SearchTypeDefault>("Default"),
              TypoTolerance = new TypoTolerance(Enum.Parse<TypoToleranceEnum>("Min")),
              UserToken = "",
            }
          )
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/*/queries", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"requests\":[{\"advancedSyntax\":true,\"advancedSyntaxFeatures\":[\"exactPhrase\"],\"allowTyposOnNumericTokens\":true,\"alternativesAsExact\":[\"multiWordsSynonym\"],\"analytics\":true,\"analyticsTags\":[\"\"],\"aroundLatLng\":\"\",\"aroundLatLngViaIP\":true,\"aroundPrecision\":0,\"aroundRadius\":\"all\",\"attributeCriteriaComputedByMinProximity\":true,\"attributesForFaceting\":[\"\"],\"attributesToHighlight\":[\"\"],\"attributesToRetrieve\":[\"\"],\"attributesToSnippet\":[\"\"],\"clickAnalytics\":true,\"customRanking\":[\"\"],\"decompoundQuery\":true,\"disableExactOnAttributes\":[\"\"],\"disableTypoToleranceOnAttributes\":[\"\"],\"distinct\":0,\"enableABTest\":true,\"enablePersonalization\":true,\"enableReRanking\":true,\"enableRules\":true,\"exactOnSingleWordQuery\":\"attribute\",\"explain\":[\"foo\",\"bar\"],\"facetFilters\":[\"\"],\"facetingAfterDistinct\":true,\"facets\":[\"\"],\"filters\":\"\",\"getRankingInfo\":true,\"highlightPostTag\":\"\",\"highlightPreTag\":\"\",\"hitsPerPage\":1,\"ignorePlurals\":false,\"indexName\":\"theIndexName\",\"insideBoundingBox\":[[47.3165,4.9665,47.3424,5.0201],[40.9234,2.1185,38.643,1.9916]],\"insidePolygon\":[[47.3165,4.9665,47.3424,5.0201,47.32,4.9],[40.9234,2.1185,38.643,1.9916,39.2587,2.0104]],\"keepDiacriticsOnCharacters\":\"\",\"length\":1,\"maxValuesPerFacet\":0,\"minProximity\":1,\"minWordSizefor1Typo\":0,\"minWordSizefor2Typos\":0,\"minimumAroundRadius\":1,\"naturalLanguages\":[\"\"],\"numericFilters\":[\"\"],\"offset\":0,\"optionalFilters\":[\"\"],\"optionalWords\":[\"\"],\"page\":0,\"percentileComputation\":true,\"personalizationImpact\":0,\"query\":\"\",\"queryLanguages\":[\"\"],\"queryType\":\"prefixAll\",\"ranking\":[\"\"],\"reRankingApplyFilter\":[\"\"],\"relevancyStrictness\":0,\"removeStopWords\":true,\"removeWordsIfNoResults\":\"allOptional\",\"renderingContent\":{\"facetOrdering\":{\"facets\":{\"order\":[\"a\",\"b\"]},\"values\":{\"a\":{\"order\":[\"b\"],\"sortRemainingBy\":\"count\"}}}},\"replaceSynonymsInHighlight\":true,\"responseFields\":[\"\"],\"restrictHighlightAndSnippetArrays\":true,\"restrictSearchableAttributes\":[\"\"],\"ruleContexts\":[\"\"],\"similarQuery\":\"\",\"snippetEllipsisText\":\"\",\"sortFacetValuesBy\":\"\",\"sumOrFiltersScores\":true,\"synonyms\":true,\"tagFilters\":[\"\"],\"type\":\"default\",\"typoTolerance\":\"min\",\"userToken\":\"\"}]}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "get searchDictionaryEntries results with minimal parameters")]
  public async Task SearchDictionaryEntriesTest0()
  {
    await _client.SearchDictionaryEntriesAsync(
      Enum.Parse<DictionaryType>("Compounds"),
      new SearchDictionaryEntriesParams { Query = "foo", }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/dictionaries/compounds/search", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault("{\"query\":\"foo\"}", req.Body, new JsonDiffConfig(false));
  }

  [Fact(DisplayName = "get searchDictionaryEntries results with all parameters")]
  public async Task SearchDictionaryEntriesTest1()
  {
    await _client.SearchDictionaryEntriesAsync(
      Enum.Parse<DictionaryType>("Compounds"),
      new SearchDictionaryEntriesParams
      {
        Query = "foo",
        Page = 4,
        HitsPerPage = 2,
        Language = "fr",
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/dictionaries/compounds/search", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"query\":\"foo\",\"page\":4,\"hitsPerPage\":2,\"language\":\"fr\"}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "get searchForFacetValues results with minimal parameters")]
  public async Task SearchForFacetValuesTest0()
  {
    await _client.SearchForFacetValuesAsync("indexName", "facetName");

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/facets/facetName/query", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault("{}", req.Body, new JsonDiffConfig(false));
  }

  [Fact(DisplayName = "get searchForFacetValues results with all parameters")]
  public async Task SearchForFacetValuesTest1()
  {
    await _client.SearchForFacetValuesAsync(
      "indexName",
      "facetName",
      new SearchForFacetValuesRequest
      {
        VarParams = "query=foo&facetFilters=['bar']",
        FacetQuery = "foo",
        MaxFacetHits = 42,
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/facets/facetName/query", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"params\":\"query=foo&facetFilters=['bar']\",\"facetQuery\":\"foo\",\"maxFacetHits\":42}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "searchRules0")]
  public async Task SearchRulesTest0()
  {
    await _client.SearchRulesAsync("indexName", new SearchRulesParams { Query = "something", });

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/rules/search", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"query\":\"something\"}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "search with minimal parameters")]
  public async Task SearchSingleIndexTest0()
  {
    await _client.SearchSingleIndexAsync<Object>("indexName");

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/query", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault("{}", req.Body, new JsonDiffConfig(false));
  }

  [Fact(DisplayName = "search with special characters in indexName")]
  public async Task SearchSingleIndexTest1()
  {
    await _client.SearchSingleIndexAsync<Object>("cts_e2e_space in index");

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/cts_e2e_space%20in%20index/query", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault("{}", req.Body, new JsonDiffConfig(false));

    // e2e
    try
    {
      var resp = await _e2eClient.SearchSingleIndexAsync<Object>("cts_e2e_space in index");
      // Check status code 200
      Assert.NotNull(resp);
    }
    catch (Exception e)
    {
      Assert.Fail("An exception was thrown: " + e.Message);
    }
  }

  [Fact(DisplayName = "search with searchParams")]
  public async Task SearchSingleIndexTest2()
  {
    await _client.SearchSingleIndexAsync<Object>(
      "indexName",
      new SearchParams(
        new SearchParamsObject
        {
          Query = "myQuery",
          FacetFilters = new FacetFilters(
            new List<MixedSearchFilters> { new MixedSearchFilters("tags:algolia") }
          ),
        }
      )
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/query", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"query\":\"myQuery\",\"facetFilters\":[\"tags:algolia\"]}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "single search retrieve snippets")]
  public async Task SearchSingleIndexTest3()
  {
    await _client.SearchSingleIndexAsync<Object>(
      "cts_e2e_browse",
      new SearchParams(
        new SearchParamsObject
        {
          Query = "batman mask of the phantasm",
          AttributesToRetrieve = new List<string> { "*" },
          AttributesToSnippet = new List<string> { "*:20" },
        }
      )
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/cts_e2e_browse/query", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"query\":\"batman mask of the phantasm\",\"attributesToRetrieve\":[\"*\"],\"attributesToSnippet\":[\"*:20\"]}",
      req.Body,
      new JsonDiffConfig(false)
    );

    // e2e
    try
    {
      var resp = await _e2eClient.SearchSingleIndexAsync<Object>(
        "cts_e2e_browse",
        new SearchParams(
          new SearchParamsObject
          {
            Query = "batman mask of the phantasm",
            AttributesToRetrieve = new List<string> { "*" },
            AttributesToSnippet = new List<string> { "*:20" },
          }
        )
      );
      // Check status code 200
      Assert.NotNull(resp);

      JsonAssert.EqualOverrideDefault(
        "{\"nbHits\":1,\"hits\":[{\"_snippetResult\":{\"genres\":[{\"value\":\"Animated\",\"matchLevel\":\"none\"},{\"value\":\"Superhero\",\"matchLevel\":\"none\"},{\"value\":\"Romance\",\"matchLevel\":\"none\"}],\"year\":{\"value\":\"1993\",\"matchLevel\":\"none\"}},\"_highlightResult\":{\"genres\":[{\"value\":\"Animated\",\"matchLevel\":\"none\",\"matchedWords\":[]},{\"value\":\"Superhero\",\"matchLevel\":\"none\",\"matchedWords\":[]},{\"value\":\"Romance\",\"matchLevel\":\"none\",\"matchedWords\":[]}],\"year\":{\"value\":\"1993\",\"matchLevel\":\"none\",\"matchedWords\":[]}}}]}",
        JsonConvert.SerializeObject(resp),
        new JsonDiffConfig(true)
      );
    }
    catch (Exception e)
    {
      Assert.Fail("An exception was thrown: " + e.Message);
    }
  }

  [Fact(DisplayName = "searchSynonyms with minimal parameters")]
  public async Task SearchSynonymsTest0()
  {
    await _client.SearchSynonymsAsync("indexName");

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/synonyms/search", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault("{}", req.Body, new JsonDiffConfig(false));
  }

  [Fact(DisplayName = "searchSynonyms with all parameters")]
  public async Task SearchSynonymsTest1()
  {
    await _client.SearchSynonymsAsync(
      "indexName",
      new SearchSynonymsParams
      {
        Query = "myQuery",
        Type = Enum.Parse<SynonymType>("Altcorrection1"),
        Page = 10,
        HitsPerPage = 10,
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/indexName/synonyms/search", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"query\":\"myQuery\",\"type\":\"altcorrection1\",\"page\":10,\"hitsPerPage\":10}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "searchUserIds0")]
  public async Task SearchUserIdsTest0()
  {
    await _client.SearchUserIdsAsync(
      new SearchUserIdsParams
      {
        Query = "test",
        ClusterName = "theClusterName",
        Page = 5,
        HitsPerPage = 10,
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/clusters/mapping/search", req.Path);
    Assert.Equal("POST", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"query\":\"test\",\"clusterName\":\"theClusterName\",\"page\":5,\"hitsPerPage\":10}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "get setDictionarySettings results with minimal parameters")]
  public async Task SetDictionarySettingsTest0()
  {
    await _client.SetDictionarySettingsAsync(
      new DictionarySettingsParams
      {
        DisableStandardEntries = new StandardEntries
        {
          Plurals = new Dictionary<string, Boolean>
          {
            { "fr", false },
            { "en", false },
            { "ru", true }
          },
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/dictionaries/*/settings", req.Path);
    Assert.Equal("PUT", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"disableStandardEntries\":{\"plurals\":{\"fr\":false,\"en\":false,\"ru\":true}}}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "get setDictionarySettings results with all parameters")]
  public async Task SetDictionarySettingsTest1()
  {
    await _client.SetDictionarySettingsAsync(
      new DictionarySettingsParams
      {
        DisableStandardEntries = new StandardEntries
        {
          Plurals = new Dictionary<string, Boolean>
          {
            { "fr", false },
            { "en", false },
            { "ru", true }
          },
          Stopwords = new Dictionary<string, Boolean> { { "fr", false } },
          Compounds = new Dictionary<string, Boolean> { { "ru", true } },
        },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/dictionaries/*/settings", req.Path);
    Assert.Equal("PUT", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"disableStandardEntries\":{\"plurals\":{\"fr\":false,\"en\":false,\"ru\":true},\"stopwords\":{\"fr\":false},\"compounds\":{\"ru\":true}}}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "setSettings with minimal parameters")]
  public async Task SetSettingsTest0()
  {
    await _client.SetSettingsAsync(
      "cts_e2e_settings",
      new IndexSettings { PaginationLimitedTo = 10, },
      true
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/cts_e2e_settings/settings", req.Path);
    Assert.Equal("PUT", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"paginationLimitedTo\":10}",
      req.Body,
      new JsonDiffConfig(false)
    );
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"forwardToReplicas\":\"true\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }

    // e2e
    try
    {
      var resp = await _e2eClient.SetSettingsAsync(
        "cts_e2e_settings",
        new IndexSettings { PaginationLimitedTo = 10, },
        true
      );
      // Check status code 200
      Assert.NotNull(resp);
    }
    catch (Exception e)
    {
      Assert.Fail("An exception was thrown: " + e.Message);
    }
  }

  [Fact(DisplayName = "setSettings allow boolean `typoTolerance`")]
  public async Task SetSettingsTest1()
  {
    await _client.SetSettingsAsync(
      "theIndexName",
      new IndexSettings { TypoTolerance = new TypoTolerance(true), },
      true
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/settings", req.Path);
    Assert.Equal("PUT", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"typoTolerance\":true}",
      req.Body,
      new JsonDiffConfig(false)
    );
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"forwardToReplicas\":\"true\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "setSettings allow enum `typoTolerance`")]
  public async Task SetSettingsTest2()
  {
    await _client.SetSettingsAsync(
      "theIndexName",
      new IndexSettings
      {
        TypoTolerance = new TypoTolerance(Enum.Parse<TypoToleranceEnum>("Min")),
      },
      true
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/settings", req.Path);
    Assert.Equal("PUT", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"typoTolerance\":\"min\"}",
      req.Body,
      new JsonDiffConfig(false)
    );
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"forwardToReplicas\":\"true\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "setSettings allow boolean `ignorePlurals`")]
  public async Task SetSettingsTest3()
  {
    await _client.SetSettingsAsync(
      "theIndexName",
      new IndexSettings { IgnorePlurals = new IgnorePlurals(true), },
      true
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/settings", req.Path);
    Assert.Equal("PUT", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"ignorePlurals\":true}",
      req.Body,
      new JsonDiffConfig(false)
    );
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"forwardToReplicas\":\"true\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "setSettings allow list of string `ignorePlurals`")]
  public async Task SetSettingsTest4()
  {
    await _client.SetSettingsAsync(
      "theIndexName",
      new IndexSettings { IgnorePlurals = new IgnorePlurals(new List<string> { "algolia" }), },
      true
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/settings", req.Path);
    Assert.Equal("PUT", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"ignorePlurals\":[\"algolia\"]}",
      req.Body,
      new JsonDiffConfig(false)
    );
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"forwardToReplicas\":\"true\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "setSettings allow boolean `removeStopWords`")]
  public async Task SetSettingsTest5()
  {
    await _client.SetSettingsAsync(
      "theIndexName",
      new IndexSettings { RemoveStopWords = new RemoveStopWords(true), },
      true
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/settings", req.Path);
    Assert.Equal("PUT", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"removeStopWords\":true}",
      req.Body,
      new JsonDiffConfig(false)
    );
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"forwardToReplicas\":\"true\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "setSettings allow list of string `removeStopWords`")]
  public async Task SetSettingsTest6()
  {
    await _client.SetSettingsAsync(
      "theIndexName",
      new IndexSettings { RemoveStopWords = new RemoveStopWords(new List<string> { "algolia" }), },
      true
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/settings", req.Path);
    Assert.Equal("PUT", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"removeStopWords\":[\"algolia\"]}",
      req.Body,
      new JsonDiffConfig(false)
    );
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"forwardToReplicas\":\"true\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "setSettings allow boolean `distinct`")]
  public async Task SetSettingsTest7()
  {
    await _client.SetSettingsAsync(
      "theIndexName",
      new IndexSettings { Distinct = new Distinct(true), },
      true
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/settings", req.Path);
    Assert.Equal("PUT", req.Method.ToString());
    JsonAssert.EqualOverrideDefault("{\"distinct\":true}", req.Body, new JsonDiffConfig(false));
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"forwardToReplicas\":\"true\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "setSettings allow integers for `distinct`")]
  public async Task SetSettingsTest8()
  {
    await _client.SetSettingsAsync(
      "theIndexName",
      new IndexSettings { Distinct = new Distinct(1), },
      true
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/settings", req.Path);
    Assert.Equal("PUT", req.Method.ToString());
    JsonAssert.EqualOverrideDefault("{\"distinct\":1}", req.Body, new JsonDiffConfig(false));
    var expectedQuery = JsonConvert.DeserializeObject<Dictionary<string, string>>(
      "{\"forwardToReplicas\":\"true\"}"
    );
    Assert.NotNull(expectedQuery);

    var actualQuery = req.QueryParameters;
    Assert.Equal(expectedQuery.Count, actualQuery.Count);

    foreach (var query in actualQuery)
    {
      expectedQuery.TryGetValue(query.Key, out var result);
      Assert.Equal(query.Value, result);
    }
  }

  [Fact(DisplayName = "setSettings allow all `indexSettings`")]
  public async Task SetSettingsTest9()
  {
    await _client.SetSettingsAsync(
      "theIndexName",
      new IndexSettings
      {
        AdvancedSyntax = true,
        AdvancedSyntaxFeatures = new List<AdvancedSyntaxFeatures>
        {
          Enum.Parse<AdvancedSyntaxFeatures>("ExactPhrase")
        },
        AllowCompressionOfIntegerArray = true,
        AllowTyposOnNumericTokens = true,
        AlternativesAsExact = new List<AlternativesAsExact>
        {
          Enum.Parse<AlternativesAsExact>("SingleWordSynonym")
        },
        AttributeCriteriaComputedByMinProximity = true,
        AttributeForDistinct = "test",
        AttributesForFaceting = new List<string> { "algolia" },
        AttributesToHighlight = new List<string> { "algolia" },
        AttributesToRetrieve = new List<string> { "algolia" },
        AttributesToSnippet = new List<string> { "algolia" },
        AttributesToTransliterate = new List<string> { "algolia" },
        CamelCaseAttributes = new List<string> { "algolia" },
        CustomNormalization = new Dictionary<string, Dictionary<string, string>>
        {
          {
            "algolia",
            new Dictionary<string, string> { { "aloglia", "aglolia" } }
          }
        },
        CustomRanking = new List<string> { "algolia" },
        DecompoundQuery = false,
        DecompoundedAttributes = new Dictionary<string, string> { { "algolia", "aloglia" } },
        DisableExactOnAttributes = new List<string> { "algolia" },
        DisablePrefixOnAttributes = new List<string> { "algolia" },
        DisableTypoToleranceOnAttributes = new List<string> { "algolia" },
        DisableTypoToleranceOnWords = new List<string> { "algolia" },
        Distinct = new Distinct(3),
        EnablePersonalization = true,
        EnableReRanking = false,
        EnableRules = true,
        ExactOnSingleWordQuery = Enum.Parse<ExactOnSingleWordQuery>("Attribute"),
        HighlightPreTag = "<span>",
        HighlightPostTag = "</span>",
        HitsPerPage = 10,
        IgnorePlurals = new IgnorePlurals(false),
        IndexLanguages = new List<string> { "algolia" },
        KeepDiacriticsOnCharacters = "abc",
        MaxFacetHits = 20,
        MaxValuesPerFacet = 30,
        MinProximity = 6,
        MinWordSizefor1Typo = 5,
        MinWordSizefor2Typos = 11,
        Mode = Enum.Parse<Mode>("NeuralSearch"),
        NumericAttributesForFiltering = new List<string> { "algolia" },
        OptionalWords = new List<string> { "myspace" },
        PaginationLimitedTo = 0,
        QueryLanguages = new List<string> { "algolia" },
        QueryType = Enum.Parse<QueryType>("PrefixLast"),
        Ranking = new List<string> { "geo" },
        ReRankingApplyFilter = new ReRankingApplyFilter("mySearch:filters"),
        RelevancyStrictness = 10,
        RemoveStopWords = new RemoveStopWords(false),
        RemoveWordsIfNoResults = Enum.Parse<RemoveWordsIfNoResults>("LastWords"),
        RenderingContent = new RenderingContent
        {
          FacetOrdering = new FacetOrdering
          {
            Facets = new Facets
            {
              Order = new List<string> { "a", "b" },
            },
            Values = new Dictionary<string, Value>
            {
              {
                "a",
                new Value
                {
                  Order = new List<string> { "b" },
                  SortRemainingBy = Enum.Parse<SortRemainingBy>("Count"),
                }
              }
            },
          },
        },
        ReplaceSynonymsInHighlight = true,
        Replicas = new List<string> { "" },
        ResponseFields = new List<string> { "algolia" },
        RestrictHighlightAndSnippetArrays = true,
        SearchableAttributes = new List<string> { "foo" },
        SemanticSearch = new SemanticSearch { EventSources = new List<string> { "foo" }, },
        SeparatorsToIndex = "bar",
        SnippetEllipsisText = "---",
        SortFacetValuesBy = "date",
        TypoTolerance = new TypoTolerance(false),
        UnretrievableAttributes = new List<string> { "foo" },
        UserData = new Dictionary<string, string> { { "user", "data" } },
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/indexes/theIndexName/settings", req.Path);
    Assert.Equal("PUT", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"advancedSyntax\":true,\"advancedSyntaxFeatures\":[\"exactPhrase\"],\"allowCompressionOfIntegerArray\":true,\"allowTyposOnNumericTokens\":true,\"alternativesAsExact\":[\"singleWordSynonym\"],\"attributeCriteriaComputedByMinProximity\":true,\"attributeForDistinct\":\"test\",\"attributesForFaceting\":[\"algolia\"],\"attributesToHighlight\":[\"algolia\"],\"attributesToRetrieve\":[\"algolia\"],\"attributesToSnippet\":[\"algolia\"],\"attributesToTransliterate\":[\"algolia\"],\"camelCaseAttributes\":[\"algolia\"],\"customNormalization\":{\"algolia\":{\"aloglia\":\"aglolia\"}},\"customRanking\":[\"algolia\"],\"decompoundQuery\":false,\"decompoundedAttributes\":{\"algolia\":\"aloglia\"},\"disableExactOnAttributes\":[\"algolia\"],\"disablePrefixOnAttributes\":[\"algolia\"],\"disableTypoToleranceOnAttributes\":[\"algolia\"],\"disableTypoToleranceOnWords\":[\"algolia\"],\"distinct\":3,\"enablePersonalization\":true,\"enableReRanking\":false,\"enableRules\":true,\"exactOnSingleWordQuery\":\"attribute\",\"highlightPreTag\":\"<span>\",\"highlightPostTag\":\"</span>\",\"hitsPerPage\":10,\"ignorePlurals\":false,\"indexLanguages\":[\"algolia\"],\"keepDiacriticsOnCharacters\":\"abc\",\"maxFacetHits\":20,\"maxValuesPerFacet\":30,\"minProximity\":6,\"minWordSizefor1Typo\":5,\"minWordSizefor2Typos\":11,\"mode\":\"neuralSearch\",\"numericAttributesForFiltering\":[\"algolia\"],\"optionalWords\":[\"myspace\"],\"paginationLimitedTo\":0,\"queryLanguages\":[\"algolia\"],\"queryType\":\"prefixLast\",\"ranking\":[\"geo\"],\"reRankingApplyFilter\":\"mySearch:filters\",\"relevancyStrictness\":10,\"removeStopWords\":false,\"removeWordsIfNoResults\":\"lastWords\",\"renderingContent\":{\"facetOrdering\":{\"facets\":{\"order\":[\"a\",\"b\"]},\"values\":{\"a\":{\"order\":[\"b\"],\"sortRemainingBy\":\"count\"}}}},\"replaceSynonymsInHighlight\":true,\"replicas\":[\"\"],\"responseFields\":[\"algolia\"],\"restrictHighlightAndSnippetArrays\":true,\"searchableAttributes\":[\"foo\"],\"semanticSearch\":{\"eventSources\":[\"foo\"]},\"separatorsToIndex\":\"bar\",\"snippetEllipsisText\":\"---\",\"sortFacetValuesBy\":\"date\",\"typoTolerance\":false,\"unretrievableAttributes\":[\"foo\"],\"userData\":{\"user\":\"data\"}}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }

  [Fact(DisplayName = "updateApiKey0")]
  public async Task UpdateApiKeyTest0()
  {
    await _client.UpdateApiKeyAsync(
      "myApiKey",
      new ApiKey
      {
        Acl = new List<Acl> { Enum.Parse<Acl>("Search"), Enum.Parse<Acl>("AddObject") },
        Validity = 300,
        MaxQueriesPerIPPerHour = 100,
        MaxHitsPerQuery = 20,
      }
    );

    var req = _echo.LastResponse;
    Assert.Equal("/1/keys/myApiKey", req.Path);
    Assert.Equal("PUT", req.Method.ToString());
    JsonAssert.EqualOverrideDefault(
      "{\"acl\":[\"search\",\"addObject\"],\"validity\":300,\"maxQueriesPerIPPerHour\":100,\"maxHitsPerQuery\":20}",
      req.Body,
      new JsonDiffConfig(false)
    );
  }
}