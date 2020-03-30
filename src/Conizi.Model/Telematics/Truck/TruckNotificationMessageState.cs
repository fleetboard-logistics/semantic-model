using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Telematics.Truck
{
    /// <summary>
    /// A notification message state is used to send a state back to the original message sender
    /// </summary>
    [DisplayName("Notification Message Sate")]
    [Description("A notification message response is used to send a state back to the original message state")]
    [ConiziSchema("https://model.conizi.io/v1/telematics/truck/truck-notification-message-state.json", "truck-notification-message-state.json")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class TruckNotificationMessageState : EdiModel
    {
        /// <summary>
        /// A reference to the original message (id)
        /// </summary>
        [DisplayName("Message Id Reference")]
        [Description("A reference to the original message (id)")]
        [JsonProperty(Order = -12)]
        [Required]
        public string MessageIdRef { get; set; }

        /// <summary>Delivered
        /// Date and time when the response was sent
        /// </summary>
        [DisplayName("Send Date-time")]
        [Description("Date and time when the state was sent")]
        [JsonProperty("sendDateTime", Order = -10)]
        [Required]
        public DateTime SendDateTime { get; set; }

        /// <summary>
        /// Returns information about the state of the original message
        /// </summary>
        [Required]
        public TruckNotificationMessageResponseStates States { get; set; }

        /// <summary>
        /// The current geo position of the sender
        /// </summary>
        public EdiGeoPosition SenderGeoPosition { get; set; }
    }

    /// <summary>
    /// Returns information about the state of the original message
    /// </summary>
    [DisplayName("Notification Message States")]
    [Description("Returns information about the state of the original message")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class TruckNotificationMessageResponseStates : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Original message was delivered 
        /// </summary>
        [DisplayName("Delivered")]
        [Description("Original message was delivered")]
        public bool? Delivered { get; set; }

        /// <summary>
        /// Original message was not delivered! 
        /// </summary>
        [DisplayName("Delivery Failed")]
        [Description("Original message was not delivered! ")]
        public bool? DeliveryFailed { get; set; }

        /// <summary>
        /// Original message was read
        /// </summary>
        [DisplayName("Message Read")]
        [Description("Original message was read")]
        public bool? MessageWasRead { get; set; }
    }
}
