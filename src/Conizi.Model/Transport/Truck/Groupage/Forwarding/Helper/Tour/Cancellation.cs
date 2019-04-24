using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding.Helper.Tour
{
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