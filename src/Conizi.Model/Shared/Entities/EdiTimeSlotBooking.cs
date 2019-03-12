using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("timeSlotBooking")]
    [DisplayName("Time slot booking")]
    [Description("Information about time slots which need to be booked or are already booked for this consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiTimeSlotBooking
    {
        public EdiPartnerIdentification ByDeliveryPartner { get; set; }

        public EdiPreBookedTimeslot PreBookedTimeslot { get; set; }

    }

    [JsonObject("preBookedTimeslot")]
    [DisplayName("Pre booked time slot")]
    [Description("A time slot has already been booked for the delivery of this consignment. Delivery must be attempted within this time slot")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPreBookedTimeslot
    {
        [JsonProperty("info", Required = Required.AllowNull)]
        public string Info { get; set; }
    }
}
