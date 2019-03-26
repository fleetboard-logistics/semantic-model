using System;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("measures")]
    [DisplayName("Measures")]
    [Description("Measures of the unit")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiMeasures : EdiPatternPropertiesBase
    {
        [DisplayName("Volume (m³)")]
        [Description("Total volume of the consignment")]
        public Decimal VolumeCubicmeter { get; set; }

        [DisplayName("Loading meters (m)")]
        [Description("Length of the area occupied on a 2.4 m wide container")]
        public Decimal LoadingMeter { get; set; }

        [DisplayName("Gross weight (kg)")]
        [Description("Weight of the consignment including all packaging")]
        public Decimal GrossWeightKilogram { get; set; }

        [DisplayName("Pallet bays")]
        [Description("Area used by the consignment in terms of standard EUR pallet bays (120 x 80 cm)")]
        public Decimal AreaPalletBays { get; set; }

        [DisplayName("Chargable weight (kg)")]
        [Description("Virtual weight of the shipment used for billing purposes. Used to take the bulkyness of goods into account or to enforce minimums")]
        public Decimal ChargeableWeightKilogram { get; set; }

        [DisplayName("Length (m)")]
        [Description("Total length")]
        public Decimal LengthMeter { get; set; }

        [DisplayName("Width (m)")]
        [Description("Total width")]
        public Decimal WidthMeter { get; set; }

        [DisplayName("Height (m)")]
        [Description("Total height")]
        public Decimal HeightMeter { get; set; }
    }
}