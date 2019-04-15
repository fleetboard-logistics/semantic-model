using System;
using System.Collections.Generic;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{
    /// <summary>
    /// An event which occured during the processing of the referenced consignment <see cref="Consignment"/>
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/transport/truck/groupage/forwarding/consignment-event.json",
        "consignment-event.json")]
    [DisplayName("Consignment event")]
    [Description("An event which occured during the processing of the referenced consignment")]
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
        /// Shipping date
        /// </summary>
        [DisplayName("Shipping date")]
        [JsonProperty(PropertyName = "shippingDate")]
        [ConiziDateOnly]
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
        /// Events occured while validating and processing the data
        /// </summary>
        public EdiDataProcessing DataProcessing { get; set; }

        /// <summary>
        /// Events occured while physically processing the consignment (e.g. moving goods, scanning packages)
        /// </summary>
        public EdiGeneralProcessingNotification GeneralProcessingNotification { get; set; }

        /// <summary>
        /// Events occured while unloading the consignment
        /// </summary>
        public EdiUnloading Unloading { get; set; }

        /// <summary>
        /// Events occured while cross docking the consignment. (i.e. HUB or gateway cross dock)
        /// </summary>
        public EdiGateway Gateway { get; set; }

        /// <summary>
        /// Events occured while planning the delivery of the consignment
        /// </summary>
        public EdiDeliveryPlanning DeliveryPlanning { get; set; }

        /// <summary>
        /// Events occured while processing the notification of the consignment
        /// </summary>
        public EdiEventNotification Notification { get; set; }

        /// <summary>
        /// Events indicating the start of the delivery
        /// </summary>
        public EdiEventDeliveryStarted DeliveryStarted { get; set; }

        /// <summary>
        /// Events occured regarding the estimated time of arrival at receiver
        /// </summary>
        public EdiEventEstimatedArrivalAtReceiver EstimatedArrivalAtReceiver { get; set; }

        /// <summary>
        /// Events occured while arriving the receiver
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
        public int WaitDowntimeMinutes { get; set; }
    }



    public class EdiGeneralProcessingNotification : EdiEventBase
    {
        public EdiNotificationEventExceptions Exceptions { get; set; } 


        /// <summary>
        /// Additional remarks
        /// </summary>
        [DisplayName("Remarks (free form)")]
        [Description("Additional remarks")]
        public string Remarks { get; set; }
    }

  
    /// <summary>
    /// Documents have been archived
    /// </summary>
    [DisplayName("Archived")]
    [Description("Documents have been archived")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiArchived : EdiPatternPropertiesBase
    {

        /// <summary>
        /// Proof of delivery was archived
        /// </summary>
        [DisplayName("Proof of Delivery")]
        [Description("Proof of delivery was archived")]
        public bool Pod { get; set; }

        /// <summary>
        /// Delivery notes were archived
        /// </summary>
        [DisplayName("Delivery notes")]
        [Description("Delivery notes were archived")]
        public bool DeliveryNote { get; set; }

        /// <summary>
        /// Customs papers were archived
        /// </summary>
        [DisplayName("Customs papers")]
        [Description("Customs papers were archived")]
        public bool CustomsPapers { get; set; }

        /// <summary>
        /// Pictures of damages were archived
        /// </summary>
        [DisplayName("Damage Pictures")]
        [Description("Pictures of damages were archived")]
        public bool DamagePictures { get; set; }
    }

    public class EdiDataProcessing
    {
    }

    /// <summary>
    /// Signing Information
    /// </summary>
    [DisplayName("Signing Information")]
    [Description("Transmission of the receipt, the delivery date and the delivery time")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiSigningInformation
    {



    }

    /// <summary>
    /// Release authorization received
    /// </summary>
    [DisplayName("Release authorization received")]
    [Description("Receiver allows dropoff")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiReleaseAuthorizationReceived
    {

    }

    /// <summary>
    /// The consignment is redirected to...
    /// </summary>
    [DisplayName("Redirected to")]
    [Description("The consignment is redirected to...")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiRedirectedTo
    {
        /// <summary>
        /// Redirected to sender
        /// </summary>
        public bool Sender { get; set; }

        /// <summary>
        /// Redirected to source partner
        /// </summary>
        public bool SourcePartner { get; set; } 
        
        /// <summary>
        /// Redirected to receiving Partner
        /// </summary>
        public bool ReceivingPartner { get; set; }

    }

    /// <summary>
    /// Consignment was disposed
    /// </summary>
    [DisplayName("Disposed")]
    [Description("Consignment was disposed")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiDisposed
    {

    }

    /// <summary>
    /// Events occured while unloading the consignment
    /// </summary>
    [DisplayName("Unloading")]
    [Description("Events occured while unloading the consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiUnloading : EdiEventBase
    {
        /// <summary>
        /// Detailed information about the exceptions that occured while processing the consignment.
        /// Use (null) to report successful processing of the consignment
        /// </summary>
        public EdiUnloadingExceptions Exceptions { get; set; }
    }

    /// <summary>
    /// Events occured while cross docking the consignment. (i.e. HUB or gateway cross dock)
    /// </summary>
    [DisplayName("Cross dock")]
    [Description("Events occured while cross docking the consignment. (i.e. HUB or gateway cross dock)")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEventGateway : EdiEventBase
    {

        /// <summary>
        /// The consignment has been loaded onto the truck leaving the gateway
        /// </summary>
        [DisplayName("The consignment has been loaded")]
        [Description("The consignment has been loaded onto the truck leaving the gateway")]
        public bool Loaded { get; set; }

        /// <summary>
        /// The consignment has been unloaded from the truck delivering the consignment to the gateway
        /// </summary>
        [DisplayName("The consignment has been unloaded")]
        [Description("The consignment has been unloaded from the truck delivering the consignment to the gateway")]
        public bool Unloaded { get; set; }

        /// <summary>
        /// Detailed information about the exceptions that occured while processing the consignment.
        /// Use (null) to report successful cross dock of the consignment
        /// </summary>
        public EdiGatewayExceptions Exceptions { get; set; }

    }

    /// <summary>
    /// Events occured while planning the delivery of the consignment
    /// </summary>
    [DisplayName("Delivery planning")]
    [Description("Events occured while planning the delivery of the consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiDeliveryPlanning : EdiEventBase
    {
       
        /// <summary>
        /// Detailed information about the exceptions that occured while planning the delivery of the consignment.
        /// Use (null) to report successful processing of the consignment
        /// </summary>
        public EdiDeliveryPlanningExceptions Exceptions { get; set; }
    }

    /// <summary>
    /// Events occured while processing the notification of the consignment
    /// </summary>
    [DisplayName("Notification")]
    [Description("Events occured while processing the notification of the consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEventNotification : EdiEventBase
    {
        public EdiTrigger Trigger { get; set; }
    }

    /// <summary>
    /// Event that is a trigger for starting a notification
    /// </summary>
    [DisplayName("Trigger")]
    [Description("Event that is a trigger for starting a notification")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiTrigger : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Start a manual notification
        /// </summary>
        [DisplayName("Manually")]
        [Description("Start a manual notification")]
        public bool Manually { get; set; }

        /// <summary>
        /// Start an automatic notification (i.e. automatic notification system via email or SMS)
        /// </summary>
        [DisplayName("Automatic")]
        [Description("Start an automatic notification (i.e. automatic notification system via email or SMS)")]
        public bool Automatic { get; set; }
    }

    /// <summary>
    /// Events indicating the start of the delivery
    /// </summary>
    [DisplayName("Delivery started")]
    [Description("Events indicating the start of the delivery")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEventDeliveryStarted: EdiEventBase
    {
        /// <summary>
        /// Number of the planned / assigned local traffic tour for delivery
        /// </summary>
        [DisplayName("Tour number")]
        [Description("Number of the planned / assigned local traffic tour for delivery")]
        public string TourNumber { get; set; }

        public EdiDeliveryStartedExceptions Exceptions { get; set; }

    }

    /// <summary>
    /// Events indicating the start of the delivery
    /// </summary>
    [DisplayName("Arrival at receiver")]
    [Description("Events occured while arriving the receiver")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEventArrivalAtReceiver : EdiEventBase
    {
      
    }

    /// <summary>
    /// Events occured regarding the estimated time of arrival at receiver
    /// </summary>
    [DisplayName("Estimated time of arrival at receiver")]
    [Description("Events occured regarding the estimated time of arrival at receiver")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEventEstimatedArrivalAtReceiver : EdiEventBase
    {
        /// <summary>
        /// Date and time of the estimated arrival
        /// </summary>
        [DisplayName("Estimated arrival date/time")]
        [Description("Date and time of the estimated arrival")]
        public string EstimatedArrivalTime { get; set; }
    }

    /// <summary>
    /// Events indicating a failed delivery attempt
    /// </summary>
    [DisplayName("Delivery attempt failed")]
    [Description("Events indicating a failed delivery attempt")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEventDeliveryAttemptFailed : EdiEventBase
    {
        /// <summary>
        /// Number of the consignment which is used to return the goods to the shipper
        /// </summary>
        [DisplayName("Return consignment no")]
        [Description("Number of the consignment which is used to return the goods to the shipper")]
        public string ReturnConsignmentNo { get; set; }

        /// <summary>
        /// Name of the person which rejected the consignment
        /// </summary>
        [DisplayName("Signee")]
        [Description("Name of the person which rejected the consignment")]
        public string Signee { get; set; }

        /// <summary>
        /// Time spent waiting during delivery
        /// </summary>
        [DisplayName("Wait time")]
        [Description("Time spent waiting during delivery")]
        public string WaitTime { get; set; }
    }

    /// <summary>
    ///Events indicating successful delivery
    /// </summary>
    [DisplayName("Delivery successful")]
    [Description("Events indicating successful delivery")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEventDeliverySuccessful : EdiEventBase
    {
        /// <summary>
        /// Detailed information about the exceptions that occured when consignment was successfully delivered
        /// </summary>
        public EdiDeliverySuccessfulExceptions Exceptions { get; set; }

        /// <summary>
        /// Name of the person which rejected the consignment
        /// </summary>
        [DisplayName("Signee")]
        [Description("Name of the person which rejected the consignment")]
        public string Signee { get; set; }

        /// <summary>
        /// Time spent waiting during delivery
        /// </summary>
        [DisplayName("Wait time")]
        [Description("Time spent waiting during delivery")]
        public string WaitTime { get; set; }
    }

    /// <summary>
    ///Events indicating successful completion of a task, consignment has been forwarded
    /// </summary>
    [DisplayName("Work completed - forwarded")]
    [Description("Events indicating successful completion of a task, consignment has been forwarded")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEventCompletion: EdiEventBase
    {
        /// <summary>
        /// Completed by another party
        /// </summary>
        [DisplayName("Completed by")]
        [Description("Completed by another party")]
        public bool CompletedBy { get; set; }

        /// <summary>
        /// Consignment was forwarded
        /// </summary>
        [DisplayName("Forwarded")]
        [Description("Consignment was forwarded")]
        public bool Forwarded { get; set; }

        /// <summary>
        /// Name of the person which rejected the consignment
        /// </summary>
        [DisplayName("Signee")]
        [Description("Name of the person which rejected the consignment")]
        public string Signee { get; set; }

        /// <summary>
        /// Time spent waiting during delivery
        /// </summary>
        [DisplayName("Wait time")]
        [Description("Time spent waiting during delivery")]
        public string WaitTime { get; set; }
    }

    /// <summary>
    /// Events indicating new information that should be added/updated in the consignment
    /// </summary>
    [DisplayName("Change request")]
    [Description("A new delivery term that should be considered for billing")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEventChangeRequest : EdiEventBase
    {

        /// <summary>
        /// A new delivery term that should be considered for billing
        /// </summary>
        [DisplayName("Billing - Delivery term")]
        [Description("A new delivery term that should be considered for billing")]
        public bool BillingDeliveryTerm { get; set; }

        /// <summary>
        /// The area occupied by the consignment - expressed in standard pallet sizes
        /// </summary>
        [DisplayName("Billing - Area (in pallet bays)")]
        [Description("The area occupied by the consignment - expressed in standard pallet sizes")]
        public string BillingAreaPalletBays { get; set; }

        /// <summary>
        /// The area occupied by the consignment - expressed in loading meters
        /// </summary>
        [DisplayName("Billing - Loading meter")]
        [Description("The area occupied by the consignment - expressed in loading meters")]
        public string BillingLoadingMeter { get; set; }
    }

    /// <summary>
    /// Events indicating the cancellation of the consignment
    /// </summary>
    [DisplayName("Cancellation")]
    [Description("Events indicating the cancellation of the consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class Cancellation : EdiEventBase
    {

    }
}