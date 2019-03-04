using System.ComponentModel;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("routing")]
    public class EdiRouting 
    {
        public EdiAddress Shipper { get; set; }
        public EdiAddress Consignee { get; set; }
        public EdiAddress LoadingAddress { get; set; }
        public EdiAddress UnloadingAddress { get; set; }
    }
}