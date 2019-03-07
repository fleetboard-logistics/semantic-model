using System.ComponentModel;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    public class EdiDocument
    {
        [JsonProperty("receiver", Required = Required.DisallowNull)]
        public EdiPartnerIdentification Receiver { get; set; }

        [JsonProperty("sender", Required = Required.DisallowNull)]
        public EdiPartnerIdentification Sender { get; set; }

        [JsonProperty("network", Required = Required.DisallowNull)]
        public EdiNetwork Network { get; set; }
    }
}