# coding: utf-8

"""
Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
"""
from __future__ import annotations

from json import loads
from typing import Any, Dict, List, Self

from pydantic import BaseModel, Field

from algoliasearch.search.models.batch_response import BatchResponse
from algoliasearch.search.models.updated_at_response import UpdatedAtResponse


class ReplaceAllObjectsResponse(BaseModel):
    """
    ReplaceAllObjectsResponse
    """

    copy_operation_response: UpdatedAtResponse = Field(alias="copyOperationResponse")
    batch_responses: List[BatchResponse] = Field(
        description="The response of the `batch` request(s).", alias="batchResponses"
    )
    move_operation_response: UpdatedAtResponse = Field(alias="moveOperationResponse")

    model_config = {"populate_by_name": True, "validate_assignment": True}

    def to_json(self) -> str:
        return self.model_dump_json(by_alias=True, exclude_unset=True)

    @classmethod
    def from_json(cls, json_str: str) -> Self:
        """Create an instance of ReplaceAllObjectsResponse from a JSON string"""
        return cls.from_dict(loads(json_str))

    def to_dict(self) -> Dict[str, Any]:
        """Return the dictionary representation of the model using alias.

        This has the following differences from calling pydantic's
        `self.model_dump(by_alias=True)`:

        * `None` is only added to the output dict for nullable fields that
          were set at model initialization. Other fields with value `None`
          are ignored.
        """
        _dict = self.model_dump(
            by_alias=True,
            exclude={},
            exclude_none=True,
        )
        if self.copy_operation_response:
            _dict["copyOperationResponse"] = self.copy_operation_response.to_dict()
        _items = []
        if self.batch_responses:
            for _item in self.batch_responses:
                if _item:
                    _items.append(_item.to_dict())
            _dict["batchResponses"] = _items
        if self.move_operation_response:
            _dict["moveOperationResponse"] = self.move_operation_response.to_dict()
        return _dict

    @classmethod
    def from_dict(cls, obj: Dict) -> Self:
        """Create an instance of ReplaceAllObjectsResponse from a dict"""
        if obj is None:
            return None

        if not isinstance(obj, dict):
            return cls.model_validate(obj)

        _obj = cls.model_validate(
            {
                "copyOperationResponse": (
                    UpdatedAtResponse.from_dict(obj.get("copyOperationResponse"))
                    if obj.get("copyOperationResponse") is not None
                    else None
                ),
                "batchResponses": (
                    [
                        BatchResponse.from_dict(_item)
                        for _item in obj.get("batchResponses")
                    ]
                    if obj.get("batchResponses") is not None
                    else None
                ),
                "moveOperationResponse": (
                    UpdatedAtResponse.from_dict(obj.get("moveOperationResponse"))
                    if obj.get("moveOperationResponse") is not None
                    else None
                ),
            }
        )
        return _obj