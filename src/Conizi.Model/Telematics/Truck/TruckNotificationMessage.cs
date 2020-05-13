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
    /// A notification message is a message that can be sent either by the driver, via a mobile application,
    /// or by the dispatcher, via the Transport Management System
    /// </summary>
    /// <remarks>
    /// This message is not intended for real time communication, so as live chat. There are other possibilities for this.
    /// </remarks>
    [DisplayName("Notification Message")]
    [Description("A notification message is a message that can be sent either by the driver, via a mobile application, or by the dispatcher, via the Transport Management System")]
    [ConiziSchema("https://model.conizi.io/v1/telematics/truck/truck-notification-message.json", "truck-notification-message.json")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class TruckNotificationMessage : EdiModel
    {
        /// <summary>
        /// An unique message id like a GUID
        /// </summary>
        [DisplayName("Message Id")]
        [Description("An unique message id like a GUID")]
        [JsonProperty("messageId", Order = -12)]
        [Required]
        public string MessageId { get; set; }

        /// <summary>
        /// The type of the message as free text... default is text-message
        /// </summary>
        [DisplayName("Message Type")]
        [Description("The type of the message as free text... default is text-message")]
        [JsonProperty("MessageType", Order = -11)]
        [Required]
        public string MessageType { get; set; } = "text";
        
        /// <summary>
        /// Date and time when the notification was sent
        /// </summary>
        [DisplayName("Send Date-time")]
        [Description("Date and time when the notification was sent")]
        [JsonProperty("sendDateTime", Order = -10)]
        [Required]
        public DateTime SendDateTime { get; set; }

        /// <summary>
        /// The text message
        /// </summary>
        [DisplayName("Message")]
        [Description("The text message")]
        [JsonProperty("message", Order = -8)]
        [Required]
        public string Message { get; set; }

        /// <summary>
        /// A reference to the original message (id)
        /// </summary>
        [DisplayName("Message Id Reference")]
        [Description("A reference to the original message (id)")]
        [JsonProperty(Order = -7)]
        public string MessageIdRef { get; set; }

        /// <summary>
        /// Object to transmit file attachments
        /// </summary>
        public EdiFileAttachment FileAttachment { get; set; }

        /// <summary>
        /// The current geo position of the sender
        /// </summary>
        public EdiGeoPosition SenderGeoPosition { get; set; } 

    }
}
