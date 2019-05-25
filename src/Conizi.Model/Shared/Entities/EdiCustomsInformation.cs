using System;
using System.Collections.Generic;
using System.ComponentModel;
using Conizi.Model.Converters;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Used to specify information necessary in the customs process
    /// </summary>
    
    [DisplayName("Customs information")]
    [Description("Used to specify information necessary in the customs process")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiCustomsInformation : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Declaring party
        /// </summary>
        public EdiPartnerIdentification DeclaringParty { get; set; }

        /// <summary>
        /// Delivery after customs clearance
        /// </summary>
        public EdiPartnerIdentification DeliverAfterDutyPaid { get; set; }

        /// <summary>
        /// Presentation deadline
        /// </summary>
        [DisplayName("Presentation deadline")]
        public string PresentationDeadline { get; set; }

        /// <summary>
        /// Cleared for free transit within EU
        /// </summary>
        [DisplayName("Cleared for free transit within EU")]
        [JsonProperty("ClearedForFreeTransitWithinEU")]
        public bool? ClearedForFreeTransitWithinEu { get; set; }

        /// <summary>
        /// Envelope for customs documents
        /// </summary>
        [DisplayName("Envelope for customs documents")]
        public bool? EnvelopeForCustomsDocuments { get; set; }

        /// <summary>
        /// Presentation to customs require
        /// </summary>
        [DisplayName("Presentation to customs require")]
        public bool? PresentationToCustomsRequired { get; set; }

        /// <summary>
        /// Value of the goods at border crossing
        /// </summary>
        public EdiValueAtBorderCrossing ValueAtBorderCrossing { get; set; }

        /// <summary>
        /// City unloading
        /// </summary>
        [DisplayName("City unloading")]
        public string CityUnloading { get; set; }

        /// <summary>
        /// Customs office
        /// </summary>
        [DisplayName("Customs office")]
        public string CustomsOffice { get; set; }

        /// <summary>
        /// Customs process
        /// </summary>
        [DisplayName("Customs process")]
        public string CustomsProcess { get; set; }

        /// <summary>
        /// Customs type
        /// </summary>
        [DisplayName("Customs type")]
        public string CustomsType { get; set; }

        /// <summary>
        /// District unloading
        /// </summary>
        [DisplayName("District unloading")]
        public string DistrictUnloading { get; set; }

        /// <summary>
        /// Import customs offic
        /// </summary>
        [DisplayName("Import customs office")]
        public string ImportCustomsOffice { get; set; }

        /// <summary>
        /// Parent document id"
        /// </summary>
        [DisplayName("Parent document id")]
        public string ParentDocumentId { get; set; }

        /// <summary>
        /// Parent document type
        /// </summary>
        [DisplayName("Parent document type")]
        public string ParentDocumentType { get; set; }

        /// <summary>
        /// Route border
        /// </summary>
        [DisplayName("Route border")]
        public string RouteBorder { get; set; }

        /// <summary>
        /// Route inland
        /// </summary>
        [DisplayName("Route inland")]
        public string RouteInland { get; set; }

        /// <summary>
        /// Statistics flag
        /// </summary>
        [DisplayName("Statistics flag")]
        public string StatisticsFlag { get; set; }

        /// <summary>
        /// Transfer type
        /// </summary>
        [DisplayName("Transfer type")]
        public string TransferType { get; set; }

        /// <summary>
        /// Country consignor
        /// </summary>
        [DisplayName("Country consignor")]
        public string CountryConsignor { get; set; }

        /// <summary>
        /// Country importer
        /// </summary>
        [DisplayName("Country importer")]
        public string CountryImporter { get; set; }

        /// <summary>
        /// Country loading
        /// </summary>
        [DisplayName("Country loading")]
        public string CountryLoading { get; set; }

        /// <summary>
        /// Country of origin
        /// </summary>
        [DisplayName("Country of origin")]
        public string CountryOfOrigin { get; set; }

        /// <summary>
        /// Country unloading
        /// </summary>
        [DisplayName("Country unloading")]
        public string CountryUnloading { get; set; }

        /// <summary>
        /// Custom documents
        /// </summary>
        public List<EdiCustomsDocuments> Documents { get; set; }
    }

    /// <summary>
    /// Value of the goods at border crossing
    /// </summary>
    
    [DisplayName("Value at border crossing")]
    [Description("Value at border crossing")]
    [ConiziAdditionalProperties(false)]
    public class EdiValueAtBorderCrossing
    {
        /// <summary>
        /// Amount
        /// </summary>
        [DisplayName("Amount")]
        [Description("Amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        [DisplayName("Currency")]
        [Description("Currency")]
        public string Currency { get; set; }
    }

    /// <summary>
    /// Customs documents
    /// </summary>
    
    [DisplayName("Customs documents")]
    [Description("Customs documents")]
    [ConiziAdditionalProperties(false)]
    public class EdiCustomsDocuments
    {
        /// <summary>
        /// Type
        /// </summary>
        [DisplayName("Type")]
        [Description("Type")]
        public string Type { get; set; }

        /// <summary>
        /// Number
        /// </summary>
        [DisplayName("Number")]
        [Description("Number")]
        public string Number { get; set; }

        /// <summary>
        /// Date
        /// </summary>
        [DisplayName("Date")]
        [Description("Date")]
        [JsonConverter(typeof(ConiziDateConverter))]
        [ConiziDateOnly]
        public DateTime Date { get; set; }
    }
}