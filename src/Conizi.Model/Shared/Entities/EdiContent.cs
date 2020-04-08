using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Describes the nature and quantity of the goods in this consignment
    /// </summary>

    [DisplayName("Content")]
    [Description("Describes the nature and quantity of the goods in this consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiContent : EdiMeasures
    {

        /// <summary>
        /// The content has no value and is not dangerous
        /// </summary>
        [DisplayName("Non hazardous waste")]
        [Description("The content has no value and is not dangerous")]
        public bool? NonHazardousWaste { get; set; }

        /// <summary>
        /// The consignment only consists of loading aids which are transported and does not contain real goods
        /// </summary>
        [DisplayName("Loading aids")]
        [Description(
            "The consignment only consists of loading aids which are transported and does not contain real goods")]
        public bool? LoadingAids { get; set; }

        /// <summary>
        /// Name of the packaging pool which is used to handle to loading aids from this consignment
        /// </summary>
        [DisplayName("Packaging pool")]
        [Description("Name of the packaging pool which is used to handle to loading aids from this consignment")]
        public string PackagingPool { get; set; }

        /// <summary>
        /// This consignment contains goods of high value which are subject to higher insure fees and a higher risk of theft
        /// </summary>
        [DisplayName("High value goods")]
        [Description(
            "This consignment contains goods of high value which are subject to higher insure fees and a higher risk of theft")]
        public bool? HighValueGoods { get; set; }
        
        /// <summary>
        ///  Dangerous goods to be declared contained in a consignment 
        /// </summary>
        public TourDangerousGoods DangerousGoods { get; set; }
        
        /// <summary>
        /// Customs goods on the tour
        /// </summary>
        [DisplayName("Customs Goods")]
        [Description("Customs goods on the tour")]
        public bool? CustomsGoods { get; set; }

        /// <summary>
        /// Value of the goods, used for insurance purposes
        /// </summary>
        public EdiInsuranceValue InsuranceValue { get; set; }

        /// <summary>
        /// Lines are describing handling units of similar sizes and content for brevity
        /// </summary>
        public List<EdiLine> Lines { get; set; }

        /// <summary>
        /// Additional loading aids which are not part of the consignment but which have been added to safely transport the goods
        /// </summary>
        public EdiAdditionalLoadingEquipment AdditionalLoadingEquipment { get; set; }

    }

    /// <summary>
    /// Value of the goods, used for insurance purposes
    /// </summary>

    [DisplayName("Insurance value")]
    [Description("Value of the goods, used for insurance purposes")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiInsuranceValue : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Amount
        /// </summary>
        [DisplayName("Amount")]
        [Description("Amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        [DisplayName("Currency")]
        [Description("Currency")]
        public string Currency { get; set; }
    }

    /// <summary>
    /// Lines are describing handling units of similar sizes and content for brevity
    /// </summary>

    [DisplayName("Line")]
    [Description("Lines are describing handling units of similar sizes and content for brevity")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiLine : EdiMeasures
    {
        /// <summary>
        /// A ordinal number, ordering the line within the consignment
        /// </summary>
        [DisplayName("Line no")]
        [Description("A ordinal number, ordering the line within the consignment/pickup order")]
        public int? LineNo { get; set; }

        /// <summary>
        /// The number of the items in this consignment/pickup order which are handled individually
        /// </summary>
        [DisplayName("Handling unit count")]
        [Description("The number of the items in this consignment/pickup order which are handeled individually")]
        public int? HandlingUnitCount { get; set; }

        /// <summary>
        /// The type of packaging (e.g. pallet, carton box, ...) ouf the outer most packaging
        /// </summary>
        [DisplayName("Handling unit type")]
        [Description("The type of packaging (e.g. pallet, carton box, ...) ouf the outer most packaging")]
        public string HandlingUnitType { get; set; }

        /// <summary>
        /// Used to specify the number of inner packages (e.g. the number of boxes on a pallet)
        /// </summary>
        [DisplayName("Inner package count")]
        [Description("Used to specify the number of inner packages (e.g. the number of boxes on a pallet)")]
        public int? InnerPackageCount { get; set; }

        /// <summary>
        /// The type of packaging of the inner packages
        /// </summary>
        [DisplayName("Inner package type")]
        [Description("The type of packaging of the inner packages")]
        public string InnerPackageType { get; set; }

        /// <summary>
        /// A short description of the nature of the goods contained within the packages
        /// </summary>
        [DisplayName("Content")]
        [Description("A short description of the nature of the goods contained within the packages")]
        public string Content { get; set; }
        
        /// <summary>
        /// A reference of the ordering party relating to the goods
        /// </summary>
        [DisplayName("Reference number")]
        [Description("A reference of the ordering party relating to the goods")]
        public string RefNo { get; set; }

        /// <summary>
        /// Used to specify information necessary in the customs process
        /// </summary>
        public EdiContentCustomsInformation CustomsInformation { get; set; }

        /// <summary>
        /// Detailed information about the individual handling units
        /// </summary>
        public List<EdiBarcode> Barcodes { get; set; }

        /// <summary>
        /// Information on dangerous goods
        /// </summary>
        public List<EdiDangerousGood> DangerousGoods { get; set; }

        /// <summary>
        /// Additional loading aids which are not part of the pickup order but which have been added to safely transport the goods
        /// </summary>
        public EdiAdditionalLoadingEquipment AdditionalLoadingEquipment { get; set; }

        /// <summary>
        /// List of packages in the current line
        /// </summary>
        public List<EdiPackage> Packages { get; set; }

        /// <summary>
        /// Additional remarks (free form)
        /// </summary>
        [DisplayName("Remarks (free form)")]
        [Description("Additional remarks")]
        public string Remarks { get; set; }

    }

    /// <summary>
    /// Used to specify information necessary in the customs process
    /// </summary>

    [DisplayName("Customs information")]
    [Description("Used to specifiy information necessary in the customs process")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiContentCustomsInformation : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Goods number
        /// </summary>
        [DisplayName("Goods number")]
        [Description("Goods number")]
        public string GoodsNo { get; set; }

        /// <summary>
        /// The Process cod
        /// </summary>
        [DisplayName("Process code")]
        [Description("The Process code")]
        public string ProcessCode { get; set; }

        /// <summary>
        /// The net weight in kilogram
        /// </summary>
        [DisplayName("Net weight kilogram")]
        [Description("The net weight in kilogram")]
        public decimal? NetWeightKilogram { get; set; }

        /// <summary>
        /// The raw weight in kilogram
        /// </summary>
        [DisplayName("Raw weight kilogram")]
        [Description("The raw weight in kilogram")]
        public decimal? RawWeightKilogram { get; set; }

        /// <summary>
        /// The Country of origin
        /// </summary>
        public string CountryOfOrigin { get; set; }

        /// <summary>
        /// The statistical value
        /// </summary>
        public EdiValue StatisticalValue { get; set; }

        /// <summary>
        /// The customs value
        /// </summary>
        public EdiValue CustomsValue { get; set; }

        /// <summary>
        /// Customs documents
        /// </summary>
        public EdiCustomsDocuments Documents { get; set; }
    }


    /// <summary>
    /// Amount value type
    /// </summary>

    [DisplayName("Customs value")]
    [Description("Amount value type")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiValue
    {
        /// <summary>
        /// Amount
        /// </summary>
        [DisplayName("Amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        [DisplayName("Currency")]
        public string Currency { get; set; }
    }


}
