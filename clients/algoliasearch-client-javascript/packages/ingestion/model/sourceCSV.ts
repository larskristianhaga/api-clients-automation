// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

import type { MappingTypeCSV } from './mappingTypeCSV';
import type { MethodType } from './methodType';

export type SourceCSV = {
  /**
   * URL of the file.
   */
  url: string;

  /**
   * Name of a column that contains a unique ID which will be used as `objectID` in Algolia.
   */
  uniqueIDColumn?: string;

  /**
   * Key-value pairs of column names and their expected types.
   */
  mapping?: Record<string, MappingTypeCSV>;

  method?: MethodType;

  /**
   * The character used to split the value on each line, default to a comma (\\r, \\n, 0xFFFD, and space are forbidden).
   */
  delimiter?: string;
};
