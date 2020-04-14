using System;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Measures of the unit
    /// </summary>
    
    [DisplayName("Measures")]
    [Description("Measures of the unit")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiMeasures : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Total volume of the consignment (m³)
        /// </summary>
        [DisplayName("Volume (m³)")]
        [Description("Total volume of the consignment")]
        public decimal? VolumeCubicmeter { get; set; }

        /// <summary>
        /// Length of the area occupied on a 2.4 m wide container
        /// </summary>
        [DisplayName("Loading meters (m)")]
        [Description("Length of the area occupied on a 2.4 m wide container")]
        public decimal? LoadingMeter { get; set; }

        /// <summary>
        /// Weight of the consignment including all packaging (kg)
        /// </summary>
        [DisplayName("Gross weight (kg)")]
        [Description("Weight of the consignment including all packaging")]
        public decimal? GrossWeightKilogram { get; set; }

        /// <summary>
        /// Area used by the consignment in terms of standard EUR pallet bays (120 x 80 cm)"
        /// </summary>
        [DisplayName("Pallet bays")]
        [Description("Area used by the consignment in terms of standard EUR pallet bays (120 x 80 cm)")]
        public decimal? AreaPalletBays { get; set; }

        /// <summary>
        /// Virtual weight of the shipment used for billing purposes. Used to take the bulkiness of goods into account or to enforce minimums (kg)
        /// </summary>
        [DisplayName("Chargeable weight (kg)")]
        [Description("Virtual weight of the shipment used for billing purposes. Used to take the bulkiness of goods into account or to enforce minimums")]
        public decimal? ChargeableWeightKilogram { get; set; }

        /// <summary>
        /// Empty weight of the vehicle/shipment in kilogram"
        /// </summary>
        [DisplayName("Empty weight (kg)")]
        [Description("Empty weight of the vehicle/shipment in kilogram")]
        public decimal? EmptyWeightKilogram { get; set; }
        
        /// <summary>
        /// Maximal loading capacity of the vehicle in kilogram"
        /// </summary>
        [DisplayName("Loading weight (kg)")]
        [Description("Maximal loading capacity of the vehicle in kilogram")]
        public decimal? LoadingWeightKilogram { get; set; }

        /// <summary>
        /// Total weight of the vehicle/shipment in kilogram"
        /// </summary>
        [DisplayName("Total weight (kg)")]
        [Description("Total weight of the vehicle/shipment in kilogram")]
        public decimal? TotalWeightKilogram { get; set; }

        /// <summary>
        /// Total length (m)
        /// </summary>
        [DisplayName("Length (m)")]
        [Description("Total length")]
        public decimal? LengthMeter { get; set; }

        /// <summary>
        /// Total width (m)
        /// </summary>
        [DisplayName("Width (m)")]
        [Description("Total width")]
        public decimal? WidthMeter { get; set; }

        /// <summary>
        /// Total height (m)
        /// </summary>
        [DisplayName("Height (m)")]
        [Description("Total height")]
        public decimal? HeightMeter { get; set; }

        /// <summary>
        /// Volume liter of the consignment/position. Used for e.g. tank transportation
        /// </summary>
        [DisplayName("Volume liter")]
        [Description("Volume liter of the consignment/position. Used for e.g. tank transportation")]
        public decimal? VolumeLiter { get; set; }
    }
}