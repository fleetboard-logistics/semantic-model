using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;
using Conizi.Model.Transport.Truck.Groupage.Forwarding.Helper.Tour;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Conizi.Model.Shared.Entities
{

    /// <summary>
    /// The empty EdiEmptyExtendableObject is used for non yet completed defined objects.
    /// This EdiEmptyExtendableObject is extendable with PatternProperties
    /// </summary>
    [DisplayName("Empty Extendable Object")]
    [Description("The empty EmptyExtendableObject is used for non yet completed defined objects. ")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    [JsonObject("emptyExtendableObject")]
    public class EdiEmptyExtendableObject : EdiPatternPropertiesBase
    {

    }

    /// <summary>
    /// Detailed information about the exceptions that occurred while processing the consignment/pickup
    /// </summary>
    [DisplayName("Exceptions")]
    [Description("Detailed information about the exceptions that occurred while processing the consignment/pickup." +
        "Use (null) to report successful processing of the consignment/pickup")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiNotificationEventExceptions : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Incompatible. The shipment is not within the agreed specifications (e.g. to heavy / big / ...)
        /// </summary>
        //DisplayName("Incompatible")]
        //[Description("The shipment is not within the agreed specifications (e.g. to heavy / big / ...)")]
        public EdiEmptyExtendableObject Incompatible { get; set; }

        /// <summary>
        /// Incomplete. There are some packages missing from this consignment
        /// </summary>
        //[DisplayName("Incomplete")]
        //[Description("There are some packages missing from this consignment")]
        public EdiEmptyExtendableObject Incomplete { get; set; }

        /// <summary>
        /// Ultimately lost. Consignment is utimately lost and will no longer be searched for
        /// </summary>
        //[DisplayName("Ultimately lost")]
        //[Description("Consignment is utimately lost and will no longer be searched for")]
        public EdiEmptyExtendableObject UltimatelyLost { get; set; }

        /// <summary>
        /// The delivery is obscure
        /// </summary>
        //[DisplayName("Delivery obscure")]
        //[Description("The delivery is obscure")]
        public EdiEmptyExtendableObject DeliveryObscure { get; set; }

        public EdiSigningInformation SigningInformation { get; set; }

        public EdiReleaseAuthorizationReceived ReleaseAuthorizationReceived { get; set; }

        public EdiRedirectedTo EdiRedirectedTo { get; set; }

        public EdiArchived Archived { get; set; }

        public EdiDisposed Disposed { get; set; }
    }

    /// <summary>
    /// Detailed information about the exceptions that occurred while processing the consignment
    /// </summary>
    [DisplayName("Exceptions")]
    [Description("Detailed information about the exceptions that occurred while processing the consignment." +
                 "Use (null) to report successful processing of the consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiUnloadingExceptions : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The consignment arrived too late for normal processing
        /// </summary>
        //[DisplayName("Late arrival")]
        //[Description("The consignment arrived too late for normal processing")]
        public EdiEmptyExtendableObject LateArrival { get; set; }

        /// <summary>
        /// The consignment did not arrive or parts of the consignment are missing
        /// </summary>
        //[DisplayName("Missing")]
        //[Description("The consignment did not arrive or parts of the consignment are missing")]
        public EdiEmptyExtendableObject Missing { get; set; }

        /// <summary>
        /// Partly missing in the entrance (additional information number and type of packaging
        /// </summary>
        //[DisplayName("Partly Missing")]
        //[Description("Partly missing in the entrance (additional information number and type of packaging")]
        public EdiEmptyExtendableObject PartlyMissing { get; set; }

        /// <summary>
        /// The consignment was damaged on arrival
        /// </summary>
        //[DisplayName("Damaged")]
        //[Description("The consignment was damaged on arrival")]
        public EdiEmptyExtendableObject Damaged { get; set; }

        /// <summary>
        /// Packaging differences (additional information number and packaging)
        /// </summary>
        //[DisplayName("Packaging Differences")]
        //[Description("Packaging differences (additional information number and packaging)")]
        public EdiEmptyExtendableObject PackagingDifferences { get; set; }

        /// <summary>
        /// Welded pallet, no guarantee for content, as not testable (only applies to non-scannable pallets)
        /// </summary>
        //[DisplayName("Not Verifiable")]
        //[Description("Welded pallet, no guarantee for content, as not testable (only applies to non-scannable pallets)")]
        public EdiEmptyExtendableObject NotVerifiable { get; set; }

        /// <summary>
        /// Quantity difference Bordero / Discharge (acquisition error)
        /// </summary>
        //[DisplayName("Quantity Differences")]
        //[Description("Quantity difference Bordero / Discharge (acquisition error)")]
        public EdiEmptyExtendableObject QuantityDifferences { get; set; }

        /// <summary>
        /// Unloading - not complete, damaged
        /// </summary>
        //[DisplayName("Partly Missing or Damaged")]
        //[Description("Unloading - not complete, damaged")]
        public EdiEmptyExtendableObject PartlyMissingDamaged { get; set; }
    }

    /// <summary>
    /// Detailed information about the exceptions that occurred while processing the consignment.
    /// Use (null) to report successful cross dock of the consignment
    /// </summary>
    [DisplayName("Exceptions")]
    [Description("Detailed information about the exceptions that occurred while processing the consignment." +
                 "Use (null) to report successful cross dock of the consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiGatewayExceptions : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The consignment was loaded
        /// </summary>
        //[DisplayName("Loaded")]
        //[Description("The consigment was loaded")]
        public EdiEmptyExtendableObject Loaded { get; set; }

        /// <summary>
        /// The consignment did not arrive or parts of the consignment are missing
        /// </summary>
        //[DisplayName("Halted")]
        //[Description("The consignment has stopped at the cross dock")]
        public EdiEmptyExtendableObject Halted { get; set; }

    }

    /// <summary>
    /// Detailed information about the exceptions that occurred while planning the delivery of the consignment.
    /// Use (null) to report successful processing of the consignment
    /// </summary>
    [DisplayName("Exceptions")]
    [Description("Detailed information about the exceptions that occurred while planning the delivery of the consignment." +
                 "Use (null) to report successful processing of the consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiDeliveryPlanningExceptions : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The address of the consignee is not within the area served
        /// </summary>
        //[DisplayName("Outside delivery area")]
        //[Description("The address of the consignee is not within the area served")]
        public EdiEmptyExtendableObject OutsideDeliveryArea { get; set; }

        /// <summary>
        /// The consignment will be picked up and delivered later on the day
        /// </summary>
        //[DisplayName("Planned for second tour")]
        //[Description("The consignment will be picked up and delivered later on the day")]
        public EdiEmptyExtendableObject PlannedForSecondTour { get; set; }

        /// <summary>
        /// The consignment will not be delivered today
        /// </summary>
        //[DisplayName("Not in delivery")]
        //[Description("The consignment will not be delivered today")]
        public EdiEmptyExtendableObject NotInDelivery { get; set; }

        /// <summary>
        /// No time slot for agreed delivery time
        /// </summary>
        //[DisplayName("No time slot for agreed delivery time")]
        //[Description("No time slot for agreed delivery time")]
        public EdiEmptyExtendableObject NoTimeSlotForAgreedDeliveryTime { get; set; }

        /// <summary>
        /// Not in delivery - incomplete / incorrect shipment information
        /// </summary>
        //[DisplayName("Invalid Shipment Information")]
        //[Description("Not in delivery - incomplete / incorrect shipment information")]
        public EdiEmptyExtendableObject InvalidShipmentInformation { get; set; }

        /// <summary>
        /// Not in delivery - goods damaged
        /// </summary>
        //[DisplayName("Damaged")]
        //[Description("Not in delivery - goods damaged")]
        public EdiEmptyExtendableObject Damaged { get; set; }

        /// <summary>
        /// Not delivered - refused consignment, return according to disposal
        /// </summary>
        //[DisplayName("Return according to disposal")]
        //[Description("Not delivered - refused consignment, return according to disposal")]
        public EdiEmptyExtendableObject ReturnAccordingToDisposal { get; set; }

        /// <summary>
        /// Not delivered - refused consignment, return - order missing
        /// </summary>
        //[DisplayName("Return Disposal Missing")]
        //[Description("Not delivered - refused consignment, return - order missing")]
        public EdiEmptyExtendableObject ReturnDisposalMissing { get; set; }

        /// <summary>
        /// Not on delivery - broadcast in search
        /// </summary>
        //[DisplayName("In Research")]
        //[Description("Not on delivery - broadcast in search")]
        public EdiEmptyExtendableObject InResearch { get; set; }

        /// <summary>
        /// The consignee has provided a time slot for delivery
        /// </summary>
        //[DisplayName("Time slot from consignee")]
        //[Description("The consignee has provided a time slot for delivery")]
        public EdiEmptyExtendableObject TimeSlotFromConsignee { get; set; }

        /// <summary>
        /// The weather does not permit delivery
        /// </summary>
        //[DisplayName("Bad weather conditions")]
        //[Description("The weather does not permit delivery")]
        public EdiEmptyExtendableObject BadWeatherConditions { get; set; }

        /// <summary>
        /// There is no time for the delivery
        /// </summary>
        //[DisplayName("Time issue")]
        //[Description("There is no time for the delivery")]
        public EdiEmptyExtendableObject TimeIssue { get; set; }

        /// <summary>
        /// There is a space issue for the delivery
        /// </summary>
        //[DisplayName("Space issue")]
        //[Description("There is a space issue for the delivery")]
        public EdiEmptyExtendableObject SpaceIssue { get; set; }

        /// <summary>
        /// Not in delivery - consignment incomplete
        /// </summary>
        //[DisplayName("Consignment not complete")]
        //[Description("Not in delivery - consignment incomplete")]
        public EdiEmptyExtendableObject ConsignmentNotComplete { get; set; }

        /// <summary>
        /// Not on delivery - Recipient is self-collector
        /// </summary>
        //[DisplayName("Self collector")]
        //[Description("Not on delivery - Recipient is self-collector")]
        public EdiEmptyExtendableObject SelfCollector { get; set; }

        /// <summary>
        /// Not on delivery - regional holiday
        /// </summary>
        //[DisplayName("Holidays")]
        //[Description("Not on delivery - regional holiday")]
        public EdiEmptyExtendableObject Holidays { get; set; }

        /// <summary>
        /// Not on delivery - Customs goods
        /// </summary>
        //[DisplayName("Customs")]
        //[Description("Not on delivery - Customs goods")]
        public EdiEmptyExtendableObject Customs { get; set; }

        /// <summary>
        /// Not in delivery - Advice of delivery according to EDI
        /// </summary>
        //[DisplayName("Waiting for notifications")]
        //[Description("Not in delivery - Advice of delivery according to EDI.")]
        public EdiEmptyExtendableObject WaitingForNotification { get; set; }

        /// <summary>
        /// Not in delivery - Delivery note missing / Accompanying documents incomplete
        /// </summary>
        //[DisplayName("Missing documentation")]
        //[Description("Not in delivery - Delivery note missing / Accompanying documents incomplete")]
        public EdiEmptyExtendableObject MissingDocumentation { get; set; }

        /// <summary>
        /// Not in delivery - long-distance traffic from VP / HUB delayed (E2 status)
        /// </summary>
        //[DisplayName("Late Arrival")]
        //[Description("Not in delivery - long-distance traffic from VP / HUB delayed (E2 status)")]
        public EdiEmptyExtendableObject LateArrival { get; set; }

        /// <summary>
        /// Not in delivery, Flex according to specification VP
        /// </summary>
        //[DisplayName("Standard delivery time sufficient")]
        //[Description("Not in delivery, Flex according to specification VP")]
        public EdiEmptyExtendableObject StandardDeliveryTimeSufficient { get; set; }

        /// <summary>
        /// Loaded from Gateway to...
        /// </summary>
        //[DisplayName("Gateway Routing")]
        //[Description("Loaded from Gateway to...")]
        public EdiEmptyExtendableObject GatewayRouting { get; set; }

        /// <summary>
        /// Receiver rejected, not in delivery by telephone refusal to accept...
        /// </summary>
        //[DisplayName("Rejected by receiver")]
        //[Description("Receiver rejected, not in delivery by telephone refusal to accept...")]
        public EdiEmptyExtendableObject RejectedByReceiver { get; set; }
    }

    /// <summary>
    /// Detailed information about the exceptions that occurred while processing the notification of the consignment
    /// </summary>
    [DisplayName("Exceptions")]
    [Description("Detailed information about the exceptions that occurred while processing the notification of the consignment." +
                 "Use (null) to report successful notifcations of the consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiNotificationExceptions : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The consignee couldn't be reached
        /// </summary>
        //[DisplayName("Not reached")]
        //[Description("The consignee couldn't be reached")]
        public EdiEmptyExtendableObject NotReached { get; set; }

        /// <summary>
        /// The (automatic) notification was disabled
        /// </summary>
        //[DisplayName("Halted")]
        //[Description("The (automatic) notification was disabled")]
        public EdiEmptyExtendableObject Disabled { get; set; }

        /// <summary>
        /// The consignment was successful, but the goods will be picked up by the customer
        /// </summary>
        //[DisplayName("Pickup by the customer")]
        //[Description("The consignment was successful, but the goods will be picked up by the customer")]
        public EdiEmptyExtendableObject PickupCustomer { get; set; }

        /// <summary>
        /// The notification was successful, but the consignment has the wrong address
        /// </summary>
        //[DisplayName("Wrong address")]
        //[Description("The notification was successful, but the consignment has the wrong address")]
        public EdiEmptyExtendableObject WrongAddress { get; set; }

        /// <summary>
        /// A Disposal was ordered
        /// </summary>
        //[DisplayName("Disposal ordered")]
        //[Description("A Disposal was ordered")]
        public EdiEmptyExtendableObject DisposalOrdered { get; set; }

        /// <summary>
        /// The receiver has not answered in time
        /// </summary>
        //[DisplayName("Not answered in time")]
        //[Description("The receiver has not answered in time")]
        public EdiEmptyExtendableObject NotInTime { get; set; }

        /// <summary>
        /// Notification has been canceled
        /// </summary>
        //[DisplayName("Canceled")]
        //[Description("Notification has been canceled")]
        public EdiEmptyExtendableObject Canceled { get; set; }

        /// <summary>
        /// Some data is invalid for processing a notification
        /// </summary>
        //[DisplayName("Invalid data")]
        //[Description("Some data is invalid for processing a notification")]
        public EdiEmptyExtendableObject InvalidData { get; set; }

        /// <summary>
        /// Some data is missing for processing a notification
        /// </summary>
        //[DisplayName("Missing data")]
        //[Description("Some data is missing for processing a notification")]
        public EdiEmptyExtendableObject MissingData { get; set; }
    }

    /// <summary>
    /// Detailed information about the exceptions that occurred while starting the delivery of the consignment.
    /// Use (null) to report successful starting of the consignment delivery
    /// </summary>
    //[DisplayName("Exceptions")]
    [Description("Detailed information about the exceptions that occurred while starting the delivery of the consignment." +
                 "Use (null) to report successful starting of the consignment delivery")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiDeliveryStartedExceptions : EdiPatternPropertiesBase
    {
        /// <summary>
        /// There is no sufficient capacity available to perform delivery at the moment
        /// </summary>
        //[DisplayName("No capacity available")]
        //[Description("There is no sufficient capacity available to perform delivery at the moment")]
        public EdiEmptyExtendableObject NoCapacity { get; set; }
    }

    /// <summary>
    /// Detailed information about the exceptions that caused the delivery to be fail
    /// </summary>
    [DisplayName("Exceptions")]
    [Description("Detailed information about the exceptions that caused the delivery to be fail")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiDeliveryAttemptFailedExceptions : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The delivery attempt was aborted due to too long waiting time at the consignee
        /// </summary>
        //[DisplayName("Aborted due to long waiting time")]
        //[Description("The delivery attempt was aborted due to too long waiting time at the consignee")]
        public EdiEmptyExtendableObject AbortedDueToLongWaitingTime { get; set; }

        /// <summary>
        /// The delivery attempt was aborted, because of weather conditions
        /// </summary>
        //[DisplayName("Aborted due weather condition")]
        //[Description("The delivery attempt was aborted, because of weather conditions")]
        public EdiEmptyExtendableObject AbortedDueWeatherCondition { get; set; }

        /// <summary>
        /// Not delivered - Lack of time on delivery tour
        /// </summary>
        //[DisplayName("Time Issue")]
        //[Description("Not delivered - Lack of time on delivery tour")]
        public EdiEmptyExtendableObject TimeIssue { get; set; }

        /// <summary>
        /// The consignee has rejected the consignment"
        /// </summary>
        public EdiDeliveryAttemptRejected Rejected { get; set; }

        /// <summary>
        /// The consignee was closed
        /// </summary>
        //[DisplayName("Closed")]
        //[Description("The consignee was closed")]
        public EdiEmptyExtendableObject Closed { get; set; }

        /// <summary>
        /// Delivery not possible because of a wrong address
        /// </summary>
        //[DisplayName("Wrong address")]
        //[Description("Delivery not possible because of a wrong address")]
        public EdiEmptyExtendableObject WrongAddress { get; set; }

        /// <summary>
        /// There were difficulties delivering the goods
        /// </summary>
        public EdiDeliveryAttemptDifficulties Difficulties { get; set; }
    }

    /// <summary>
    /// The consignee has rejected the consignment"
    /// </summary>
    [DisplayName("Rejected")]
    [Description("The consignee has rejected the consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiDeliveryAttemptRejected : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The delivery was rejected because the consignment is damaged
        /// </summary>
        //[DisplayName("Damaged")]
        //[Description("The delivery was rejected because the consignment is damaged")]
        public EdiEmptyExtendableObject Damaged { get; set; }

        /// <summary>
        /// The delivery was rejected because some parts of the consignment are missing
        /// </summary>
        //[DisplayName("Incomplete")]
        //[Description("The delivery was rejected because some parts of the consignment are missing")]
        public EdiEmptyExtendableObject Incomplete { get; set; }

        /// <summary>
        /// The delivery rejected because it was performed after the deadline
        /// </summary>
        //[DisplayName("Too late")]
        //[Description("The delivery rejected because it was performed after the deadline")]
        public EdiEmptyExtendableObject TooLate { get; set; }
        
        /// <summary>
        /// The delivery was rejected because required documentation (e.g. delivery note) was missing
        /// </summary>
        //[DisplayName("Missing documentation")]
        //[Description("The delivery was rejected because required documentation (e.g. delivery note) was missing")]
        public EdiEmptyExtendableObject MissingDocumentation { get; set; }

        /// <summary>
        /// The delivery was rejected because the consignee never ordered the goods
        /// </summary>
        //[DisplayName("Not ordered")]
        //[Description("The delivery was rejected because the consignee never ordered the goods")]
        public EdiEmptyExtendableObject NotOrdered { get; set; }

        /// <summary>
        /// The delivery was rejected because of a missing notification
        /// </summary>
        //[DisplayName("Missing notification")]
        //[Description("The delivery was rejected because of a missing notification")]
        public EdiEmptyExtendableObject MissingNotification { get; set; }

        /// <summary>
        /// The delivery was rejected because required documentation (e.g. delivery note) was missing
        /// </summary>
        //[DisplayName("No payment")]
        //[Description("The delivery couldn't be processed because the consignee has not payed")]
        public EdiEmptyExtendableObject NoPayment { get; set; }
    }

    /// <summary>
    /// There were difficulties delivering the goods
    /// </summary>
    [DisplayName("Difficulties")]
    [Description("There were difficulties delivering the goods")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiDeliveryAttemptDifficulties : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The delivery was not possible because of a missing tail lift
        /// </summary>
        //[DisplayName("Missing tail lift")]
        //[Description("The delivery was not possible because of a missing tail lift")]
        public EdiEmptyExtendableObject TailLift { get; set; }
    }

    /// <summary>
    /// Detailed information about the exceptions that occurred when consignment was successfully delivered.
    /// Use (null) to report successful processing of the consignment
    /// </summary>
    [DisplayName("Exceptions")]
    [Description("Detailed information about the exceptions that occurred when consignment was successfully delivered." +
                 "Use (null) to report successful processing of the consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiDeliverySuccessfulExceptions : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Some parts were missing and thus not delivered
        /// </summary>
        //[DisplayName("Incomplete")]
        //[Description("Some parts were missing and thus not delivered")]
        public EdiEmptyExtendableObject Incomplete { get; set; }

        /// <summary>
        /// Delivered but incomplete
        /// </summary>
        //[DisplayName("Service incomplete")]
        //[Description("Delivered but incomplete")]
        public EdiEmptyExtendableObject ServiceIncomplete { get; set; }

        /// <summary>
        /// The consignment was damaged
        /// </summary>
        //[DisplayName("Damaged")]
        //[Description("The consignment was damaged")]
        public EdiEmptyExtendableObject Damaged { get; set; }

        /// <summary>
        /// Some parts were missing and some were damaged
        /// </summary>
        //[DisplayName("Incomplete and damaged")]
        //[Description("Some parts were missing and some were damaged")]
        public EdiEmptyExtendableObject IncompleteAndDamaged { get; set; }

        /// <summary>
        /// The consignment was partially rejected
        /// </summary>
        //[DisplayName("Partially rejected")]
        //[Description("The consignment was partially rejected")]
        public EdiEmptyExtendableObject PartiallyRejected { get; set; }

        /// <summary>
        /// The consignment was partially rejected
        /// </summary>
        //[DisplayName("To late")]
        //[Description("The delivery was to late")]
        public EdiEmptyExtendableObject TooLate { get; set; }

        /// <summary>
        /// Served, delivery not assignable
        /// </summary>
        //[DisplayName("No receipt")]
        //[Description("Served, delivery not assignable")]
        public EdiEmptyExtendableObject NoReceipt { get; set; }

        /// <summary>
        /// Delivered, Exhibition- / House carrier- / Inselspediteur handed over
        /// </summary>
        //[DisplayName("Forwarded to external provider")]
        //[Description("Delivered, Exhibition- / House carrier- / Inselspediteur handed over")]
        public EdiEmptyExtendableObject ForwardedToExternalProvider { get; set; }

        /// <summary>
        /// The goods were deposit as agreed in a signed release authorization
        /// </summary>
        //[DisplayName("Release authorization")]
        //[Description("The goods were deposit as agreed in a signed release authorization")]
        public EdiEmptyExtendableObject ReleaseAuthorization { get; set; }
    }

    /// <summary>
    /// Detailed information about the exceptions that occured while planning the pickup.
    /// Use (null) to report successful planning of the pickup
    /// </summary>
    [DisplayName("Exceptions")]
    [Description("Detailed information about the exceptions that occured while planning the pickup." +
                 "Use(null) to report successful planning of the pickup")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPickupPlanningExceptions : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Pick-up point is outside the pick-up zone
        /// </summary>
        //[DisplayName("Outside Pickup Zone")]
        //[Description("Pick-up point is outside the pick-up zone")]
        public EdiEmptyExtendableObject OutsidePickupZone { get; set; }

        /// <summary>
        /// The pickup is later on the day
        /// </summary>
        //[DisplayName("Later on the day")]
        //[Description("The pickup is later on the day")]
        public EdiEmptyExtendableObject PlannedForSecondTour { get; set; }

        /// <summary>
        /// Pickup is planned for a specific date
        /// </summary>
        //[DisplayName("Planned for Date")]
        //[Description("Pickup is planned for a specific date")]
        public EdiEmptyExtendableObject PlannedForDate { get; set; }

        /// <summary>
        /// The customer has provided a time slot for pickup
        /// </summary>
        //[DisplayName("Time slot from consignee")]
        //[Description("The customer has provided a time slot for pickup")]
        public EdiEmptyExtendableObject TimeSlotFromConsignee { get; set; }

        /// <summary>
        /// The weather does not permit pickup
        /// </summary>
        //[DisplayName("Bad weather conditions")]
        //[Description("The weather does not permit pickup")]
        public EdiEmptyExtendableObject BadWeatherConditions { get; set; }

        /// <summary>
        /// There is no time for the pickup
        /// </summary>
        //[DisplayName("Time issue")]
        //[Description("There is no time for the pickup")]
        public EdiEmptyExtendableObject TimeIssue { get; set; }

        /// <summary>
        /// There is a space issue for the pickup
        /// </summary>
        //[DisplayName("Space issue")]
        //[Description("There is a space issue for the pickup")]
        public EdiEmptyExtendableObject SpaceIssue { get; set; }

        /// <summary>
        /// Pickup is planned for the next day
        /// </summary>
        //[DisplayName("Planned for next day")]
        //[Description("Pickup is planned for the next day")]
        public EdiEmptyExtendableObject PlannedForNextDay { get; set; }

    }

    /// <summary>
    /// Detailed information about the exceptions that occured while starting the pickup.
    /// Use (null) to report successful starting of the pickup
    /// </summary>
    [DisplayName("Exceptions")]
    [Description("Detailed information about the exceptions that occured while starting the pickup." +
                 "Use (null) to report successful starting of the pickup")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPickupStartedExceptions : EdiPatternPropertiesBase
    {

    }

    /// <summary>
    /// Detailed information about the exceptions that occured while arrival at the pickup location
    /// Use (null) to report successful arrival
    /// </summary>
    [DisplayName("Exceptions")]
    [Description("Detailed information about the exceptions that occured while arrival at the pickup location." +
                 "Use (null) to report successful arrival")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPickupArrivalExceptions : EdiPatternPropertiesBase
    {

    }

    /// <summary>
    /// Detailed information about the exceptions that occured while the pickup finished at shipper.
    /// Use (null) to report successful arrival
    /// </summary>
    [DisplayName("Exceptions")]
    [Description("Detailed information about the exceptions that occured while the pickup finished at shipper." +
                 "Use (null) to report successful arrival")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPickupFinishedAtShipperExceptions : EdiPatternPropertiesBase
    {

    }


    /// <summary>
    /// Detailed information about the exceptions that occured while starting the loading process.
    /// Use (null) to report successful starting the loading process
    /// </summary>
    [DisplayName("Exceptions")]
    [Description("Detailed information about the exceptions that occured while starting the loading process." +
                 "Use (null) to report successful starting the loading process")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPickupLoadingStartedExceptions : EdiPatternPropertiesBase
    {
      
    }

    /// <summary>
    /// Detailed information about the exceptions that occured while completing the loading process.
    /// Use (null) to report successful completion of the loading process
    /// </summary>
    [DisplayName("Exceptions")]
    [Description("Detailed information about the exceptions that occured while completing the loading process." +
                 "Use (null) to report successful completion of the loading process")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPickupLoadingCompletedExceptions : EdiPatternPropertiesBase
    {

    }

    /// <summary>
    /// Detailed information about the exceptions that caused the pickup to be fail
    /// </summary>
    [DisplayName("Exceptions")]
    [Description("Detailed information about the exceptions that caused the pickup to be fail")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPickupAttemptFailedExceptions : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Pickup was aborted due to long waiting time
        /// </summary>
        //[DisplayName("Aborted Due To Long Waiting Time")]
        //[Description("There is no time for the pickup")]
        public EdiEmptyExtendableObject AbortedDueToLongWaitingTime { get; set; }

        /// <summary>
        /// Pickup was aborted, because of company holiday
        /// </summary>
        //[DisplayName("Company Holiday")]
        //[Description("Pickup was aborted, because of company holiday")]
        public EdiEmptyExtendableObject CompanyHoliday { get; set; }

        /// <summary>
        /// Pickup was aborted because no one was to be found
        /// </summary>
        //[DisplayName("No Encounter")]
        //[Description("Pickup was aborted because no one was to be found")]
        public EdiEmptyExtendableObject NoEncounter { get; set; }

        /// <summary>
        /// Pickup was aborted because there was no pick-up order available
        /// </summary>
        //[DisplayName("No Pickup order")]
        //[Description("Pickup was aborted because there was no pick-up order available")]
        public EdiEmptyExtendableObject NoPickupOrder { get; set; }

        /// <summary>
        /// Pickup was aborted because the address was wrong
        /// </summary>
        //[DisplayName("Wrong address")]
        //[Description("Pickup was aborted because the address was wrong")]
        public EdiEmptyExtendableObject WrongAddress { get; set; }

        /// <summary>
        /// Pickup was rejected because of a missing notification
        /// </summary>
        //[DisplayName("Missing notification")]
        //[Description("Pickup was rejected because of a missing notification")]
        public EdiEmptyExtendableObject MissingNotification { get; set; }

        /// <summary>
        /// Pickup was rejected because required documentation (e.g. delivery note) was missing
        /// </summary>
        //[DisplayName("Missing documentation")]
        //[Description("Pickup was rejected because required documentation (e.g. delivery note) was missing")]
        public EdiEmptyExtendableObject MissingDocumentation { get; set; }

        /// <summary>
        /// Pickup was aborted because required transport safety device not available
        /// </summary>
        //[DisplayName("Missing transport lock")]
        //[Description("Pickup was aborted because required transport safety device not available")]
        public EdiEmptyExtendableObject MissingTransportLock { get; set; }

        /// <summary>
        /// Pickup was aborted because consignment not ready to picked up
        /// </summary>
        //[DisplayName("Consignment not ready")]
        //[Description("Pickup was aborted because consignment not ready to picked up")]
        public EdiEmptyExtendableObject ConsignmentNotReady { get; set; }

        /// <summary>
        /// Pickup was aborted because consignment already shipped
        /// </summary>
        //[DisplayName("Consignment already shipped")]
        //[Description("Pickup was aborted because consignment already shipped")]
        public EdiEmptyExtendableObject ConsignmentAlreadyShipped { get; set; }

        /// <summary>
        /// Pickup was aborted because no goods were received
        /// </summary>
        //[DisplayName("No goods received")]
        //[Description("Pickup was aborted because no goods were received")]
        public EdiEmptyExtendableObject NoGoodsReceived { get; set; }

        /// <summary>
        /// Pickup aborted because, pick-up outside opening hours / closed
        /// </summary>
        //[DisplayName("Closed")]
        //[Description("Pick-up outside opening hours / closed")]
        public EdiEmptyExtendableObject Closed { get; set; }

        /// <summary>
        /// Pickup aborted because pick-up time slot was missed
        /// </summary>
        //[DisplayName("Closed")]
        //[Description("Pickup aborted because pick-up time slot was missed")]
        public EdiEmptyExtendableObject TimeSlotMissed { get; set; }
    }
}
