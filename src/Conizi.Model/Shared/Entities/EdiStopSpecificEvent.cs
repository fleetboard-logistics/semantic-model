using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
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
        public bool? OnWayLoadingPoint { get; set; }

        /// <summary>
        /// Arrived at loading point
        /// </summary>
        [DisplayName("Arrived at loading point")]
        [Description("Vehicle is arrived at loading point")]
        public bool? ArrivedAtLoadingPoint { get; set; }

        /// <summary>
        /// Loading of the vehicle has started
        /// </summary>
        [DisplayName("Loading Started")]
        [Description("Loading of the vehicle has started")]
        public bool? LoadingStarted { get; set; }

        /// <summary>
        /// Loading of the vehicle was completed
        /// </summary>
        [DisplayName("Loading Completed")]
        [Description("Loading of the vehicle was completed")]
        public bool? LoadingCompleted { get; set; }

        /// <summary>
        /// Vehicle is on the way to unloading point
        /// </summary>
        [DisplayName("On the way to unloading point")]
        [Description("Vehicle is on the way to unloading point")]
        public bool? OnWayUnloadingPoint { get; set; }

        /// <summary>
        /// Vehicle is arrived at unloading point
        /// </summary>
        [DisplayName("Arrived at unloading point")]
        [Description("Vehicle is arrived at unloading point")]
        public bool? ArrivedAtUnloadingPoint { get; set; }

        /// <summary>
        /// Unloading of the vehicle has started
        /// </summary>
        [DisplayName("Unloading Started")]
        [Description("Unloading of the vehicle has started")]
        public bool? UnloadingStarted { get; set; }

        /// <summary>
        /// Unloading of the vehicle was completed
        /// </summary>
        [DisplayName("Unloading Completed")]
        [Description("Unloading of the vehicle was completed")]
        public bool? UnloadingCompleted { get; set; }

        /// <summary>
        /// Documents has been received
        /// </summary>
        [DisplayName("Documents Received")]
        [Description("Documents has been received")]
        public bool? DocumentsReceived { get; set; }

        /// <summary>
        /// Departure, the stop has been completed
        /// </summary>
        [DisplayName("Departure")]
        [Description("Departure, the stop has been completed")]
        public bool? Departure { get; set; }

        /// <summary>
        /// Information on loading equipment exchange at this stop
        /// </summary>
        public EdiLoadingEquipmentExchange LoadingEquipmentExchange { get; set; }

        /// <summary>
        /// ETA (Estimated time of arrival)
        /// </summary>
        public EdiGeoEta Eta { get; set; }
    }
}