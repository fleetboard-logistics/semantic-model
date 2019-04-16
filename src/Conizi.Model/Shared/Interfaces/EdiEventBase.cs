using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Interfaces
{
    /// <summary>
    /// Base class for events
    /// </summary>
    public abstract class EdiEventBase : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Date and time when the event occured
        /// </summary>
        [DisplayName("Event Date-time")]
        [Description("Date and time when the event occured")]
        [JsonProperty("eventDateTime", Order = -8, Required = Required.Always)]
        public DateTime EventDateTime { get; set; }

        /// <summary>
        /// Additional remarks
        /// </summary>
        [DisplayName("Remarks (free form)")]
        [Description("Additional remarks")]
        public string Remarks { get; set; }
    }
}
