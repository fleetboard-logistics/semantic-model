using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Information for the driver to assign the tour to himself
    /// </summary>

    [DisplayName("Self Disposal")]
    [Description("Information for the driver to assign the tour to himself")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiSelfDisposal
    {
        /// <summary>
        /// Self-disposal allowed?
        /// </summary>
        [DisplayName("Allowed")]
        [Description("Self-disposal allowed?")]
        public bool? Allowed { get; set; }

        /// <summary>
        /// Self-disposal only with barcode
        /// </summary>
        [DisplayName("Barcode Only")]
        [Description("Self-disposal only with barcode")]
        public bool? BarcodeOnly { get; set; }

        /// <summary>
        /// Barcode for self-disposal
        /// </summary>
        [DisplayName("Barcode")]
        [Description("Barcode for self-disposall")]
        public string Barcode { get; set; }
    }
}