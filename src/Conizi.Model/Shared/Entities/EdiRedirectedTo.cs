using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// The consignment is redirected to...
    /// </summary>
    [DisplayName("Redirected to")]
    [Description("The consignment is redirected to...")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiRedirectedTo :  EdiPatternPropertiesBase
    {
        /// <summary>
        /// Redirected to sender
        /// </summary>
        public bool? Sender { get; set; }

        /// <summary>
        /// Redirected to source partner
        /// </summary>
        public bool? SourcePartner { get; set; } 
        
        /// <summary>
        /// Redirected to receiving Partner
        /// </summary>
        public bool? ReceivingPartner { get; set; }

    }
}