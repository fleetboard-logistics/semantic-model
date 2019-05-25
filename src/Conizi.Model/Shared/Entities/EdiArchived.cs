using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Documents have been archived
    /// </summary>
    [DisplayName("Archived")]
    [Description("Documents have been archived")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiArchived : EdiPatternPropertiesBase
    {

        /// <summary>
        /// Proof of delivery was archived
        /// </summary>
        [DisplayName("Proof of Delivery")]
        [Description("Proof of delivery was archived")]
        public bool? Pod { get; set; }

        /// <summary>
        /// Delivery notes were archived
        /// </summary>
        [DisplayName("Delivery notes")]
        [Description("Delivery notes were archived")]
        public bool? DeliveryNote { get; set; }

        /// <summary>
        /// Customs papers were archived
        /// </summary>
        [DisplayName("Customs papers")]
        [Description("Customs papers were archived")]
        public bool? CustomsPapers { get; set; }

        /// <summary>
        /// Pictures of damages were archived
        /// </summary>
        [DisplayName("Damage Pictures")]
        [Description("Pictures of damages were archived")]
        public bool? DamagePictures { get; set; }
    }
}