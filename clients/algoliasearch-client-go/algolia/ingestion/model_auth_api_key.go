// File generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation.
package ingestion

import (
	"encoding/json"
	"fmt"
)

// AuthAPIKey Authentication input used for token credentials.
type AuthAPIKey struct {
	Key string `json:"key"`
}

// NewAuthAPIKey instantiates a new AuthAPIKey object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed.
func NewAuthAPIKey(key string) *AuthAPIKey {
	this := &AuthAPIKey{}
	this.Key = key
	return this
}

// NewAuthAPIKeyWithDefaults instantiates a new AuthAPIKey object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set.
func NewAuthAPIKeyWithDefaults() *AuthAPIKey {
	this := &AuthAPIKey{}
	return this
}

// GetKey returns the Key field value.
func (o *AuthAPIKey) GetKey() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Key
}

// GetKeyOk returns a tuple with the Key field value
// and a boolean to check if the value has been set.
func (o *AuthAPIKey) GetKeyOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Key, true
}

// SetKey sets field value.
func (o *AuthAPIKey) SetKey(v string) {
	o.Key = v
}

func (o AuthAPIKey) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]any{}
	if true {
		toSerialize["key"] = o.Key
	}
	return json.Marshal(toSerialize)
}

func (o AuthAPIKey) String() string {
	out := ""
	out += fmt.Sprintf("  key=%v\n", o.Key)
	return fmt.Sprintf("AuthAPIKey {\n%s}", out)
}

type NullableAuthAPIKey struct {
	value *AuthAPIKey
	isSet bool
}

func (v NullableAuthAPIKey) Get() *AuthAPIKey {
	return v.value
}

func (v *NullableAuthAPIKey) Set(val *AuthAPIKey) {
	v.value = val
	v.isSet = true
}

func (v NullableAuthAPIKey) IsSet() bool {
	return v.isSet
}

func (v *NullableAuthAPIKey) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableAuthAPIKey(val *AuthAPIKey) *NullableAuthAPIKey {
	return &NullableAuthAPIKey{value: val, isSet: true}
}

func (v NullableAuthAPIKey) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableAuthAPIKey) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}
