using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;
using Conizi.Model.Core.Converters;
using Conizi.Model.Core.Entities;
using Conizi.Model.Extensions;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace Conizi.Model.Core.Tools
{
    /// <summary>
    /// The converter is used to serialize a C# conizi model to JSON or deserialize JSON to a C# model
    /// </summary>
    public static class Converter
    {
        static Converter()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        }

        /// <summary>
        /// Settings for the JSON serializer and deserializer
        /// </summary>
        internal static JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Include,
            DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,
            DateFormatHandling = DateFormatHandling.IsoDateFormat,
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            Converters = new List<JsonConverter>
            {
                new CombinedSchemaConverter()
            }
        };

        /// <summary>
        /// Serialize a C# model instance to JSON
        /// </summary>
        /// <typeparam name="TModel">The model type should be serialized</typeparam>
        /// <param name="model">The instance of the model, should be serialized</param>
        /// <param name="indented">Should the content well formatted?</param>
        /// <param name="ignoreValidation">Ignore the validation after serialization. May be helpful if no JSON Schema license is available</param>
        /// <returns>Instance of <see cref="SerializationResult"/></returns>
        /// <example>
        /// Serialize a model instance to JSON.
        /// <code>var result = Converter.Serialize(m);</code>
        /// </example>
        public static SerializationResult Serialize<TModel>(TModel model, bool indented = false,
            bool ignoreValidation = false) where TModel : EdiModel
        {
            var schemaAttribute = typeof(TModel).GetCustomAttribute<ConiziSchemaAttribute>();

            if (schemaAttribute == null)
                throw new InvalidOperationException("Class is no valid conizi model!");

            var settings = SerializerSettings;

            model.AddOrUpdateMetadata(new EdiMetadata
            {
                CreatedAt = DateTime.Now,
                CreatedBy = typeof(Converter).Namespace + " (" + typeof(Converter).Assembly.GetName().Version + ")",
            });
            
            var jsonString = JsonConvert.SerializeObject(model, settings);
            
            var conversionResult = new SerializationResult
            {
                Content = jsonString
            };

            if (ignoreValidation)
                return conversionResult;

            if (!Validator.ValidateSchema<TModel>(jsonString, out var validationErrors).IsValid)
            {
                conversionResult.ValidationErrors = validationErrors;
            }

            conversionResult.IsValidated = true;

            return conversionResult;
        }

        /// <summary>
        /// Deserialize a JSON file to an instance of a C# model.
        /// </summary>
        /// <typeparam name="TModel">The target C# model in which the JSON is to be deserialized</typeparam>
        /// <param name="json">The JSON content as string</param>
        /// <returns>Instance of the set model type</returns>
        /// <example>
        /// Deserialize JSON to C# <see cref="TourEvent"></see> model instance.
        /// <code>var m = Converter.Deserialize&lt;TourEvent&gt;(content);</code>
        /// </example>
        public static TModel Deserialize<TModel>(string json) where TModel : EdiModel
        {
            var result = JsonConvert.DeserializeObject<TModel>(json, SerializerSettings);
            
           return result;
        }
    }
}