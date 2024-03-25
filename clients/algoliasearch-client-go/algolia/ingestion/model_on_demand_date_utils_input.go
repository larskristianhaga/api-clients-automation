// File generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation.
package ingestion

import (
	"encoding/json"
	"fmt"
)

// OnDemandDateUtilsInput Input for a manually-triggered task whose source is of type `bigquery` and for which extracted data spans a given time range.
type OnDemandDateUtilsInput struct {
	// Earliest date in RFC3339 format of the extracted data from Big Query.
	StartDate string `json:"startDate"`
	// Latest date in RFC3339 format of the extracted data from Big Query.
	EndDate string        `json:"endDate"`
	Mapping *MappingInput `json:"mapping,omitempty"`
}

type OnDemandDateUtilsInputOption func(f *OnDemandDateUtilsInput)

func WithOnDemandDateUtilsInputMapping(val MappingInput) OnDemandDateUtilsInputOption {
	return func(f *OnDemandDateUtilsInput) {
		f.Mapping = &val
	}
}

// NewOnDemandDateUtilsInput instantiates a new OnDemandDateUtilsInput object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed.
func NewOnDemandDateUtilsInput(startDate string, endDate string, opts ...OnDemandDateUtilsInputOption) *OnDemandDateUtilsInput {
	this := &OnDemandDateUtilsInput{}
	this.StartDate = startDate
	this.EndDate = endDate
	for _, opt := range opts {
		opt(this)
	}
	return this
}

// NewEmptyOnDemandDateUtilsInput return a pointer to an empty OnDemandDateUtilsInput object.
func NewEmptyOnDemandDateUtilsInput() *OnDemandDateUtilsInput {
	return &OnDemandDateUtilsInput{}
}

// GetStartDate returns the StartDate field value.
func (o *OnDemandDateUtilsInput) GetStartDate() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.StartDate
}

// GetStartDateOk returns a tuple with the StartDate field value
// and a boolean to check if the value has been set.
func (o *OnDemandDateUtilsInput) GetStartDateOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.StartDate, true
}

// SetStartDate sets field value.
func (o *OnDemandDateUtilsInput) SetStartDate(v string) *OnDemandDateUtilsInput {
	o.StartDate = v
	return o
}

// GetEndDate returns the EndDate field value.
func (o *OnDemandDateUtilsInput) GetEndDate() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.EndDate
}

// GetEndDateOk returns a tuple with the EndDate field value
// and a boolean to check if the value has been set.
func (o *OnDemandDateUtilsInput) GetEndDateOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.EndDate, true
}

// SetEndDate sets field value.
func (o *OnDemandDateUtilsInput) SetEndDate(v string) *OnDemandDateUtilsInput {
	o.EndDate = v
	return o
}

// GetMapping returns the Mapping field value if set, zero value otherwise.
func (o *OnDemandDateUtilsInput) GetMapping() MappingInput {
	if o == nil || o.Mapping == nil {
		var ret MappingInput
		return ret
	}
	return *o.Mapping
}

// GetMappingOk returns a tuple with the Mapping field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *OnDemandDateUtilsInput) GetMappingOk() (*MappingInput, bool) {
	if o == nil || o.Mapping == nil {
		return nil, false
	}
	return o.Mapping, true
}

// HasMapping returns a boolean if a field has been set.
func (o *OnDemandDateUtilsInput) HasMapping() bool {
	if o != nil && o.Mapping != nil {
		return true
	}

	return false
}

// SetMapping gets a reference to the given MappingInput and assigns it to the Mapping field.
func (o *OnDemandDateUtilsInput) SetMapping(v *MappingInput) *OnDemandDateUtilsInput {
	o.Mapping = v
	return o
}

func (o OnDemandDateUtilsInput) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]any{}
	if true {
		toSerialize["startDate"] = o.StartDate
	}
	if true {
		toSerialize["endDate"] = o.EndDate
	}
	if o.Mapping != nil {
		toSerialize["mapping"] = o.Mapping
	}
	serialized, err := json.Marshal(toSerialize)
	if err != nil {
		return nil, fmt.Errorf("failed to marshal OnDemandDateUtilsInput: %w", err)
	}

	return serialized, nil
}

func (o OnDemandDateUtilsInput) String() string {
	out := ""
	out += fmt.Sprintf("  startDate=%v\n", o.StartDate)
	out += fmt.Sprintf("  endDate=%v\n", o.EndDate)
	out += fmt.Sprintf("  mapping=%v\n", o.Mapping)
	return fmt.Sprintf("OnDemandDateUtilsInput {\n%s}", out)
}

type NullableOnDemandDateUtilsInput struct {
	value *OnDemandDateUtilsInput
	isSet bool
}

func (v NullableOnDemandDateUtilsInput) Get() *OnDemandDateUtilsInput {
	return v.value
}

func (v *NullableOnDemandDateUtilsInput) Set(val *OnDemandDateUtilsInput) {
	v.value = val
	v.isSet = true
}

func (v NullableOnDemandDateUtilsInput) IsSet() bool {
	return v.isSet
}

func (v *NullableOnDemandDateUtilsInput) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableOnDemandDateUtilsInput(val *OnDemandDateUtilsInput) *NullableOnDemandDateUtilsInput {
	return &NullableOnDemandDateUtilsInput{value: val, isSet: true}
}

func (v NullableOnDemandDateUtilsInput) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value) //nolint:wrapcheck
}

func (v *NullableOnDemandDateUtilsInput) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value) //nolint:wrapcheck
}
