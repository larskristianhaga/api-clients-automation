// File generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation.
package ingestion

import (
	"encoding/json"
	"fmt"
)

// TaskUpdate API request body for updating a task.
type TaskUpdate struct {
	// Universally unique identifier (UUID) of a destination resource.
	DestinationID *string             `json:"destinationID,omitempty"`
	Trigger       *TriggerUpdateInput `json:"trigger,omitempty"`
	Input         *TaskInput          `json:"input,omitempty"`
	// Whether the task is enabled.
	Enabled *bool `json:"enabled,omitempty"`
	// Maximum accepted percentage of failures for a task run to finish successfully.
	FailureThreshold *int32 `json:"failureThreshold,omitempty"`
}

type TaskUpdateOption func(f *TaskUpdate)

func WithTaskUpdateDestinationID(val string) TaskUpdateOption {
	return func(f *TaskUpdate) {
		f.DestinationID = &val
	}
}

func WithTaskUpdateTrigger(val TriggerUpdateInput) TaskUpdateOption {
	return func(f *TaskUpdate) {
		f.Trigger = &val
	}
}

func WithTaskUpdateInput(val TaskInput) TaskUpdateOption {
	return func(f *TaskUpdate) {
		f.Input = &val
	}
}

func WithTaskUpdateEnabled(val bool) TaskUpdateOption {
	return func(f *TaskUpdate) {
		f.Enabled = &val
	}
}

func WithTaskUpdateFailureThreshold(val int32) TaskUpdateOption {
	return func(f *TaskUpdate) {
		f.FailureThreshold = &val
	}
}

// NewTaskUpdate instantiates a new TaskUpdate object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed.
func NewTaskUpdate(opts ...TaskUpdateOption) *TaskUpdate {
	this := &TaskUpdate{}
	for _, opt := range opts {
		opt(this)
	}
	return this
}

// NewEmptyTaskUpdate return a pointer to an empty TaskUpdate object.
func NewEmptyTaskUpdate() *TaskUpdate {
	return &TaskUpdate{}
}

// GetDestinationID returns the DestinationID field value if set, zero value otherwise.
func (o *TaskUpdate) GetDestinationID() string {
	if o == nil || o.DestinationID == nil {
		var ret string
		return ret
	}
	return *o.DestinationID
}

// GetDestinationIDOk returns a tuple with the DestinationID field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *TaskUpdate) GetDestinationIDOk() (*string, bool) {
	if o == nil || o.DestinationID == nil {
		return nil, false
	}
	return o.DestinationID, true
}

// HasDestinationID returns a boolean if a field has been set.
func (o *TaskUpdate) HasDestinationID() bool {
	if o != nil && o.DestinationID != nil {
		return true
	}

	return false
}

// SetDestinationID gets a reference to the given string and assigns it to the DestinationID field.
func (o *TaskUpdate) SetDestinationID(v string) *TaskUpdate {
	o.DestinationID = &v
	return o
}

// GetTrigger returns the Trigger field value if set, zero value otherwise.
func (o *TaskUpdate) GetTrigger() TriggerUpdateInput {
	if o == nil || o.Trigger == nil {
		var ret TriggerUpdateInput
		return ret
	}
	return *o.Trigger
}

// GetTriggerOk returns a tuple with the Trigger field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *TaskUpdate) GetTriggerOk() (*TriggerUpdateInput, bool) {
	if o == nil || o.Trigger == nil {
		return nil, false
	}
	return o.Trigger, true
}

// HasTrigger returns a boolean if a field has been set.
func (o *TaskUpdate) HasTrigger() bool {
	if o != nil && o.Trigger != nil {
		return true
	}

	return false
}

// SetTrigger gets a reference to the given TriggerUpdateInput and assigns it to the Trigger field.
func (o *TaskUpdate) SetTrigger(v *TriggerUpdateInput) *TaskUpdate {
	o.Trigger = v
	return o
}

// GetInput returns the Input field value if set, zero value otherwise.
func (o *TaskUpdate) GetInput() TaskInput {
	if o == nil || o.Input == nil {
		var ret TaskInput
		return ret
	}
	return *o.Input
}

// GetInputOk returns a tuple with the Input field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *TaskUpdate) GetInputOk() (*TaskInput, bool) {
	if o == nil || o.Input == nil {
		return nil, false
	}
	return o.Input, true
}

// HasInput returns a boolean if a field has been set.
func (o *TaskUpdate) HasInput() bool {
	if o != nil && o.Input != nil {
		return true
	}

	return false
}

// SetInput gets a reference to the given TaskInput and assigns it to the Input field.
func (o *TaskUpdate) SetInput(v *TaskInput) *TaskUpdate {
	o.Input = v
	return o
}

// GetEnabled returns the Enabled field value if set, zero value otherwise.
func (o *TaskUpdate) GetEnabled() bool {
	if o == nil || o.Enabled == nil {
		var ret bool
		return ret
	}
	return *o.Enabled
}

// GetEnabledOk returns a tuple with the Enabled field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *TaskUpdate) GetEnabledOk() (*bool, bool) {
	if o == nil || o.Enabled == nil {
		return nil, false
	}
	return o.Enabled, true
}

// HasEnabled returns a boolean if a field has been set.
func (o *TaskUpdate) HasEnabled() bool {
	if o != nil && o.Enabled != nil {
		return true
	}

	return false
}

// SetEnabled gets a reference to the given bool and assigns it to the Enabled field.
func (o *TaskUpdate) SetEnabled(v bool) *TaskUpdate {
	o.Enabled = &v
	return o
}

// GetFailureThreshold returns the FailureThreshold field value if set, zero value otherwise.
func (o *TaskUpdate) GetFailureThreshold() int32 {
	if o == nil || o.FailureThreshold == nil {
		var ret int32
		return ret
	}
	return *o.FailureThreshold
}

// GetFailureThresholdOk returns a tuple with the FailureThreshold field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *TaskUpdate) GetFailureThresholdOk() (*int32, bool) {
	if o == nil || o.FailureThreshold == nil {
		return nil, false
	}
	return o.FailureThreshold, true
}

// HasFailureThreshold returns a boolean if a field has been set.
func (o *TaskUpdate) HasFailureThreshold() bool {
	if o != nil && o.FailureThreshold != nil {
		return true
	}

	return false
}

// SetFailureThreshold gets a reference to the given int32 and assigns it to the FailureThreshold field.
func (o *TaskUpdate) SetFailureThreshold(v int32) *TaskUpdate {
	o.FailureThreshold = &v
	return o
}

func (o TaskUpdate) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]any{}
	if o.DestinationID != nil {
		toSerialize["destinationID"] = o.DestinationID
	}
	if o.Trigger != nil {
		toSerialize["trigger"] = o.Trigger
	}
	if o.Input != nil {
		toSerialize["input"] = o.Input
	}
	if o.Enabled != nil {
		toSerialize["enabled"] = o.Enabled
	}
	if o.FailureThreshold != nil {
		toSerialize["failureThreshold"] = o.FailureThreshold
	}
	serialized, err := json.Marshal(toSerialize)
	if err != nil {
		return nil, fmt.Errorf("failed to marshal TaskUpdate: %w", err)
	}

	return serialized, nil
}

func (o TaskUpdate) String() string {
	out := ""
	out += fmt.Sprintf("  destinationID=%v\n", o.DestinationID)
	out += fmt.Sprintf("  trigger=%v\n", o.Trigger)
	out += fmt.Sprintf("  input=%v\n", o.Input)
	out += fmt.Sprintf("  enabled=%v\n", o.Enabled)
	out += fmt.Sprintf("  failureThreshold=%v\n", o.FailureThreshold)
	return fmt.Sprintf("TaskUpdate {\n%s}", out)
}

type NullableTaskUpdate struct {
	value *TaskUpdate
	isSet bool
}

func (v NullableTaskUpdate) Get() *TaskUpdate {
	return v.value
}

func (v *NullableTaskUpdate) Set(val *TaskUpdate) {
	v.value = val
	v.isSet = true
}

func (v NullableTaskUpdate) IsSet() bool {
	return v.isSet
}

func (v *NullableTaskUpdate) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableTaskUpdate(val *TaskUpdate) *NullableTaskUpdate {
	return &NullableTaskUpdate{value: val, isSet: true}
}

func (v NullableTaskUpdate) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value) //nolint:wrapcheck
}

func (v *NullableTaskUpdate) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value) //nolint:wrapcheck
}
