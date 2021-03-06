﻿using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Tour end options. Activities the driver is supposed to do before starting driving the tour
    /// </summary>
    [DisplayName("Tour end options")]
    [Description("Activities the driver is supposed to do after finishing driver the tour")]
    
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class TourEndOptions : EdiPatternPropertiesBase
    {

        /// <summary>
        /// Write down the mileage
        /// </summary>
        [DisplayName("Write Down Mileage")]
        [Description("Write down the mileage")]
        public bool? WriteDownMileage { get; set; }

        /// <summary>
        /// Additional remarks (free form)
        /// </summary>
        [DisplayName("Remarks (free form)")]
        [Description("Additional remarks")]
        public string Remarks { get; set; }
    }
}