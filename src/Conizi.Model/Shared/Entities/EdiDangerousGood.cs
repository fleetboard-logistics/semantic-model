using System;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("dangerousGoods")]
    [DisplayName("Dangerous goods")]
    [Description("Dangerous goods")]
    [ConiziAdditionalProperties(false)]
    public class EdiDangerousGood
    {
        [DisplayName("Gross weight (kg)")]
        [Description("Weight of the consignment including all packaging")]
        public Decimal GrossWeightKilogram { get; set; }

        [DisplayName("UnNo")]
        [Description("UnNo")]
        public string UnNo { get; set; }

        [DisplayName("Multiplier")]
        [Description("Multiplier")]
        public int Multiplier { get; set; }
        
        [DisplayName("Unique key")]
        [Description("The unique Key")]
        public string UniqueKey { get; set; }

        [DisplayName("Substance Name")]
        [Description("The substance Name")]
        public string SubstanceName { get; set; }

        [DisplayName("Label for main risk")]
        [Description("Label for main risk")]
        public string LabelMainRisk { get; set; }

        [DisplayName("Label for sub risk 1")]
        [Description("Label for sub risk 1")]
        public string LabelSubRisk1 { get; set; }

        [DisplayName("Label for sub risk 2")]
        [Description("Label for sub risk 2")]
        public string LabelSubRisk2 { get; set; }

        [DisplayName("Label for sub risk 3")]
        [Description("Label for sub risk 3")]
        public string LabelSubRisk3 { get; set; }

        [DisplayName("Packaging description")]
        [Description("The packaging description")]
        public string PackagingDescription { get; set; }

        [DisplayName("Net explosive mass in kilogram")]
        [Description("The net explosive mass in kilogram")]
        public Decimal NetExplosiveMassKilogram { get; set; }

        [DisplayName("Limited quantity")]
        [Description("Limited quantity")]
        public bool LimitedQuantity { get; set; }

        [DisplayName("Total points ADR")]
        [Description("Total points ADR")]
        public int TotalPointsAdr { get; set; }

        [DisplayName("Tunnel restriction")]
        [Description("Tunnel restriction")]
        public string TunnelRestriction { get; set; }

        [DisplayName("Packaging group")]
        [Description("Packaging group")]
        public string PackagingGroup { get; set; }

        [DisplayName("Classification code")]
        [Description("Classification code")]
        public string ClassificationCode { get; set; }

        [DisplayName("Exempted quantity")]
        [Description("Exempted quantity")]
        public bool ExemptedQuantity { get; set; }

        [DisplayName("Net weight kilogram")]
        [Description("Net weight kilogram")]
        public decimal NetWeightKilogram { get; set; }

        [DisplayName("Volume liter")]
        [Description("Volume liter")]
        public decimal VolumeLiter { get; set; }

        [DisplayName("High consequences dangerous goods")]
        [Description("High consequences dangerous goods ")]
        public bool HighConsequencesDangerousGoods { get; set; }

        [DisplayName("ADR Release")]
        [Description("ADR Release")]
        public string AdrRelease { get; set; }

        [DisplayName("Packaging class")]
        [Description("Packaging class")]
        public string PackagingClass { get; set; }

        public EdiDangerousGoodsReferences References { get; set; }
    }

    [JsonObject("dangerousGoodsReferences")]
    [DisplayName("Dangerous goods references")]
    [Description("Dangerous goods references")]
    public class EdiDangerousGoodsReferences
    {
        [DisplayName("Fireworks bam number")]
        [Description("Fireworks bam number")]
        public string FireworksBamNo { get; set; }
    }
}