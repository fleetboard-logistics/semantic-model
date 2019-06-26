using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;

namespace Conizi.Model.Shared.Entities
{

    /// <summary>
    /// Events occurred while validating and processing the data
    /// </summary>
    [DisplayName("Data processing")]
    [Description("Events occurred while validating and processing the data")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiDataProcessing : EdiEventBase
    {
        /// <summary>
        /// The data for <see cref="PickupOrder"/> or <see cref="Consignment"/> were received
        /// </summary>
        public bool DocumentDataReceived { get; set; }


        /// <summary>
        /// Detailed information about the exceptions that occured while processing the data.
        /// Use(null) to report successful processing of the data
        /// </summary>
        public EdiDataProcessingExceptions Exceptions { get; set; }
    }
}