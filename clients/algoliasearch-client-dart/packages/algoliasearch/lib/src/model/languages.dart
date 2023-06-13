// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
// ignore_for_file: unused_element
import 'package:algoliasearch/src/model/dictionary_language.dart';

import 'package:json_annotation/json_annotation.dart';

part 'languages.g.dart';

@JsonSerializable()
final class Languages {
  /// Returns a new [Languages] instance.
  const Languages({
    required this.plurals,
    required this.stopwords,
    required this.compounds,
  });

  @JsonKey(name: r'plurals')
  final DictionaryLanguage? plurals;

  @JsonKey(name: r'stopwords')
  final DictionaryLanguage? stopwords;

  @JsonKey(name: r'compounds')
  final DictionaryLanguage? compounds;

  @override
  bool operator ==(Object other) =>
      identical(this, other) ||
      other is Languages &&
          other.plurals == plurals &&
          other.stopwords == stopwords &&
          other.compounds == compounds;

  @override
  int get hashCode =>
      (plurals == null ? 0 : plurals.hashCode) +
      (stopwords == null ? 0 : stopwords.hashCode) +
      (compounds == null ? 0 : compounds.hashCode);

  factory Languages.fromJson(Map<String, dynamic> json) =>
      _$LanguagesFromJson(json);

  Map<String, dynamic> toJson() => _$LanguagesToJson(this);

  @override
  String toString() {
    return toJson().toString();
  }
}