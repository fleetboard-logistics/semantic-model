using System.Collections.Generic;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Information about the current tour
    /// </summary>
    [DisplayName("Tour Information")]
    [Description("Information about the current stop")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiTourInformation : EdiPatternPropertiesBase
    {
        
        /// <summary>
        /// Remarks in general as free-text
        /// </summary>
        [DisplayName("Remarks General")]
        [Description("Remarks in general as free-text")]
        public List<string> RemarksGeneral { get; set; }

        /// <summary>
        /// Remarks about the invoice as free-text
        /// </summary>
        [DisplayName("Remarks Invoice")]
        [Description("Remarks about the invoice as free-text")]
        public List<string> RemarksInvoice { get; set; }

        /// <summary>
        /// Remarks about the vehicle as free-text
        /// </summary>
        [DisplayName("Remarks Vehicle")]
        [Description("Remarks about the vehicle as free-text")]
        public List<string> RemarksVehicle { get; set; }

        /// <summary>
        /// Remarks about the driver as free-text
        /// </summary>
        [DisplayName("Remarks Driver")]
        [Description("Remarks about the driver as free-text")]
        public List<string> RemarksDriver { get; set; }
         
        /// <summary>
        /// Remarks from the disposal office as free-text
        /// </summary>
        [DisplayName("Remarks Dispatcher")]
        [Description("Remarks from the disposal office as free-text")]
        public List<string> RemarksDispatcher { get; set; }

        /// <summary>
        /// Remarks about the tour as free-text
        /// </summary>
        [DisplayName("Remarks Tour")]
        [Description("Remarks about the tour as free-text")]
        public List<string> RemarksTour { get; set; }
    }
}