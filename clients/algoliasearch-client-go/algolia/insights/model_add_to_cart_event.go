// File generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation.
package insights

import (
	"encoding/json"
	"fmt"
)

// AddToCartEvent the model 'AddToCartEvent'.
type AddToCartEvent string

// List of AddToCartEvent.
const (
	ADDTOCARTEVENT_ADD_TO_CART AddToCartEvent = "addToCart"
)

// All allowed values of AddToCartEvent enum.
var AllowedAddToCartEventEnumValues = []AddToCartEvent{
	"addToCart",
}

func (v *AddToCartEvent) UnmarshalJSON(src []byte) error {
	var value string
	err := json.Unmarshal(src, &value)
	if err != nil {
		return err
	}
	enumTypeValue := AddToCartEvent(value)
	for _, existing := range AllowedAddToCartEventEnumValues {
		if existing == enumTypeValue {
			*v = enumTypeValue
			return nil
		}
	}

	return fmt.Errorf("%+v is not a valid AddToCartEvent", value)
}

// NewAddToCartEventFromValue returns a pointer to a valid AddToCartEvent
// for the value passed as argument, or an error if the value passed is not allowed by the enum.
func NewAddToCartEventFromValue(v string) (*AddToCartEvent, error) {
	ev := AddToCartEvent(v)
	if ev.IsValid() {
		return &ev, nil
	} else {
		return nil, fmt.Errorf("invalid value '%v' for AddToCartEvent: valid values are %v", v, AllowedAddToCartEventEnumValues)
	}
}

// IsValid return true if the value is valid for the enum, false otherwise.
func (v AddToCartEvent) IsValid() bool {
	for _, existing := range AllowedAddToCartEventEnumValues {
		if existing == v {
			return true
		}
	}
	return false
}

// Ptr returns reference to AddToCartEvent value.
func (v AddToCartEvent) Ptr() *AddToCartEvent {
	return &v
}

type NullableAddToCartEvent struct {
	value *AddToCartEvent
	isSet bool
}

func (v NullableAddToCartEvent) Get() *AddToCartEvent {
	return v.value
}

func (v *NullableAddToCartEvent) Set(val *AddToCartEvent) {
	v.value = val
	v.isSet = true
}

func (v NullableAddToCartEvent) IsSet() bool {
	return v.isSet
}

func (v *NullableAddToCartEvent) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableAddToCartEvent(val *AddToCartEvent) *NullableAddToCartEvent {
	return &NullableAddToCartEvent{value: val, isSet: true}
}

func (v NullableAddToCartEvent) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableAddToCartEvent) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}
