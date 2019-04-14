using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Detailed information about the exceptions that occured while processing the consignment
    /// </summary>
    [DisplayName("Exceptions")]
    [Description("Detailed information about the exceptions that occured while processing the consignment." +
        "Use (null) to report successful processing of the consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiNotificationEventExceptions
    {
        /// <summary>
        /// Incompatible. The shipment is not within the agreed specifications (e.g. to heavy / big / ...)
        /// </summary>
        [DisplayName("Incompatible")]
        [Description("The shipment is not within the agreed specifications (e.g. to heavy / big / ...)")]
        public bool Incompatible { get; set; }

        /// <summary>
        /// Incomplete. There are some packages missing from this consignment
        /// </summary>
        [DisplayName("Incomplete")]
        [Description("There are some packages missing from this consignment")]
        public bool Incomplete { get; set; }

        /// <summary>
        /// Ultimately lost. Consignment is utimately lost and will no longer be searched for
        /// </summary>
        [DisplayName("Ultimately lost")]
        [Description("Consignment is utimately lost and will no longer be searched for")]
        public bool UltimatelyLost { get; set; }

        /// <summary>
        /// The delivery is obscure
        /// </summary>
        [DisplayName("Delivery obscure")]
        [Description("The delivery is obscure")]
        public bool DeliveryObscure { get; set; }

        public EdiSigningInformation SigningInformation { get; set; }

        public EdiReleaseAuthorizationReceived ReleaseAuthorizationReceived { get; set; }

        public EdiRedirectedTo EdiRedirectedTo { get; set; }

        public EdiArchived Archived { get; set; }

        public EdiDisposed Disposed { get; set; }
    }

    /// <summary>
    /// Detailed information about the exceptions that occured while processing the consignment
    /// </summary>
    [DisplayName("Exceptions")]
    [Description("Detailed information about the exceptions that occured while processing the consignment." +
                 "Use (null) to report successful processing of the consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiUnloadingExceptions
    {
        /// <summary>
        /// The consignment arrived too late for normal processing
        /// </summary>
        [DisplayName("Late arrival")]
        [Description("The consignment arrived too late for normal processing")]
        public bool LateArrival { get; set; }

        /// <summary>
        /// The consignment did not arrive or parts of the consignment are missing
        /// </summary>
        [DisplayName("Missing")]
        [Description("The consignment did not arrive or parts of the consignment are missing")]
        public bool Missing { get; set; }

        /// <summary>
        /// Partly missing in the entrance (additional information number and type of packaging
        /// </summary>
        [DisplayName("Partly Missing")]
        [Description("Partly missing in the entrance (additional information number and type of packaging")]
        public bool PartlyMissing { get; set; }

        /// <summary>
        /// The consignment was damaged on arrival
        /// </summary>
        [DisplayName("Damaged")]
        [Description("The consignment was damaged on arrival")]
        public bool Damaged { get; set; }

        /// <summary>
        /// Packaging differences (additional information number and packaging)
        /// </summary>
        [DisplayName("Packaging Differences")]
        [Description("Packaging differences (additional information number and packaging)")]
        public bool PackagingDifferences { get; set; }

        /// <summary>
        /// Welded pallet, no guarantee for content, as not testable (only applies to non-scannable pallets)
        /// </summary>
        [DisplayName("Not Verifiable")]
        [Description("Welded pallet, no guarantee for content, as not testable (only applies to non-scannable pallets)")]
        public bool NotVerifiable { get; set; }

        /// <summary>
        /// Quantity difference Bordero / Discharge (acquisition error)
        /// </summary>
        [DisplayName("Quantity Differences")]
        [Description("Quantity difference Bordero / Discharge (acquisition error)")]
        public bool QuantityDifferences { get; set; }

        /// <summary>
        /// Unloading - not complete, damaged
        /// </summary>
        [DisplayName("Partly Missing or Damaged")]
        [Description("Unloading - not complete, damaged")]
        public bool PartlyMissingDamaged { get; set; }
    }

    /// <summary>
    /// Detailed information about the exceptions that occured while processing the consignment.
    /// Use (null) to report successful cross dock of the consignment
    /// </summary>
    [DisplayName("Exceptions")]
    [Description("Detailed information about the exceptions that occured while processing the consignment." +
                 "Use (null) to report successful cross dock of the consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiGatewayExceptions
    {
        /// <summary>
        /// The consignment was loaded
        /// </summary>
        [DisplayName("Loaded")]
        [Description("The consigment was loaded")]
        public bool Loaded { get; set; }

        /// <summary>
        /// The consignment did not arrive or parts of the consignment are missing
        /// </summary>
        [DisplayName("Halted")]
        [Description("The consignment has stopped at the cross dock")]
        public bool Halted { get; set; }

       
    }

    /// <summary>
    /// Detailed information about the exceptions that occured while planning the delivery of the consignment.
    /// Use (null) to report successful processing of the consignment
    /// </summary>
    [DisplayName("Exceptions")]
    [Description("Detailed information about the exceptions that occured while planning the delivery of the consignment." +
                 "Use (null) to report successful processing of the consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiDeliveryPlanningExceptions
    {
        /// <summary>
        /// The address of the consignee is not within the area served
        /// </summary>
        [DisplayName("Outside delivery area")]
        [Description("The address of the consignee is not within the area served")]
        public bool OutsideDeliveryArea { get; set; }

        /// <summary>
        /// The consignment will be picked up and delivered later on the day
        /// </summary>
        [DisplayName("Planned for second tour")]
        [Description("The consignment will be picked up and delivered later on the day")]
        public bool PlannedForSecondTour { get; set; }

        /// <summary>
        /// The consignment will not be delivered today
        /// </summary>
        [DisplayName("Not in delivery")]
        [Description("The consignment will not be delivered today")]
        public bool NotInDelivery { get; set; }

        /// <summary>
        /// No time slot for agreed delivery time
        /// </summary>
        [DisplayName("No time slot for agreed delivery time")]
        [Description("No time slot for agreed delivery time")]
        public bool NoTimeSlotForAgreedDeliveryTime { get; set; }

        /// <summary>
        /// Not in delivery - incomplete / incorrect shipment information
        /// </summary>
        [DisplayName("Invalid Shipment Information")]
        [Description("Not in delivery - incomplete / incorrect shipment information")]
        public bool InvalidShipmentInformation { get; set; }

        /// <summary>
        /// Not in delivery - goods damaged
        /// </summary>
        [DisplayName("Damaged")]
        [Description("Not in delivery - goods damaged")]
        public bool Damaged { get; set; }

        /// <summary>
        /// Not delivered - refused consignment, return according to disposal
        /// </summary>
        [DisplayName("Return according to disposal")]
        [Description("Not delivered - refused consignment, return according to disposal")]
        public bool ReturnAccordingToDisposal { get; set; }

        /// <summary>
        /// Not delivered - refused consignment, return - order missing
        /// </summary>
        [DisplayName("Return Disposal Missing")]
        [Description("Not delivered - refused consignment, return - order missing")]
        public bool ReturnDisposalMissing { get; set; }

        /// <summary>
        /// Not on delivery - broadcast in search
        /// </summary>
        [DisplayName("In Research")]
        [Description("Not on delivery - broadcast in search")]
        public bool InResearch { get; set; }

        /// <summary>
        /// The consignee has provided a time slot for delivery
        /// </summary>
        [DisplayName("Time slot from consignee")]
        [Description("The consignee has provided a time slot for delivery")]
        public bool TimeSlotFromConsignee { get; set; }

        /// <summary>
        /// The weather does not permit delivery
        /// </summary>
        [DisplayName("Bad weather conditions")]
        [Description("The weather does not permit delivery")]
        public bool BadWeatherConditions { get; set; }

        /// <summary>
        /// There is no time for the delivery
        /// </summary>
        [DisplayName("Time issue")]
        [Description("There is no time for the delivery")]
        public bool IimeIssue { get; set; }

        /// <summary>
        /// There is a space issue for the delivery
        /// </summary>
        [DisplayName("Space issue")]
        [Description("There is a space issue for the delivery")]
        public bool SpaceIssue { get; set; }

        /// <summary>
        /// Not in delivery - consignment incomplete
        /// </summary>
        [DisplayName("Consignment not complete")]
        [Description("Not in delivery - consignment incomplete")]
        public bool ConsignmentNotComplete { get; set; }

        /// <summary>
        /// Not on delivery - Recipient is self-collector
        /// </summary>
        [DisplayName("Self collector")]
        [Description("Not on delivery - Recipient is self-collector")]
        public bool SelfCollector { get; set; }

        /// <summary>
        /// Not on delivery - regional holiday
        /// </summary>
        [DisplayName("Holidays")]
        [Description("Not on delivery - regional holiday")]
        public bool Holidays { get; set; }

        /// <summary>
        /// Not on delivery - Customs goods
        /// </summary>
        [DisplayName("Customs")]
        [Description("Not on delivery - Customs goods")]
        public bool Customs { get; set; }

        /// <summary>
        /// Not in delivery - Advice of delivery according to EDI
        /// </summary>
        [DisplayName("Waiting for notifications")]
        [Description("Not in delivery - Advice of delivery according to EDI.")]
        public bool WaitingForNotification { get; set; }

        /// <summary>
        /// Not in delivery - Delivery note missing / Accompanying documents incomplete
        /// </summary>
        [DisplayName("Missing documentation")]
        [Description("Not in delivery - Delivery note missing / Accompanying documents incomplete")]
        public bool MissingDocumentation { get; set; }

        /// <summary>
        /// Not in delivery - long-distance traffic from VP / HUB delayed (E2 status)
        /// </summary>
        [DisplayName("Late Arrival")]
        [Description("Not in delivery - long-distance traffic from VP / HUB delayed (E2 status)")]
        public bool LateArrival { get; set; }

        /// <summary>
        /// Not in delivery, Flex according to specification VP
        /// </summary>
        [DisplayName("Standard delivery time sufficient")]
        [Description("Not in delivery, Flex according to specification VP")]
        public bool StandardDeliveryTimeSufficient { get; set; }

        /// <summary>
        /// Loaded from Gateway to...
        /// </summary>
        [DisplayName("Gateway Routing")]
        [Description("Loaded from Gateway to...")]
        public bool GatewayRouting { get; set; }

        /// <summary>
        /// Receiver rejected, not in delivery by telephone refusal to accept...
        /// </summary>
        [DisplayName("Rejected by receiver")]
        [Description("Receiver rejected, not in delivery by telephone refusal to accept...")]
        public bool RejectedByReceiver { get; set; }
    }

    /// <summary>
    /// Detailed information about the exceptions that occured while processing the notification of the consignment
    /// </summary>
    [DisplayName("Exceptions")]
    [Description("Detailed information about the exceptions that occured while processing the notification of the consignment." +
                 "Use (null) to report successful notifcations of the consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiNotificationExceptions
    {
        /// <summary>
        /// The consignee couldn't be reached
        /// </summary>
        [DisplayName("Not reached")]
        [Description("The consignee couldn't be reached")]
        public bool NotReached { get; set; }

        /// <summary>
        /// The (automatic) notification was disabled
        /// </summary>
        [DisplayName("Halted")]
        [Description("The (automatic) notification was disabled")]
        public bool Disabled { get; set; }

        /// <summary>
        /// The consignment was successful, but the goods will be picked up by the customer
        /// </summary>
        [DisplayName("Pickup by the customer")]
        [Description("The consignment was successful, but the goods will be picked up by the customer")]
        public bool PickupCustomer { get; set; }

        /// <summary>
        /// The notification was successful, but the consignment has the wrong address
        /// </summary>
        [DisplayName("Wrong address")]
        [Description("The notification was successful, but the consignment has the wrong address")]
        public bool WrongAddress { get; set; }

        /// <summary>
        /// A Disposal was ordered
        /// </summary>
        [DisplayName("Disposal ordered")]
        [Description("A Disposal was ordered")]
        public bool DisposalOrdered { get; set; }

        /// <summary>
        /// The receiver has not answered in time
        /// </summary>
        [DisplayName("Not answered in time")]
        [Description("The receiver has not answered in time")]
        public bool NotInTime { get; set; }

        /// <summary>
        /// Notification has been canceled
        /// </summary>
        [DisplayName("Canceled")]
        [Description("Notification has been canceled")]
        public bool Canceled { get; set; }

        /// <summary>
        /// Some data is invalid for processing a notification
        /// </summary>
        [DisplayName("Invalid data")]
        [Description("Some data is invalid for processing a notification")]
        public bool InvalidData { get; set; }

        /// <summary>
        /// Some data is missing for processing a notification
        /// </summary>
        [DisplayName("Missing data")]
        [Description("Some data is missing for processing a notification")]
        public bool MissingData { get; set; }
    }

    /// <summary>
    /// Detailed information about the exceptions that occured while starting the delivery of the consignment.
    /// Use (null) to report successful starting of the consignment delivery
    /// </summary>
    [DisplayName("Exceptions")]
    [Description("Detailed information about the exceptions that occured while starting the delivery of the consignment." +
                 "Use (null) to report successful starting of the consignment delivery")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiDeliveryStartedExceptions
    {
        /// <summary>
        /// There is no sufficient capacity available to perform delivery at the moment
        /// </summary>
        [DisplayName("No capacity available")]
        [Description("There is no sufficient capacity available to perform delivery at the moment")]
        public bool NoCapacity { get; set; }
    }
}
