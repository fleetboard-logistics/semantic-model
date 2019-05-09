using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
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
        public bool? TourScheduled { get; set; }

        /// <summary>
        /// The tour was transmitted to the mobile device
        /// </summary>
        [DisplayName("Tour transmitted")]
        [Description("The tour was transmitted to the mobile device")]
        public bool? TourTransmitted { get; set; }

        /// <summary>
        /// The tour was accepted by the driver on mobile device
        /// </summary>
        [DisplayName("Tour accepted")]
        [Description("The tour was accepted by the driver on mobile device")]
        public bool? TourAccepted { get; set; }

        /// <summary>
        /// The tour was rejected by the driver on mobile device
        /// </summary>
        [DisplayName("Tour rejected")]
        [Description("The tour was rejected by the driver on mobile device")]
        public bool? TourRejected { get; set; }

        /// <summary>
        /// The tour was started by the driver
        /// </summary>
        [DisplayName("Tour started")]
        [Description("The tour was started by the driver")]
        public bool? TourStarted { get; set; }

        /// <summary>
        /// The tour was completed by the driver
        /// </summary>
        [DisplayName("Tour completed")]
        [Description("The tour was completed by the driver")]
        public bool? TourCompleted { get; set; }

        /// <summary>
        /// The tour was paused by the driver
        /// </summary>
        [DisplayName("Tour paused")]
        [Description("The tour was paused by the driver")]
        public bool? TourPaused { get; set; }

        /// <summary>
        /// The tour was resumed by the driver
        /// </summary>
        [DisplayName("Tour resumed")]
        [Description("The tour was resumed by the driver")]
        public bool? TourResumed { get; set; }

        /// <summary>
        /// Working time has been started for the driver
        /// </summary>
        [DisplayName("Working Time Started")]
        [Description("Working time has been started for the driver")]
        public bool? WorkingTimeStarted { get; set; }

        /// <summary>
        /// Working time has been ended for the driver
        /// </summary>
        [DisplayName("Working Time Completed")]
        [Description("Working time has been ended for the driver")]
        public bool? WorkingTimeCompleted { get; set; }

        /// <summary>
        /// Cleaning of the vehicle has been started
        /// </summary>
        [DisplayName("Cleaning Started")]
        [Description("Cleaning of the vehicle has been started")]
        public bool? CleaningStarted { get; set; }

        /// <summary>
        /// Cleaning of the vehicle has been completed
        /// </summary>
        [DisplayName("Cleaning Completed")]
        [Description("Cleaning of the vehicle has been completed")]
        public bool? CleaningCompleted { get; set; }

        /// <summary>
        /// Exchange of the trailer has been started
        /// </summary>
        [DisplayName("Trailer Exchange Started")]
        [Description("Exchange of the trailer has been started")]
        public bool? TrailerExchangeStarted { get; set; }

        /// <summary>
        /// Exchange of the trailer has been completed
        /// </summary>
        [DisplayName("Trailer Exchange Completed")]
        [Description("Exchange of the trailer has been completed")]
        public bool? TrailerExchangeCompleted { get; set; }

        /// <summary>
        /// Exchange of the trailer has been started
        /// </summary>
        [DisplayName("Trailer Exchange Started")]
        [Description("Exchange of the trailer has been started")]
        public bool? ChangeSwapBodyStarted { get; set; }

        /// <summary>
        /// Exchange of the trailer has been completed
        /// </summary>
        [DisplayName("Trailer Exchange Completed")]
        [Description("Exchange of the trailer has been completed")]
        public bool? ChangeSwapBodyCompleted { get; set; }

        /// <summary>
        /// Waiting time for next action started
        /// </summary>
        [DisplayName("Waiting time for next action started")]
        [Description("Exchange of the trailer has been started")]
        public bool? WaitingTimeStarted { get; set; }

        /// <summary>
        /// Waiting time for next action completed
        /// </summary>
        [DisplayName("Waiting Time Completed")]
        [Description("Waiting time for next action completed")]
        public bool? WaitingTimeCompleted { get; set; }

        /// <summary>
        /// Vehicle is ready to load
        /// </summary>
        [DisplayName("Ready to load")]
        [Description("Vehicle is ready to load")]
        public bool? ReadyToLoad { get; set; }

        /// <summary>
        /// Vehicle is ready to unload
        /// </summary>
        [DisplayName("Ready to unload")]
        [Description("Vehicle is ready to unload")]
        public bool? ReadyToUnload { get; set; }
    }
}