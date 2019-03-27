using System;
using Conizi.Model.Shared.Entities;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{
    public class ConsignmentEvent : EdiModel
    {
        public EdiPartnerIdentification ShippingPartner { get; set; }
        public EdiPartnerIdentification ReceivingPartner { get; set; }
        public EdiPartnerIdentification ReportingPartner { get; set; }

        public string ConsignmentNoShippingPartner { get; set; }

        public string ConsignmentNoReceivingPartner { get; set; }

        public EdiGeneralProcessingNotification GeneralProcessingNotification { get; set; }

        public EdiDataProcessing DataProcessing { get; set; }
    }

    public class EdiGeneralProcessingNotification
    {
        public EdiExceptions Exceptions { get; set; }
        public string Remarks { get; set; }
        public DateTime EventDateTime { get; set; }
    }

    public class EdiExceptions
    {
        public EdiArchived Archived { get; set; }
    }

    public class EdiArchived
    {
        public bool Pod { get; set; }
    }

    public class EdiDataProcessing
    {

    }
}
