using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Definitions;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Special loading equipment, like a fork lift, crane...
    /// </summary>
    
    [DisplayName("Additional loading equipment")]
    [Description("Special loading equipment, like a fork lift, crane...")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiSpecialEquipment : EdiPatternPropertiesBase
    {
        /// <summary>
        /// A forklift is needed for the transport
        /// </summary>
        [DisplayName("ForkLift")]
        [Description("A forklift is needed for the transport")]
        public bool? ForkLift { get; set; }

        /// <summary>
        /// A lifting platform is needed for the transport
        /// </summary>
        [DisplayName("LiftingPlatform")]
        [Description("A lifting platform is needed for the transport")]
        public bool? LiftingPlatform { get; set; }

        /// <summary>
        /// A crane is needed for the transport
        /// </summary>
        [DisplayName("Crane")]
        [Description("A crane is needed for the transport")]
        public bool? Crane { get; set; }


        /// <summary>
        /// A hand lifter is needed for the transport
        /// </summary>
        [DisplayName("HandLifter")]
        [Description("A hand lifter is needed for the transport")]
        public bool? HandLifter { get; set; }


        /// <summary>
        /// A refrigerated truck is needed for the transport
        /// </summary>
        [DisplayName("Refrigerated Truck")]
        [Description("A refrigerated truck is needed for the transport")]
        public bool? RefrigeratedTruck { get; set; }

        /// <summary>
        /// Additional remarks (free form)
        /// </summary>
        [DisplayName("Remarks (free form)")]
        [Description("Additional remarks")]
        public string Remarks { get; set; }

    }
}