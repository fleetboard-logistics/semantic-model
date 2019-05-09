using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Additional loading aids which are not part of the consignment but which have been added to safely transport the goods
    /// </summary>
    [JsonObject("additionalLoadingEquipment")]
    [DisplayName("Additional loading equipment")]
    [Description("Additional loading aids which are not part of the consignment but which have been added to safely transport the goods")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiAdditionalLoadingEquipment : EdiPatternPropertiesBase
    {
        /// <summary>
        /// EUR pallets as defined by European Pallet Association (EPAL)
        /// </summary>
        [DisplayName("EPAL")]
        [Description("EUR pallets as defined by European Pallet Association (EPAL)")]
        public int? EurPallets { get; set; }

        /// <summary>
        /// EUR Box pallets as defined by European Pallet Association (EPAL)
        /// </summary>
        [DisplayName("EUR box pallets")]
        [Description("EUR Box pallets as defined by European Pallet Association (EPAL)")]
        public int? EurBoxes { get; set; }

    }

    /// <summary>
    /// Information about loading equipment exchange
    /// </summary>
    [JsonObject("loadingEquipmentExchange")]
    [DisplayName("Loading equipment exchange")]
    [Description("Information about loading equipment exchange")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiLoadingEquipmentExchange : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Loading Equipment was exchanged
        /// </summary>
        [DisplayName("Exchanged")]
        [Description("Loading Equipment was exchanged")]
        [JsonRequired]
        public bool? Exchanged { get; set; }

        /// <summary>
        /// Add/Remove amount of EUR pallets as defined by European Pallet Association (EPAL)
        /// </summary>
        [DisplayName("Amount Euro Pallets")]
        [Description("Add/Remove amount of EUR pallets as defined by European Pallet Association (EPAL)")]
        public int? AmountEurPallets { get; set; }

        /// <summary>
        /// Add/Remove amount EUR Box pallets as defined by European Pallet Association (EPAL)
        /// </summary>
        [DisplayName("AmountEuro Boxes")]
        [Description("Add/Remove amount EUR Box pallets as defined by European Pallet Association (EPAL)")]
        public int? AmountEurBoxes { get; set; }

        
    }
}