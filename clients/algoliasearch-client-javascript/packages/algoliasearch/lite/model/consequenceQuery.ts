// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

import type { ConsequenceQueryObject } from './consequenceQueryObject';

/**
 * Replace or edit the search query.  If `consequenceQuery` is a string, the entire search query is replaced with that string. If `consequenceQuery` is an object, it describes incremental edits made to the query.
 */
export type ConsequenceQuery = ConsequenceQueryObject | string;
