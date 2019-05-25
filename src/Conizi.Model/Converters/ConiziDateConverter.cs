using System;
using System.Collections.Generic;
using System.Linq;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Converters
{
    /// <summary>
    /// Converts a C# <see cref="DateTime"/> to a ISO conform string yyyy-MM-dd
    /// </summary>
    public class ConiziDateConverter : JsonConverter<DateTime>
    {
        /// <summary>
        /// <inheritdoc cref="JsonConverter"/>
        /// </summary>
        public override void WriteJson(JsonWriter writer, DateTime value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString("yyyy-MM-dd"));
        }

        /// <summary>
        /// <inheritdoc cref="JsonConverter"/>
        /// </summary>
        public override DateTime ReadJson(JsonReader reader, Type objectType, DateTime existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            if (!hasExistingValue)
                return default(DateTime);

            return existingValue;
        }

        public override bool CanRead => false;
    }
}
