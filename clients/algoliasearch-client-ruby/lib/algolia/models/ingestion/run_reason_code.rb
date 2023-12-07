# Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

require 'date'
require 'time'

module Algolia
  class RunReasonCode
    INTERNAL = "internal".freeze
    CRITICAL = "critical".freeze
    NO_EVENTS = "no_events".freeze
    TOO_MANY_ERRORS = "too_many_errors".freeze
    OK = "ok".freeze
    DISCARDED = "discarded".freeze
    BLOCKING = "blocking".freeze

    def self.all_vars
      @all_vars ||= [INTERNAL, CRITICAL, NO_EVENTS, TOO_MANY_ERRORS, OK, DISCARDED, BLOCKING].freeze
    end

    # Builds the enum from string
    # @param [String] The enum value in the form of the string
    # @return [String] The enum value
    def self.build_from_hash(value)
      new.build_from_hash(value)
    end

    # Builds the enum from string
    # @param [String] The enum value in the form of the string
    # @return [String] The enum value
    def build_from_hash(value)
      return value if RunReasonCode.all_vars.include?(value)
      raise "Invalid ENUM value #{value} for class #RunReasonCode"
    end
  end
end