<?php

// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

namespace Algolia\AlgoliaSearch\Model\Search;

/**
 * DictionaryType Class Doc Comment.
 *
 * @category Class
 */
class DictionaryType
{
    /**
     * Possible values of this enum.
     */
    public const PLURALS = 'plurals';

    public const STOPWORDS = 'stopwords';

    public const COMPOUNDS = 'compounds';

    /**
     * Gets allowable values of the enum.
     *
     * @return string[]
     */
    public static function getAllowableEnumValues()
    {
        return [
            self::PLURALS,
            self::STOPWORDS,
            self::COMPOUNDS,
        ];
    }
}
