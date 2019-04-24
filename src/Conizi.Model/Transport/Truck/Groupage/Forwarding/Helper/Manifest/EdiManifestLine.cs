using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding.Helper.Manifest
{
    [JsonObject("manifestLine")]
    [DisplayName("Line")]
    [Description("Line of the manifest")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiManifestLine
    {
        [DisplayName("Line number")]
        [Description("Ordinal number of the line within the manifest. Is referenced in other messages such as the unloading report")]
        public int LineNo { get; set; }

        public Consignment Consignment { get; set; }
    }
}