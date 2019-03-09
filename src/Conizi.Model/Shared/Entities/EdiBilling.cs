using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("billing")]
    [DisplayName("Billing information")]
    [Description("Information for invoicing and clearing")]
    [ConiziAdditionalProperties(false)]
    public class EdiBilling
    {
        public EdiAddress FreightPayer { get; set; }

        [DisplayName("Tariff")]
        [Description("Use to specify a special tariff to be used for freight calculation (e.g. heavy goods, ...)")]
        public string Tariff { get; set; }

        public EdiPartnerIdentification RoutingOrder { get; set; }

        [DisplayName("Delivery terms")]
        [Description("Use to specify under which terms the consignment is process and which legs are billed to whom")]
        public string DeliveryTerms { get; set; }

        [DisplayName("Logistic model")]
        [Description("Used to active special billing and clearing conditions the partners have agreed on")]
        public string LogisticModel { get; set; }

        public CostsAndCharges CostsAndCharges { get; set; }
    }


    [JsonObject("costsAndCharges")]
    [DisplayName("Costs and charges")]
    [Description("Used to transfer detailed information about the fees")]
    [ConiziAdditionalProperties(false)]
    public class CostsAndCharges
    {

    }
}
