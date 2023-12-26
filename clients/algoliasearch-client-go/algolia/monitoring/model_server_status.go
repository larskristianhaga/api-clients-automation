// File generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation.
package monitoring

import (
	"encoding/json"
	"fmt"
)

// ServerStatus the model 'ServerStatus'.
type ServerStatus string

// List of ServerStatus.
const (
	SERVERSTATUS_PRODUCTION ServerStatus = "PRODUCTION"
)

// All allowed values of ServerStatus enum.
var AllowedServerStatusEnumValues = []ServerStatus{
	"PRODUCTION",
}

func (v *ServerStatus) UnmarshalJSON(src []byte) error {
	var value string
	err := json.Unmarshal(src, &value)
	if err != nil {
		return err
	}
	enumTypeValue := ServerStatus(value)
	for _, existing := range AllowedServerStatusEnumValues {
		if existing == enumTypeValue {
			*v = enumTypeValue
			return nil
		}
	}

	return fmt.Errorf("%+v is not a valid ServerStatus", value)
}

// NewServerStatusFromValue returns a pointer to a valid ServerStatus
// for the value passed as argument, or an error if the value passed is not allowed by the enum.
func NewServerStatusFromValue(v string) (*ServerStatus, error) {
	ev := ServerStatus(v)
	if ev.IsValid() {
		return &ev, nil
	} else {
		return nil, fmt.Errorf("invalid value '%v' for ServerStatus: valid values are %v", v, AllowedServerStatusEnumValues)
	}
}

// IsValid return true if the value is valid for the enum, false otherwise.
func (v ServerStatus) IsValid() bool {
	for _, existing := range AllowedServerStatusEnumValues {
		if existing == v {
			return true
		}
	}
	return false
}

// Ptr returns reference to ServerStatus value.
func (v ServerStatus) Ptr() *ServerStatus {
	return &v
}

type NullableServerStatus struct {
	value *ServerStatus
	isSet bool
}

func (v NullableServerStatus) Get() *ServerStatus {
	return v.value
}

func (v *NullableServerStatus) Set(val *ServerStatus) {
	v.value = val
	v.isSet = true
}

func (v NullableServerStatus) IsSet() bool {
	return v.isSet
}

func (v *NullableServerStatus) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableServerStatus(val *ServerStatus) *NullableServerStatus {
	return &NullableServerStatus{value: val, isSet: true}
}

func (v NullableServerStatus) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableServerStatus) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}
