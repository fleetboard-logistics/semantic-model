using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities
{

    /// <summary>
    /// Events occurred while validating and processing the data
    /// </summary>
    [DisplayName("Data processing")]
    [Description("Events occurred while validating and processing the data")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiDataProcessing : EdiEventBase
    {
        /// <summary>
        /// The data is incomplete, missing or wrong
        /// </summary>
        //DisplayName("Wrong data")]
        //[Description("The data is incomplete, missing or wrong")]
        public EdiEmptyExtendableObject InvalidData { get; set; }

        /// <summary>
        /// Wrong, incomplete or missing package type information
        /// </summary>
        //DisplayName("Wrong package type")]
        //[Description("Wrong, incomplete or missing package type information")]
        public EdiEmptyExtendableObject InvalidPackageType { get; set; }

        /// <summary>
        /// Wrong, incomplete or missing package type information
        /// </summary>
        //DisplayName("Invalid Dangerous good information")]
        //[Description("Wrong, incomplete or missing information about the dangerous goods")]
        public EdiEmptyExtendableObject InvalidDangerousGoodInformation { get; set; }
    }
}