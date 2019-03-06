using System.ComponentModel;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("notifications")]
    [DisplayName("Notifications")]
    [Description("Notifications which should be sent while processing the shipment, e.g. notifications about successful delivery, advance notifications, ...")]
    public class EdiNotifications
    {
        public EdiAddress GeneralNotificationAddress { get; set; }

        public EdiAddress AfterDelivery { get; set; }

        public EdiAddress BeforeDelivery { get; set; }

        public EdiAddress ByDriver { get; set; }

    }
}