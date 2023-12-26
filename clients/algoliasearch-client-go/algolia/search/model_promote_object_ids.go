// File generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation.
package search

import (
	"encoding/json"
	"fmt"
)

// PromoteObjectIDs Records to promote.
type PromoteObjectIDs struct {
	// Unique identifiers of the records to promote.
	ObjectIDs []string `json:"objectIDs"`
	// The position to promote the records to. If you pass objectIDs, the records are placed at this position as a group. For example, if you pronmote four objectIDs to position 0, the records take the first four positions.
	Position int32 `json:"position"`
}

// NewPromoteObjectIDs instantiates a new PromoteObjectIDs object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed.
func NewPromoteObjectIDs(objectIDs []string, position int32) *PromoteObjectIDs {
	this := &PromoteObjectIDs{}
	this.ObjectIDs = objectIDs
	this.Position = position
	return this
}

// NewPromoteObjectIDsWithDefaults instantiates a new PromoteObjectIDs object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set.
func NewPromoteObjectIDsWithDefaults() *PromoteObjectIDs {
	this := &PromoteObjectIDs{}
	return this
}

// GetObjectIDs returns the ObjectIDs field value.
func (o *PromoteObjectIDs) GetObjectIDs() []string {
	if o == nil {
		var ret []string
		return ret
	}

	return o.ObjectIDs
}

// GetObjectIDsOk returns a tuple with the ObjectIDs field value
// and a boolean to check if the value has been set.
func (o *PromoteObjectIDs) GetObjectIDsOk() ([]string, bool) {
	if o == nil {
		return nil, false
	}
	return o.ObjectIDs, true
}

// SetObjectIDs sets field value.
func (o *PromoteObjectIDs) SetObjectIDs(v []string) {
	o.ObjectIDs = v
}

// GetPosition returns the Position field value.
func (o *PromoteObjectIDs) GetPosition() int32 {
	if o == nil {
		var ret int32
		return ret
	}

	return o.Position
}

// GetPositionOk returns a tuple with the Position field value
// and a boolean to check if the value has been set.
func (o *PromoteObjectIDs) GetPositionOk() (*int32, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Position, true
}

// SetPosition sets field value.
func (o *PromoteObjectIDs) SetPosition(v int32) {
	o.Position = v
}

func (o PromoteObjectIDs) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]any{}
	if true {
		toSerialize["objectIDs"] = o.ObjectIDs
	}
	if true {
		toSerialize["position"] = o.Position
	}
	return json.Marshal(toSerialize)
}

func (o PromoteObjectIDs) String() string {
	out := ""
	out += fmt.Sprintf("  objectIDs=%v\n", o.ObjectIDs)
	out += fmt.Sprintf("  position=%v\n", o.Position)
	return fmt.Sprintf("PromoteObjectIDs {\n%s}", out)
}

type NullablePromoteObjectIDs struct {
	value *PromoteObjectIDs
	isSet bool
}

func (v NullablePromoteObjectIDs) Get() *PromoteObjectIDs {
	return v.value
}

func (v *NullablePromoteObjectIDs) Set(val *PromoteObjectIDs) {
	v.value = val
	v.isSet = true
}

func (v NullablePromoteObjectIDs) IsSet() bool {
	return v.isSet
}

func (v *NullablePromoteObjectIDs) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullablePromoteObjectIDs(val *PromoteObjectIDs) *NullablePromoteObjectIDs {
	return &NullablePromoteObjectIDs{value: val, isSet: true}
}

func (v NullablePromoteObjectIDs) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullablePromoteObjectIDs) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}
