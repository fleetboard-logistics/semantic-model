using System.ComponentModel;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    public class EdiDocument
    {
        [JsonProperty("receiver", IsReference = true)]
        public EdiPartnerIdentification Receiver { get; set; }
        [JsonProperty("sender", IsReference = true)]
        public EdiPartnerIdentification Sender { get; set; }
        public EdiNetwork Network { get; set; }
    }
}