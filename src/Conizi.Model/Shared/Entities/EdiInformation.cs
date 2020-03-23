using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel;

    namespace Conizi.Model.Shared.Entities
    {
        /// <summary>
        /// General information about the consignment
        /// </summary>

        [DisplayName("Information")]
        [Description("General information about the consignment")]
        [ConiziAdditionalProperties(false)]
        [ConiziAllowXProperties]
        public class EdiInformation : EdiPatternPropertiesBase
        {
            /// <summary>
            /// Free text information for the invoice
            /// </summary>
            [DisplayName("Invoice remarks")]
            [Description("Free text information for the invoice")]
            public List<string> RemarksInvoice { get; set; }

            /// <summary>
            /// Free text information for the pick up
            /// </summary>
            [DisplayName("Pickup remarks")]
            [Description("Free text information for the pick up")]
            public List<string> RemarksPickup { get; set; }

            /// <summary>
            /// Free text information for the delivery
            /// </summary>
            [DisplayName("Delivery Remarks")]
            [Description("Free text information for the delivery")]
            public List<string> RemarksDelivery { get; set; }

            /// <summary>
            /// General free text information
            /// </summary>
            [DisplayName("General remarks")]
            [Description("General free text information")]
            public List<string> RemarksGeneral { get; set; }
        }
    }
}
