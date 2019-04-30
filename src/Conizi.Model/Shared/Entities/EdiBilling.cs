using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Information for invoicing and clearing
    /// </summary>
    [JsonObject("billing")]
    [DisplayName("Billing information")]
    [Description("Information for invoicing and clearing")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiBilling : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The party which receives the invoice (if different from the shipper)
        /// </summary>
        public EdiPartnerIdentification FreightPayer { get; set; }

        /// <summary>
        /// Use to specify a special tariff to be used for freight calculation (e.g. heavy goods, ...)
        /// </summary>
        [DisplayName("Tariff")]
        [Description("Use to specify a special tariff to be used for freight calculation (e.g. heavy goods, ...)")]
        public string Tariff { get; set; }

        /// <summary>
        /// Use to specify that the consignment results of a standing pickup order and specifies the partner which issued this pickup order and thus should be billed
        /// </summary>
        public EdiPartnerIdentification RoutingOrder { get; set; }

        /// <summary>
        /// Use to specify under which terms the consignment followed by this pickup order is process and which legs are billed to whom
        /// </summary>
        [DisplayName("Delivery terms")]
        [Description("Use to specify under which terms the consignment is process and which legs are billed to whom")]
        public string DeliveryTerms { get; set; }

        /// <summary>
        /// Used to active special billing and clearing conditions the partners have agreed on
        /// </summary>
        [DisplayName("Logistic model")]
        [Description("Used to active special billing and clearing conditions the partners have agreed on")]
        public string LogisticModel { get; set; }

        /// <summary>
        /// Used to transfer detailed information about the fees
        /// </summary>
        public CostsAndCharges CostsAndCharges { get; set; }
    }

    /// <summary>
    /// Used to transfer detailed information about the fees
    /// </summary>
    [JsonObject("costsAndCharges")]
    [DisplayName("Costs and charges")]
    [Description("Used to transfer detailed information about the fees")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class CostsAndCharges : EdiPatternPropertiesBase
    {

    }
}
