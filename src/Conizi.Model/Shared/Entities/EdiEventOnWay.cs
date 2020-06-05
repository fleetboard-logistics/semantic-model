using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities
{

    /// <summary>
    /// Events on the way to the referenced stop 
    /// </summary>
    [DisplayName("On Way Event")]
    [Description("Events on the way to the referenced stop")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEventOnWay : EdiEventBase
    {
        /// <summary>
        /// Detailed information about the exceptions that occurred while on the way to the referenced stop
        /// </summary>
        public EdiOnWayEventExceptions Exceptions { get; set; }

    }


    /// <summary>
    /// Detailed information about the exceptions that occurred while on the way to the referenced stop
    /// </summary>
    [DisplayName("On Way Exception")]
    [Description("Detailed information about the exceptions that occurred while on the way to the referenced stop")]
    [ConiziAllowXProperties]
    public class EdiOnWayEventExceptions : EdiPatternPropertiesBase
    {
        /// <summary>
        /// An accident has occurred
        /// </summary>
        [DisplayName("Accident")]
        [Description("An accident has occurred")]
        public bool? Accident { get; set; }

        /// <summary>
        /// A traffic jam has occurred
        /// </summary>
        [DisplayName("Traffic Jam")]
        [Description("A traffic jam has occurred")]
        public bool? TrafficJam { get; set; }

        /// <summary>
        /// Vehicle has taken a break
        /// </summary>
        [DisplayName("Break")]
        [Description("Vehicle has taken a break")]
        public bool? Break { get; set; }

        /// <summary>
        /// Vehicle has a defect
        /// </summary>
        [DisplayName("Defect")]
        [Description("Vehicle has a defect")]
        public bool? Defect { get; set; }

        /// <summary>
        /// Another type of exception has occurred
        /// </summary>
        [DisplayName("Other")]
        [Description("Another type of exception has occurred")]
        public bool? Other { get; set; }

    }
}
