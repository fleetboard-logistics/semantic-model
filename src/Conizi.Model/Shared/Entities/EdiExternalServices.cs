using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Services that are not provided by the parties involved in the physical transport but by external service providers (e.g. central services by the networks)
    /// </summary>
    [JsonObject("#externalServices")]
    [DisplayName("External services")]
    [Description("Services that are not provided by the parties involved in the physical transport but by external service providers (e.g. central services by the networks)")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiExternalServices : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Functions provided by the digtal archive systems
        /// </summary>
        public EdiArchive Archive { get; set; }
    }

    /// <summary>
    /// Functions provided by the digital archive systems
    /// </summary>
    [JsonObject("#archive")]
    [DisplayName("Digital archive")]
    [Description("Functions provided by the digital archive systems")]
    [ConiziAdditionalProperties(false)]
    public class EdiArchive : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The proof of delivery document is provided for automatic download"
        /// </summary>
        [DisplayName("PoD push")]
        [Description("The proof of delivery document is provided for automatic download")]
        public bool? AutomaticDownloadOfPod { get; set; }
    }
}
