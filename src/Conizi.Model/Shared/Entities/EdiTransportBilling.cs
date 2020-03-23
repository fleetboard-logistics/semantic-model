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
    /// <summary>
    /// Financial information about this transport
    /// </summary>

    [DisplayName("Transport Billing")]
    [Description("Financial information about this transport")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiTransportBilling : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Cash is paid on Delivery
        /// </summary>
        [DisplayName("Cash on Delivery")]
        [Description("Cash is paid on Delivery")]
        public bool? CashOnDelivery { get; set; }

        /// <summary>
        /// Person / Company paying for the transport
        /// </summary>
        public EdiAddress FreightPayer { get; set; }

        /// <summary>
        /// Agreed price with customer
        /// </summary>
        public EdiCostsAndCharges PriceCustomer { get; set; }

        /// <summary>
        /// Agreed price with carrier
        /// </summary>
        public EdiCostsAndCharges PriceCarrier { get; set; }

        /// <summary>
        /// Value of the transported goods
        /// </summary>
        public EdiCostsAndCharges ValueGoods { get; set; }

    }

    /// <summary>
    /// Costs and charges for this transport
    /// </summary>
    [DisplayName("Costs and charges")]
    [Description("Costs and charges for this transport")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiCostsAndCharges : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Amount of the object in Euro
        /// </summary>
        [DisplayName("Amount")]
        [Description("Amount of the object in Euro")]
        public  decimal? Amount { get; set; }

        /// <summary>
        /// Currency of the object as ISO-4217 (EUR, USD...)
        /// </summary>
        [DisplayName("Currency")]
        [Description("Currency of the object as ISO-4217 (EUR, USD...)")]
        public string Currency { get; set; }

    }
}
