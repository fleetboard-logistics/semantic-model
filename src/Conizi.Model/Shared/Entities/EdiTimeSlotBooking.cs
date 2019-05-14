using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Information about time slots which need to be booked or are already booked for the pickup or the following consignment
    /// </summary>
    
    [DisplayName("Time slot booking")]
    [Description("Information about time slots which need to be booked or are already booked for this consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiTimeSlotBooking : EdiPatternPropertiesBase
    {
        /// <summary>
        /// A time slot must be book by the delivering partner before making a delivery attempt
        /// </summary>
        public EdiPartnerIdentification ByDeliveryPartner { get; set; }

        /// <summary>
        /// A time slot must be book by the contracted partner before making the pickup attempt
        /// </summary>
        public EdiPartnerIdentification ByContractedPartner { get; set; }

        /// <summary>
        /// A time slot has already been booked for the delivery of this consignment. Delivery must be attempted within this time slot
        /// </summary>
        public EdiPreBookedTimeslot PreBookedTimeslot { get; set; }
    }

    /// <summary>
    /// A time slot has already been booked for the delivery of this consignment. Delivery must be attempted within this time slot
    /// </summary>
    
    [DisplayName("Pre booked time slot")]
    [Description("A time slot has already been booked for the delivery of this consignment. Delivery must be attempted within this time slot")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPreBookedTimeslot : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Info about the pre booked time slot
        /// </summary>
        [DisplayName("Info about pre booked time slot")]
        [Description("Info about the pre booked time slot")]
        [JsonProperty("info", Required = Required.AllowNull)]
        public string Info { get; set; }
    }
}
