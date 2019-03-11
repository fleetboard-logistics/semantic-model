using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("additionalLoadingEquipment")]
    [DisplayName("Additional loading equipment")]
    [Description("Additional loading aids which are not part of the consignment but which have been added to safely transport the goods")]
    [ConiziAdditionalProperties(false)]
    public class EdiAdditionalLoadingEquipment
    {
        [DisplayName("EPAL")]
        [Description("EUR pallets as defined by European Pallet Association (EPAL)")]
        public int EurPallets { get; set; }

        [DisplayName("EUR box pallets")]
        [Description("EUR Box pallets as defined by European Pallet Association (EPAL)")]
        public int EurBoxes { get; set; }

    }
}