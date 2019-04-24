using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Threading;
using Conizi.Model.Core.Conversion.Converters;
using Conizi.Model.Core.Entities;
using Conizi.Model.Core.Validate;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Conizi.Model.Core.Conversion
{
    public static class Converter
    {
        static Converter()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        }


        public static JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
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

        public static SerializationResult Serialize<TModel>(TModel model, bool indented = false,
            bool ignoreValidation = false) where TModel : EdiModel
        {
            var schemaAttribute = typeof(TModel).GetCustomAttribute<ConiziSchemaAttribute>();

            if (schemaAttribute == null)
                throw new InvalidOperationException("Class is no valid conizi model!");

            if (string.IsNullOrEmpty(model.Schema))
                model.Schema = schemaAttribute.Id;

            var settings = SerializerSettings;


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

        public static TModel Deserialize<TModel>(string json) where TModel : EdiModel
        {
            var result = JsonConvert.DeserializeObject<TModel>(json, SerializerSettings);
            
           return result;
        }
    }
}