using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities.Consignment
{
    /// <summary>
    /// Events occurred while physically processing the pickup order (e.g. moving goods, scanning packages)
    /// </summary>
    [DisplayName("General processing")]
    [Description("Events occurred while physically processing the pickup order (e.g. moving goods, scanning packages)")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiGeneralProcessingNotification : EdiEventBase
    {
        /// <summary>
        /// Detailed information about the exceptions that occured while processing the pickup. Use (null) to report successful processing of the pickup
        /// </summary>
        public EdiNotificationEventExceptions Exceptions { get; set; } 
    }
}