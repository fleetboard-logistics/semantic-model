using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Consignment was disposed
    /// </summary>
    [DisplayName("Disposed")]
    [Description("Consignment was disposed")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiDisposed : EdiPatternPropertiesBase
    {

    }
}