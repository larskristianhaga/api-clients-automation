// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
package ingestion

import (
	"encoding/json"
	"fmt"
)

// ScheduleTrigger The trigger information for a task of type 'schedule'.
type ScheduleTrigger struct {
	Type ScheduleTriggerType `json:"type"`
	// A cron expression that represent at which regularity the task should run.
	Cron string `json:"cron"`
	// The last time the scheduled task ran (RFC3339 format).
	LastRun *string `json:"lastRun,omitempty"`
	// The next scheduled run of the task (RFC3339 format).
	NextRun string `json:"nextRun"`
}

type ScheduleTriggerOption func(f *ScheduleTrigger)

func WithScheduleTriggerLastRun(val string) ScheduleTriggerOption {
	return func(f *ScheduleTrigger) {
		f.LastRun = &val
	}
}

// NewScheduleTrigger instantiates a new ScheduleTrigger object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewScheduleTrigger(type_ ScheduleTriggerType, cron string, nextRun string, opts ...ScheduleTriggerOption) *ScheduleTrigger {
	this := &ScheduleTrigger{}
	this.Type = type_
	this.Cron = cron
	this.NextRun = nextRun
	for _, opt := range opts {
		opt(this)
	}
	return this
}

// NewScheduleTriggerWithDefaults instantiates a new ScheduleTrigger object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewScheduleTriggerWithDefaults() *ScheduleTrigger {
	this := &ScheduleTrigger{}
	return this
}

// GetType returns the Type field value
func (o *ScheduleTrigger) GetType() ScheduleTriggerType {
	if o == nil {
		var ret ScheduleTriggerType
		return ret
	}

	return o.Type
}

// GetTypeOk returns a tuple with the Type field value
// and a boolean to check if the value has been set.
func (o *ScheduleTrigger) GetTypeOk() (*ScheduleTriggerType, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Type, true
}

// SetType sets field value
func (o *ScheduleTrigger) SetType(v ScheduleTriggerType) {
	o.Type = v
}

// GetCron returns the Cron field value
func (o *ScheduleTrigger) GetCron() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Cron
}

// GetCronOk returns a tuple with the Cron field value
// and a boolean to check if the value has been set.
func (o *ScheduleTrigger) GetCronOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Cron, true
}

// SetCron sets field value
func (o *ScheduleTrigger) SetCron(v string) {
	o.Cron = v
}

// GetLastRun returns the LastRun field value if set, zero value otherwise.
func (o *ScheduleTrigger) GetLastRun() string {
	if o == nil || o.LastRun == nil {
		var ret string
		return ret
	}
	return *o.LastRun
}

// GetLastRunOk returns a tuple with the LastRun field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ScheduleTrigger) GetLastRunOk() (*string, bool) {
	if o == nil || o.LastRun == nil {
		return nil, false
	}
	return o.LastRun, true
}

// HasLastRun returns a boolean if a field has been set.
func (o *ScheduleTrigger) HasLastRun() bool {
	if o != nil && o.LastRun != nil {
		return true
	}

	return false
}

// SetLastRun gets a reference to the given string and assigns it to the LastRun field.
func (o *ScheduleTrigger) SetLastRun(v string) {
	o.LastRun = &v
}

// GetNextRun returns the NextRun field value
func (o *ScheduleTrigger) GetNextRun() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.NextRun
}

// GetNextRunOk returns a tuple with the NextRun field value
// and a boolean to check if the value has been set.
func (o *ScheduleTrigger) GetNextRunOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.NextRun, true
}

// SetNextRun sets field value
func (o *ScheduleTrigger) SetNextRun(v string) {
	o.NextRun = v
}

func (o ScheduleTrigger) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]any{}
	if true {
		toSerialize["type"] = o.Type
	}
	if true {
		toSerialize["cron"] = o.Cron
	}
	if o.LastRun != nil {
		toSerialize["lastRun"] = o.LastRun
	}
	if true {
		toSerialize["nextRun"] = o.NextRun
	}
	return json.Marshal(toSerialize)
}

func (o ScheduleTrigger) String() string {
	out := ""
	out += fmt.Sprintf("  type=%v\n", o.Type)
	out += fmt.Sprintf("  cron=%v\n", o.Cron)
	out += fmt.Sprintf("  lastRun=%v\n", o.LastRun)
	out += fmt.Sprintf("  nextRun=%v\n", o.NextRun)
	return fmt.Sprintf("ScheduleTrigger {\n%s}", out)
}

type NullableScheduleTrigger struct {
	value *ScheduleTrigger
	isSet bool
}

func (v NullableScheduleTrigger) Get() *ScheduleTrigger {
	return v.value
}

func (v *NullableScheduleTrigger) Set(val *ScheduleTrigger) {
	v.value = val
	v.isSet = true
}

func (v NullableScheduleTrigger) IsSet() bool {
	return v.isSet
}

func (v *NullableScheduleTrigger) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableScheduleTrigger(val *ScheduleTrigger) *NullableScheduleTrigger {
	return &NullableScheduleTrigger{value: val, isSet: true}
}

func (v NullableScheduleTrigger) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableScheduleTrigger) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}
