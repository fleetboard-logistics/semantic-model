using System;
using System.Linq;
using System.Reflection;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Conizi.Model.Core.Conversion
{
    public static class Converter
    {
        public static string Serialize<TModel>(TModel model, bool indented = false, bool ignoreValidation = false) where TModel : EdiDocument
        {
            var schemaAttribute = typeof(TModel).GetCustomAttribute<ConiziSchemaAttribute>();

            if (schemaAttribute == null)
                throw new InvalidOperationException("Class is no valid conizi model!");

            if (string.IsNullOrEmpty(model.Schema))
                model.Schema = schemaAttribute.Id;

            var settings = new JsonSerializerSettings
            {
                Formatting = indented ? Formatting.Indented : Formatting.None,
                NullValueHandling = NullValueHandling.Include,
                DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            var jsonString = JsonConvert.SerializeObject(model, settings);
            return jsonString;

            
            
        }
    }
}