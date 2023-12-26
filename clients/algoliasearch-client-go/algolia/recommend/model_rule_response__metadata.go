// File generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation.
package recommend

import (
	"encoding/json"
	"fmt"
)

// RuleResponseMetadata struct for RuleResponseMetadata.
type RuleResponseMetadata struct {
	// Timestamp of the last update in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format.
	LastUpdate *string `json:"lastUpdate,omitempty"`
}

type RuleResponseMetadataOption func(f *RuleResponseMetadata)

func WithRuleResponseMetadataLastUpdate(val string) RuleResponseMetadataOption {
	return func(f *RuleResponseMetadata) {
		f.LastUpdate = &val
	}
}

// NewRuleResponseMetadata instantiates a new RuleResponseMetadata object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed.
func NewRuleResponseMetadata(opts ...RuleResponseMetadataOption) *RuleResponseMetadata {
	this := &RuleResponseMetadata{}
	for _, opt := range opts {
		opt(this)
	}
	return this
}

// NewRuleResponseMetadataWithDefaults instantiates a new RuleResponseMetadata object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set.
func NewRuleResponseMetadataWithDefaults() *RuleResponseMetadata {
	this := &RuleResponseMetadata{}
	return this
}

// GetLastUpdate returns the LastUpdate field value if set, zero value otherwise.
func (o *RuleResponseMetadata) GetLastUpdate() string {
	if o == nil || o.LastUpdate == nil {
		var ret string
		return ret
	}
	return *o.LastUpdate
}

// GetLastUpdateOk returns a tuple with the LastUpdate field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *RuleResponseMetadata) GetLastUpdateOk() (*string, bool) {
	if o == nil || o.LastUpdate == nil {
		return nil, false
	}
	return o.LastUpdate, true
}

// HasLastUpdate returns a boolean if a field has been set.
func (o *RuleResponseMetadata) HasLastUpdate() bool {
	if o != nil && o.LastUpdate != nil {
		return true
	}

	return false
}

// SetLastUpdate gets a reference to the given string and assigns it to the LastUpdate field.
func (o *RuleResponseMetadata) SetLastUpdate(v string) {
	o.LastUpdate = &v
}

func (o RuleResponseMetadata) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]any{}
	if o.LastUpdate != nil {
		toSerialize["lastUpdate"] = o.LastUpdate
	}
	return json.Marshal(toSerialize)
}

func (o RuleResponseMetadata) String() string {
	out := ""
	out += fmt.Sprintf("  lastUpdate=%v\n", o.LastUpdate)
	return fmt.Sprintf("RuleResponseMetadata {\n%s}", out)
}

type NullableRuleResponseMetadata struct {
	value *RuleResponseMetadata
	isSet bool
}

func (v NullableRuleResponseMetadata) Get() *RuleResponseMetadata {
	return v.value
}

func (v *NullableRuleResponseMetadata) Set(val *RuleResponseMetadata) {
	v.value = val
	v.isSet = true
}

func (v NullableRuleResponseMetadata) IsSet() bool {
	return v.isSet
}

func (v *NullableRuleResponseMetadata) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableRuleResponseMetadata(val *RuleResponseMetadata) *NullableRuleResponseMetadata {
	return &NullableRuleResponseMetadata{value: val, isSet: true}
}

func (v NullableRuleResponseMetadata) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableRuleResponseMetadata) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}
