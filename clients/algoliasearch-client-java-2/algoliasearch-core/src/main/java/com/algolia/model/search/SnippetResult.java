// This file is generated, manual changes will be lost - read more on
// https://github.com/algolia/api-clients-automation.

package com.algolia.model.search;

import com.algolia.utils.CompoundType;
import com.fasterxml.jackson.annotation.*;
import com.fasterxml.jackson.core.*;
import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.*;
import com.fasterxml.jackson.databind.annotation.JsonDeserialize;
import com.fasterxml.jackson.databind.annotation.JsonSerialize;
import com.fasterxml.jackson.databind.deser.std.StdDeserializer;
import com.fasterxml.jackson.databind.ser.std.StdSerializer;
import java.io.IOException;
import java.util.List;

/** SnippetResult */
@JsonDeserialize(using = SnippetResult.SnippetResultDeserializer.class)
@JsonSerialize(using = SnippetResult.SnippetResultSerializer.class)
public abstract class SnippetResult implements CompoundType {

  public static SnippetResult of(List<SnippetResultOption> inside) {
    return new SnippetResultListOfSnippetResultOption(inside);
  }

  public static SnippetResult of(SnippetResultOption inside) {
    return new SnippetResultSnippetResultOption(inside);
  }

  public static class SnippetResultSerializer extends StdSerializer<SnippetResult> {

    public SnippetResultSerializer(Class<SnippetResult> t) {
      super(t);
    }

    public SnippetResultSerializer() {
      this(null);
    }

    @Override
    public void serialize(SnippetResult value, JsonGenerator jgen, SerializerProvider provider)
      throws IOException, JsonProcessingException {
      jgen.writeObject(value.getInsideValue());
    }
  }

  public static class SnippetResultDeserializer extends StdDeserializer<SnippetResult> {

    public SnippetResultDeserializer() {
      this(SnippetResult.class);
    }

    public SnippetResultDeserializer(Class<?> vc) {
      super(vc);
    }

    @Override
    public SnippetResult deserialize(JsonParser jp, DeserializationContext ctxt) throws IOException, JsonProcessingException {
      JsonNode tree = jp.readValueAsTree();
      SnippetResult deserialized = null;

      int match = 0;
      JsonToken token = tree.traverse(jp.getCodec()).nextToken();
      String currentType = "";
      // deserialize List<SnippetResultOption>
      try {
        boolean attemptParsing = true;
        currentType = "List<SnippetResultOption>";
        if (
          ((currentType.equals("Integer") || currentType.equals("Long")) && token == JsonToken.VALUE_NUMBER_INT) |
          ((currentType.equals("Float") || currentType.equals("Double")) && token == JsonToken.VALUE_NUMBER_FLOAT) |
          (currentType.equals("Boolean") && (token == JsonToken.VALUE_FALSE || token == JsonToken.VALUE_TRUE)) |
          (currentType.equals("String") && token == JsonToken.VALUE_STRING) |
          (currentType.startsWith("List<") && token == JsonToken.START_ARRAY)
        ) {
          deserialized =
            SnippetResult.of(
              (List<SnippetResultOption>) tree.traverse(jp.getCodec()).readValueAs(new TypeReference<List<SnippetResultOption>>() {})
            );
          match++;
        } else if (token == JsonToken.START_OBJECT) {
          try {
            deserialized =
              SnippetResult.of(
                (List<SnippetResultOption>) tree.traverse(jp.getCodec()).readValueAs(new TypeReference<List<SnippetResultOption>>() {})
              );
            match++;
          } catch (IOException e) {
            // do nothing
          }
        }
      } catch (Exception e) {
        // deserialization failed, continue
        System.err.println(
          "Failed to deserialize oneOf List<SnippetResultOption> (error: " + e.getMessage() + ") (type: " + currentType + ")"
        );
      }

      // deserialize SnippetResultOption
      try {
        boolean attemptParsing = true;
        currentType = "SnippetResultOption";
        if (
          ((currentType.equals("Integer") || currentType.equals("Long")) && token == JsonToken.VALUE_NUMBER_INT) |
          ((currentType.equals("Float") || currentType.equals("Double")) && token == JsonToken.VALUE_NUMBER_FLOAT) |
          (currentType.equals("Boolean") && (token == JsonToken.VALUE_FALSE || token == JsonToken.VALUE_TRUE)) |
          (currentType.equals("String") && token == JsonToken.VALUE_STRING) |
          (currentType.startsWith("List<") && token == JsonToken.START_ARRAY)
        ) {
          deserialized =
            SnippetResult.of((SnippetResultOption) tree.traverse(jp.getCodec()).readValueAs(new TypeReference<SnippetResultOption>() {}));
          match++;
        } else if (token == JsonToken.START_OBJECT) {
          try {
            deserialized =
              SnippetResult.of((SnippetResultOption) tree.traverse(jp.getCodec()).readValueAs(new TypeReference<SnippetResultOption>() {}));
            match++;
          } catch (IOException e) {
            // do nothing
          }
        }
      } catch (Exception e) {
        // deserialization failed, continue
        System.err.println("Failed to deserialize oneOf SnippetResultOption (error: " + e.getMessage() + ") (type: " + currentType + ")");
      }

      if (match == 1) {
        return deserialized;
      }
      throw new IOException(String.format("Failed deserialization for SnippetResult: %d classes match result, expected 1", match));
    }

    /** Handle deserialization of the 'null' value. */
    @Override
    public SnippetResult getNullValue(DeserializationContext ctxt) throws JsonMappingException {
      throw new JsonMappingException(ctxt.getParser(), "SnippetResult cannot be null");
    }
  }
}

class SnippetResultListOfSnippetResultOption extends SnippetResult {

  private final List<SnippetResultOption> insideValue;

  SnippetResultListOfSnippetResultOption(List<SnippetResultOption> insideValue) {
    this.insideValue = insideValue;
  }

  @Override
  public List<SnippetResultOption> getInsideValue() {
    return insideValue;
  }
}

class SnippetResultSnippetResultOption extends SnippetResult {

  private final SnippetResultOption insideValue;

  SnippetResultSnippetResultOption(SnippetResultOption insideValue) {
    this.insideValue = insideValue;
  }

  @Override
  public SnippetResultOption getInsideValue() {
    return insideValue;
  }
}
