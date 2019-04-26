using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Transport.Truck.Groupage.Forwarding.Helper.Tour;
using Newtonsoft.Json;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{
    /// <summary>
    /// An event which occurred during the processing of the referenced tour <see cref="Tour"/>
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/transport/truck/groupage/forwarding/tour-event.json",
        "tour-event.json")]
    [DisplayName("Tour event")]
    [Description("An event which occurred during the processing of the referenced tour")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class TourEvent : EdiModel
    {
        /// <summary>
        /// The referenced Tour Id. A unique identifier assigned to this tour by the devlivering company
        /// </summary>
        [DisplayName("Referenced Tour Id")]
        [Description("A unique identifier assigned to this tour by the devlivering company")]
        [JsonProperty("tourId", Order = -10, Required = Required.Always)]
        public string TourId { get; set; }

        /// <summary>
        /// Event to notify about tour specific incidents
        /// </summary>
        public EdiTourSpecificEvent Tour { get; set; }

        /// <summary>
        /// Event to notify about stop specific incidents
        /// </summary>
        public EdiStopSpecificEvent Stop { get; set; }

        /// <summary>
        /// Event to notify about vehicle specific incidents
        /// </summary>
        public EdiVehicleSpecificEvent Vehicle { get; set; }

        /// <summary>
        /// Event to notify about tour specific documents
        /// </summary>
        public EdiTourDocuments Documents { get; set; }
    }
}