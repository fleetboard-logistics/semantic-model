using System.ComponentModel;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("routing")]
    public class EdiRouting 
    {
        public EdiPartnerIdentification Shipper { get; set; }
        public EdiPartnerIdentification Consignee { get; set; }
        public EdiPartnerIdentification LoadingAddress { get; set; }
        public EdiPartnerIdentification UnloadingAddress { get; set; }
    }
}