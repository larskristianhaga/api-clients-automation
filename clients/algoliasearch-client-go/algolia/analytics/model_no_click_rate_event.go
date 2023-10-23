// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
package analytics

import (
	"encoding/json"
	"fmt"
)

// NoClickRateEvent struct for NoClickRateEvent
type NoClickRateEvent struct {
	// [Click-through rate (CTR)](https://www.algolia.com/doc/guides/search-analytics/concepts/metrics/#click-through-rate).
	Rate float64 `json:"rate"`
	// Number of tracked _and_ untracked searches (where the `clickAnalytics` parameter isn't `true`).
	Count int32 `json:"count"`
	// Number of click events.
	NoClickCount int32 `json:"noClickCount"`
	// Date of the event in the format YYYY-MM-DD.
	Date string `json:"date"`
}

// NewNoClickRateEvent instantiates a new NoClickRateEvent object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewNoClickRateEvent(rate float64, count int32, noClickCount int32, date string) *NoClickRateEvent {
	this := &NoClickRateEvent{}
	this.Rate = rate
	this.Count = count
	this.NoClickCount = noClickCount
	this.Date = date
	return this
}

// NewNoClickRateEventWithDefaults instantiates a new NoClickRateEvent object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewNoClickRateEventWithDefaults() *NoClickRateEvent {
	this := &NoClickRateEvent{}
	return this
}

// GetRate returns the Rate field value
func (o *NoClickRateEvent) GetRate() float64 {
	if o == nil {
		var ret float64
		return ret
	}

	return o.Rate
}

// GetRateOk returns a tuple with the Rate field value
// and a boolean to check if the value has been set.
func (o *NoClickRateEvent) GetRateOk() (*float64, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Rate, true
}

// SetRate sets field value
func (o *NoClickRateEvent) SetRate(v float64) {
	o.Rate = v
}

// GetCount returns the Count field value
func (o *NoClickRateEvent) GetCount() int32 {
	if o == nil {
		var ret int32
		return ret
	}

	return o.Count
}

// GetCountOk returns a tuple with the Count field value
// and a boolean to check if the value has been set.
func (o *NoClickRateEvent) GetCountOk() (*int32, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Count, true
}

// SetCount sets field value
func (o *NoClickRateEvent) SetCount(v int32) {
	o.Count = v
}

// GetNoClickCount returns the NoClickCount field value
func (o *NoClickRateEvent) GetNoClickCount() int32 {
	if o == nil {
		var ret int32
		return ret
	}

	return o.NoClickCount
}

// GetNoClickCountOk returns a tuple with the NoClickCount field value
// and a boolean to check if the value has been set.
func (o *NoClickRateEvent) GetNoClickCountOk() (*int32, bool) {
	if o == nil {
		return nil, false
	}
	return &o.NoClickCount, true
}

// SetNoClickCount sets field value
func (o *NoClickRateEvent) SetNoClickCount(v int32) {
	o.NoClickCount = v
}

// GetDate returns the Date field value
func (o *NoClickRateEvent) GetDate() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Date
}

// GetDateOk returns a tuple with the Date field value
// and a boolean to check if the value has been set.
func (o *NoClickRateEvent) GetDateOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Date, true
}

// SetDate sets field value
func (o *NoClickRateEvent) SetDate(v string) {
	o.Date = v
}

func (o NoClickRateEvent) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]any{}
	if true {
		toSerialize["rate"] = o.Rate
	}
	if true {
		toSerialize["count"] = o.Count
	}
	if true {
		toSerialize["noClickCount"] = o.NoClickCount
	}
	if true {
		toSerialize["date"] = o.Date
	}
	return json.Marshal(toSerialize)
}

func (o NoClickRateEvent) String() string {
	out := ""
	out += fmt.Sprintf("  rate=%v\n", o.Rate)
	out += fmt.Sprintf("  count=%v\n", o.Count)
	out += fmt.Sprintf("  noClickCount=%v\n", o.NoClickCount)
	out += fmt.Sprintf("  date=%v\n", o.Date)
	return fmt.Sprintf("NoClickRateEvent {\n%s}", out)
}

type NullableNoClickRateEvent struct {
	value *NoClickRateEvent
	isSet bool
}

func (v NullableNoClickRateEvent) Get() *NoClickRateEvent {
	return v.value
}

func (v *NullableNoClickRateEvent) Set(val *NoClickRateEvent) {
	v.value = val
	v.isSet = true
}

func (v NullableNoClickRateEvent) IsSet() bool {
	return v.isSet
}

func (v *NullableNoClickRateEvent) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableNoClickRateEvent(val *NoClickRateEvent) *NullableNoClickRateEvent {
	return &NullableNoClickRateEvent{value: val, isSet: true}
}

func (v NullableNoClickRateEvent) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableNoClickRateEvent) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}
