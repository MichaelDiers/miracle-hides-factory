namespace MiracleHides.Factory.Generator.Converter
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    ///     Base class for json converters that check for required data fields.
    /// </summary>
    /// <typeparam name="T">The type of the deserialized instance.</typeparam>
    public abstract class RequiredJsonConverter<T> : JsonConverter<T>
    {
        /// <summary>
        ///     Reads and converts the JSON to type T.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="typeToConvert">The type to convert.</param>
        /// <param name="options">An object that specifies serialization options to use.</param>
        /// <returns>The converted value.</returns>
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var newOptions = new JsonSerializerOptions();
            newOptions.PropertyNameCaseInsensitive = true;
            newOptions.Converters.Add(new JsonStringEnumConverter());            
            var value = JsonSerializer.Deserialize<T>(ref reader, newOptions);

            return this.CheckRequired(value);
        }

        /// <summary>
        ///     Writes the JSON representation of a type specified by a generic type parameter
        ///     to the provided writer.
        /// </summary>
        /// <param name="writer">A JSON writer to write to.</param>
        /// <param name="value">The value to convert and write.</param>
        /// <param name="options">Options to control serialization behavior.</param>
        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value);
        }

        /// <summary>
        ///     Check for required data fields.
        /// </summary>
        /// <param name="value">The converted value.</param>
        /// <returns>The given <paramref name="value"/>.</returns>
        protected abstract T CheckRequired(T value);
    }
}
