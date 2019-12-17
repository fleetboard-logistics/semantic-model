using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Information about the individual package
    /// </summary>
    [DisplayName("Package")]
    [Description("Information about the individual package")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPackage
    {
        /// <summary>
        /// The reference number
        /// </summary>
        [DisplayName("Reference number")]
        [Description("The reference number")]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// The packaging type
        /// </summary>
        [DisplayName("Packaging Type")]
        [Description("The packaging type")]
        public string PackagingType { get; set; }

        /// <summary>
        /// Scan id of the package, usually printed as machine readable bar code on the package
        /// </summary>
        [DisplayName("Bar code / SSCC / NVE")]
        [Description("Scan id of the package, usually printed as machine readable bar code on the package")]
        public string BarCode { get; set; }

        /// <summary>
        /// Weight of the package in kg
        /// </summary>
        [DisplayName("Weight of package (kg)")]
        [Description("Weight of the package in kg")]
        public decimal? Weight { get; set; }

        /// <summary>
        /// Height in meter
        /// </summary>
        [DisplayName("Height (m)")]
        [Description("Height in meter")]
        public decimal? Height { get; set; }

        /// <summary>
        /// Width in meter
        /// </summary>
        [DisplayName("Width (m)")]
        [Description("Width in meter")]
        public decimal? Width { get; set; }

        /// <summary>
        /// Length in meter
        /// </summary>
        [DisplayName("Length (m)")]
        [Description("Length in meter")]
        public decimal? Length { get; set; }

        /// <summary>
        /// Total volume of the package (m³)
        /// </summary>
        [DisplayName("Volume (m³)")]
        [Description("Total volume of the package")]
        public decimal? Volume { get; set; }
    }
}