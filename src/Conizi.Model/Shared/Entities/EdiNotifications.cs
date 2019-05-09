using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Notifications which should be sent while processing the shipment, e.g. notifications about successful delivery, advance notifications, ...
    /// </summary>
    
    [DisplayName("Notifications")]
    [Description("Notifications which should be sent while processing the shipment, e.g. notifications about successful delivery, advance notifications, ...")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiNotifications : EdiPatternPropertiesBase
    {
        /// <summary>
        /// An address and associated contact information which should be kept in the loop
        /// </summary>
        public EdiAddress GeneralNotificationAddress { get; set; }

        /// <summary>
        /// Information about successful delivery should be given to this address
        /// </summary>
        public EdiAddress AfterDelivery { get; set; }

        /// <summary>
        /// Before a delivery is attempted the person noted here should be contacted within the given time frame
        /// </summary>
        public EdiNotifyBeforePickupDeliver BeforeDelivery { get; set; }

        /// <summary>
        /// The driver should call the given contact before delivery
        /// </summary>
        public EdiAddress ByDriver { get; set; }

    }



    /// <summary>
    /// Notifications which should be sent while processing the shipment, e.g. notifications about successful delivery, advance notifications for the pickup order
    /// </summary>
    
    [DisplayName("Notifications")]
    [Description("Notifications which should be sent while processing the shipment, e.g. notifications about successful delivery, advance notifications, ...")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPickupNotifications : EdiNotifications
    {
        /// <summary>
        /// Before a pickup is attempted the address noted here should be contacted within the given time frame
        /// </summary>
        public EdiNotifyBeforePickupDeliver BeforePickup { get; set; }

        /// <summary>
        /// Information about successful pickup should be given to this address
        /// </summary>
        public EdiAddress AfterPickup { get; set; }

        /// <summary>
        /// The driver should call the given contact before pickup
        /// </summary>
        public EdiAddress ByDriverBeforePickup { get; set; }

    }

    /// <summary>
    /// Before a pickup or delivery is attempted the address noted here, should be contacted within the given time frame
    /// </summary>
    [DisplayName("Before pickup / deliver")]
    [Description("Before a pickup or delivery is attempted the address noted here, should be contacted within the given time frame")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiNotifyBeforePickupDeliver : EdiAddress
    {
        /// <summary>
        /// Time frame begin for notification before delivery
        /// </summary>
        [DisplayName("Lead Time Seconds Minimum")]
        [Description("Time frame begin for notification before delivery")]
        public int LeadTimeSecondsMinimum { get; set; }
        
        /// <summary>
        /// Time frame end for notification before delivery
        /// </summary>
        [DisplayName("Lead Time Seconds Maximum")]
        [Description("Time frame end for notification before delivery")]
        public int LeadTimeSecondsMaximum { get; set; }
    }
}