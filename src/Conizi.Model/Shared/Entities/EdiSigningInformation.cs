using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Signing Information
    /// </summary>
    [DisplayName("Signing Information")]
    [Description("Transmission of the receipt, the delivery date and the delivery time")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiSigningInformation : EdiPatternPropertiesBase
    {



    }
}