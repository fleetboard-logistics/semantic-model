using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("references")]
    [DisplayName("References")]
    [Description("Numbers of various sources identifing this consignment or references from this consignment to other business processes")]
    [ConiziAdditionalProperties(false)]
    public class EdiReferences
    {
        public EdiReturnOfPreviousConsignment ReturnOfPreviousConsignment { get; set; }
    }


    [JsonObject("returnOfPreviousConsignment")]
    [DisplayName("Return of previous consignment")]
    [Description("Reference to another consignment which content is return using this consignment")]
    [ConiziAdditionalProperties(false)]
    public class EdiReturnOfPreviousConsignment
    {
        [DisplayName("Consignment number of the consignment being returned")]
        [Description("The consignment number of the original consignment being returned")]
        public string ConsignmentNoShippingPartner { get; set; }
        
        [DisplayName("Shipping date")]
        [Description("The date when the original shipment was forwarded")]
        [ConiziDateOnly]
        public DateTime ShippingDate { get; set; }

        [DisplayName("Shipping partner")]
        [Description("The partner which originally forwarded the consignment")]
        public EdiPartnerIdentification ShippingPartner { get; set; }
    }

}
