using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Shared.Entities.Consignment;
using Conizi.Model.Transport.Truck.Groupage.Forwarding.Helper;
using Conizi.Model.Transport.Truck.Groupage.Forwarding.Helper.Tour;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{
    /// <summary>
    /// An event which occurred during the processing of the referenced pickup order <seealso cref="PickupOrder"/>
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/transport/truck/groupage/forwarding/pickuporder-event.json",
        "pickuporder-event.json")]
    [DisplayName("Pickup order event")]
    [Description("An event which occurred during the processing of the referenced pickup order")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class PickupOrderEvent : EdiModel
    {
        /// <summary>
        /// Unique identification for the pickup order within the transport management system of the contract partner
        /// </summary>
        [DisplayName("Pickup order number of the contract partner")]
        [Description("Unique identification for the pickup order within the transport management system of the contract partner")]
        [JsonProperty("tourId", Order = -10, Required = Required.Always)]
        public string PickupOrderNo { get; set; }

        /// <summary>
        /// Pickup order date
        /// </summary>
        [DisplayName("Pickup order date")]
        [Description("The date on which the pickup order was forwarded to the contracted partner")]
        [JsonProperty("pickupOrderDate", Order = -9)]
        [ConiziDateOnly]
        public DateTime PickupOrderDate { get; set; }

        /// <summary>
        /// Person or company that ordered the transport of the consignment. Often identical to the shipper
        /// </summary>
        public EdiAddress OrderingParty { get; set; }

        /// <summary>
        /// The partner which is sending the pickup order to the contracted partner for pickup
        /// </summary>
        public EdiPartnerIdentification OrderingPartner { get; set; }

        /// <summary>
        /// TThe partner which is contracted for processing the pickup order
        /// </summary>
        public EdiPartnerIdentification ContractedPartner { get; set; }


        /// <summary>
        /// The partner which is sending the consignment to the receiving partner for further delivery
        /// </summary>
        public EdiPartnerIdentification ShippingPartner { get; set; }

        /// <summary>
        /// The partner which is receiving the goods declared on the manifest from the shipping partner for further delivery
        /// </summary>
        public EdiPartnerIdentification ReceivingPartner { get; set; }

        /// <summary>
        /// The partner which is reporting the event
        /// </summary>
        public EdiPartnerIdentification ReportingPartner { get; set; }

        /// <summary>
        /// Events occurred while validating and processing the data
        /// </summary>
        public EdiDataProcessing DataProcessing { get; set; }

        /// <summary>
        /// Events occurred while physically processing the consignment (e.g. moving goods, scanning packages)
        /// </summary>
        public EdiGeneralProcessingNotification GeneralProcessingNotification { get; set; }

        /// <summary>
        /// Events occurred while planning a pickup order
        /// </summary>
        public EdiPickupPlanning PickupPlanning { get; set; }

        /// <summary>
        /// Events occurred while starting a pickup order
        /// </summary>
        public EdiPickupStarted PickupStarted { get; set; }

        /// <summary>
        /// Events occurred while arrival a pickup location
        /// </summary>
        public EdiPickupArrival PickupArrival { get; set; }

        /// <summary>
        /// Events occurred while pickup finished at shipper
        /// </summary>
        public EdiPickupFinishedAtShipper PickupFinishedAtShipper { get; set; }

        /// <summary>
        /// Events occurred while pickup loading started
        /// </summary>
        public EdiPickupLoadingStarted PickupLoadingStarted { get; set; }

        /// <summary>
        /// Events occurred while pickup loading completed
        /// </summary>
        public EdiPickupLoadingCompleted PickupLoadingCompleted { get; set; }

        /// <summary>
        /// Events indicating a failed pickup attempt
        /// </summary>
        public EdiPickupAttemptFailed PickupAttemptFailed { get; set; }


    }
}
