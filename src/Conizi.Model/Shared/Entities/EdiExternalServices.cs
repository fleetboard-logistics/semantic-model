using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("externalServices")]
    [DisplayName("External services")]
    [Description("Services that are not provided by the parties involved in the physical transport but by external service providers (e.g. central services by the networks)")]
    [ConiziAdditionalProperties(false)]
    public class EdiExternalServices
    {
        public EdiArchive Archive { get; set; }
    }

    [JsonObject("archive")]
    [DisplayName("Digital archive")]
    [Description("Functions provided by the digtal archive systems")]
    [ConiziAdditionalProperties(false)]
    public class EdiArchive
    {
        [DisplayName("PoD push")]
        [Description("The proof of delivery document is provided for automatic download")]
        public bool AutomaticDownloadOfPod { get; set; }
    }
}
