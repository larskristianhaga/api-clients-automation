/* eslint no-console: ["error", { allow: ["log"] }] */

import { liteClient } from 'algoliasearch/lite';

// Snippet for the customPost method.
//
// allow post method for a custom path with minimal parameters
export async function snippetForcustomPost(): Promise<void> {
  // >SEPARATOR customPost
  // Initialize the client
  const client = liteClient('YOUR_APP_ID', 'YOUR_API_KEY');

  // Call the API
  const response = await client.customPost({ path: '/test/minimal' });

  // use typed response
  console.log(response);
  // SEPARATOR<
}

// Snippet for the getRecommendations method.
//
// get recommendations for recommend model with minimal parameters
export async function snippetForgetRecommendations(): Promise<void> {
  // >SEPARATOR getRecommendations
  // Initialize the client
  const client = liteClient('YOUR_APP_ID', 'YOUR_API_KEY');

  // Call the API
  const response = await client.getRecommendations({
    requests: [
      {
        indexName: 'indexName',
        objectID: 'objectID',
        model: 'related-products',
        threshold: 42,
      },
    ],
  });

  // use typed response
  console.log(response);
  // SEPARATOR<
}

// Snippet for the search method.
//
// search for a single hits request with minimal parameters
export async function snippetForsearch(): Promise<void> {
  // >SEPARATOR search
  // Initialize the client
  const client = liteClient('YOUR_APP_ID', 'YOUR_API_KEY');

  // Call the API
  const response = await client.search({
    requests: [{ indexName: 'cts_e2e_search_empty_index' }],
  });

  // use typed response
  console.log(response);
  // SEPARATOR<
}
