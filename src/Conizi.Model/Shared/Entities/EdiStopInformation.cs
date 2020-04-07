using System.Collections.Generic;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Information about the current stop
    /// </summary>
    [DisplayName("Stop Information")]
    [Description("Information about the current stop")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiStopInformation
    {
        
        /// <summary>
        /// Remarks in general as free-text
        /// </summary>
        [DisplayName("Remarks General")]
        [Description("Remarks in general as free-text")]
        public List<string> RemarksGeneral { get; set; }

        /// <summary>
        /// Remarks about the stop Address as free-text
        /// </summary>
        [DisplayName("Remarks Address")]
        [Description("Remarks about the stop Address as free-text")]
        public List<string> RemarksAddress { get; set; }

        /// <summary>
        /// Remarks about the handling instruction as free-text
        /// </summary>
        [DisplayName("Remarks Handling Instruction")]
        [Description("Remarks about the handling instruction as free-text")]
        public List<string> RemarksHandlingInstruction { get; set; }


        /// <summary>
        /// Remarks from the disposal office as free-text
        /// </summary>
        [DisplayName("Remarks Dispatcher")]
        [Description("Remarks from the disposal office as free-text")]
        public List<string> RemarksDispatcher { get; set; }
    }
}