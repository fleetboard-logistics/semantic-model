using System;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Base model in the conizi context
    /// </summary>
    public class 
        EdiModel : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The id (URI) of the model
        /// </summary>
        [JsonProperty("$schema", Required = Required.Always, Order = -999)]
        [DisplayName("Json schema")]
        [Description("The used json schema")]
        public string Schema { get; internal set; }

        [JsonProperty("receiver", Required = Required.Always, Order = -998)]
        public EdiMessageRouting Receiver { get; set; }

        [JsonProperty("sender", Required = Required.DisallowNull, Order = -997)]
        public EdiMessageRouting Sender { get; set; }

        //[JsonProperty("receiver", Required = Required.DisallowNull, Order = -998)]
        //public EdiPartnerIdentification Receiver { get; set; }

        //[JsonProperty("sender", Required = Required.DisallowNull, Order = -997)]
        //public EdiPartnerIdentification Sender { get; set; }

        [JsonProperty("network", Required = Required.DisallowNull, Order = -996)]
        public EdiNetwork Network { get; set; }

    }

    [JsonObject("converterInfo")]
    [DisplayName("Converter info")]
    [Description("conizi internal information about the converter process")]
    [ConiziAdditionalProperties(false)]
    public class ConverterInfo
    {
        [DisplayName("Original format")]
        [Description("The original format like FORTRAS...")]
        public string OriginalFormat { get; set; }

        [DisplayName("Original codelist")]
        [Description("The original code list like SYA, SAE...")]
        public string OriginalCodelist { get; set; }

        [DisplayName("Converter version")]
        [Description("The version string of the converter")]
        public string ConverterVersion { get; set; }

        [DisplayName("Converter name")]
        [Description("The name of the used converter")]
        public string ConverterName { get; set; }

        [DisplayName("Conversion date")]
        [Description("The date of conversion")]
        public DateTime ConversionDate { get; set; }
    }

  
}