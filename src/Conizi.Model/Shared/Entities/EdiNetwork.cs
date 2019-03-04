using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("network")]
    public class EdiNetwork
    {
        public string NetworkId { get; set; }
        public string Codelist { get; set; }
        public string Product { get; set; }
    }
}