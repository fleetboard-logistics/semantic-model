using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Time information of this transport
    /// </summary>

    [DisplayName("Transport Time Slot")]
    [Description("Time information of this transport")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiTransportTimeSlot : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Time slot for pickup of the order
        /// </summary>
        public TourBookedTimeSlot Pickup { get; set; }

        /// <summary>
        /// Time slot for delivery of the order
        /// </summary>
        public TourBookedTimeSlot Delivery { get; set; }
    }
}