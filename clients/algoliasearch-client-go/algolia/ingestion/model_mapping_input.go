// File generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation.
package ingestion

import (
	"encoding/json"
	"fmt"
)

// MappingInput Transformations to apply to the source, serialized as a JSON string.
type MappingInput struct {
	Format  MappingFormatSchema `json:"format"`
	Actions []MappingKitAction  `json:"actions"`
}

// NewMappingInput instantiates a new MappingInput object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed.
func NewMappingInput(format MappingFormatSchema, actions []MappingKitAction) *MappingInput {
	this := &MappingInput{}
	this.Format = format
	this.Actions = actions
	return this
}

// NewEmptyMappingInput return a pointer to an empty MappingInput object.
func NewEmptyMappingInput() *MappingInput {
	return &MappingInput{}
}

// GetFormat returns the Format field value.
func (o *MappingInput) GetFormat() MappingFormatSchema {
	if o == nil {
		var ret MappingFormatSchema
		return ret
	}

	return o.Format
}

// GetFormatOk returns a tuple with the Format field value
// and a boolean to check if the value has been set.
func (o *MappingInput) GetFormatOk() (*MappingFormatSchema, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Format, true
}

// SetFormat sets field value.
func (o *MappingInput) SetFormat(v MappingFormatSchema) *MappingInput {
	o.Format = v
	return o
}

// GetActions returns the Actions field value.
func (o *MappingInput) GetActions() []MappingKitAction {
	if o == nil {
		var ret []MappingKitAction
		return ret
	}

	return o.Actions
}

// GetActionsOk returns a tuple with the Actions field value
// and a boolean to check if the value has been set.
func (o *MappingInput) GetActionsOk() ([]MappingKitAction, bool) {
	if o == nil {
		return nil, false
	}
	return o.Actions, true
}

// SetActions sets field value.
func (o *MappingInput) SetActions(v []MappingKitAction) *MappingInput {
	o.Actions = v
	return o
}

func (o MappingInput) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]any{}
	if true {
		toSerialize["format"] = o.Format
	}
	if true {
		toSerialize["actions"] = o.Actions
	}
	serialized, err := json.Marshal(toSerialize)
	if err != nil {
		return nil, fmt.Errorf("failed to marshal MappingInput: %w", err)
	}

	return serialized, nil
}

func (o MappingInput) String() string {
	out := ""
	out += fmt.Sprintf("  format=%v\n", o.Format)
	out += fmt.Sprintf("  actions=%v\n", o.Actions)
	return fmt.Sprintf("MappingInput {\n%s}", out)
}

type NullableMappingInput struct {
	value *MappingInput
	isSet bool
}

func (v NullableMappingInput) Get() *MappingInput {
	return v.value
}

func (v *NullableMappingInput) Set(val *MappingInput) {
	v.value = val
	v.isSet = true
}

func (v NullableMappingInput) IsSet() bool {
	return v.isSet
}

func (v *NullableMappingInput) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableMappingInput(val *MappingInput) *NullableMappingInput {
	return &NullableMappingInput{value: val, isSet: true}
}

func (v NullableMappingInput) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value) //nolint:wrapcheck
}

func (v *NullableMappingInput) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value) //nolint:wrapcheck
}
