// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

import { createHmac } from 'crypto';

import type { ClientOptions } from '@algolia/client-common';
import {
  createMemoryCache,
  createNullCache,
  serializeQueryParameters,
  DEFAULT_CONNECT_TIMEOUT_NODE,
  DEFAULT_READ_TIMEOUT_NODE,
  DEFAULT_WRITE_TIMEOUT_NODE,
} from '@algolia/client-common';
import { createHttpRequester } from '@algolia/requester-node-http';

import type {
  GenerateSecuredApiKeyOptions,
  GetSecuredApiKeyRemainingValidityOptions,
} from '../model';
import { createSearchClient } from '../src/searchClient';

export { apiClientVersion } from '../src/searchClient';
export * from '../model';

/**
 * The client type.
 */
export type SearchClient = ReturnType<typeof searchClient>;

// eslint-disable-next-line @typescript-eslint/explicit-function-return-type
export function searchClient(
  appId: string,
  apiKey: string,
  options?: ClientOptions
) {
  if (!appId || typeof appId !== 'string') {
    throw new Error('`appId` is missing.');
  }

  if (!apiKey || typeof apiKey !== 'string') {
    throw new Error('`apiKey` is missing.');
  }

  return {
    ...createSearchClient({
      appId,
      apiKey,
      timeouts: {
        connect: DEFAULT_CONNECT_TIMEOUT_NODE,
        read: DEFAULT_READ_TIMEOUT_NODE,
        write: DEFAULT_WRITE_TIMEOUT_NODE,
      },
      requester: createHttpRequester(),
      algoliaAgents: [{ segment: 'Node.js', version: process.versions.node }],
      responsesCache: createNullCache(),
      requestsCache: createNullCache(),
      hostsCache: createMemoryCache(),
      ...options,
    }),

    /**
     * Helper: Generates a secured API key based on the given `parentApiKey` and given `restrictions`.
     *
     * @summary Helper: Generates a secured API key based on the given `parentApiKey` and given `restrictions`.
     * @param generateSecuredApiKey - The `generateSecuredApiKey` object.
     * @param generateSecuredApiKey.parentApiKey - The base API key from which to generate the new secured one.
     * @param generateSecuredApiKey.restrictions - A set of properties defining the restrictions of the secured API key.
     */
    generateSecuredApiKey({
      parentApiKey,
      restrictions = {},
    }: GenerateSecuredApiKeyOptions): string {
      const queryParameters = serializeQueryParameters(restrictions);
      return Buffer.from(
        createHmac('sha256', parentApiKey)
          .update(queryParameters)
          .digest('hex') + queryParameters
      ).toString('base64');
    },

    /**
     * Helper: Retrieves the remaining validity of the previous generated `secured_api_key`, the `ValidUntil` parameter must have been provided.
     *
     * @summary Helper: Retrieves the remaining validity of the previous generated `secured_api_key`, the `ValidUntil` parameter must have been provided.
     * @param getSecuredApiKeyRemainingValidity - The `getSecuredApiKeyRemainingValidity` object.
     * @param getSecuredApiKeyRemainingValidity.securedApiKey - The secured API key generated with the `generateSecuredApiKey` method.
     */
    getSecuredApiKeyRemainingValidity({
      securedApiKey,
    }: GetSecuredApiKeyRemainingValidityOptions): number {
      const decodedString = Buffer.from(securedApiKey, 'base64').toString(
        'ascii'
      );
      const regex = /validUntil=(\d+)/;
      const match = decodedString.match(regex);

      if (match === null) {
        throw new Error('validUntil not found in given secured api key.');
      }

      return parseInt(match[1], 10) - Math.round(new Date().getTime() / 1000);
    },
  };
}
