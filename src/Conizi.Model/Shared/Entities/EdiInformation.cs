using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("information")]
    [DisplayName("Information")]
    [Description("General information about the consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiInformation : EdiPatternPropertiesBase
    {
        [DisplayName("Invoice remarks")]
        [Description("Free text information for the invoice")]
        public List<string> RemarksInvoice { get; set; }

        [DisplayName("Pickup remarks")]
        [Description("Free text information for the pick up")]
        public List<string> RemarksPickup { get; set; }

        [DisplayName("Delivery Remarks")]
        [Description("Free text information for the delivery")]
        public List<string> RemarksDelivery { get; set; }

        [DisplayName("General remarks")]
        [Description("General free text information")]
        public List<string> RemarksGeneral { get; set; }
    }
}
