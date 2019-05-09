using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Line of the manifest (consignment etc)
    /// </summary>
    [JsonObject("#manifestLine")]
    [DisplayName("Line")]
    [Description("Line of the manifest")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiManifestLine
    {
        /// <summary>
        /// The number of the line
        /// </summary>
        [DisplayName("Line number")]
        [Description("Ordinal number of the line within the manifest. Is referenced in other messages such as the unloading report")]
        public int? LineNo { get; set; }

        /// <summary>
        /// The consignment included in the line of the manifest
        /// </summary>
        public Transport.Truck.Groupage.Forwarding.Consignment Consignment { get; set; }
    }
}