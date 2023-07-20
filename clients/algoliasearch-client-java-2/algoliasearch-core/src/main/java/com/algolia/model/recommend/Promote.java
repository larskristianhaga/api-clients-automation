// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost
// - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.

package com.algolia.model.recommend;

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

/** Promote */
@JsonDeserialize(using = Promote.PromoteDeserializer.class)
@JsonSerialize(using = Promote.PromoteSerializer.class)
public abstract class Promote implements CompoundType {

  public static Promote of(PromoteObjectID inside) {
    return new PromotePromoteObjectID(inside);
  }

  public static Promote of(PromoteObjectIDs inside) {
    return new PromotePromoteObjectIDs(inside);
  }

  public static class PromoteSerializer extends StdSerializer<Promote> {

    public PromoteSerializer(Class<Promote> t) {
      super(t);
    }

    public PromoteSerializer() {
      this(null);
    }

    @Override
    public void serialize(Promote value, JsonGenerator jgen, SerializerProvider provider) throws IOException, JsonProcessingException {
      jgen.writeObject(value.getInsideValue());
    }
  }

  public static class PromoteDeserializer extends StdDeserializer<Promote> {

    public PromoteDeserializer() {
      this(Promote.class);
    }

    public PromoteDeserializer(Class<?> vc) {
      super(vc);
    }

    @Override
    public Promote deserialize(JsonParser jp, DeserializationContext ctxt) throws IOException, JsonProcessingException {
      JsonNode tree = jp.readValueAsTree();
      Promote deserialized = null;

      int match = 0;
      JsonToken token = tree.traverse(jp.getCodec()).nextToken();
      String currentType = "";
      // deserialize PromoteObjectID
      try {
        boolean attemptParsing = true;
        currentType = "PromoteObjectID";
        if (
          ((currentType.equals("Integer") || currentType.equals("Long")) && token == JsonToken.VALUE_NUMBER_INT) |
          ((currentType.equals("Float") || currentType.equals("Double")) && token == JsonToken.VALUE_NUMBER_FLOAT) |
          (currentType.equals("Boolean") && (token == JsonToken.VALUE_FALSE || token == JsonToken.VALUE_TRUE)) |
          (currentType.equals("String") && token == JsonToken.VALUE_STRING) |
          (currentType.startsWith("List<") && token == JsonToken.START_ARRAY)
        ) {
          deserialized = Promote.of((PromoteObjectID) tree.traverse(jp.getCodec()).readValueAs(new TypeReference<PromoteObjectID>() {}));
          match++;
        } else if (token == JsonToken.START_OBJECT) {
          try {
            deserialized = Promote.of((PromoteObjectID) tree.traverse(jp.getCodec()).readValueAs(new TypeReference<PromoteObjectID>() {}));
            match++;
          } catch (IOException e) {
            // do nothing
          }
        }
      } catch (Exception e) {
        // deserialization failed, continue
        System.err.println("Failed to deserialize oneOf PromoteObjectID (error: " + e.getMessage() + ") (type: " + currentType + ")");
      }

      // deserialize PromoteObjectIDs
      try {
        boolean attemptParsing = true;
        currentType = "PromoteObjectIDs";
        if (
          ((currentType.equals("Integer") || currentType.equals("Long")) && token == JsonToken.VALUE_NUMBER_INT) |
          ((currentType.equals("Float") || currentType.equals("Double")) && token == JsonToken.VALUE_NUMBER_FLOAT) |
          (currentType.equals("Boolean") && (token == JsonToken.VALUE_FALSE || token == JsonToken.VALUE_TRUE)) |
          (currentType.equals("String") && token == JsonToken.VALUE_STRING) |
          (currentType.startsWith("List<") && token == JsonToken.START_ARRAY)
        ) {
          deserialized = Promote.of((PromoteObjectIDs) tree.traverse(jp.getCodec()).readValueAs(new TypeReference<PromoteObjectIDs>() {}));
          match++;
        } else if (token == JsonToken.START_OBJECT) {
          try {
            deserialized =
              Promote.of((PromoteObjectIDs) tree.traverse(jp.getCodec()).readValueAs(new TypeReference<PromoteObjectIDs>() {}));
            match++;
          } catch (IOException e) {
            // do nothing
          }
        }
      } catch (Exception e) {
        // deserialization failed, continue
        System.err.println("Failed to deserialize oneOf PromoteObjectIDs (error: " + e.getMessage() + ") (type: " + currentType + ")");
      }

      if (match == 1) {
        return deserialized;
      }
      throw new IOException(String.format("Failed deserialization for Promote: %d classes match result, expected 1", match));
    }

    /** Handle deserialization of the 'null' value. */
    @Override
    public Promote getNullValue(DeserializationContext ctxt) throws JsonMappingException {
      throw new JsonMappingException(ctxt.getParser(), "Promote cannot be null");
    }
  }
}

class PromotePromoteObjectID extends Promote {

  private final PromoteObjectID insideValue;

  PromotePromoteObjectID(PromoteObjectID insideValue) {
    this.insideValue = insideValue;
  }

  @Override
  public PromoteObjectID getInsideValue() {
    return insideValue;
  }
}

class PromotePromoteObjectIDs extends Promote {

  private final PromoteObjectIDs insideValue;

  PromotePromoteObjectIDs(PromoteObjectIDs insideValue) {
    this.insideValue = insideValue;
  }

  @Override
  public PromoteObjectIDs getInsideValue() {
    return insideValue;
  }
}