using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
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
        /// Numbers of various sources identifying this transport order or references from this tour to other business processes
        /// </summary>
        [JsonProperty("references", Order = -5)]
        [Required]
        public new EdiDocumentReferences References { get; set; }

        /// <summary>
        /// A list of status images
        /// </summary>
        [JsonProperty(Order = -4)]
        public List<EdiStatusImage> Images { get; set; }
        
        /// <summary>
        /// A list of document items
        /// </summary>
        [JsonProperty(Order = -3)]
        public List<EdiDocumentItem> Documents { get; set; }

    }
}
