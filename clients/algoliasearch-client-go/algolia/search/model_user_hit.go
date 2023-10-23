// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
package search

import (
	"encoding/json"
	"fmt"
)

// UserHit struct for UserHit
type UserHit struct {
	// userID of the user.
	UserID string `json:"userID"`
	// Cluster name.
	ClusterName string `json:"clusterName"`
	// Number of records in the cluster.
	NbRecords int32 `json:"nbRecords"`
	// Data size taken by all the users assigned to the cluster.
	DataSize int32 `json:"dataSize"`
	// userID of the requested user. Same as userID.
	ObjectID        string              `json:"objectID"`
	HighlightResult UserHighlightResult `json:"_highlightResult"`
}

// NewUserHit instantiates a new UserHit object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewUserHit(userID string, clusterName string, nbRecords int32, dataSize int32, objectID string, highlightResult UserHighlightResult) *UserHit {
	this := &UserHit{}
	this.UserID = userID
	this.ClusterName = clusterName
	this.NbRecords = nbRecords
	this.DataSize = dataSize
	this.ObjectID = objectID
	this.HighlightResult = highlightResult
	return this
}

// NewUserHitWithDefaults instantiates a new UserHit object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewUserHitWithDefaults() *UserHit {
	this := &UserHit{}
	return this
}

// GetUserID returns the UserID field value
func (o *UserHit) GetUserID() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.UserID
}

// GetUserIDOk returns a tuple with the UserID field value
// and a boolean to check if the value has been set.
func (o *UserHit) GetUserIDOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.UserID, true
}

// SetUserID sets field value
func (o *UserHit) SetUserID(v string) {
	o.UserID = v
}

// GetClusterName returns the ClusterName field value
func (o *UserHit) GetClusterName() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.ClusterName
}

// GetClusterNameOk returns a tuple with the ClusterName field value
// and a boolean to check if the value has been set.
func (o *UserHit) GetClusterNameOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.ClusterName, true
}

// SetClusterName sets field value
func (o *UserHit) SetClusterName(v string) {
	o.ClusterName = v
}

// GetNbRecords returns the NbRecords field value
func (o *UserHit) GetNbRecords() int32 {
	if o == nil {
		var ret int32
		return ret
	}

	return o.NbRecords
}

// GetNbRecordsOk returns a tuple with the NbRecords field value
// and a boolean to check if the value has been set.
func (o *UserHit) GetNbRecordsOk() (*int32, bool) {
	if o == nil {
		return nil, false
	}
	return &o.NbRecords, true
}

// SetNbRecords sets field value
func (o *UserHit) SetNbRecords(v int32) {
	o.NbRecords = v
}

// GetDataSize returns the DataSize field value
func (o *UserHit) GetDataSize() int32 {
	if o == nil {
		var ret int32
		return ret
	}

	return o.DataSize
}

// GetDataSizeOk returns a tuple with the DataSize field value
// and a boolean to check if the value has been set.
func (o *UserHit) GetDataSizeOk() (*int32, bool) {
	if o == nil {
		return nil, false
	}
	return &o.DataSize, true
}

// SetDataSize sets field value
func (o *UserHit) SetDataSize(v int32) {
	o.DataSize = v
}

// GetObjectID returns the ObjectID field value
func (o *UserHit) GetObjectID() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.ObjectID
}

// GetObjectIDOk returns a tuple with the ObjectID field value
// and a boolean to check if the value has been set.
func (o *UserHit) GetObjectIDOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.ObjectID, true
}

// SetObjectID sets field value
func (o *UserHit) SetObjectID(v string) {
	o.ObjectID = v
}

// GetHighlightResult returns the HighlightResult field value
func (o *UserHit) GetHighlightResult() UserHighlightResult {
	if o == nil {
		var ret UserHighlightResult
		return ret
	}

	return o.HighlightResult
}

// GetHighlightResultOk returns a tuple with the HighlightResult field value
// and a boolean to check if the value has been set.
func (o *UserHit) GetHighlightResultOk() (*UserHighlightResult, bool) {
	if o == nil {
		return nil, false
	}
	return &o.HighlightResult, true
}

// SetHighlightResult sets field value
func (o *UserHit) SetHighlightResult(v UserHighlightResult) {
	o.HighlightResult = v
}

func (o UserHit) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]any{}
	if true {
		toSerialize["userID"] = o.UserID
	}
	if true {
		toSerialize["clusterName"] = o.ClusterName
	}
	if true {
		toSerialize["nbRecords"] = o.NbRecords
	}
	if true {
		toSerialize["dataSize"] = o.DataSize
	}
	if true {
		toSerialize["objectID"] = o.ObjectID
	}
	if true {
		toSerialize["_highlightResult"] = o.HighlightResult
	}
	return json.Marshal(toSerialize)
}

func (o UserHit) String() string {
	out := ""
	out += fmt.Sprintf("  userID=%v\n", o.UserID)
	out += fmt.Sprintf("  clusterName=%v\n", o.ClusterName)
	out += fmt.Sprintf("  nbRecords=%v\n", o.NbRecords)
	out += fmt.Sprintf("  dataSize=%v\n", o.DataSize)
	out += fmt.Sprintf("  objectID=%v\n", o.ObjectID)
	out += fmt.Sprintf("  _highlightResult=%v\n", o.HighlightResult)
	return fmt.Sprintf("UserHit {\n%s}", out)
}

type NullableUserHit struct {
	value *UserHit
	isSet bool
}

func (v NullableUserHit) Get() *UserHit {
	return v.value
}

func (v *NullableUserHit) Set(val *UserHit) {
	v.value = val
	v.isSet = true
}

func (v NullableUserHit) IsSet() bool {
	return v.isSet
}

func (v *NullableUserHit) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableUserHit(val *UserHit) *NullableUserHit {
	return &NullableUserHit{value: val, isSet: true}
}

func (v NullableUserHit) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableUserHit) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}
