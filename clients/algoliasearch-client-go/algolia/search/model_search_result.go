// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
package search

import (
	"encoding/json"
	"fmt"
)

// SearchResult - struct for SearchResult
type SearchResult struct {
	SearchForFacetValuesResponse *SearchForFacetValuesResponse
	SearchResponse               *SearchResponse
}

// SearchForFacetValuesResponseAsSearchResult is a convenience function that returns SearchForFacetValuesResponse wrapped in SearchResult
func SearchForFacetValuesResponseAsSearchResult(v *SearchForFacetValuesResponse) SearchResult {
	return SearchResult{
		SearchForFacetValuesResponse: v,
	}
}

// SearchResponseAsSearchResult is a convenience function that returns SearchResponse wrapped in SearchResult
func SearchResponseAsSearchResult(v *SearchResponse) SearchResult {
	return SearchResult{
		SearchResponse: v,
	}
}

// Unmarshal JSON data into one of the pointers in the struct
func (dst *SearchResult) UnmarshalJSON(data []byte) error {
	var err error
	// try to unmarshal data into SearchForFacetValuesResponse
	err = newStrictDecoder(data).Decode(&dst.SearchForFacetValuesResponse)
	if err == nil && validateStruct(dst.SearchForFacetValuesResponse) == nil {
		jsonSearchForFacetValuesResponse, _ := json.Marshal(dst.SearchForFacetValuesResponse)
		if string(jsonSearchForFacetValuesResponse) == "{}" { // empty struct
			dst.SearchForFacetValuesResponse = nil
		} else {
			return nil
		}
	} else {
		dst.SearchForFacetValuesResponse = nil
	}

	// try to unmarshal data into SearchResponse
	err = newStrictDecoder(data).Decode(&dst.SearchResponse)
	if err == nil && validateStruct(dst.SearchResponse) == nil {
		jsonSearchResponse, _ := json.Marshal(dst.SearchResponse)
		if string(jsonSearchResponse) == "{}" { // empty struct
			dst.SearchResponse = nil
		} else {
			return nil
		}
	} else {
		dst.SearchResponse = nil
	}

	return fmt.Errorf("Data failed to match schemas in oneOf(SearchResult)")
}

// Marshal data from the first non-nil pointers in the struct to JSON
func (src SearchResult) MarshalJSON() ([]byte, error) {
	if src.SearchForFacetValuesResponse != nil {
		return json.Marshal(&src.SearchForFacetValuesResponse)
	}

	if src.SearchResponse != nil {
		return json.Marshal(&src.SearchResponse)
	}

	return nil, nil // no data in oneOf schemas
}

// Get the actual instance
func (obj *SearchResult) GetActualInstance() any {
	if obj == nil {
		return nil
	}
	if obj.SearchForFacetValuesResponse != nil {
		return obj.SearchForFacetValuesResponse
	}

	if obj.SearchResponse != nil {
		return obj.SearchResponse
	}

	// all schemas are nil
	return nil
}

type NullableSearchResult struct {
	value *SearchResult
	isSet bool
}

func (v NullableSearchResult) Get() *SearchResult {
	return v.value
}

func (v *NullableSearchResult) Set(val *SearchResult) {
	v.value = val
	v.isSet = true
}

func (v NullableSearchResult) IsSet() bool {
	return v.isSet
}

func (v *NullableSearchResult) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableSearchResult(val *SearchResult) *NullableSearchResult {
	return &NullableSearchResult{value: val, isSet: true}
}

func (v NullableSearchResult) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableSearchResult) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}
