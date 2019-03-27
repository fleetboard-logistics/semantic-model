using System;
using System.Collections.Generic;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("customsInformation")]
    [DisplayName("Customs information")]
    [Description("Used to specifiy information necessary in the customs process")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiCustomsInformation : EdiPatternPropertiesBase
    {
        public EdiPartnerIdentification DeclaringParty { get; set; }

        public EdiPartnerIdentification DeliverAfterDutyPaid { get; set; }

        [DisplayName("Presentation deadline")]
        public string PresentationDeadline { get; set; }

        [DisplayName("Cleared for free transit within EU")]
        public bool ClearedForFreeTransitWithinEU { get; set; }

        [DisplayName("Envelope for customs documents")]
        public bool EnvelopeForCustomsDocuments { get; set; }

        [DisplayName("Presentation to customs require")]
        public bool PresentationToCustomsRequired { get; set; }

        public EdiValueAtBorderCrossing ValueAtBorderCrossing { get; set; }

        [DisplayName("City unloading")]
        public string CityUnloading { get; set; }
        [DisplayName("Customs office")]
        public string CustomsOffice { get; set; }
        [DisplayName("Customs process")]
        public string CustomsProcess { get; set; }
        [DisplayName("Customs type")]
        public string CustomsType { get; set; }
        [DisplayName("District unloading")]
        public string DistrictUnloading { get; set; }
        [DisplayName("Import customs office")]
        public string ImportCustomsOffice { get; set; }
        [DisplayName("Parent document id")]
        public string ParentDocumentId { get; set; }
        [DisplayName("Parent document type")]
        public string ParentDocumentType { get; set; }
        [DisplayName("Route border")]
        public string RouteBorder { get; set; }
        [DisplayName("Route inland")]
        public string RouteInland { get; set; }
        [DisplayName("Statistics flag")]
        public string StatisticsFlag { get; set; }
        [DisplayName("Transfer type")]
        public string TransferType { get; set; }
        [DisplayName("Country consignor")]
        public string CountryConsignor { get; set; }
        [DisplayName("Country importer")]
        public string CountryImporter { get; set; }
        [DisplayName("Country loading")]
        public string CountryLoading { get; set; }
        [DisplayName("Country of origin")]
        public string CountryOfOrigin { get; set; }
        [DisplayName("Country unloading")]
        public string CountryUnloading { get; set; }

        public List<EdiCustomsDocuments> Documents { get; set; }
    }

    [JsonObject("valueAtBorderCrossing")]
    [DisplayName("Value at border crossing")]
    [Description("Value at border crossing")]
    [ConiziAdditionalProperties(false)]
    public class EdiValueAtBorderCrossing
    {
        [DisplayName("Amount")]
        [Description("Amount")]
        public decimal Amount { get; set; }

        [DisplayName("Currency")]
        [Description("Currency")]
        public string Currency { get; set; }
    }

    [JsonObject("documents")]
    [DisplayName("Custom documents")]
    [Description("Custom documents")]
    [ConiziAdditionalProperties(false)]
    public class EdiCustomsDocuments
    {
        [DisplayName("Type")]
        [Description("Type")]
        public string Type { get; set; }

        [DisplayName("Number")]
        [Description("Number")]
        public string Number { get; set; }

        [DisplayName("Date")]
        [Description("Date")]
        [ConiziDateOnly]
        public DateTime Date { get; set; }
    }
}