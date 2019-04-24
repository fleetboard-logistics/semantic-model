using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding.Helper.Tour
{
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
}