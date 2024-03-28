// File generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation.
package ingestion

import (
	"encoding/json"
	"fmt"
)

// ScheduleTriggerInput Trigger input for scheduled tasks.
type ScheduleTriggerInput struct {
	Type ScheduleTriggerType `json:"type"`
	// Cron expression for the task's schedule.
	Cron string `json:"cron"`
}

// NewScheduleTriggerInput instantiates a new ScheduleTriggerInput object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed.
func NewScheduleTriggerInput(type_ ScheduleTriggerType, cron string) *ScheduleTriggerInput {
	this := &ScheduleTriggerInput{}
	this.Type = type_
	this.Cron = cron
	return this
}

// NewEmptyScheduleTriggerInput return a pointer to an empty ScheduleTriggerInput object.
func NewEmptyScheduleTriggerInput() *ScheduleTriggerInput {
	return &ScheduleTriggerInput{}
}

// GetType returns the Type field value.
func (o *ScheduleTriggerInput) GetType() ScheduleTriggerType {
	if o == nil {
		var ret ScheduleTriggerType
		return ret
	}

	return o.Type
}

// GetTypeOk returns a tuple with the Type field value
// and a boolean to check if the value has been set.
func (o *ScheduleTriggerInput) GetTypeOk() (*ScheduleTriggerType, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Type, true
}

// SetType sets field value.
func (o *ScheduleTriggerInput) SetType(v ScheduleTriggerType) *ScheduleTriggerInput {
	o.Type = v
	return o
}

// GetCron returns the Cron field value.
func (o *ScheduleTriggerInput) GetCron() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Cron
}

// GetCronOk returns a tuple with the Cron field value
// and a boolean to check if the value has been set.
func (o *ScheduleTriggerInput) GetCronOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Cron, true
}

// SetCron sets field value.
func (o *ScheduleTriggerInput) SetCron(v string) *ScheduleTriggerInput {
	o.Cron = v
	return o
}

func (o ScheduleTriggerInput) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]any{}
	if true {
		toSerialize["type"] = o.Type
	}
	if true {
		toSerialize["cron"] = o.Cron
	}
	serialized, err := json.Marshal(toSerialize)
	if err != nil {
		return nil, fmt.Errorf("failed to marshal ScheduleTriggerInput: %w", err)
	}

	return serialized, nil
}

func (o ScheduleTriggerInput) String() string {
	out := ""
	out += fmt.Sprintf("  type=%v\n", o.Type)
	out += fmt.Sprintf("  cron=%v\n", o.Cron)
	return fmt.Sprintf("ScheduleTriggerInput {\n%s}", out)
}

type NullableScheduleTriggerInput struct {
	value *ScheduleTriggerInput
	isSet bool
}

func (v NullableScheduleTriggerInput) Get() *ScheduleTriggerInput {
	return v.value
}

func (v *NullableScheduleTriggerInput) Set(val *ScheduleTriggerInput) {
	v.value = val
	v.isSet = true
}

func (v NullableScheduleTriggerInput) IsSet() bool {
	return v.isSet
}

func (v *NullableScheduleTriggerInput) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableScheduleTriggerInput(val *ScheduleTriggerInput) *NullableScheduleTriggerInput {
	return &NullableScheduleTriggerInput{value: val, isSet: true}
}

func (v NullableScheduleTriggerInput) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value) //nolint:wrapcheck
}

func (v *NullableScheduleTriggerInput) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value) //nolint:wrapcheck
}
