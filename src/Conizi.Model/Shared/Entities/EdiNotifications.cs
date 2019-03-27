using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("notifications")]
    [DisplayName("Notifications")]
    [Description("Notifications which should be sent while processing the shipment, e.g. notifications about successful delivery, advance notifications, ...")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiNotifications : EdiPatternPropertiesBase
    {
        public EdiPartnerIdentification GeneralNotificationAddress { get; set; }

        public EdiPartnerIdentification AfterDelivery { get; set; }

        public EdiPartnerIdentification BeforeDelivery { get; set; }

        public EdiPartnerIdentification ByDriver { get; set; }

    }
}