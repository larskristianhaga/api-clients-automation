# coding: utf-8

"""
Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
"""
from __future__ import annotations

import json
from enum import Enum

try:
    from typing import Self
except ImportError:
    from typing_extensions import Self


class ExactOnSingleWordQuery(str, Enum):
    """
    Determines how the [Exact ranking criterion](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/override-search-engine-defaults/in-depth/adjust-exact-settings/#turn-off-exact-for-some-attributes) is computed when the query contains only one word.
    """

    """
    allowed enum values
    """
    ATTRIBUTE = "attribute"
    NONE = "none"
    WORD = "word"

    @classmethod
    def from_json(cls, json_str: str) -> Self:
        """Create an instance of ExactOnSingleWordQuery from a JSON string"""
        return cls(json.loads(json_str))