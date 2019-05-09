using System;
using System.Reflection;
using System.Text.RegularExpressions;
using Conizi.Model.Core.Entities;
using Conizi.Model.Core.Provider;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
using Newtonsoft.Json.Serialization;

namespace Conizi.Model.Core.Tools
{
    /// <summary>
    /// The conizi schema generator is used to generate a JSON Schema out of the conizi C# models
    /// </summary>
    public static class Generator
    {
        /// <summary>
        /// Register a JsonSchema License if available
        /// </summary>
        /// <param name="license"><see href="https://www.nuget.org/packages/Newtonsoft.Json.Schema/">Newtonsoft.Json.Schema</see> license as string</param>
        public static void RegisterJsonSchemaLicense(string license)
        {
            License.RegisterLicense(license);
        }

        /// <summary>
        /// Generate a JSON schema from the C# model of type T
        /// </summary>
        /// <typeparam name="TModel">The C# model type, should be generated to a JSON schema</typeparam>
        /// <returns><see cref="GenerationResult"/></returns>
        public static GenerationResult Generate<TModel>()
        {
            return Generate(typeof(TModel));
        }

        /// <summary>
        /// Generate a JSON schema from the C# model instance type
        /// </summary>
        /// <param name="modelType">Type of the C# model instance</param>
        /// <returns><see cref="GenerationResult"/></returns>
        public static GenerationResult Generate(Type modelType)
        {
       
            var schemaAttribute = modelType.GetCustomAttribute<ConiziSchemaAttribute>();

            if (schemaAttribute == null)
                throw new InvalidOperationException("Class is no valid conizi model!");

            var generator = new JSchemaGenerator
            {
                DefaultRequired = Newtonsoft.Json.Required.DisallowNull,
                SchemaIdGenerationHandling = SchemaIdGenerationHandling.None,
                SchemaReferenceHandling = SchemaReferenceHandling.Objects,
                SchemaPropertyOrderHandling = SchemaPropertyOrderHandling.Default,
                SchemaLocationHandling = SchemaLocationHandling.Definitions,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            generator.GenerationProviders.Add(new ConiziDefaultGenerationProvider());
            generator.GenerationProviders.Add(new StringEnumGenerationProvider());

            JSchema schema = generator.Generate(modelType);
            var baseUri = "https://model.conizi.io/";

            // Get model shortcut from model id
            var model = Regex.Replace(schemaAttribute.Id, baseUri + "(v([0-9]|\\.)+/)|(\\.json)", String.Empty);

            if (string.IsNullOrEmpty(model))
                throw new InvalidOperationException($"Model could not be extracted from {schemaAttribute.Id}!");

            var match = Regex.Match(schemaAttribute.Id, "(?<version>(v([0-9]|[0-9]\\.)+))");

            var version = match.Groups["version"]?.Value;

            if (string.IsNullOrEmpty(version))
                throw new InvalidOperationException($"Version could not be extracted from {schemaAttribute.Id}!");

            var result = new GenerationResult
            {
                Id = schemaAttribute.Id,
                Title = schema.Title,
                Description = schema.Description,
                Model = model,
                JSchema = schema,
                File = schemaAttribute.FileName,
                Version = version
            };


            return result;
        }

    }
}
