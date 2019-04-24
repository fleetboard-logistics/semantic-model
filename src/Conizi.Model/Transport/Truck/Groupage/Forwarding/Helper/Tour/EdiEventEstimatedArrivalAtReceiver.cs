using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding.Helper.Tour
{
    /// <summary>
    /// Events occured regarding the estimated time of arrival at receiver
    /// </summary>
    [DisplayName("Estimated time of arrival at receiver")]
    [Description("Events occured regarding the estimated time of arrival at receiver")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEventEstimatedArrivalAtReceiver : EdiEventBase
    {
        /// <summary>
        /// Date and time of the estimated arrival
        /// </summary>
        [DisplayName("Estimated arrival date/time")]
        [Description("Date and time of the estimated arrival")]
        public string EstimatedArrivalTime { get; set; }
    }
}