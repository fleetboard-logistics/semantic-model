using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Converters
{
  /// <summary>
  /// Converts a C# <see cref="DateTime"/> to a ISO conform string yyyy-MM-dd
  /// </summary>
  public class ConiziDateConverter : JsonConverter<DateTime?>
  {
    /// <summary>
    /// <inheritdoc cref="JsonConverter"/>
    /// </summary>
    public override void WriteJson(JsonWriter writer, DateTime? value, JsonSerializer serializer)
    {
      if (value.HasValue)
        writer.WriteValue(DateTime.SpecifyKind(value.Value, DateTimeKind.Utc).ToString("yyyy-MM-dd"));
    }

    /// <summary>
    /// <inheritdoc cref="JsonConverter"/>
    /// </summary>
    public override DateTime? ReadJson(JsonReader reader, Type objectType, DateTime? existingValue, bool hasExistingValue,
        JsonSerializer serializer)
    {
      //if (!hasExistingValue)
      //  return DateTime.SpecifyKind(default(DateTime), DateTimeKind.Utc);
      if (reader.Value != null)
      {
        var utcDate = DateTime.SpecifyKind(DateTime.Parse(reader.Value.ToString(), new CultureInfo("en-US")), DateTimeKind.Utc);
        return utcDate;
      }
      else
        return null;
    }

    public override bool CanRead => true;
  }
}
