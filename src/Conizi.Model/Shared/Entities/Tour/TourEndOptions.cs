using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities.Tour
{
    /// <summary>
    /// Tour end options. Activities the driver is supposed to do before starting driving the tour
    /// </summary>
    [DisplayName("Tour end options")]
    [Description("Activities the driver is supposed to do after finishing driver the tour")]
    [JsonObject("tourEndOptions")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class TourEndOptions
    {

        /// <summary>
        /// Write down the mileage
        /// </summary>
        [DisplayName("Write Down Mileage")]
        [Description("Write down the mileage")]
        public bool WriteDownMileage { get; set; }
    }
}