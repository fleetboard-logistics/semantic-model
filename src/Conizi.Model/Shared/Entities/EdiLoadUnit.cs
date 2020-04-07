using System.Collections.Generic;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Definitions;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Load units (containers, swap bodies, ...) used to transport the goods
    /// </summary>
    
    [DisplayName("Load units")]
    [Description("Load units (containers, swap bodies, ...) used to transport the goods")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiLoadUnit : EdiPatternPropertiesBase
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

        /// <summary>
        /// Type of loading equipment like eur pallets, euro boxes...
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public LoadingUnitType UnitType { get; set; }

        /// <summary>
        /// Custom Loading Unit Type Name, like specialContainers or trailer formats
        /// </summary>
        /// <remarks>Should only be used, if the UnitType is set to CustomLoadingUnit!</remarks>
        [DisplayName("Custom Loading Type Unit Name")]
        [Description("Custom Loading Unit Type Name, like specialContainers or trailer formats")]
        public string CustomLoadingUnitTypeName { get; set; }

    }

    
}