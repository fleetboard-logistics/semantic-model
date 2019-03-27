using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace Conizi.Model.Core.Conversion.Converters
{
    public class PatternPropertyConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {

            var patternProperties = value as EdiPatternPropertiesBase;

            if (patternProperties == null)
                return;
            var o = JObject.FromObject(value, new JsonSerializer
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = Converter.SerializerSettings.NullValueHandling,
                DefaultValueHandling = Converter.SerializerSettings.DefaultValueHandling,
                MissingMemberHandling = Converter.SerializerSettings.MissingMemberHandling
            });

            var combinedSchemaConverter = new CombinedSchemaConverter();

            if(combinedSchemaConverter.CheckIfNeeded(value.GetType()))
                combinedSchemaConverter.HandleCombinedSchemas(o,value.GetType());

            foreach (var property in patternProperties.GetInstancePatternProperies())
            {
                o.Last.AddAfterSelf(new JProperty(property.Name, property.Value));
            }

            o.WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            if(objectType ==  typeof(List<EdiPatternProperty>))
                return false;

            var custAttribute = objectType.CustomAttributes
                .FirstOrDefault(a => a.AttributeType == typeof(ConiziAllowXPropertiesAttribute));

            if (custAttribute == null)
                return false;

            return Convert.ToBoolean(custAttribute.ConstructorArguments[0].Value);
        }
    }
}
