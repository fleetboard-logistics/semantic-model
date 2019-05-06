using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Events indicating new information that should be added/updated in the consignment
    /// </summary>
    [DisplayName("Change request")]
    [Description("A new delivery term that should be considered for billing")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEventChangeRequest : EdiEventBase
    {

        /// <summary>
        /// A new delivery term that should be considered for billing
        /// </summary>
        [DisplayName("Billing - Delivery term")]
        [Description("A new delivery term that should be considered for billing")]
        public bool? BillingDeliveryTerm { get; set; }

        /// <summary>
        /// The area occupied by the consignment - expressed in standard pallet sizes
        /// </summary>
        [DisplayName("Billing - Area (in pallet bays)")]
        [Description("The area occupied by the consignment - expressed in standard pallet sizes")]
        public string BillingAreaPalletBays { get; set; }

        /// <summary>
        /// The area occupied by the consignment - expressed in loading meters
        /// </summary>
        [DisplayName("Billing - Loading meter")]
        [Description("The area occupied by the consignment - expressed in loading meters")]
        public string BillingLoadingMeter { get; set; }

    }
}