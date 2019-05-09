using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// The time span for an activity
    /// </summary>
    [JsonObject("#timespan")]
    [DisplayName("Time span")]
    [Description("The time span for an activity")]
    [ConiziAdditionalProperties(false)]
    public class EdiTimeSpan
    {
        /// <summary>
        /// Time span from
        /// </summary>
        [DisplayName("Time from")]
        [Description("Time span from")]
        [ConiziTimeOnly]
        public string From { get; set; }

        /// <summary>
        /// Time span until
        /// </summary>
        [DisplayName("Time until")]
        [Description("Time span until")]
        [ConiziTimeOnly]
        public string Until { get; set; }
    }
}