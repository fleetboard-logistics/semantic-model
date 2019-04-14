using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Core.Conversion.Converters
{
    public class DateTimeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public bool CheckIfNeeded(Type objectType)
        {
            var combinedAttributes = new List<Type>()
            {
                typeof(ConiziDateOnlyAttribute),
                //typeof(ConiziTimeOnlyAttribute)
            };

            var coniziDateAvailable =
                objectType.CustomAttributes.Any(x => combinedAttributes.Contains(x.AttributeType));

            return coniziDateAvailable;
        }

        public override bool CanConvert(Type objectType)
        {
            return false; //CheckIfNeeded(objectType.);
        }
    }
}
