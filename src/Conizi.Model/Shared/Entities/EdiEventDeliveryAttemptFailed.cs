using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Events indicating a failed delivery attempt
    /// </summary>
    [DisplayName("Delivery attempt failed")]
    [Description("Events indicating a failed delivery attempt")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEventDeliveryAttemptFailed : EdiEventBase
    {
        /// <summary>
        /// Number of the consignment which is used to return the goods to the shipper
        /// </summary>
        [DisplayName("Return consignment no")]
        [Description("Number of the consignment which is used to return the goods to the shipper")]
        public string ReturnConsignmentNo { get; set; }



        /// <summary>
        /// Name of the person which rejected the consignment
        /// </summary>
        [DisplayName("Signee")]
        [Description("Name of the person which rejected the consignment")]
        public string Signee { get; set; }

        /// <summary>
        /// Time spent waiting during delivery
        /// </summary>
        [DisplayName("Wait time")]
        [Description("Time spent waiting during delivery")]
        public string WaitTime { get; set; }

        /// <summary>
        /// Detailed information about the exceptions that occurred when consignment was not delivered
        /// </summary>
        public EdiDeliveryAttemptFailedExceptions Exceptions { get; set; }
    }
}