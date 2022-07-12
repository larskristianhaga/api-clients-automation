// This file is generated, manual changes will be lost - read more on https://github.com/algolia/api-clients-automation.

import type { Direction } from './direction';
import type { OrderBy } from './orderBy';

/**
 * Properties for the `del` method.
 */
export type DelProps = {
  /**
   * The path of the API endpoint to target, anything after the /1 needs to be specified.
   */
  path: string;
  /**
   * Query parameters to be applied to the current query.
   */
  parameters?: Record<string, any>;
};

/**
 * Properties for the `get` method.
 */
export type GetProps = {
  /**
   * The path of the API endpoint to target, anything after the /1 needs to be specified.
   */
  path: string;
  /**
   * Query parameters to be applied to the current query.
   */
  parameters?: Record<string, any>;
};

/**
 * Properties for the `getAverageClickPosition` method.
 */
export type GetAverageClickPositionProps = {
  /**
   * The index name to target.
   */
  index: string;
  /**
   * The lower bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  startDate?: string;
  /**
   * The upper bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  endDate?: string;
  /**
   * Filter metrics on the provided tags. Each tag must correspond to an analyticsTags set at search time. Multiple tags can be combined with the operators OR and AND. If a tag contains characters like spaces or parentheses, it should be URL encoded.
   */
  tags?: string;
};

/**
 * Properties for the `getClickPositions` method.
 */
export type GetClickPositionsProps = {
  /**
   * The index name to target.
   */
  index: string;
  /**
   * The lower bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  startDate?: string;
  /**
   * The upper bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  endDate?: string;
  /**
   * Filter metrics on the provided tags. Each tag must correspond to an analyticsTags set at search time. Multiple tags can be combined with the operators OR and AND. If a tag contains characters like spaces or parentheses, it should be URL encoded.
   */
  tags?: string;
};

/**
 * Properties for the `getClickThroughRate` method.
 */
export type GetClickThroughRateProps = {
  /**
   * The index name to target.
   */
  index: string;
  /**
   * The lower bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  startDate?: string;
  /**
   * The upper bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  endDate?: string;
  /**
   * Filter metrics on the provided tags. Each tag must correspond to an analyticsTags set at search time. Multiple tags can be combined with the operators OR and AND. If a tag contains characters like spaces or parentheses, it should be URL encoded.
   */
  tags?: string;
};

/**
 * Properties for the `getConversationRate` method.
 */
export type GetConversationRateProps = {
  /**
   * The index name to target.
   */
  index: string;
  /**
   * The lower bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  startDate?: string;
  /**
   * The upper bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  endDate?: string;
  /**
   * Filter metrics on the provided tags. Each tag must correspond to an analyticsTags set at search time. Multiple tags can be combined with the operators OR and AND. If a tag contains characters like spaces or parentheses, it should be URL encoded.
   */
  tags?: string;
};

/**
 * Properties for the `getNoClickRate` method.
 */
export type GetNoClickRateProps = {
  /**
   * The index name to target.
   */
  index: string;
  /**
   * The lower bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  startDate?: string;
  /**
   * The upper bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  endDate?: string;
  /**
   * Filter metrics on the provided tags. Each tag must correspond to an analyticsTags set at search time. Multiple tags can be combined with the operators OR and AND. If a tag contains characters like spaces or parentheses, it should be URL encoded.
   */
  tags?: string;
};

/**
 * Properties for the `getNoResultsRate` method.
 */
export type GetNoResultsRateProps = {
  /**
   * The index name to target.
   */
  index: string;
  /**
   * The lower bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  startDate?: string;
  /**
   * The upper bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  endDate?: string;
  /**
   * Filter metrics on the provided tags. Each tag must correspond to an analyticsTags set at search time. Multiple tags can be combined with the operators OR and AND. If a tag contains characters like spaces or parentheses, it should be URL encoded.
   */
  tags?: string;
};

/**
 * Properties for the `getSearchesCount` method.
 */
export type GetSearchesCountProps = {
  /**
   * The index name to target.
   */
  index: string;
  /**
   * The lower bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  startDate?: string;
  /**
   * The upper bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  endDate?: string;
  /**
   * Filter metrics on the provided tags. Each tag must correspond to an analyticsTags set at search time. Multiple tags can be combined with the operators OR and AND. If a tag contains characters like spaces or parentheses, it should be URL encoded.
   */
  tags?: string;
};

/**
 * Properties for the `getSearchesNoClicks` method.
 */
export type GetSearchesNoClicksProps = {
  /**
   * The index name to target.
   */
  index: string;
  /**
   * The lower bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  startDate?: string;
  /**
   * The upper bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  endDate?: string;
  /**
   * Number of records to return. Limit is the size of the page.
   */
  limit?: number;
  /**
   * Position of the starting record. Used for paging. 0 is the first record.
   */
  offset?: number;
  /**
   * Filter metrics on the provided tags. Each tag must correspond to an analyticsTags set at search time. Multiple tags can be combined with the operators OR and AND. If a tag contains characters like spaces or parentheses, it should be URL encoded.
   */
  tags?: string;
};

/**
 * Properties for the `getSearchesNoResults` method.
 */
export type GetSearchesNoResultsProps = {
  /**
   * The index name to target.
   */
  index: string;
  /**
   * The lower bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  startDate?: string;
  /**
   * The upper bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  endDate?: string;
  /**
   * Number of records to return. Limit is the size of the page.
   */
  limit?: number;
  /**
   * Position of the starting record. Used for paging. 0 is the first record.
   */
  offset?: number;
  /**
   * Filter metrics on the provided tags. Each tag must correspond to an analyticsTags set at search time. Multiple tags can be combined with the operators OR and AND. If a tag contains characters like spaces or parentheses, it should be URL encoded.
   */
  tags?: string;
};

/**
 * Properties for the `getStatus` method.
 */
export type GetStatusProps = {
  /**
   * The index name to target.
   */
  index: string;
};

/**
 * Properties for the `getTopCountries` method.
 */
export type GetTopCountriesProps = {
  /**
   * The index name to target.
   */
  index: string;
  /**
   * The lower bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  startDate?: string;
  /**
   * The upper bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  endDate?: string;
  /**
   * Number of records to return. Limit is the size of the page.
   */
  limit?: number;
  /**
   * Position of the starting record. Used for paging. 0 is the first record.
   */
  offset?: number;
  /**
   * Filter metrics on the provided tags. Each tag must correspond to an analyticsTags set at search time. Multiple tags can be combined with the operators OR and AND. If a tag contains characters like spaces or parentheses, it should be URL encoded.
   */
  tags?: string;
};

/**
 * Properties for the `getTopFilterAttributes` method.
 */
export type GetTopFilterAttributesProps = {
  /**
   * The index name to target.
   */
  index: string;
  /**
   * The query term to search for. Must match the exact user input.
   */
  search?: string;
  /**
   * The lower bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  startDate?: string;
  /**
   * The upper bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  endDate?: string;
  /**
   * Number of records to return. Limit is the size of the page.
   */
  limit?: number;
  /**
   * Position of the starting record. Used for paging. 0 is the first record.
   */
  offset?: number;
  /**
   * Filter metrics on the provided tags. Each tag must correspond to an analyticsTags set at search time. Multiple tags can be combined with the operators OR and AND. If a tag contains characters like spaces or parentheses, it should be URL encoded.
   */
  tags?: string;
};

/**
 * Properties for the `getTopFilterForAttribute` method.
 */
export type GetTopFilterForAttributeProps = {
  /**
   * The exact name of the attribute.
   */
  attribute: string;
  /**
   * The index name to target.
   */
  index: string;
  /**
   * The query term to search for. Must match the exact user input.
   */
  search?: string;
  /**
   * The lower bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  startDate?: string;
  /**
   * The upper bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  endDate?: string;
  /**
   * Number of records to return. Limit is the size of the page.
   */
  limit?: number;
  /**
   * Position of the starting record. Used for paging. 0 is the first record.
   */
  offset?: number;
  /**
   * Filter metrics on the provided tags. Each tag must correspond to an analyticsTags set at search time. Multiple tags can be combined with the operators OR and AND. If a tag contains characters like spaces or parentheses, it should be URL encoded.
   */
  tags?: string;
};

/**
 * Properties for the `getTopFiltersNoResults` method.
 */
export type GetTopFiltersNoResultsProps = {
  /**
   * The index name to target.
   */
  index: string;
  /**
   * The query term to search for. Must match the exact user input.
   */
  search?: string;
  /**
   * The lower bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  startDate?: string;
  /**
   * The upper bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  endDate?: string;
  /**
   * Number of records to return. Limit is the size of the page.
   */
  limit?: number;
  /**
   * Position of the starting record. Used for paging. 0 is the first record.
   */
  offset?: number;
  /**
   * Filter metrics on the provided tags. Each tag must correspond to an analyticsTags set at search time. Multiple tags can be combined with the operators OR and AND. If a tag contains characters like spaces or parentheses, it should be URL encoded.
   */
  tags?: string;
};

/**
 * Properties for the `getTopHits` method.
 */
export type GetTopHitsProps = {
  /**
   * The index name to target.
   */
  index: string;
  /**
   * The query term to search for. Must match the exact user input.
   */
  search?: string;
  /**
   * Whether to include the click-through and conversion rates for a search.
   */
  clickAnalytics?: boolean;
  /**
   * The lower bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  startDate?: string;
  /**
   * The upper bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  endDate?: string;
  /**
   * Number of records to return. Limit is the size of the page.
   */
  limit?: number;
  /**
   * Position of the starting record. Used for paging. 0 is the first record.
   */
  offset?: number;
  /**
   * Filter metrics on the provided tags. Each tag must correspond to an analyticsTags set at search time. Multiple tags can be combined with the operators OR and AND. If a tag contains characters like spaces or parentheses, it should be URL encoded.
   */
  tags?: string;
};

/**
 * Properties for the `getTopSearches` method.
 */
export type GetTopSearchesProps = {
  /**
   * The index name to target.
   */
  index: string;
  /**
   * Whether to include the click-through and conversion rates for a search.
   */
  clickAnalytics?: boolean;
  /**
   * The lower bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  startDate?: string;
  /**
   * The upper bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  endDate?: string;
  /**
   * Reorder the results.
   */
  orderBy?: OrderBy;
  /**
   * The sorting of the result.
   */
  direction?: Direction;
  /**
   * Number of records to return. Limit is the size of the page.
   */
  limit?: number;
  /**
   * Position of the starting record. Used for paging. 0 is the first record.
   */
  offset?: number;
  /**
   * Filter metrics on the provided tags. Each tag must correspond to an analyticsTags set at search time. Multiple tags can be combined with the operators OR and AND. If a tag contains characters like spaces or parentheses, it should be URL encoded.
   */
  tags?: string;
};

/**
 * Properties for the `getUsersCount` method.
 */
export type GetUsersCountProps = {
  /**
   * The index name to target.
   */
  index: string;
  /**
   * The lower bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  startDate?: string;
  /**
   * The upper bound timestamp (a date, a string like \"2006-01-02\") of the period to analyze.
   */
  endDate?: string;
  /**
   * Filter metrics on the provided tags. Each tag must correspond to an analyticsTags set at search time. Multiple tags can be combined with the operators OR and AND. If a tag contains characters like spaces or parentheses, it should be URL encoded.
   */
  tags?: string;
};

/**
 * Properties for the `post` method.
 */
export type PostProps = {
  /**
   * The path of the API endpoint to target, anything after the /1 needs to be specified.
   */
  path: string;
  /**
   * Query parameters to be applied to the current query.
   */
  parameters?: Record<string, any>;
  /**
   * The parameters to send with the custom request.
   */
  body?: Record<string, any>;
};

/**
 * Properties for the `put` method.
 */
export type PutProps = {
  /**
   * The path of the API endpoint to target, anything after the /1 needs to be specified.
   */
  path: string;
  /**
   * Query parameters to be applied to the current query.
   */
  parameters?: Record<string, any>;
  /**
   * The parameters to send with the custom request.
   */
  body?: Record<string, any>;
};
