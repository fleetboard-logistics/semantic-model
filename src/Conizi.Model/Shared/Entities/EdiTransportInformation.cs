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
    /// General information about the consignment
    /// </summary>
    
    [DisplayName("Information")]
    [Description("General information about the consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiTransportInformation : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Free text information for the invoice
        /// </summary>
        [DisplayName("Invoice remarks")]
        [Description("Free text information about the invoice")]
        public string RemarksInvoice { get; set; }

        /// <summary>
        /// Free text information for the pick up
        /// </summary>
        [DisplayName("Pickup remarks")]
        [Description("Free text information about the pick up")]
        public string RemarksPickup { get; set; }

        /// <summary>
        /// Free text information for the delivery
        /// </summary>
        [DisplayName("Delivery Remarks")]
        [Description("Free text information about the delivery")]
        public string RemarksDelivery { get; set; }

        /// <summary>
        /// General free text information
        /// </summary>
        [DisplayName("General remarks")]
        [Description("General free text information")]
        public string RemarksGeneral { get; set; }

        /// <summary>
        /// Free text information about the content of the order
        /// </summary>
        [DisplayName("Remarks content")]
        [Description("Free-text information about the content of the order")]
        public string RemarksContent { get; set; }
    }
}
