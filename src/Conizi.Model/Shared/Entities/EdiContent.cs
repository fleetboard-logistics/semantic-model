using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("content")]
    [DisplayName("Content")]
    [Description("Describes the nature and quantity of the goods in this consignment")]
    [ConiziAdditionalProperties(false)]
    public class EdiContent : EdiMeasures
    {
        [DisplayName("Non hazardous waste")]
        [Description("The content has no value and is not dangerous")]
        public bool NonHazardousWaste { get; set; }

        [DisplayName("Loading aids")]
        [Description("The consignment only consists of loading aids which are transported and does not contain real goods")]
        public bool LoadingAids { get; set; }

        [DisplayName("Packaging pool")]
        [Description("Name of the packaging pool which is used to handle to loading aids from this consignment")]
        public string PackagingPool { get; set; }

        [DisplayName("High value goods")]
        [Description("This consignment contains goods of high value which are subject to higher insure fees and a higher risk of theft")]
        public bool HighValueGoods { get; set; }

        public EdiInsuranceValue InsuranceValue { get; set; }

        public List<EdiLine> Lines { get; set; }
    }

    [JsonObject("insuranceValue")]
    [DisplayName("Insurance value")]
    [Description("Value of the goods, used for insurance purposes")]
    [ConiziAdditionalProperties(false)]
    public class EdiInsuranceValue
    {
        [DisplayName("Amount")]
        [Description("Amount")]
        public Decimal Amount { get; set; }

        [DisplayName("Currency")]
        [Description("Currency")]
        public string Currency { get; set; }
    }

    [JsonObject("line")]
    [DisplayName("Line")]
    [Description("Lines are describing handling units of similar sizes and content for brevity")]
    [ConiziAdditionalProperties(false)]
    public class EdiLine : EdiMeasures
    {
        [DisplayName("Line no")]
        [Description("A ordinal number, ordering the line within the consignment")]
        public int LineNo { get; set; }

        [DisplayName("Handling unit count")]
        [Description("The number of the items in this consignment which are handeled individually")]
        public int HandlingUnitCount { get; set; }

        [DisplayName("Handling unit type")]
        [Description("The type of packaging (e.g. pallet, carton box, ...) ouf the outer most packaging")]
        public string HandlingUnitType { get; set; }

        [DisplayName("Inner package count")]
        [Description("Used to specify the number of inner packages (e.g. the number of boxes on a pallet)")]
        public int InnerPackageCount { get; set; }

        [DisplayName("Inner package type")]
        [Description("The type of packaging of the inner packages")]
        public string InnerPackageTyp { get; set; }

        [DisplayName("Content")]
        [Description("A short description of the nature of the goods contained within the packages")]
        public string Content { get; set; }

        [DisplayName("Reference number")]
        [Description("A reference of the ordering party relating to the goods")]
        public string RefNo { get; set; }

        public EdiContentCustomsInformation CustomsInformation { get; set; }

        public List<EdiBarcode> Barcodes { get; set; }

        public List<EdiDangerousGood> DangerousGoods { get; set; }

        public EdiAdditionalLoadingEquipment AdditionalLoadingEquipment { get; set; }

    }

    [JsonObject("contentCustomsInformation")]
    [DisplayName("Customs information")]
    [Description("Used to specifiy information necessary in the customs process")]
    [ConiziAdditionalProperties(false)]
    public class EdiContentCustomsInformation
    {
        [DisplayName("Goods number")]
        [Description("Goods number")]
        public string GoodsNo { get; set; }

        [DisplayName("Process code")]
        [Description("The Process code")]
        public string ProcessCode { get; set; }

        [DisplayName("Net weight kilogram")]
        [Description("The net weight in kilogram")]
        public Decimal NetweightKilogram { get; set; }

        [DisplayName("Raw weight kilogram")]
        [Description("The raw weight in kilogram")]
        public Decimal RawWeightKilogram { get; set; }

        [DisplayName("Country of origin")]
        [Description("The Country of origin")]
        public string CountryOfOrigin { get; set; }

        [DisplayName("Customs value")]
        [Description("The customs value")]
        public string CustomsValue { get; set; }
    }
}
