using System.ComponentModel;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    public class EdiDocument
    {
        [JsonProperty("receiver")]
        public EdiPartnerIdentification Receiver { get; set; }
        [JsonProperty("sender")]
        public EdiPartnerIdentification Sender { get; set; }
        public EdiNetwork Network { get; set; }
    }
}