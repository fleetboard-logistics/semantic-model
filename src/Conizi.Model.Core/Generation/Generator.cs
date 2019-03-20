using System;
using System.Reflection;
using System.Text.RegularExpressions;
using Conizi.Model.Core.Entities;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
using Newtonsoft.Json.Serialization;

namespace Conizi.Model.Core.Generation
{
    /// <summary>
    /// The conizi schema generator
    /// </summary>
    public class Generator
    {
        public SchemaResult Generate<TModel>()
        {
            var schemaAttribute = typeof(TModel).GetCustomAttribute<ConiziSchemaAttribute>();

            if(schemaAttribute == null)
                throw new InvalidOperationException("Class is no valid conizi model!");

            var generator = new JSchemaGenerator
            {
                DefaultRequired = Newtonsoft.Json.Required.DisallowNull,
                SchemaIdGenerationHandling = SchemaIdGenerationHandling.None,
                SchemaPropertyOrderHandling = SchemaPropertyOrderHandling.Default,
                SchemaLocationHandling = SchemaLocationHandling.Definitions,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            generator.GenerationProviders.Add(new ConiziDefaultGenerationProvider());
            generator.GenerationProviders.Add(new StringEnumGenerationProvider());

            JSchema schema = generator.Generate(typeof(TModel));
            var baseUri = "https://model.conizi.io/";

            // Get model shortcut from model id
            var model = Regex.Replace(schemaAttribute.Id, baseUri + "(v([0-9]|\\.)+/)|(\\.json)", String.Empty);

            if (string.IsNullOrEmpty(model))
                throw new InvalidOperationException($"Model could not be extracted from {schemaAttribute.Id}!");

            var match = Regex.Match(schemaAttribute.Id, "(?<version>(v([0-9]|[0-9]\\.)+))");

            var version = match.Groups["version"]?.Value;

            if (string.IsNullOrEmpty(version))
                throw new InvalidOperationException($"Version could not be extracted from {schemaAttribute.Id}!");

            var result = new SchemaResult
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
