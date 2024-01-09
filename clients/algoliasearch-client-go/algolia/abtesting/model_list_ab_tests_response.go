// File generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation.
package abtesting

import (
	"encoding/json"
	"fmt"
)

// ListABTestsResponse struct for ListABTestsResponse.
type ListABTestsResponse struct {
	// A/B tests.
	Abtests []ABTest `json:"abtests"`
	// Number of A/B tests implemented.
	Count int32 `json:"count"`
	// Number of retrievable A/B tests.
	Total int32 `json:"total"`
}

// NewListABTestsResponse instantiates a new ListABTestsResponse object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed.
func NewListABTestsResponse(abtests []ABTest, count int32, total int32) *ListABTestsResponse {
	this := &ListABTestsResponse{}
	this.Abtests = abtests
	this.Count = count
	this.Total = total
	return this
}

// NewListABTestsResponseWithDefaults instantiates a new ListABTestsResponse object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set.
func NewListABTestsResponseWithDefaults() *ListABTestsResponse {
	this := &ListABTestsResponse{}
	return this
}

// GetAbtests returns the Abtests field value.
func (o *ListABTestsResponse) GetAbtests() []ABTest {
	if o == nil {
		var ret []ABTest
		return ret
	}

	return o.Abtests
}

// GetAbtestsOk returns a tuple with the Abtests field value
// and a boolean to check if the value has been set.
func (o *ListABTestsResponse) GetAbtestsOk() ([]ABTest, bool) {
	if o == nil {
		return nil, false
	}
	return o.Abtests, true
}

// SetAbtests sets field value.
func (o *ListABTestsResponse) SetAbtests(v []ABTest) {
	o.Abtests = v
}

// GetCount returns the Count field value.
func (o *ListABTestsResponse) GetCount() int32 {
	if o == nil {
		var ret int32
		return ret
	}

	return o.Count
}

// GetCountOk returns a tuple with the Count field value
// and a boolean to check if the value has been set.
func (o *ListABTestsResponse) GetCountOk() (*int32, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Count, true
}

// SetCount sets field value.
func (o *ListABTestsResponse) SetCount(v int32) {
	o.Count = v
}

// GetTotal returns the Total field value.
func (o *ListABTestsResponse) GetTotal() int32 {
	if o == nil {
		var ret int32
		return ret
	}

	return o.Total
}

// GetTotalOk returns a tuple with the Total field value
// and a boolean to check if the value has been set.
func (o *ListABTestsResponse) GetTotalOk() (*int32, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Total, true
}

// SetTotal sets field value.
func (o *ListABTestsResponse) SetTotal(v int32) {
	o.Total = v
}

func (o ListABTestsResponse) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]any{}
	if true {
		toSerialize["abtests"] = o.Abtests
	}
	if true {
		toSerialize["count"] = o.Count
	}
	if true {
		toSerialize["total"] = o.Total
	}
	return json.Marshal(toSerialize)
}

func (o ListABTestsResponse) String() string {
	out := ""
	out += fmt.Sprintf("  abtests=%v\n", o.Abtests)
	out += fmt.Sprintf("  count=%v\n", o.Count)
	out += fmt.Sprintf("  total=%v\n", o.Total)
	return fmt.Sprintf("ListABTestsResponse {\n%s}", out)
}

type NullableListABTestsResponse struct {
	value *ListABTestsResponse
	isSet bool
}

func (v NullableListABTestsResponse) Get() *ListABTestsResponse {
	return v.value
}

func (v *NullableListABTestsResponse) Set(val *ListABTestsResponse) {
	v.value = val
	v.isSet = true
}

func (v NullableListABTestsResponse) IsSet() bool {
	return v.isSet
}

func (v *NullableListABTestsResponse) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableListABTestsResponse(val *ListABTestsResponse) *NullableListABTestsResponse {
	return &NullableListABTestsResponse{value: val, isSet: true}
}

func (v NullableListABTestsResponse) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableListABTestsResponse) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}