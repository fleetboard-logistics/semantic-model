using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("customsInformation")]
    [DisplayName("Customs information")]
    [Description("Used to specifiy information necessary in the customs process")]
    [ConiziAdditionalProperties(false)]
    public class EdiCustomsInformation
    {
        public EdiAddress DeclaringParty { get; set; }

        public EdiAddress DeliverAfterDutyPaid { get; set; }

        [DisplayName("Presentation deadline")]
        public string PresentationDeadline { get; set; }

        [DisplayName("Cleared for free transit within EU")]
        public bool ClearedForFreeTransitWithinEU { get; set; }

        [DisplayName("Envelope for customs documents")]
        public bool EnvelopeForCustomsDocuments { get; set; }

        [DisplayName("Presentation to customs require")]
        public bool PresentationToCustomsRequired { get; set; }

        public ValueAtBorderCrossing ValueAtBorderCrossing { get; set; }

    }

    [JsonObject("valueAtBorderCrossing")]
    [DisplayName("Value at border crossing")]
    [Description("Value at border crossing")]
    [ConiziAdditionalProperties(false)]
    public class ValueAtBorderCrossing
    {
        [DisplayName("Amount")]
        [Description("Amount")]
        public decimal Amount { get; set; }

        [DisplayName("Currency")]
        [Description("Currency")]
        public string Currency { get; set; }
    }
}
