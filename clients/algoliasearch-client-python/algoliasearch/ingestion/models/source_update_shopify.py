# coding: utf-8

"""
Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
"""
from __future__ import annotations

from json import loads
from typing import Any, Dict, Optional, Self

from pydantic import BaseModel, Field, StrictBool


class SourceUpdateShopify(BaseModel):
    """
    SourceUpdateShopify
    """

    collection_id_indexing: Optional[StrictBool] = Field(
        default=False,
        description="Whether to index collection IDs.   If your store has `has_collection_search_page` set to true, collection IDs will be indexed even if `collectionIDIndexing` is false.  ",
        alias="collectionIDIndexing",
    )
    increase_product_collection_limit: Optional[StrictBool] = Field(
        default=False,
        description="Whether to increase the number of indexed collections per product. If true, Algolia indexes 200 collections per product. If false, 100 collections per product are indexed. ",
        alias="increaseProductCollectionLimit",
    )
    default_price_ratio_as_one: Optional[StrictBool] = Field(
        default=True,
        description="Whether to set the default price ratio to 1 if no sale price is present.  The price ratio is determined by the ratio: `sale_price` / `regular_price`. If no sale price is present, the price ratio would be 0. If `defaultPriceRatioAsOne` is true, the price ratio is indexed as 1 instead. ",
        alias="defaultPriceRatioAsOne",
    )
    exclude_oos_variants_for_price_at_trs: Optional[StrictBool] = Field(
        default=True,
        description="Whether to exclude out-of-stock variants when determining the `max_variant_price` and `min_variant_price` attributes. ",
        alias="excludeOOSVariantsForPriceAtTRS",
    )
    include_variants_inventory: Optional[StrictBool] = Field(
        default=True,
        description="Whether to include an inventory with every variant for every product record. ",
        alias="includeVariantsInventory",
    )
    has_collection_search_page: Optional[StrictBool] = Field(
        default=False,
        description="Whether to include collection IDs and handles in the product records. ",
        alias="hasCollectionSearchPage",
    )
    product_named_tags: Optional[StrictBool] = Field(
        default=False,
        description="Whether to convert tags on products to named tags.  To learn more, see [Named tags](https://www.algolia.com/doc/integration/shopify/sending-and-managing-data/named-tags). ",
        alias="productNamedTags",
    )

    model_config = {"populate_by_name": True, "validate_assignment": True}

    def to_json(self) -> str:
        return self.model_dump_json(by_alias=True, exclude_unset=True)

    @classmethod
    def from_json(cls, json_str: str) -> Self:
        """Create an instance of SourceUpdateShopify from a JSON string"""
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
        return _dict

    @classmethod
    def from_dict(cls, obj: Dict) -> Self:
        """Create an instance of SourceUpdateShopify from a dict"""
        if obj is None:
            return None

        if not isinstance(obj, dict):
            return cls.model_validate(obj)

        _obj = cls.model_validate(
            {
                "collectionIDIndexing": obj.get("collectionIDIndexing"),
                "increaseProductCollectionLimit": obj.get(
                    "increaseProductCollectionLimit"
                ),
                "defaultPriceRatioAsOne": obj.get("defaultPriceRatioAsOne"),
                "excludeOOSVariantsForPriceAtTRS": obj.get(
                    "excludeOOSVariantsForPriceAtTRS"
                ),
                "includeVariantsInventory": obj.get("includeVariantsInventory"),
                "hasCollectionSearchPage": obj.get("hasCollectionSearchPage"),
                "productNamedTags": obj.get("productNamedTags"),
            }
        )
        return _obj
