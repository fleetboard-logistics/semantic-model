using System.Collections.Generic;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Definitions;
using Conizi.Model.Shared.Interfaces;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Event to notify about stop order
    /// </summary>
    [DisplayName("Stop specific Event")]
    [Description("Event to notify about stop specific incidents")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]

    public class EdiStopOrderingEvent : EdiEventBase
    {
        /// <summary>
        /// Describes if the reorder has already been handled
        /// </summary>
        [DisplayName("Handling done")]
        [Description("Describes if the reordering has already been handled")]
        public bool? HandlingDone { get; set; }

        /// <summary>
        /// Sort-items of the stop-ordering event. Describes stacking and new stoporder
        /// </summary>
        [DisplayName("Sort items")]
        [Description("Sort-items of the stop-ordering event. Describes stacking and new stoporder")]
        public List<EdiStopOrderingSortingItem> Sorting { get; set; }
    }

    /// <summary>
    /// Sortitem of the stop-ordering event. Describes stacking and new stoporder
    /// </summary>
    [DisplayName("Sort item")]
    [Description("Sortitem of the stop-ordering event. Describes stacking and new stoporder")]
    [ConiziAdditionalProperties(false)]
    public class EdiStopOrderingSortingItem
    {
        /// <summary>
        /// The (possibly new) StopId of the stop
        /// </summary>
        [DisplayName("StopId")]
        [Description("The (possibly new) StopId of the stop")]
        public string StopId { get; set; }
        /// <summary>
        /// The new StopNo of the stop. Used for sorting
        /// </summary>
        [DisplayName("StopNo new")]
        [Description("The new StopNo of the stop. Used for sorting")]
        public int StopNo { get; set; }
        /// <summary>
        /// Contains the StopIds of the stops that are merged together. If the SourceStopId is equals the new StopId it will not be included here.
        /// </summary>
        [DisplayName("StopIds to merge")]
        [Description("Contains the StopIds of the stops that are merged together. If a SourceStopId is equals the StopId of the current EdiStopOrderingSortingItem it will not be included here.")]
        public List<string> SourceStopIds { get; set; }
    }
}