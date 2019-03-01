using System;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json;

namespace Conizi.Model.Archiving
{

    [ConiziSchema("http://conizi.io/model/archiving/proof-of-delivery.json", "proof-of-delivery.json")]
    [DisplayName("Proof of Delivery")]
    public class ProofOfDelivery : EdiDocument 
    {
        [JsonProperty(Required = Required.Always)]
        public override EdiSender Sender { get; set; }

        [JsonProperty(Required = Required.Always)]
        public override EdiReceiver Receiver { get; set; }

        [JsonProperty(Required = Required.Always)]
        public EdiAddress Consignee { get; set; }

        [JsonProperty(Required = Required.Always)]
        public EdiAddress Shipper { get; set; }

        public EdiAddress Carrier { get; set; }

        public EdiPartner ReceivingPartner { get; set; }
        public EdiPartner ShippingPartner { get; set; }

        [JsonProperty("content", IsReference = false, ItemIsReference = false)]
        public ConiziOneOf<EdiFileData, EdiFileReference> Content { get; set; }

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
    }

   
}
