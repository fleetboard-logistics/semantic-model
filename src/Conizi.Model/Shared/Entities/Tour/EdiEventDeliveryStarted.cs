using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities.Tour
{
    /// <summary>
    /// Events indicating the start of the delivery
    /// </summary>
    [DisplayName("Delivery started")]
    [Description("Events indicating the start of the delivery")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEventDeliveryStarted: EdiEventBase
    {
        /// <summary>
        /// Number of the planned / assigned local traffic tour for delivery
        /// </summary>
        [DisplayName("Tour number")]
        [Description("Number of the planned / assigned local traffic tour for delivery")]
        public string TourNumber { get; set; }

        public EdiDeliveryStartedExceptions Exceptions { get; set; }

    }
}