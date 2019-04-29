using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities.Tour
{
    /// <summary>
    /// Events occurred while unloading the consignment
    /// </summary>
    [DisplayName("Unloading")]
    [Description("Events occurred while unloading the consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiUnloading : EdiEventBase
    {
        /// <summary>
        /// Detailed information about the exceptions that occurred while processing the consignment.
        /// Use (null) to report successful processing of the consignment
        /// </summary>
        public EdiUnloadingExceptions Exceptions { get; set; }
    }
}