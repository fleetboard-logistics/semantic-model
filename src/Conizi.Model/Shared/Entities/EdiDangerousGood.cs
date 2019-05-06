using System;
using System.ComponentModel;
using System.Numerics;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Information on dangerous goods
    /// </summary>
    [JsonObject("dangerousGoods")]
    [DisplayName("Dangerous goods")]
    [Description("Dangerous goods")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiDangerousGood : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The quantity
        /// </summary>
        [DisplayName("Quantity")]
        [Description("The quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// Weight of the consignment including all packaging (kg)
        /// </summary>
        [DisplayName("Gross weight (kg)")]
        [Description("Weight of the consignment including all packaging")]
        public decimal? GrossWeightKilogram { get; set; }

        /// <summary>
        /// The UN number, also known as the substance number, is an identification number that can be used for all dangerous substances.
        /// </summary>
        [DisplayName("UnNo")]
        [Description("UnNo")]
        public string UnNo { get; set; }

        /// <summary>
        /// Risk factor multiplier
        /// </summary>
        [DisplayName("Multiplier")]
        [Description("Multiplier")]
        public int? Multiplier { get; set; }

        /// <summary>
        /// The unique Key for this good
        /// </summary>
        [DisplayName("Unique key")]
        [Description("The unique Key")]
        public string UniqueKey { get; set; }

        /// <summary>
        /// The substance Name
        /// </summary>
        [DisplayName("Substance Name")]
        [Description("The substance Name")]
        public string SubstanceName { get; set; }

        /// <summary>
        /// Technical name if not otherwise specified
        /// </summary>
        [DisplayName("Technical name if not otherwise specified")]
        [Description("The technical name if not otherwise specified")]
        public string TechnicalNameIfNotOtherwiseSpecified { get; set; }

        /// <summary>
        /// Label for main risk
        /// </summary>
        [DisplayName("Label for main risk")]
        [Description("Label for main risk")]
        public string LabelMainRisk { get; set; }

        /// <summary>
        /// Label for sub risk 1
        /// </summary>
        [DisplayName("Label for sub risk 1")]
        [Description("Label for sub risk 1")]
        public string LabelSubRisk1 { get; set; }

        /// <summary>
        /// Label for sub risk 2
        /// </summary>
        [DisplayName("Label for sub risk 2")]
        [Description("Label for sub risk 2")]
        public string LabelSubRisk2 { get; set; }

        /// <summary>
        /// Label for sub risk 3
        /// </summary>
        [DisplayName("Label for sub risk 3")]
        [Description("Label for sub risk 3")]
        public string LabelSubRisk3 { get; set; }

        /// <summary>
        /// The packaging description
        /// </summary>
        [DisplayName("Packaging description")]
        [Description("The packaging description")]
        public string PackagingDescription { get; set; }

        /// <summary>
        /// The net explosive mass in kilogram
        /// </summary>
        [DisplayName("Net explosive mass in kilogram")]
        [Description("The net explosive mass in kilogram")]
        public decimal? NetExplosiveMassKilogram { get; set; }

        /// <summary>
        /// The transport category
        /// </summary>
        [DisplayName("Transport category")]
        [Description("The transport category")]
        public string TransportCategory { get; set; }

        /// <summary>
        /// Limited quantity
        /// </summary>
        [DisplayName("Limited quantity")]
        [Description("Limited quantity")]
        public bool? LimitedQuantity { get; set; }

        /// <summary>
        /// Total points for ADR
        /// </summary>
        [DisplayName("Total points ADR")]
        [Description("Total points for ADR")]
        [JsonProperty("totalPointsADR")]
        public int? TotalPointsAdr { get; set; }

        /// <summary>
        /// Restriction for tunnels
        /// </summary>
        [DisplayName("Tunnel restriction")]
        [Description("Tunnel restriction")]
        public string TunnelRestriction { get; set; }

        /// <summary>
        /// Packaging group
        /// </summary>
        [DisplayName("Packaging group")]
        [Description("Packaging group")]
        public string PackagingGroup { get; set; }

        /// <summary>
        /// The Classification code
        /// </summary>
        [DisplayName("Classification code")]
        [Description("Classification code")]
        public string ClassificationCode { get; set; }

        /// <summary>
        /// Exempted quantity
        /// </summary>
        [DisplayName("Exempted quantity")]
        [Description("Exempted quantity")]
        public bool? ExemptedQuantity { get; set; }

        /// <summary>
        /// Net weight kilogram
        /// </summary>
        [DisplayName("Net weight kilogram")]
        [Description("Net weight kilogram")]
        public decimal? NetWeightKilogram { get; set; }

        /// <summary>
        /// Volume liter
        /// </summary>
        [DisplayName("Volume liter")]
        [Description("Volume liter")]
        public decimal? VolumeLiter { get; set; }

        /// <summary>
        /// Transport of high consequences dangerous goods
        /// </summary>
        [DisplayName("High consequences dangerous goods")]
        [Description("High consequences dangerous goods")]
        public bool? HighConsequencesDangerousGoods { get; set; }

        /// <summary>
        /// ADR Release
        /// </summary>
        [DisplayName("ADR Release")]
        [Description("ADR Release")]
        public string AdrRelease { get; set; }

        /// <summary>
        /// Packaging class
        /// </summary>
        [DisplayName("Packaging class")]
        [Description("Packaging class")]
        public string PackagingClass { get; set; }

        /// <summary>
        /// Dangerous goods references
        /// </summary>
        public EdiDangerousGoodsReferences References { get; set; }
    }

    /// <summary>
    /// Dangerous goods references
    /// </summary>
    [JsonObject("dangerousGoodsReferences")]
    [DisplayName("Dangerous goods references")]
    [Description("Dangerous goods references")]
    public class EdiDangerousGoodsReferences
    {
        /// <summary>
        /// The fireworks Bam number
        /// </summary>
        [DisplayName("Fireworks bam number")]
        [Description("Fireworks Bam number")]
        public string FireworksBamNo { get; set; }
    }
}