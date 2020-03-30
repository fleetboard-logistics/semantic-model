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
    /// Event occurred while arriving at the referenced stop 
    /// </summary>
    [DisplayName("Arrived Event")]
    [Description("Event occurred while arriving at the referenced stop ")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEventArrived : EdiEventBase
    {
        /// <summary>
        /// Detailed information about the exceptions that occurred while loading the order
        /// </summary>
        public EdiEventArrivedExceptions Exceptions { get; set; }

    }

    /// <summary>
    /// Detailed information about the exceptions that occurred while arriving at the referenced stop. 
    /// </summary>
    [DisplayName("Arrived Exception")]
    [Description("Detailed information about the exceptions that occurred while arriving at the referenced stop. ")]
    public class EdiEventArrivedExceptions : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The goods receiving department was closed
        /// </summary>
        [DisplayName("Closed")]
        [Description("The goods receiving department was closed")]
        public bool? Closed { get; set; }

        /// <summary>
        /// Arrived at the wrong address
        /// </summary>
        [DisplayName("Wrong Address")]
        [Description("Arrived at the wrong address")]
        public bool? WrongAddress { get; set; }

    }
}
