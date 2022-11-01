namespace MiracleHides.Factory.Generator.Test.Converter
{
    using System.IO;
    using System.Text.Json;
    using Xunit;
    using MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification;
    using MiracleHides.Factory.Generator.Converter;
    using MiracleHides.Factory.Generator.Models.JsonSpecification;    

    public class SpecificationJsonConverterTests
    {
        [Theory]
        [InlineData("Python", "None", "Language is not set or None")]
        [InlineData("Crud", "None", "Type is not set or None")]
        [InlineData("test_service_folder", "", "Folder is null or whitespace")]
        public void DeserializeFailsDueToInvalidEnumValue(string oldValue, string newValue, string message)
        {
            var jsonFileName = "Converter/SpecificationJsonConverterTests.Deserialize.json";
            var json = File.ReadAllText(jsonFileName);

            try
            {
                SpecificationJsonConverter.Deserialize(json.Replace(oldValue, newValue));
            }
            catch (JsonException ex)
            {
                Assert.Contains(message, ex.Message);
            }
        }            

        [Fact]
        public void DeserializeSucceeds()
        {
            var jsonFileName = "Converter/SpecificationJsonConverterTests.Deserialize.json";
            var json = File.ReadAllText(jsonFileName);
            var specification = SpecificationJsonConverter.Deserialize(json);

            Assert.NotNull(specification);
            Assert.Equal(Language.Python, specification.Language);
            Assert.Equal(SpecificationType.Crud, specification.Type);
        }

        [Theory]
        [InlineData(Language.Python, SpecificationType.Crud, "folder")]
        public void Serialize(Language language, SpecificationType type, string folder)
        {
            var specification = new Specification
            {
                Language = language,
                Type = type,
                Folder = folder,
            };

            var serialized = JsonSerializer.Serialize(specification);

            var options = new JsonSerializerOptions();
            options.Converters.Add(new SpecificationJsonConverter());
            var deserialized = JsonSerializer.Deserialize<Specification>(serialized, options);

            Assert.Equal(language, deserialized.Language);
            Assert.Equal(type, deserialized.Type);
            Assert.Equal(folder, deserialized.Folder);
        }
    }
}
