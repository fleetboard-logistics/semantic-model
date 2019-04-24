using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding.Helper.Tour
{
    /// <summary>
    /// Event that is a trigger for starting a notification
    /// </summary>
    [DisplayName("Trigger")]
    [Description("Event that is a trigger for starting a notification")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiTrigger : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Start a manual notification
        /// </summary>
        [DisplayName("Manually")]
        [Description("Start a manual notification")]
        public bool Manually { get; set; }

        /// <summary>
        /// Start an automatic notification (i.e. automatic notification system via email or SMS)
        /// </summary>
        [DisplayName("Automatic")]
        [Description("Start an automatic notification (i.e. automatic notification system via email or SMS)")]
        public bool Automatic { get; set; }
    }
}