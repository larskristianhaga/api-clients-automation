// This file is generated, manual changes will be lost - read more on https://github.com/algolia/api-clients-automation.

import type { InitClientOptions } from '@algolia/client-common';
import {
  DEFAULT_CONNECT_TIMEOUT_BROWSER,
  DEFAULT_READ_TIMEOUT_BROWSER,
  DEFAULT_WRITE_TIMEOUT_BROWSER,
  createMemoryCache,
  createFallbackableCache,
  createBrowserLocalStorageCache,
} from '@algolia/client-common';
import { createXhrRequester } from '@algolia/requester-browser-xhr';

import { createSearchClient, apiClientVersion } from '../src/searchClient';
import type { SearchClient } from '../src/searchClient';

export { apiClientVersion, SearchClient } from '../src/searchClient';
export * from '../model';

export function searchClient(
  appId: string,
  apiKey: string,
  options?: InitClientOptions
): SearchClient {
  if (!appId || typeof appId !== 'string') {
    throw new Error('`appId` is missing.');
  }

  if (!apiKey || typeof apiKey !== 'string') {
    throw new Error('`apiKey` is missing.');
  }

  return createSearchClient({
    appId,
    apiKey,
    timeouts: {
      connect: DEFAULT_CONNECT_TIMEOUT_BROWSER,
      read: DEFAULT_READ_TIMEOUT_BROWSER,
      write: DEFAULT_WRITE_TIMEOUT_BROWSER,
    },
    requester: createXhrRequester(),
    algoliaAgents: [{ segment: 'Browser' }],
    authMode: 'WithinQueryParameters',
    responsesCache: createMemoryCache(),
    requestsCache: createMemoryCache({ serializable: false }),
    hostsCache: createFallbackableCache({
      caches: [
        createBrowserLocalStorageCache({ key: `${apiClientVersion}-${appId}` }),
        createMemoryCache(),
      ],
    }),
    ...options,
  });
}
