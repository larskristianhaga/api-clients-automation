// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
package recommend

import (
	"encoding/json"
	"fmt"
)

// HighlightResult - struct for HighlightResult
type HighlightResult struct {
	HighlightResultOption               *HighlightResultOption
	MapmapOfStringHighlightResultOption *map[string]HighlightResultOption
}

// HighlightResultOptionAsHighlightResult is a convenience function that returns HighlightResultOption wrapped in HighlightResult
func HighlightResultOptionAsHighlightResult(v *HighlightResultOption) HighlightResult {
	return HighlightResult{
		HighlightResultOption: v,
	}
}

// map[string]HighlightResultOptionAsHighlightResult is a convenience function that returns map[string]HighlightResultOption wrapped in HighlightResult
func MapmapOfStringHighlightResultOptionAsHighlightResult(v *map[string]HighlightResultOption) HighlightResult {
	return HighlightResult{
		MapmapOfStringHighlightResultOption: v,
	}
}

// Unmarshal JSON data into one of the pointers in the struct
func (dst *HighlightResult) UnmarshalJSON(data []byte) error {
	var err error
	// use discriminator value to speed up the lookup
	var jsonDict map[string]any
	err = newStrictDecoder(data).Decode(&jsonDict)
	if err != nil {
		return fmt.Errorf("Failed to unmarshal JSON into map for the discriminator lookup (HighlightResultOption).")
	}

	// Hold the schema validity between checks
	validSchemaForModel := true

	// If the model wasn't discriminated yet, continue checking for other discriminating properties
	if validSchemaForModel {
		// Check if the model holds a property 'matchLevel'
		if _, ok := jsonDict["matchLevel"]; !ok {
			validSchemaForModel = false
		}
	}

	// If the model wasn't discriminated yet, continue checking for other discriminating properties
	if validSchemaForModel {
		// Check if the model holds a property 'value'
		if _, ok := jsonDict["value"]; !ok {
			validSchemaForModel = false
		}
	}

	// If the model wasn't discriminated yet, continue checking for other discriminating properties
	if validSchemaForModel {
		// Check if the model holds a property 'matchedWords'
		if _, ok := jsonDict["matchedWords"]; !ok {
			validSchemaForModel = false
		}
	}

	if validSchemaForModel {
		// try to unmarshal data into HighlightResultOption
		err = newStrictDecoder(data).Decode(&dst.HighlightResultOption)
		if err == nil && validateStruct(dst.HighlightResultOption) == nil {
			jsonHighlightResultOption, _ := json.Marshal(dst.HighlightResultOption)
			if string(jsonHighlightResultOption) == "{}" { // empty struct
				dst.HighlightResultOption = nil
			} else {
				return nil
			}
		} else {
			dst.HighlightResultOption = nil
		}
	}

	// Reset the schema validity for the next class check
	validSchemaForModel = true

	// try to unmarshal data into MapmapOfStringHighlightResultOption
	err = newStrictDecoder(data).Decode(&dst.MapmapOfStringHighlightResultOption)
	if err == nil && validateStruct(dst.MapmapOfStringHighlightResultOption) == nil {
		jsonMapmapOfStringHighlightResultOption, _ := json.Marshal(dst.MapmapOfStringHighlightResultOption)
		if string(jsonMapmapOfStringHighlightResultOption) == "{}" { // empty struct
			dst.MapmapOfStringHighlightResultOption = nil
		} else {
			return nil
		}
	} else {
		dst.MapmapOfStringHighlightResultOption = nil
	}

	return fmt.Errorf("Data failed to match schemas in oneOf(HighlightResult)")
}

// Marshal data from the first non-nil pointers in the struct to JSON
func (src HighlightResult) MarshalJSON() ([]byte, error) {
	if src.HighlightResultOption != nil {
		return json.Marshal(&src.HighlightResultOption)
	}

	if src.MapmapOfStringHighlightResultOption != nil {
		return json.Marshal(&src.MapmapOfStringHighlightResultOption)
	}

	return nil, nil // no data in oneOf schemas
}

// Get the actual instance
func (obj *HighlightResult) GetActualInstance() any {
	if obj == nil {
		return nil
	}
	if obj.HighlightResultOption != nil {
		return obj.HighlightResultOption
	}

	if obj.MapmapOfStringHighlightResultOption != nil {
		return obj.MapmapOfStringHighlightResultOption
	}

	// all schemas are nil
	return nil
}

type NullableHighlightResult struct {
	value *HighlightResult
	isSet bool
}

func (v NullableHighlightResult) Get() *HighlightResult {
	return v.value
}

func (v *NullableHighlightResult) Set(val *HighlightResult) {
	v.value = val
	v.isSet = true
}

func (v NullableHighlightResult) IsSet() bool {
	return v.isSet
}

func (v *NullableHighlightResult) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableHighlightResult(val *HighlightResult) *NullableHighlightResult {
	return &NullableHighlightResult{value: val, isSet: true}
}

func (v NullableHighlightResult) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableHighlightResult) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}
