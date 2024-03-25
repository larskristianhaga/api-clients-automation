# coding: utf-8

"""
Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
"""
from __future__ import annotations

from enum import Enum
from json import loads
from typing import Self


class DestinationType(str, Enum):
    """
    Destination type.  <dl> <dt><code>search</code></dt> <dd>Data is stored in an Algolia index.</dd> <dt><code>insights</code></dt> <dd>Data is recorded as user events in the Insights API.</dd> </dl>.
    """

    """
    allowed enum values
    """
    SEARCH = "search"
    INSIGHTS = "insights"

    @classmethod
    def from_json(cls, json_str: str) -> Self:
        """Create an instance of DestinationType from a JSON string"""
        return cls(loads(json_str))
