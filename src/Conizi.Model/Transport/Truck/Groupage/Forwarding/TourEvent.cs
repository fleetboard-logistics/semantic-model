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

        /// <summary>
        /// Event to notify about vehicle specific incidents
        /// </summary>
        public EdiVehicleSpecificEvent VehicleSpecific { get; set; }

        /// <summary>
        /// Event to notify about tour specific documents
        /// </summary>
        public EdiTourDocuments TourDocuments { get; set; }
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
        public bool WorkingTimeCompleted { get; set; }

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

        /// <summary>
        /// Waiting time for next action started
        /// </summary>
        [DisplayName("Waiting time for next action started")]
        [Description("Exchange of the trailer has been started")]
        public bool WaitingTimeStarted { get; set; }

        /// <summary>
        /// Waiting time for next action completed
        /// </summary>
        [DisplayName("Waiting Time Completed")]
        [Description("Waiting time for next action completed")]
        public bool WaitingTimeCompleted { get; set; }

        /// <summary>
        /// Vehicle is ready to load
        /// </summary>
        [DisplayName("Ready to load")]
        [Description("Vehicle is ready to load")]
        public bool ReadyToLoad { get; set; }

        /// <summary>
        /// Vehicle is ready to unload
        /// </summary>
        [DisplayName("Ready to unload")]
        [Description("Vehicle is ready to unload")]
        public bool ReadyToUnload { get; set; }
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
        /// Unique identifier for this stop. References the stop within the tour <see cref="Tour"/>
        /// </summary>
        [DisplayName("Stop Id")]
        [Description("Unique identifier for this stop. References the stop within the tour")]
        [JsonRequired]
        public string StopId { get; set; }

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
        public bool LoadingCompleted { get; set; }

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

        /// <summary>
        /// Documents has been received
        /// </summary>
        [DisplayName("Documents Received")]
        [Description("Documents has been received")]
        public bool DocumentsReceived { get; set; }

        /// <summary>
        /// Departure, the stop has been completed
        /// </summary>
        [DisplayName("Departure")]
        [Description("Departure, the stop has been completed")]
        public bool Departure { get; set; }

        /// <summary>
        /// Information on loading equipment exchange at this stop
        /// </summary>
        public EdiLoadingEquipmentExchange LoadingEquipmentExchange { get; set; }
    }

    /// <summary>
    /// Event to notify about vehicle specific incidents
    /// </summary>
    [DisplayName("Vehicle specific Event")]
    [Description("Event to notify about vehicle specific incidents")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiVehicleSpecificEvent : EdiTourEventBase
    {
        /// <summary>
        /// Weight of the vehicle
        /// </summary>
        [DisplayName("Weight of vehicle")]
        [Description("Weight of the vehicle in kg")]
        public decimal Weight { get; set; }

        /// <summary>
        /// Available loading meter
        /// </summary>
        [DisplayName("loading meter")]
        [Description("Available loading meter")]
        public decimal LoadingMeter { get; set; }

        /// <summary>
        /// Name of the driver
        /// </summary>
        [DisplayName("Driver Name")]
        [Description("Name of the driver")]
        public string DriverName { get; set; }

        /// <summary>
        /// Name of the co-driver
        /// </summary>
        [DisplayName("Co-driver Name")]
        [Description("Name of the co-driver")]
        public string CoDriverName { get; set; }

        /// <summary>
        /// Mileage of the vehicle at tour start
        /// </summary>
        [DisplayName("Mileage Start")]
        [Description("Mileage of the vehicle at tour start")]
        public decimal MileageStart { get; set; }

        /// <summary>
        /// Mileage of the vehicle at the end of the tour
        /// </summary>
        [DisplayName("Mileage Finish")]
        [Description("Mileage of the vehicle at the end of the tour")]
        public decimal MileageFinish { get; set; }

        /// <summary>
        /// Current temperature in degrees Celsius
        /// </summary>
        [DisplayName("Temperature")]
        [Description("Current temperature in degrees Celsius")]
        public decimal Temperature { get; set; }

        /// <summary>
        /// Registration number of the truck
        /// </summary>
        [DisplayName("Truck Registration Number")]
        [Description("The registration number of the truck")]
        public string TruckRegistrationNumber { get; set; }

        /// <summary>
        /// Registration number of the trailer
        /// </summary>
        [DisplayName("Trailer Registration Number")]
        [Description("Registration number of the trailer")]
        public string TrailerRegistrationNumber { get; set; }

        /// <summary>
        /// The current calculated estimated arrival time (ETA)
        /// </summary>
        [DisplayName("Estimated Arrival Time")]
        [Description("The current calculated estimated arrival time (ETA)")]
        public DateTime EstimatedArrivalTime { get; set; }
    }

    /// <summary>
    /// Event to notify about tour specific documents
    /// </summary>
    [DisplayName("Tour Documents")]
    [Description("Event to notify about tour specific documents")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiTourDocuments : EdiTourEventBase
    {
        /// <summary>
        /// Pictures/Files of signee's signature
        /// </summary>
        public List<EdiFileContent> Signature { get; set; }

        /// <summary>
        /// Pictures/Files of damages
        /// </summary>
        public List<EdiFileContent> Damages { get; set; }

        /// <summary>
        /// Pictures/Files of load securing
        /// </summary>
        public List<EdiFileContent> LoadSecuring { get; set; }

        /// <summary>
        /// Pictures/Files of driving license
        /// </summary>
        public List<EdiFileContent> DrivingLicense { get; set; }

        /// <summary>
        /// Checklist of departure control available
        /// </summary>
        [DisplayName("Checklist Departure Control")]
        [Description("A checklist of departure control is available")]
        public bool ChecklistDepartureControl { get; set; }

        /// <summary>
        /// Checklist of instructions available
        /// </summary>
        [DisplayName("Checklist Instruction")]
        [Description("A checklist of vehicle inspection is available")]
        public bool ChecklistInstruction{ get; set; }

        /// <summary>
        /// Checklist of vehicle inspection available
        /// </summary>
        [DisplayName("ChecklistVehicle Inspection")]
        [Description("A checklist of vehicle inspection is available")]
        public bool ChecklistVehicleInspection { get; set; }
    }

    /// <summary>
    /// Base class for a tour based event
    /// </summary>
    public abstract class EdiTourEventBase : EdiEventBase
    {
        /// <summary>
        /// The geo location, the event was recorded
        /// </summary>
        [JsonProperty("geoPosition", Order = -9, Required = Required.DisallowNull)]
        public EdiGeoPosition GeoPosition { get; set; }
    }
}