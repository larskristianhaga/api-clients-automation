// File generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation.
package recommend

import (
	"encoding/json"
	"fmt"
)

// SearchRecommendRulesParams Recommend rules search parameters.
type SearchRecommendRulesParams struct {
	// Full-text query.
	Query *string `json:"query,omitempty"`
	// Restricts responses to the specified [contextual rule](https://www.algolia.com/doc/guides/managing-results/rules/rules-overview/how-to/customize-search-results-by-platform/#creating-contextual-rules).
	Context *string `json:"context,omitempty"`
	// Requested page (the first page is page 0).
	Page *int32 `json:"page,omitempty"`
	// Maximum number of hits per page.
	HitsPerPage *int32 `json:"hitsPerPage,omitempty"`
	// Restricts responses to enabled rules. When absent (default), _all_ rules are retrieved.
	Enabled NullableBool `json:"enabled,omitempty"`
	// Request options to send with the API call.
	RequestOptions []map[string]interface{} `json:"requestOptions,omitempty"`
}

type SearchRecommendRulesParamsOption func(f *SearchRecommendRulesParams)

func WithSearchRecommendRulesParamsQuery(val string) SearchRecommendRulesParamsOption {
	return func(f *SearchRecommendRulesParams) {
		f.Query = &val
	}
}

func WithSearchRecommendRulesParamsContext(val string) SearchRecommendRulesParamsOption {
	return func(f *SearchRecommendRulesParams) {
		f.Context = &val
	}
}

func WithSearchRecommendRulesParamsPage(val int32) SearchRecommendRulesParamsOption {
	return func(f *SearchRecommendRulesParams) {
		f.Page = &val
	}
}

func WithSearchRecommendRulesParamsHitsPerPage(val int32) SearchRecommendRulesParamsOption {
	return func(f *SearchRecommendRulesParams) {
		f.HitsPerPage = &val
	}
}

func WithSearchRecommendRulesParamsEnabled(val NullableBool) SearchRecommendRulesParamsOption {
	return func(f *SearchRecommendRulesParams) {
		f.Enabled = val
	}
}

func WithSearchRecommendRulesParamsRequestOptions(val []map[string]interface{}) SearchRecommendRulesParamsOption {
	return func(f *SearchRecommendRulesParams) {
		f.RequestOptions = val
	}
}

// NewSearchRecommendRulesParams instantiates a new SearchRecommendRulesParams object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed.
func NewSearchRecommendRulesParams(opts ...SearchRecommendRulesParamsOption) *SearchRecommendRulesParams {
	this := &SearchRecommendRulesParams{}
	for _, opt := range opts {
		opt(this)
	}
	return this
}

// NewSearchRecommendRulesParamsWithDefaults instantiates a new SearchRecommendRulesParams object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set.
func NewSearchRecommendRulesParamsWithDefaults() *SearchRecommendRulesParams {
	this := &SearchRecommendRulesParams{}
	var query string = ""
	this.Query = &query
	var hitsPerPage int32 = 20
	this.HitsPerPage = &hitsPerPage
	return this
}

// GetQuery returns the Query field value if set, zero value otherwise.
func (o *SearchRecommendRulesParams) GetQuery() string {
	if o == nil || o.Query == nil {
		var ret string
		return ret
	}
	return *o.Query
}

// GetQueryOk returns a tuple with the Query field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SearchRecommendRulesParams) GetQueryOk() (*string, bool) {
	if o == nil || o.Query == nil {
		return nil, false
	}
	return o.Query, true
}

// HasQuery returns a boolean if a field has been set.
func (o *SearchRecommendRulesParams) HasQuery() bool {
	if o != nil && o.Query != nil {
		return true
	}

	return false
}

// SetQuery gets a reference to the given string and assigns it to the Query field.
func (o *SearchRecommendRulesParams) SetQuery(v string) {
	o.Query = &v
}

// GetContext returns the Context field value if set, zero value otherwise.
func (o *SearchRecommendRulesParams) GetContext() string {
	if o == nil || o.Context == nil {
		var ret string
		return ret
	}
	return *o.Context
}

// GetContextOk returns a tuple with the Context field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SearchRecommendRulesParams) GetContextOk() (*string, bool) {
	if o == nil || o.Context == nil {
		return nil, false
	}
	return o.Context, true
}

// HasContext returns a boolean if a field has been set.
func (o *SearchRecommendRulesParams) HasContext() bool {
	if o != nil && o.Context != nil {
		return true
	}

	return false
}

// SetContext gets a reference to the given string and assigns it to the Context field.
func (o *SearchRecommendRulesParams) SetContext(v string) {
	o.Context = &v
}

// GetPage returns the Page field value if set, zero value otherwise.
func (o *SearchRecommendRulesParams) GetPage() int32 {
	if o == nil || o.Page == nil {
		var ret int32
		return ret
	}
	return *o.Page
}

// GetPageOk returns a tuple with the Page field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SearchRecommendRulesParams) GetPageOk() (*int32, bool) {
	if o == nil || o.Page == nil {
		return nil, false
	}
	return o.Page, true
}

// HasPage returns a boolean if a field has been set.
func (o *SearchRecommendRulesParams) HasPage() bool {
	if o != nil && o.Page != nil {
		return true
	}

	return false
}

// SetPage gets a reference to the given int32 and assigns it to the Page field.
func (o *SearchRecommendRulesParams) SetPage(v int32) {
	o.Page = &v
}

// GetHitsPerPage returns the HitsPerPage field value if set, zero value otherwise.
func (o *SearchRecommendRulesParams) GetHitsPerPage() int32 {
	if o == nil || o.HitsPerPage == nil {
		var ret int32
		return ret
	}
	return *o.HitsPerPage
}

// GetHitsPerPageOk returns a tuple with the HitsPerPage field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SearchRecommendRulesParams) GetHitsPerPageOk() (*int32, bool) {
	if o == nil || o.HitsPerPage == nil {
		return nil, false
	}
	return o.HitsPerPage, true
}

// HasHitsPerPage returns a boolean if a field has been set.
func (o *SearchRecommendRulesParams) HasHitsPerPage() bool {
	if o != nil && o.HitsPerPage != nil {
		return true
	}

	return false
}

// SetHitsPerPage gets a reference to the given int32 and assigns it to the HitsPerPage field.
func (o *SearchRecommendRulesParams) SetHitsPerPage(v int32) {
	o.HitsPerPage = &v
}

// GetEnabled returns the Enabled field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *SearchRecommendRulesParams) GetEnabled() bool {
	if o == nil || o.Enabled.Get() == nil {
		var ret bool
		return ret
	}
	return *o.Enabled.Get()
}

// GetEnabledOk returns a tuple with the Enabled field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned.
func (o *SearchRecommendRulesParams) GetEnabledOk() (*bool, bool) {
	if o == nil {
		return nil, false
	}
	return o.Enabled.Get(), o.Enabled.IsSet()
}

// HasEnabled returns a boolean if a field has been set.
func (o *SearchRecommendRulesParams) HasEnabled() bool {
	if o != nil && o.Enabled.IsSet() {
		return true
	}

	return false
}

// SetEnabled gets a reference to the given NullableBool and assigns it to the Enabled field.
func (o *SearchRecommendRulesParams) SetEnabled(v bool) {
	o.Enabled.Set(&v)
}

// SetEnabledNil sets the value for Enabled to be an explicit nil.
func (o *SearchRecommendRulesParams) SetEnabledNil() {
	o.Enabled.Set(nil)
}

// UnsetEnabled ensures that no value is present for Enabled, not even an explicit nil.
func (o *SearchRecommendRulesParams) UnsetEnabled() {
	o.Enabled.Unset()
}

// GetRequestOptions returns the RequestOptions field value if set, zero value otherwise.
func (o *SearchRecommendRulesParams) GetRequestOptions() []map[string]interface{} {
	if o == nil || o.RequestOptions == nil {
		var ret []map[string]interface{}
		return ret
	}
	return o.RequestOptions
}

// GetRequestOptionsOk returns a tuple with the RequestOptions field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SearchRecommendRulesParams) GetRequestOptionsOk() ([]map[string]interface{}, bool) {
	if o == nil || o.RequestOptions == nil {
		return nil, false
	}
	return o.RequestOptions, true
}

// HasRequestOptions returns a boolean if a field has been set.
func (o *SearchRecommendRulesParams) HasRequestOptions() bool {
	if o != nil && o.RequestOptions != nil {
		return true
	}

	return false
}

// SetRequestOptions gets a reference to the given []map[string]interface{} and assigns it to the RequestOptions field.
func (o *SearchRecommendRulesParams) SetRequestOptions(v []map[string]interface{}) {
	o.RequestOptions = v
}

func (o SearchRecommendRulesParams) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]any{}
	if o.Query != nil {
		toSerialize["query"] = o.Query
	}
	if o.Context != nil {
		toSerialize["context"] = o.Context
	}
	if o.Page != nil {
		toSerialize["page"] = o.Page
	}
	if o.HitsPerPage != nil {
		toSerialize["hitsPerPage"] = o.HitsPerPage
	}
	if o.Enabled.IsSet() {
		toSerialize["enabled"] = o.Enabled.Get()
	}
	if o.RequestOptions != nil {
		toSerialize["requestOptions"] = o.RequestOptions
	}
	return json.Marshal(toSerialize)
}

func (o SearchRecommendRulesParams) String() string {
	out := ""
	out += fmt.Sprintf("  query=%v\n", o.Query)
	out += fmt.Sprintf("  context=%v\n", o.Context)
	out += fmt.Sprintf("  page=%v\n", o.Page)
	out += fmt.Sprintf("  hitsPerPage=%v\n", o.HitsPerPage)
	out += fmt.Sprintf("  enabled=%v\n", o.Enabled)
	out += fmt.Sprintf("  requestOptions=%v\n", o.RequestOptions)
	return fmt.Sprintf("SearchRecommendRulesParams {\n%s}", out)
}

type NullableSearchRecommendRulesParams struct {
	value *SearchRecommendRulesParams
	isSet bool
}

func (v NullableSearchRecommendRulesParams) Get() *SearchRecommendRulesParams {
	return v.value
}

func (v *NullableSearchRecommendRulesParams) Set(val *SearchRecommendRulesParams) {
	v.value = val
	v.isSet = true
}

func (v NullableSearchRecommendRulesParams) IsSet() bool {
	return v.isSet
}

func (v *NullableSearchRecommendRulesParams) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableSearchRecommendRulesParams(val *SearchRecommendRulesParams) *NullableSearchRecommendRulesParams {
	return &NullableSearchRecommendRulesParams{value: val, isSet: true}
}

func (v NullableSearchRecommendRulesParams) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableSearchRecommendRulesParams) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}
