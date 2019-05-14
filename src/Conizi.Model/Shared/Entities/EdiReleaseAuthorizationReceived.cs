using System.ComponentModel;
using Conizi.Model.Shared.Attributes;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Release authorization received
    /// </summary>
    [DisplayName("Release authorization received")]
    [Description("Receiver allows dropoff")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiReleaseAuthorizationReceived
    {

    }
}