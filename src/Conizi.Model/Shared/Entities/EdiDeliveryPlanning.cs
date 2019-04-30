using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Events occurred while planning the delivery of the consignment
    /// </summary>
    [DisplayName("Delivery planning")]
    [Description("Events occurred while planning the delivery of the consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiDeliveryPlanning : EdiEventBase
    {
       
        /// <summary>
        /// Detailed information about the exceptions that occurred while planning the delivery of the consignment.
        /// Use (null) to report successful processing of the consignment
        /// </summary>
        public EdiDeliveryPlanningExceptions Exceptions { get; set; }
    }
}