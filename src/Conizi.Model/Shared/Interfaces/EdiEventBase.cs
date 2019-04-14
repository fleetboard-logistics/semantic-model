using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Conizi.Model.Shared.Interfaces
{
    public abstract class EdiEventBase : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Date and time when the event occured
        /// </summary>
        [DisplayName("Event Date-time")]
        [Description("Date and time when the event occured")]
        public DateTime EventDateTime { get; set; }

        /// <summary>
        /// Additional remarks
        /// </summary>
        [DisplayName("Remarks (free form)")]
        [Description("Additional remarks")]
        public string Remarks { get; set; }
    }
}
