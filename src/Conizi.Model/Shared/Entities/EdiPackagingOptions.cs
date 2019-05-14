using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Packaging Options
    /// </summary>
    
    [DisplayName("Packaging Options")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPackagingOptions : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Packaging material return
        /// </summary>
        [DisplayName("Return")]
        [Description("Packaging material return")]
        public bool? Return { get; set; }

        /// <summary>
        /// Packaging correction for your Bordero from: ... (Additional description)"
        /// </summary>
        [DisplayName("Correction")]
        [Description("Packaging correction for your Bordero from: ... (Additional description)")]
        public string Correction { get; set; }

        /// <summary>
        /// Delivery of packaging by third parties on: ... (Additional description)
        /// </summary>
        [DisplayName("Third Party Delivery")]
        [Description("Delivery of packaging by third parties on: ... (Additional description)")]
        public string ThirdPartyDelivery { get; set; }

        /// <summary>
        /// Package Pickup
        /// </summary>
        [DisplayName("Package Pickup")]
        [Description("Package Pickup")]
        public string Pickup { get; set; }
    }
}