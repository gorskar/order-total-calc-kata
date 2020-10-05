using System;
using Newtonsoft.Json;


namespace BusinessObjects
{

    internal class ProductConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Product) || t == typeof(Product?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Gas":
                    return Product.Gas;
                case "TV":
                    return Product.Tv;
            }
            throw new Exception("Cannot unmarshal type Product");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Product)untypedValue;
            switch (value)
            {
                case Product.Gas:
                    serializer.Serialize(writer, "Gas");
                    return;
                case Product.Tv:
                    serializer.Serialize(writer, "TV");
                    return;
            }
            throw new Exception("Cannot marshal type Product");
        }

        public static readonly ProductConverter Singleton = new ProductConverter();
    }
}
