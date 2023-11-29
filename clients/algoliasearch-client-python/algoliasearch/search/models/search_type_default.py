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


class SearchTypeDefault(str, Enum):
    """
    - `default`: perform a search query - `facet` [searches for facet values](https://www.algolia.com/doc/guides/managing-results/refine-results/faceting/#search-for-facet-values).
    """

    """
    allowed enum values
    """
    DEFAULT = "default"

    @classmethod
    def from_json(cls, json_str: str) -> Self:
        """Create an instance of SearchTypeDefault from a JSON string"""
        return cls(json.loads(json_str))