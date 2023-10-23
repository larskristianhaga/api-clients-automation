// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
package search

import (
	"encoding/json"
	"fmt"
)

// UpdatedAtResponse Response, taskID, and update timestamp.
type UpdatedAtResponse struct {
	// Unique identifier of a task. A successful API response means that a task was added to a queue. It might not run immediately. You can check the task's progress with the `task` operation and this `taskID`.
	TaskID int64 `json:"taskID"`
	// Timestamp of the last update in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format.
	UpdatedAt string `json:"updatedAt"`
}

// NewUpdatedAtResponse instantiates a new UpdatedAtResponse object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewUpdatedAtResponse(taskID int64, updatedAt string) *UpdatedAtResponse {
	this := &UpdatedAtResponse{}
	this.TaskID = taskID
	this.UpdatedAt = updatedAt
	return this
}

// NewUpdatedAtResponseWithDefaults instantiates a new UpdatedAtResponse object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewUpdatedAtResponseWithDefaults() *UpdatedAtResponse {
	this := &UpdatedAtResponse{}
	return this
}

// GetTaskID returns the TaskID field value
func (o *UpdatedAtResponse) GetTaskID() int64 {
	if o == nil {
		var ret int64
		return ret
	}

	return o.TaskID
}

// GetTaskIDOk returns a tuple with the TaskID field value
// and a boolean to check if the value has been set.
func (o *UpdatedAtResponse) GetTaskIDOk() (*int64, bool) {
	if o == nil {
		return nil, false
	}
	return &o.TaskID, true
}

// SetTaskID sets field value
func (o *UpdatedAtResponse) SetTaskID(v int64) {
	o.TaskID = v
}

// GetUpdatedAt returns the UpdatedAt field value
func (o *UpdatedAtResponse) GetUpdatedAt() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.UpdatedAt
}

// GetUpdatedAtOk returns a tuple with the UpdatedAt field value
// and a boolean to check if the value has been set.
func (o *UpdatedAtResponse) GetUpdatedAtOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.UpdatedAt, true
}

// SetUpdatedAt sets field value
func (o *UpdatedAtResponse) SetUpdatedAt(v string) {
	o.UpdatedAt = v
}

func (o UpdatedAtResponse) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]any{}
	if true {
		toSerialize["taskID"] = o.TaskID
	}
	if true {
		toSerialize["updatedAt"] = o.UpdatedAt
	}
	return json.Marshal(toSerialize)
}

func (o UpdatedAtResponse) String() string {
	out := ""
	out += fmt.Sprintf("  taskID=%v\n", o.TaskID)
	out += fmt.Sprintf("  updatedAt=%v\n", o.UpdatedAt)
	return fmt.Sprintf("UpdatedAtResponse {\n%s}", out)
}

type NullableUpdatedAtResponse struct {
	value *UpdatedAtResponse
	isSet bool
}

func (v NullableUpdatedAtResponse) Get() *UpdatedAtResponse {
	return v.value
}

func (v *NullableUpdatedAtResponse) Set(val *UpdatedAtResponse) {
	v.value = val
	v.isSet = true
}

func (v NullableUpdatedAtResponse) IsSet() bool {
	return v.isSet
}

func (v *NullableUpdatedAtResponse) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableUpdatedAtResponse(val *UpdatedAtResponse) *NullableUpdatedAtResponse {
	return &NullableUpdatedAtResponse{value: val, isSet: true}
}

func (v NullableUpdatedAtResponse) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableUpdatedAtResponse) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}
