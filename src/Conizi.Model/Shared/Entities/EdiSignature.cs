using System;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("signature")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiSignature : EdiPatternPropertiesBase
    {
        [JsonProperty(Required = Required.Always)]
        public bool SignatureAvailable { get; set; }
        public string SigneeName { get; set; }
        [JsonProperty(Required = Required.Always)]
        public DateTime SignatureDate { get; set; }

        [ConiziAnyOf]
        public EdiFileContent SignatureContent { get; set; }
    }
}