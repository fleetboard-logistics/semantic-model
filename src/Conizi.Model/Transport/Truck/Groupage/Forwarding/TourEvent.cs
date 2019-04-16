using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{
    /// <summary>
    /// An event which occured during the processing of the referenced tour <see cref="Tour"/>
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/transport/truck/groupage/forwarding/tour-event.json",
        "tour-event.json")]
    [DisplayName("Tour event")]
    [Description("An event which occured during the processing of the referenced tour")]
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
        public EdiTourSpecificEvent TourSpecific { get; set; }

        /// <summary>
        /// Event to notify about stop specific incidents
        /// </summary>
        public EdiStopSpecificEvent StopSpecific { get; set; }

    }

    /// <summary>
    /// Event to notify about tour specific incidents
    /// </summary>
    [DisplayName("Tour specific Event")]
    [Description("Event to notify about tour specific incidents")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiTourSpecificEvent : EdiTourEventBase
    {
        /// <summary>
        /// Disposal of a tour was done
        /// </summary>
        [DisplayName("Tour scheduled")]
        [Description("Disposal of a tour was done")]
        public bool TourScheduled { get; set; }

        /// <summary>
        /// The tour was transmitted to the mobile device
        /// </summary>
        [DisplayName("Tour transmitted")]
        [Description("The tour was transmitted to the mobile device")]
        public bool TourTransmitted { get; set; }

        /// <summary>
        /// The tour was accepted by the driver on mobile device
        /// </summary>
        [DisplayName("Tour accepted")]
        [Description("The tour was accepted by the driver on mobile device")]
        public bool TourAccepted { get; set; }

        /// <summary>
        /// The tour was rejected by the driver on mobile device
        /// </summary>
        [DisplayName("Tour rejected")]
        [Description("The tour was rejected by the driver on mobile device")]
        public bool TourRejected { get; set; }

        /// <summary>
        /// The tour was started by the driver
        /// </summary>
        [DisplayName("Tour started")]
        [Description("The tour was started by the driver")]
        public bool TourStarted { get; set; }

        /// <summary>
        /// The tour was completed by the driver
        /// </summary>
        [DisplayName("Tour completed")]
        [Description("The tour was completed by the driver")]
        public bool TourCompleted { get; set; }

        /// <summary>
        /// The tour was paused by the driver
        /// </summary>
        [DisplayName("Tour paused")]
        [Description("The tour was paused by the driver")]
        public bool TourPaused { get; set; }

        /// <summary>
        /// The tour was resumed by the driver
        /// </summary>
        [DisplayName("Tour resumed")]
        [Description("The tour was resumed by the driver")]
        public bool TourResumed { get; set; }

        /// <summary>
        /// Working time has been started for the driver
        /// </summary>
        [DisplayName("Working Time Started")]
        [Description("Working time has been started for the driver")]
        public bool WorkingTimeStarted { get; set; }

        /// <summary>
        /// Working time has been ended for the driver
        /// </summary>
        [DisplayName("Working Time Completed")]
        [Description("Working time has been ended for the driver")]
        public bool WorkingTimeCompleted{ get; set; }

        /// <summary>
        /// Cleaning of the vehicle has been started
        /// </summary>
        [DisplayName("Cleaning Started")]
        [Description("Cleaning of the vehicle has been started")]
        public bool CleaningStarted { get; set; }

        /// <summary>
        /// Cleaning of the vehicle has been completed
        /// </summary>
        [DisplayName("Cleaning Completed")]
        [Description("Cleaning of the vehicle has been completed")]
        public bool CleaningCompleted { get; set; }

        /// <summary>
        /// Exchange of the trailer has been started
        /// </summary>
        [DisplayName("Trailer Exchange Started")]
        [Description("Exchange of the trailer has been started")]
        public bool TrailerExchangeStarted { get; set; }

        /// <summary>
        /// Exchange of the trailer has been completed
        /// </summary>
        [DisplayName("Trailer Exchange Completed")]
        [Description("Exchange of the trailer has been completed")]
        public bool TrailerExchangeCompleted { get; set; }

        /// <summary>
        /// Exchange of the trailer has been started
        /// </summary>
        [DisplayName("Trailer Exchange Started")]
        [Description("Exchange of the trailer has been started")]
        public bool ChangeSwapBodyStarted { get; set; }

        /// <summary>
        /// Exchange of the trailer has been completed
        /// </summary>
        [DisplayName("Trailer Exchange Completed")]
        [Description("Exchange of the trailer has been completed")]
        public bool ChangeSwapBodyCompleted { get; set; }
    }

    /// <summary>
    /// Event to notify about stop specific incidents
    /// </summary>
    [DisplayName("Stop specific Event")]
    [Description("Event to notify about stop specific incidents")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiStopSpecificEvent : EdiTourEventBase
    {
        /// <summary>
        /// Vehicle is on the way to loading point
        /// </summary>
        [DisplayName("On the way to loading point")]
        [Description("Vehicle is on the way to loading point")]
        public bool OnWayLoadingPoint { get; set; }

        /// <summary>
        /// Arrived at loading point
        /// </summary>
        [DisplayName("Arrived at loading point")]
        [Description("Vehicle is arrived at loading point")]
        public bool ArrivedAtLoadingPoint { get; set; }

        /// <summary>
        /// Loading of the vehicle has started
        /// </summary>
        [DisplayName("Loading Started")]
        [Description("Loading of the vehicle has started")]
        public bool LoadingStarted { get; set; }

        /// <summary>
        /// Loading of the vehicle was completed
        /// </summary>
        [DisplayName("Loading Completed")]
        [Description("Loading of the vehicle was completed")]
        public bool LoadingCompleted{ get; set; }

        /// <summary>
        /// Vehicle is on the way to unloading point
        /// </summary>
        [DisplayName("On the way to unloading point")]
        [Description("Vehicle is on the way to unloading point")]
        public bool OnWayUnloadingPoint { get; set; }

        /// <summary>
        /// Vehicle is arrived at unloading point
        /// </summary>
        [DisplayName("Arrived at unloading point")]
        [Description("Vehicle is arrived at unloading point")]
        public bool ArrivedAtUnloadingPoint { get; set; }

        /// <summary>
        /// Unloading of the vehicle has started
        /// </summary>
        [DisplayName("Unloading Started")]
        [Description("Unloading of the vehicle has started")]
        public bool UnloadingStarted { get; set; }

        /// <summary>
        /// Unloading of the vehicle was completed
        /// </summary>
        [DisplayName("Unloading Completed")]
        [Description("Unloading of the vehicle was completed")]
        public bool UnloadingCompleted { get; set; }


    }

    /// <summary>
    /// Base class for a tour based event
    /// </summary>
    public abstract class EdiTourEventBase : EdiEventBase
    {
        /// <summary>
        /// The geo location, the event was recorded
        /// </summary>
        [JsonProperty("geoLocation", Order = -9, Required = Required.DisallowNull)]
        public EdiGeoLocation GeoLocation { get; set; }

    }

}
