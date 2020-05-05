using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Definitions;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Stop for delivering. Stop for delivering the actual goods
    /// </summary>
    [DisplayName("Stop for delivering")]
    [Description("Stop for delivering the actual goods")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiTourStop
    {
        /// <summary>
        /// Stop number. The whole of the stop numbers in the right order defines the order of the stops
        /// </summary>
        [DisplayName("Stop number")]
        [Description("The whole of the stop numbers in the right order defines the order of the stops")]
        public int? StopNo { get; set; }

        /// <summary>
        /// Stop Id. Unique identifier for this stop within the tour
        /// </summary>
        [DisplayName("Stop Id")]
        [Description("Unique identifier for this stop within the tour")]
        [JsonRequired]
        public string StopId { get; set; }

        /// <summary>
        /// Type of a stop, like loading, unloading...
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public StopType StopType { get; set; }

        /// <summary>
        /// The address information of the stop
        /// </summary>
        public EdiAddress Address { get; set; }

        /// <summary>
        /// Stop to refuel the vehicle
        /// </summary>
        public TourFuelStopInformation FuelStopInformation { get; set; }

        /// <summary>
        /// Way point information of the tour
        /// </summary>
        public TourWayPointInformation WayPointInformation { get; set; }

        /// <summary>
        /// Information on border crossing
        /// </summary>
        public TourBorderCrossInformation BorderCrossInformation { get; set; }

        /// <summary>
        /// Information about loading
        /// </summary>
        [JsonProperty(Required = Required.DisallowNull)]
        public TourLoadingInformation LoadingInformation { get; set; }

        /// <summary>
        /// Information about unloading
        /// </summary>
        [JsonProperty(Required = Required.DisallowNull)]
        public TourUnloadingInformation UnloadingInformation { get; set; }

        /// <summary>
        /// Navigation information between two partners. Usually used in a <see cref="T:Conizi.Model.Transport.Truck.Groupage.Forwarding.Tour" />
        /// to extend the stops in a <see cref="T:Conizi.Model.Transport.Truck.Groupage.Forwarding.Tour" /> with necessary information for the navigation on the yard (last mile)
        /// </summary>
        public List<EdiYardNavigationInformation> YardNavigationInformation { get; set; }
    }

    /// <summary>
    /// Stop to refuel. Stop to refuel the vehicle
    /// </summary>
    [DisplayName("Stop to refuel")]
    [Description("Stop to refuel the vehicle")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class TourFuelStopInformation : TourInformation
    {
    }

    /// <summary>
    /// Way Point Information
    /// </summary>
    [DisplayName("Way Point Information")]
    [Description("Way point information of the tour")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class TourWayPointInformation : TourFuelStopInformation
    {
        /// <summary>
        /// Cross Docking
        /// </summary>
        [DisplayName("Cross Docking")]
        public bool? CrossDocking { get; set; }
    }

    /// <summary>
    /// Information on border crossing
    /// </summary>
    [DisplayName("Border cross information")]
    [Description("Information on border crossing")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class TourBorderCrossInformation : TourInformation
    {
    }

    /// <summary>
    /// Information about loading
    /// </summary>
    [DisplayName("Loading information")]
    [Description("Information about loading")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class TourLoadingInformation : TourInformation
    {
        /// <summary>
        /// References to the consignments, depending on this stop
        /// </summary>
        [DisplayName("References to the consignments")]
        [Description("References to the consignments, depending on this stop")]
        [Required]
        public List<string> ConsignmentObjectIds { get; set; }

        [JsonProperty("bookedTimeslots")] public List<TourBookedTimeSlot> BookedTimeSlots { get; set; }

        /// <summary>
        /// Booked time slot for the tour
        /// </summary>
        [DisplayName("Booked Time Slots")]
        [Description("Booked time slots for the tour")]
        public List<TourWorkingHours> WorkingHours { get; set; }
    }

    /// <summary>
    /// Information about unloading
    /// </summary>
    [DisplayName("Unloading information")]
    [Description("Information about unloading")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class TourUnloadingInformation : TourInformation
    {
        /// <summary>
        /// References to the consignments, depending on this stop
        /// </summary>
        [DisplayName("References to the consignments")]
        [Description("References to the consignments, depending on this stop")]
        public List<string> ConsignmentObjectIds { get; set; }

        [JsonProperty("bookedTimeslots")] public List<TourBookedTimeSlot> BookedTimeSlots { get; set; }

        /// <summary>
        /// Booked time slot for the tour
        /// </summary>
        [DisplayName("Booked Time Slots")]
        [Description("Booked time slots for the tour")]
        public List<TourWorkingHours> WorkingHours { get; set; }
    }

    public class TourInformation : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Scheduled Arrival for refuel
        /// </summary>
        //[DisplayName("Scheduled Arrival")]
        //[Description("Scheduled Arrival for refuel")]
        public EdiTimeSpan ScheduledArrival { get; set; }

        /// <summary>
        /// Scheduled Arrival after refuel
        /// </summary>
        //[DisplayName("Scheduled Departure")]
        //[Description("Scheduled Arrival after refuel")]
        public EdiTimeSpan ScheduledDeparture { get; set; }

        /// <summary>
        /// Scheduled wait time in minutes to begin the activity
        /// </summary>
        [DisplayName("Scheduled wait minutes")]
        [Description("Scheduled wait time in minutes to begin the activity")]
        public int? ScheduledWaitMinutes { get; set; }

        /// <summary>
        /// Scheduled time for handling the activity
        /// </summary>
        [DisplayName("Scheduled handling minutes")]
        [Description("Scheduled time for handling the activity")]
        public int? ScheduledHandlingMinutes { get; set; }

        /// <summary>
        /// Notes on the Stop
        /// </summary>
        [DisplayName("Notes")]
        [Description("Notes on the Stop")]
        public string Notes { get; set; }
    }

    /// <summary>
    /// Booked time slot for the tour
    /// </summary>
    [DisplayName("Booked Time Slots")]
    [Description("Booked time slots for the tour")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class TourBookedTimeSlot : TourWorkingHours
    {
        /// <summary>
        /// Gate to use
        /// </summary>
        [DisplayName("Gate")]
        public string Gate { get; set; }

        /// <summary>
        /// Notes
        /// </summary>
        [DisplayName("Notes")]
        public string Notes { get; set; }

        public TourWayPointInformation WayPointInformation { get; set; }
    }


    public class TourWorkingHours : EdiPatternPropertiesBase
    {
        /// <summary>
        /// From Date Time
        /// </summary>
        [DisplayName("From Date Time")]
        public DateTime? FromDateTime { get; set; }

        /// <summary>
        /// Until Date Time
        /// </summary>
        [DisplayName("Until Date Time")]
        public DateTime? UntilDateTime { get; set; }
    }
}