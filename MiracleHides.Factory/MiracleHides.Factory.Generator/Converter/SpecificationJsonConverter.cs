namespace MiracleHides.Factory.Generator.Converter
{
    using System.Text.Json;
    using MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification;
    using MiracleHides.Factory.Generator.Models.JsonSpecification;

    /// <summary>
    ///     Converter for <see cref="Specification"/> that includes required checks for data fields.
    /// </summary>
    public class SpecificationJsonConverter : RequiredJsonConverter<Specification>
    {
        /// <summary>
        ///     Deserialize the given <paramref name="json"/> to a <see cref="Specification"/>.
        /// </summary>
        /// <param name="json">A <see cref="string"/> in json format.</param>
        /// <returns>A <see cref="Specification"/>.</returns>
        public static Specification Deserialize(string json)
        {
            var options = new JsonSerializerOptions();
            options.Converters.Add(new SpecificationJsonConverter());
            return JsonSerializer.Deserialize<Specification>(json, options);
        }

        /// <summary>
        ///     Check for required data fields.
        /// </summary>
        /// <param name="value">The converted value.</param>
        /// <returns>The given <paramref name="value"/>.</returns>
        protected override Specification CheckRequired(Specification value)
        {
            if (value.Language == Language.None)
            {
                throw new JsonException($"{nameof(Specification.Language)} is not set or None.");
            }

            if (value.Type == SpecificationType.None)
            {
                throw new JsonException($"{nameof(Specification.Type)} is not set or None.");
            }

            return value;
        }
    }
}
