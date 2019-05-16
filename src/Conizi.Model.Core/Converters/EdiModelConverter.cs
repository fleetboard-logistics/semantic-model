using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Conizi.Model.Core.Tools;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace Conizi.Model.Core.Converters
{
    public class EdiModelConverter : JsonConverter<EdiModel>
    {
        public override void WriteJson(JsonWriter writer, EdiModel value, JsonSerializer serializer)
        {
            var schemaAttribute = value.GetType().GetCustomAttribute<ConiziSchemaAttribute>();

            if (schemaAttribute == null)
                throw new InvalidOperationException($"Class {value.GetType()} is no valid conizi model!");

            if (string.IsNullOrEmpty(value.Schema))
                value.Schema = schemaAttribute.Id;

            var obj = JObject.FromObject(value, serializer);
            
            obj.WriteTo(writer);
        }

        public override EdiModel ReadJson(JsonReader reader, Type objectType, EdiModel existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
