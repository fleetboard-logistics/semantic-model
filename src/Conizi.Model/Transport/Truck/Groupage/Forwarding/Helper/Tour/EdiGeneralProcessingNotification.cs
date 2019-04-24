using System.ComponentModel;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding.Helper.Tour
{
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
}