using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities.Consignment
{

    /// <summary>
    /// Events occurred while planning a pickup order
    /// </summary>
    [DisplayName("Pickup planning")]
    [Description("Events occurred while planning a pickup order")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPickupPlanning : EdiEventBase
    {
        /// <summary>
        /// The data is incomplete, missing or wrong
        /// </summary>
        //DisplayName("Wrong data")]
        //[Description("The data is incomplete, missing or wrong")]
        public EdiEmptyExtendableObject InvalidData { get; set; }

        /// <summary>
        /// Wrong, incomplete or missing package type information
        /// </summary>
        //DisplayName("Wrong package type")]
        //[Description("Wrong, incomplete or missing package type information")]
        public EdiEmptyExtendableObject InvalidPackageType { get; set; }

        /// <summary>
        /// Wrong, incomplete or missing package type information
        /// </summary>
        //DisplayName("Invalid Dangerous good information")]
        //[Description("Wrong, incomplete or missing information about the dangerous goods")]
        public EdiEmptyExtendableObject InvalidDangerousGoodInformation { get; set; }

        /// <summary>
        /// Detailed information about the exceptions that occured while planning the pickup.
        /// Use (null) to report successful planning of the pickup
        /// </summary>
        public EdiPickupPlanningExceptions Exceptions { get; set; }
    }

    /// <summary>
    /// Events occurred while starting a pickup order"
    /// </summary>
    [DisplayName("Pickup started")]
    [Description("Events occurred while starting a pickup order")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPickupStarted : EdiEventBase
    {
        /// <summary>
        /// Detailed information about the exceptions that occured while starting the pickup.
        /// Use (null) to report successful starting of the pickup
        /// </summary>
        public EdiPickupStartedExceptions Exceptions { get; set; }
    }

    /// <summary>
    /// Events occurred while arrival a pickup location
    /// </summary>
    [DisplayName("Pickup Arrival")]
    [Description("Events occurred while arrival a pickup location")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPickupArrival : EdiEventBase
    {
        /// <summary>
        /// Detailed information about the exceptions that occured while arrival at the pickup location.
        ///  Use (null) to report successful arrival
        /// </summary>
        public EdiPickupArrivalExceptions Exceptions { get; set; }
    }

    /// <summary>
    /// Events occurred while pickup finished at shipper
    /// </summary>
    [DisplayName("Pickup Finished At Shipper")]
    [Description("Events occurred while pickup finished at shipper")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPickupFinishedAtShipper : EdiEventBase
    {
        /// <summary>
        /// Detailed information about the exceptions that occured while the pickup finished at shipper.
        /// Use (null) to report successful arrival
        /// </summary>
        public EdiPickupFinishedAtShipperExceptions Exceptions { get; set; }
    }

    /// <summary>
    /// Events occurred while pickup loading started
    /// </summary>
    [DisplayName("Pickup loading started")]
    [Description("Events occurred while pickup loading started")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPickupLoadingStarted : EdiEventBase
    {
        /// <summary>
        /// Detailed information about the exceptions that occured while starting the loading process.
        /// Use (null) to report successful starting the loading process
        /// </summary>
        public EdiPickupLoadingStartedExceptions Exceptions { get; set; }
    }

    /// <summary>
    /// Events occurred while pickup loading completed
    /// </summary>
    [DisplayName("Pickup loading completed")]
    [Description("Events occurred while pickup loading completed")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPickupLoadingCompleted : EdiEventBase
    {
        /// <summary>
        /// Detailed information about the exceptions that occured while completing the loading process.
        /// Use (null) to report successful completion of the loading process
        /// </summary>
        public EdiPickupLoadingCompletedExceptions Exceptions { get; set; }
    }

    /// <summary>
    /// Events indicating a failed pickup attempt
    /// </summary>
    [DisplayName("Pickup attempt failed")]
    [Description("Events indicating a failed pickup attempt")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPickupAttemptFailed : EdiEventBase
    {
        /// <summary>
        /// Detailed information about the exceptions that caused the pickup to be fail
        /// </summary>
        public EdiPickupAttemptFailedExceptions Exceptions { get; set; }
    }


}