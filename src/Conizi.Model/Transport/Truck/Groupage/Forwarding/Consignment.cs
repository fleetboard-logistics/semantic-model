using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{
    [ConiziSchema("https://model.conizi.io/v1.23/transport/truck/groupage/forwarding/consignment.json", "consignment.json")]
    [DisplayName("Consignment")]
    [Description("A single consignment which is transferred between two partners. Usually used within the context a manifest")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class Consignment : EdiDocument
    {

        [DisplayName("Unique central consignment number")]
        public string ConsignmentObjectId { get; set; }
        [DisplayName("Consignment number of the shipping partner")]
        public string ConsignmentNoShippingPartner { get; set; }
        [DisplayName("Consignment number of the receiving partner")]
        public string ConsignmentNoReceivingPartner { get; set; }

        [DisplayName("Shipping date")] 
        [JsonProperty(PropertyName = "shippingDate",Required = Required.Always)]
        [ConiziDateOnly]
        public DateTime ShippingDate { get; set; }

        [DisplayName("Manifest id of the shipping partner")]
        public string ManifestId { get; set; }

        [DisplayName("Is a pre advice")]
        public bool IsPreAdvice { get; set; }

        public List<EdiPartnerIdentification> AdditionalPartners { get; set; }

        public EdiAddress OrderingParty { get; set; }

        [JsonRequired]
        public EdiPartnerIdentification ShippingPartner { get; set; }

        [JsonRequired]
        public EdiPartnerIdentification ReceivingPartner { get; set; }

        public EdiRouting Routing { get; set; }

        public EdiServices Services { get; set; }

        public EdiExternalServices ExternalServices { get; set; }

        public EdiInformation Information { get; set; }

        public EdiReferences References { get; set; }

        public EdiBilling Billing { get; set; }

        public EdiCustomsInformation CustomsInformation { get; set; }

        public EdiContent Content { get; set; }
    }
}
