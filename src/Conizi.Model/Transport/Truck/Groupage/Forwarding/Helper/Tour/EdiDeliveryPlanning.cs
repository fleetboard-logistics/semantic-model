using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding.Helper.Tour
{
    /// <summary>
    /// Events occured while planning the delivery of the consignment
    /// </summary>
    [DisplayName("Delivery planning")]
    [Description("Events occured while planning the delivery of the consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiDeliveryPlanning : EdiEventBase
    {
       
        /// <summary>
        /// Detailed information about the exceptions that occured while planning the delivery of the consignment.
        /// Use (null) to report successful processing of the consignment
        /// </summary>
        public EdiDeliveryPlanningExceptions Exceptions { get; set; }
    }
}