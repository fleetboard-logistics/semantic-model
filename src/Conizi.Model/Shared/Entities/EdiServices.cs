using System.ComponentModel;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("services")]
    [DisplayName("Services")]
    [Description("Special services which can be requested by the ordering party (or the shipping partner)")]
    public class EdiServices
    {
        public string NetworkId { get; set; }
        public string Codelist { get; set; }
        public string Product { get; set; }
    }
}