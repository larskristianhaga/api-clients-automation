// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
package ingestion

import (
	"encoding/json"
	"fmt"
)

// TriggerUpdateInput Trigger for a task update.
type TriggerUpdateInput struct {
	// Cron expression for the task's schedule.
	Cron string `json:"cron"`
}

// NewTriggerUpdateInput instantiates a new TriggerUpdateInput object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed.
func NewTriggerUpdateInput(cron string) *TriggerUpdateInput {
	this := &TriggerUpdateInput{}
	this.Cron = cron
	return this
}

// NewEmptyTriggerUpdateInput return a pointer to an empty TriggerUpdateInput object.
func NewEmptyTriggerUpdateInput() *TriggerUpdateInput {
	return &TriggerUpdateInput{}
}

// GetCron returns the Cron field value.
func (o *TriggerUpdateInput) GetCron() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Cron
}

// GetCronOk returns a tuple with the Cron field value
// and a boolean to check if the value has been set.
func (o *TriggerUpdateInput) GetCronOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Cron, true
}

// SetCron sets field value.
func (o *TriggerUpdateInput) SetCron(v string) *TriggerUpdateInput {
	o.Cron = v
	return o
}

func (o TriggerUpdateInput) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]any{}
	if true {
		toSerialize["cron"] = o.Cron
	}
	serialized, err := json.Marshal(toSerialize)
	if err != nil {
		return nil, fmt.Errorf("failed to marshal TriggerUpdateInput: %w", err)
	}

	return serialized, nil
}

func (o TriggerUpdateInput) String() string {
	out := ""
	out += fmt.Sprintf("  cron=%v\n", o.Cron)
	return fmt.Sprintf("TriggerUpdateInput {\n%s}", out)
}

type NullableTriggerUpdateInput struct {
	value *TriggerUpdateInput
	isSet bool
}

func (v NullableTriggerUpdateInput) Get() *TriggerUpdateInput {
	return v.value
}

func (v *NullableTriggerUpdateInput) Set(val *TriggerUpdateInput) {
	v.value = val
	v.isSet = true
}

func (v NullableTriggerUpdateInput) IsSet() bool {
	return v.isSet
}

func (v *NullableTriggerUpdateInput) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableTriggerUpdateInput(val *TriggerUpdateInput) *NullableTriggerUpdateInput {
	return &NullableTriggerUpdateInput{value: val, isSet: true}
}

func (v NullableTriggerUpdateInput) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value) //nolint:wrapcheck
}

func (v *NullableTriggerUpdateInput) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value) //nolint:wrapcheck
}
