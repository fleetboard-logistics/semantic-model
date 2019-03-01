using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("partner")]
    public class EdiPartner : EdiAddress
    {
        public string PartnerId { get; set; }   
    }
}
