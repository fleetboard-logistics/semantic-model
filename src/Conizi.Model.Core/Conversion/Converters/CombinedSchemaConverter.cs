using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using Conizi.Model.Core.Extensions;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace Conizi.Model.Core.Conversion.Converters
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class CombinedSchemaConverter : JsonConverter
    {

        public void HandleCombinedSchemas(JObject jObject, Type objectType)
        {
            var knownTypes = objectType.GetCustomAttributes().Where(a => a is KnownTypeAttribute)
                .Cast<KnownTypeAttribute>().ToList();

            if (!knownTypes.Any())
                return;

            var combinedProps = new List<string>();

            foreach (var propertyInfo in objectType.GetProperties())
            {
                var isKnownType = knownTypes.Any(x => x.Type == propertyInfo.PropertyType);

                if (!isKnownType)
                    continue;

                var jp = propertyInfo.CustomAttributes.FirstOrDefault(a =>
                    a.AttributeType == typeof(JsonPropertyAttribute));

                var name = jp == null ? propertyInfo.Name.ToCamelCase() :
                    jp.ConstructorArguments.Count == 1 ? jp.ConstructorArguments[0].Value.ToString() :
                    propertyInfo.Name.ToCamelCase();

                combinedProps.Add(name);
            }

            if (!combinedProps.Any())
                return;

            var propsToReorder = jObject.Properties().Where(knownObject => combinedProps.Contains(knownObject.Name)).ToList();

            foreach (var prop in propsToReorder)
            {
                jObject.Remove(prop.Name);

                foreach (var jToken in prop.Children())
                {
                    if (jToken.Type == JTokenType.Object)
                    {
                        foreach (var child in jToken.Children())
                        {
                            jObject.Add(child);
                        }
                        continue;
                    }

                    jObject.Add(jToken);
                }
            }

        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
          

            var o = JObject.FromObject(value, new JsonSerializer
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = Converter.SerializerSettings.NullValueHandling,
                DefaultValueHandling = Converter.SerializerSettings.DefaultValueHandling,
                MissingMemberHandling = Converter.SerializerSettings.MissingMemberHandling
            });

            this.HandleCombinedSchemas(o, value.GetType());
       
            o.WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }


        public bool CheckIfNeeded(Type objectType)
        {
            var combinedAttributes = new List<Type>()
            {
                typeof(ConiziOneOfAttribute),
                typeof(ConiziAnyOfAttribute),
                typeof(ConiziAllOfAttribute)
            };

            var combinedSchemaAvailable =
                objectType.CustomAttributes.Any(x => combinedAttributes.Contains(x.AttributeType));

            return combinedSchemaAvailable;
        }

        public override bool CanConvert(Type objectType)
        {
            return CheckIfNeeded(objectType);
        }
    }
}