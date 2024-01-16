using System.Text.Json.Serialization;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace StoreLib.Models
{
    public partial class DCatSearch
    {
        [JsonPropertyName("Results")]
        public List<Result> Results { get; set; }

        [JsonPropertyName("TotalResultCount")]
        public long TotalResultCount { get; set; }
    }

    public partial class Result
    {
        [JsonPropertyName("ProductFamilyName")]
        public string ProductFamilyName { get; set; }

        [JsonPropertyName("Products")]
        public List<Product> Products { get; set; }
    }

    public partial class Product
    {
        [JsonPropertyName("Height")]
        public long Height { get; set; }

        [JsonPropertyName("ImageType")]
        public string ImageType { get; set; }

        [JsonPropertyName("Width")]
        public long Width { get; set; }

        [JsonPropertyName("PlatformProperties")]
        public List<object> PlatformProperties { get; set; }

        [JsonPropertyName("Icon")]
        public string Icon { get; set; }

        [JsonPropertyName("ProductId")]
        public string ProductId { get; set; }

        [JsonPropertyName("Type")]
        public string Type { get; set; }

        [JsonPropertyName("Title")]
        public string Title { get; set; }

        [JsonConverter(typeof(IgnoreNullStringConverter))]
        public string BackgroundColor { get; set; }
    }

    public partial class DCatSearch
    {
        public static DCatSearch FromJson(string json) => JsonSerializer.Deserialize<DCatSearch>(json, CustomJsonSerializerOptions.jsonSerializerOptions);
    }

    public static class Serialize1
    {
        public static string ToJson(this DCatSearch self) => JsonSerializer.Serialize(self, CustomJsonSerializerOptions.jsonSerializerOptions);

        
    }

    internal class CustomJsonSerializerOptions
    {
        internal static readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            Converters = { new UtcDateTimeConverter() }
        };
    }

    internal class UtcDateTimeConverter: JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string dateString = reader.GetString();

            if (DateTime.TryParse(dateString, null, DateTimeStyles.RoundtripKind, out DateTime date))
            {
                // If DateTime has no DateTimeKind, assume it's UTC
                return DateTime.SpecifyKind(date, date.Kind == DateTimeKind.Unspecified ? DateTimeKind.Utc : date.Kind);
            }

            throw new JsonException("Invalid date format.");
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }

    internal class IgnoreNullStringConverter: JsonConverter<String>
    {
        public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString();
        }

        public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
        {
            // Only write the string if it's not null
            if (value != null)
            {
                writer.WriteStringValue(value);
            }
        }
    }
}
