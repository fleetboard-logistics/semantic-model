using System;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json;

namespace Conizi.Model.Archiving
{


    [ConiziSchema("http://conizi.io/model/archiving/proof-of-delivery.json", "proof-of-delivery.json")]
    [DisplayName("Proof of Delivery")]
    public class ProofOfDelivery : EdiModel 
    {
        [JsonProperty(Required = Required.Always)]
        public new EdiPartnerIdentification Sender { get; set; }

        [JsonProperty(Required = Required.Always)]
        public new EdiPartnerIdentification Receiver { get; set; }

        [JsonProperty(Required = Required.Always)]
        public EdiPartnerIdentification Consignee { get; set; }

        [JsonProperty(Required = Required.Always)]
        public EdiPartnerIdentification Shipper { get; set; }

        public EdiPartnerIdentification Carrier { get; set; }

        public EdiPartnerIdentification ReceivingPartner { get; set; }
        public EdiPartnerIdentification ShippingPartner { get; set; }

        [JsonProperty("content")]
        public EdiFileContent Content { get; set; }

        /// <summary>
        ///  POD Id
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Id { get; set; }

        /// <summary>
        /// Reference Number (consignment)
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string RefNo { get; set; }

        public DateTime ShippingDate { get; set; }
        [JsonProperty(Required = Required.Always)]
        public DateTime DocumentCreationDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime PlannedShippingDate { get; set; }

        public EdiSignature Signature { get; set; }
    }

   
}
