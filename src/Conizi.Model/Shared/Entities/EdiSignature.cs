using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// The signature of the recipient/person of interest
    /// </summary>
    
    [DisplayName("Signature")]
    [Description("The signature of the recipient/person of interest")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiSignature : EdiPatternPropertiesBase
    {
      
        /// <summary>
        /// Name of the signee
        /// </summary>
        [DisplayName("Signee name")]
        [Description("Name of the signee")]
        public string SigneeName { get; set; }

        /// <summary>
        /// The date and time of signature
        /// </summary>
        [Required]
        [DisplayName("Signature date and time")]
        [Description("The date and time of signature")]
        public DateTime SignatureDateTime { get; set; }

        /// <summary>
        /// The signature as a file (image, reference)
        /// </summary>
        [Required]
        public EdiFileContent SignatureContent { get; set; }
    }
}