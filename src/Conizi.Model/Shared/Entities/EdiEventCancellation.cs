using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Events indicating the cancellation of the consignment
    /// </summary>
    [DisplayName("EdiEventCancellation")]
    [Description("Events indicating the cancellation of the consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEventCancellation : EdiEventBase
    {

    }
}