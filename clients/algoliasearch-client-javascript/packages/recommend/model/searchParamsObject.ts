// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

import type { BaseSearchParams } from './baseSearchParams';
import type { IndexSettingsAsSearchParams } from './indexSettingsAsSearchParams';

/**
 * Each parameter value, including the `query` must not be larger than 512 bytes.
 */
export type SearchParamsObject = BaseSearchParams & IndexSettingsAsSearchParams;
