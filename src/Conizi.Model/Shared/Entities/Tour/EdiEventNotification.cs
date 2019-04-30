using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities.Tour
{
    /// <summary>
    /// Events occurred while processing the notification of the consignment
    /// </summary>
    [DisplayName("Notification")]
    [Description("Events occurred while processing the notification of the consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEventNotification : EdiEventBase
    {
        public EdiTrigger Trigger { get; set; }
    }
}