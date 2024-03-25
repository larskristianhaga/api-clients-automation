<?php

// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

namespace Algolia\AlgoliaSearch\Model\Ingestion;

/**
 * PlatformNone Class Doc Comment.
 *
 * @category Class
 * @description Authentication resource not tied to any ecommerce platform, used for filtering.
 */
class PlatformNone
{
    /**
     * Possible values of this enum.
     */
    public const NONE = 'none';

    /**
     * Gets allowable values of the enum.
     *
     * @return string[]
     */
    public static function getAllowableEnumValues()
    {
        return [
            self::NONE,
        ];
    }
}
