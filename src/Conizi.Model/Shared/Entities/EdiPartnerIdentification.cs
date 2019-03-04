using System.ComponentModel;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    
    [DisplayName("Fields to identify the partner")]
    [JsonObject("partnerIdentification")]
    public  class EdiPartnerIdentification
    {
        [DisplayName("The Edi Id (e.g. CONIZVK)")]
        public string EdiId { get; set; }

        [DisplayName("The PartnerId (e.g. 1234)")]
        public string PartnerId { get; set; }

        public EdiAddress Address { get; set; }

        [DisplayName("The conizi id for internal routing purposes")]
        public string ConiziId { get; set; }
    }
}