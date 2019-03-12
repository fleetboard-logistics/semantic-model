using System;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("signature")]
    [ConiziAllowXProperties]
    public class EdiSignature
    {
        [JsonProperty(Required = Required.Always)]
        public bool SignatureAvailable { get; set; }
        public string SigneeName { get; set; }
        [JsonProperty(Required = Required.Always)]
        public DateTime SignatureDate { get; set; }

        [ConiziAnyOf]
        public EdiFileBase SignatureContent { get; set; }
    }
}