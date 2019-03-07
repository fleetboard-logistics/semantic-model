using System.ComponentModel;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("services")]
    [DisplayName("Services")]
    [Description("Special services which can be requested by the ordering party (or the shipping partner)")]
    public class EdiServices
    {

        public EdiPackagingOptions PackagingOptions { get; set; }

        [DisplayName("Special Run")]
        [Description("The transport is produced via special run (and with special fares)")]
        public string SpecialRun { get; set; }

        public EdiNotifications Notifications { get; set; }

        public EdiAnonymity Anonymity { get; set; }

        public EdiTimeSlotBooking TimeSlotBooking { get; set; }

    }
}