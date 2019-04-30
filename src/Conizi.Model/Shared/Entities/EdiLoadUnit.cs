using System.Collections.Generic;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Load units (containers, swap bodies, ...) used to transport the goods
    /// </summary>
    [JsonObject("loadUnits")]
    [DisplayName("Load units")]
    [Description("Load units (containers, swap bodies, ...) used to transport the goods")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiLoadUnit
    {
        /// <summary>
        /// Identification (e.g. registration number) of the unit"
        /// </summary>
        [DisplayName("Identification")]
        [Description("Identification (e.g. registration number) of the unit")]
        public string Identification { get; set; }

        /// <summary>
        ///  List of seals used to prevent tampering with the goods in the load unit
        /// </summary>
        public List<EdiSeal> Seals { get; set; }

    }
}