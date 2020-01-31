using System;
using System.Collections.Generic;
using System.ComponentModel;
using Conizi.Model.Converters;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{
    /// <summary>
    /// An event which occurred during the processing of the referenced consignment <see cref="Consignment"/>
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/transport/truck/groupage/forwarding/consignment-event.json",
        "consignment-event.json")]
    [DisplayName("Consignment event")]
    [Description("An event which occurred during the processing of the referenced consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class ConsignmentEvent : EdiModel
    {
        /// <summary>
        /// Consignment number of the shipping partner
        /// </summary>
        [JsonRequired]
        [DisplayName("Consignment number of the shipping partner")]
        [Description(
            "Unique identification for the consignment within the transport management system of the shipping partner")]
        public string ConsignmentNoShippingPartner { get; set; }

        /// <summary>
        /// Consignment number of the receiving partner
        /// </summary>
        [DisplayName("Consignment number of the receiving partner")]
        [Description(
            "Unique identification for the consignment within the transport management system of the receiving partner")]
        public string ConsignmentNoReceivingPartner { get; set; }

        /// <summary>
        /// Consignment number of the delivering partner
        /// </summary>
        [DisplayName("Consignment number of the delivering partner")]
        [Description(
            "Unique identification for the consignment within the transport management system of the delivering partner")]
        public string ConsignmentNoDeliveringPartner { get; set; }

        /// <summary>
        /// Unique identification for the consignment in a central system
        /// </summary>
        [DisplayName("Unique central consignment number")]
        [Description("Unique identification for the consignment in a central system")]
        public string ConsignmentObjectId { get; set; }

        /// <summary>
        /// Shipping date
        /// </summary>
        [DisplayName("Shipping date")]
        [JsonProperty(PropertyName = "shippingDate")]
        [ConiziDateOnly]
        [JsonConverter(typeof(ConiziDateConverter))]
        public DateTime ShippingDate { get; set; }

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
        /// Person or company that ordered the transport of the consignment. Often identical to the shipper
        /// </summary>
        public EdiAddress OrderingParty { get; set; }

        /// <summary>
        /// Events occurred while validating and processing the data
        /// </summary>
        public EdiDataProcessing DataProcessing { get; set; }

        /// <summary>
        /// Events occurred while physically processing the consignment (e.g. moving goods, scanning packages)
        /// </summary>
        public EdiGeneralProcessingNotification GeneralProcessingNotification { get; set; }

        /// <summary>
        /// Events occurred while unloading the consignment
        /// </summary>
        public EdiUnloading Unloading { get; set; }

        /// <summary>
        /// Events occurred while cross docking the consignment. (i.e. HUB or gateway cross dock)
        /// </summary>
        public EdiEventGateway Gateway { get; set; }

        /// <summary>
        /// Events occurred while planning the delivery of the consignment
        /// </summary>
        public EdiDeliveryPlanning DeliveryPlanning { get; set; }

        /// <summary>
        /// Events occurred while processing the notification of the consignment
        /// </summary>
        public EdiEventNotification Notification { get; set; }

        /// <summary>
        /// Events indicating the start of the delivery
        /// </summary>
        public EdiEventDeliveryStarted DeliveryStarted { get; set; }

        /// <summary>
        /// Events occurred regarding the estimated time of arrival at receiver
        /// </summary>
        public EdiEventEstimatedArrivalAtReceiver EstimatedArrivalAtReceiver { get; set; }

        /// <summary>
        /// Events occurred while arriving the receiver
        /// </summary>
        public EdiEventArrivalAtReceiver ArrivalAtReceiver { get; set; }

        /// <summary>
        /// Events indicating a failed delivery attempt
        /// </summary>
        public EdiEventDeliveryAttemptFailed DeliveryAttemptFailed { get; set; }

        /// <summary>
        /// Events indicating successful delivery
        /// </summary>
        public EdiEventDeliverySuccessful DeliverySuccessful { get; set; }

        /// <summary>
        /// Events indicating successful completion of a task, consignment has been forwarded
        /// </summary>
        public EdiEventCompletion Completion { get; set; }

        /// <summary>
        /// Events indicating new information that should be added/updated in the consignment
        /// </summary>
        public EdiEventChangeRequest ChangeRequest { get; set; }

        /// <summary>
        /// Events indicating new information that should be added/updated in the consignment
        /// </summary>
        public EdiEventCancellation Cancellation { get; set; }

        /// <summary>
        /// Original event code
        /// </summary>
        [DisplayName("Original event code")]
        [Description("Original event code")]
        public string OriginalEventCode { get; set; }

        /// <summary>
        /// Additional remarks (free form)
        /// </summary>
        [DisplayName("Additional remarks")]
        [Description("Additional remarks (free form)")]
        public List<string> AdditionalRemarks { get; set; }

        /// <summary>
        /// Reference number of the parent consignment
        /// </summary>
        [DisplayName("Reference number")]
        [Description("Reference number")]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Wait/Downtime in minute
        /// </summary>
        [DisplayName("Wait/Downtime in minute")]
        [Description("Wait/Downtime in minute")]
        public int? WaitDowntimeMinutes { get; set; }

        /// <summary>
        /// The geo position
        /// </summary>
        [JsonProperty("geoPosition", Order = -15, Required = Required.DisallowNull)]
        public EdiGeoPosition GeoPosition { get; set; }

        /// <summary>
        /// A list of document items
        /// </summary>
        public List<EdiDocumentItem> Documents { get; set; }

        /// <summary>
        /// A list of status images
        /// </summary>
        public List<EdiStatusImage> Images { get; set; }
    }
}