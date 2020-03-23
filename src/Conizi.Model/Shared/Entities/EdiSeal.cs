using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Seals used to prevent tampering with the goods in the load unit
    /// </summary>
    
    [DisplayName("Seal")]
    [Description("Seals used to prevent tampering with the goods in the load unit")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiSeal : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Code / number of the seal
        /// </summary>
        [DisplayName("Code / number of the seal")]
        [Description("Code / number of the seal")]
        public string Code { get; set; }
    }
}