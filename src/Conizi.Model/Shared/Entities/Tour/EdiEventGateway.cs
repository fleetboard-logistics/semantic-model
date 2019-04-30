using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities.Tour
{
    /// <summary>
    /// Events occurred while cross docking the consignment. (i.e. HUB or gateway cross dock)
    /// </summary>
    [DisplayName("Cross dock")]
    [Description("Events occurred while cross docking the consignment. (i.e. HUB or gateway cross dock)")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEventGateway : EdiEventBase
    {

        /// <summary>
        /// The consignment has been loaded onto the truck leaving the gateway
        /// </summary>
        [DisplayName("The consignment has been loaded")]
        [Description("The consignment has been loaded onto the truck leaving the gateway")]
        public bool Loaded { get; set; }

        /// <summary>
        /// The consignment has been unloaded from the truck delivering the consignment to the gateway
        /// </summary>
        [DisplayName("The consignment has been unloaded")]
        [Description("The consignment has been unloaded from the truck delivering the consignment to the gateway")]
        public bool Unloaded { get; set; }

        /// <summary>
        /// Detailed information about the exceptions that occurred while processing the consignment.
        /// Use (null) to report successful cross dock of the consignment
        /// </summary>
        public EdiGatewayExceptions Exceptions { get; set; }

    }
}