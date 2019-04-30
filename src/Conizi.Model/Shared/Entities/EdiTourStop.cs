using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{/// <summary>
 /// Stop for delivering. Stop for delivering the actual goods
 /// </summary>
    [DisplayName("Stop for delivering")]
    [Description("Stop for delivering the actual goods")]
    [JsonObject("stop")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiTourStop
    {

        /// <summary>
        /// Stop number. The whole of the stop numbers in the right order defines the order of the stops
        /// </summary>
        [DisplayName("Stop number")]
        [Description("The whole of the stop numbers in the right order defines the order of the stops")]
        public int StopNo { get; set; }

        /// <summary>
        /// Stop Id. Unique identifier for this stop within the tour
        /// </summary>
        [DisplayName("Stop Id")]
        [Description("Unique identifier for this stop within the tour")]
        [JsonRequired]
        public string StopId { get; set; }

        public EdiAddress Address { get; set; }

        public TourFuelStopInformation FuelStopInformation { get; set; }

        public TourWayPointInformation WayPointInformation { get; set; }

        public TourBorderCrossInformation BorderCrossInformation { get; set; }

        public TourLoadingInformation LoadingInformation { get; set; }

        public TourUnloadingInformation UnloadingInformation { get; set; }
    }

    /// <summary>
    /// Stop to refuel. Stop to refuel the vehicle
    /// </summary>
    [DisplayName("Stop to refuel")]
    [Description("Stop to refuel the vehicle")]
    [JsonObject("fuelStopInformation")]
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
    [JsonObject("wayPointInformation")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class TourWayPointInformation : TourFuelStopInformation
    {
        /// <summary>
        /// Cross Docking
        /// </summary>
        [DisplayName("Cross Docking")]
        public bool CrossDocking { get; set; }
    }

    /// <summary>
    /// Information on border crossing
    /// </summary>
    [DisplayName("Border cross information")]
    [Description("Information on border crossing")]
    [JsonObject("borderCrossInformation")]
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
    [JsonObject("loadingInformation")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class TourLoadingInformation : TourInformation
    {
        /// <summary>
        /// References to the consignments, depending on this stop
        /// </summary>
        [DisplayName("References to the consignments")]
        [Description("References to the consignments, depending on this stop")]
        public List<string> ConsignmentObjectIds { get; set; }

        [JsonProperty("bookedTimeslots")]
        public List<TourBookedTimeSlot> BookedTimeSlots { get; set; }

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
    [JsonObject("unloadingInformation")]
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

        [JsonProperty("bookedTimeslots")]
        public List<TourBookedTimeSlot> BookedTimeSlots { get; set; }
        
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
        public int ScheduledWaitMinutes { get; set; }

        /// <summary>
        /// Scheduled time for handling the activity
        /// </summary>
        [DisplayName("Scheduled handling minutes")]
        [Description("Scheduled time for handling the activity")]
        public int ScheduledHandlingMinutes { get; set; }

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
    [JsonObject("bookedTimeSlot")]
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
    }


    [JsonObject("workingHours")]
    public class TourWorkingHours : EdiPatternPropertiesBase
    {
        /// <summary>
        /// From Date Time
        /// </summary>
        [DisplayName("From Date Time")]
        public DateTime FromDateTime { get; set; }

        /// <summary>
        /// Until Date Time
        /// </summary>
        [DisplayName("Until Date Time")]
        public DateTime UntilDateTime { get; set; }

    }
}