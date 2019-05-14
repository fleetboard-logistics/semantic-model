using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Base model in the conizi context
    /// </summary>
    /// <remarks>Every conizi model must inherit from this class to be serialized correctly</remarks>
    public class 
        EdiModel : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The id (URI) of the model
        /// </summary>
        ///<remarks>
        /// The production ready models are hosted at https://model.conizi.io/[version]
        /// The github repository https://github.com/fleetboard-logistics/semantic-model contains the models source.
        /// Please use the production branch to get a stable version.
        /// </remarks>
        [JsonProperty("$schema", Order = -999)]
        [DisplayName("Json schema")]
        [Description("The used json schema")]
        [Required]
        public string Schema { get; internal set; }

      
        /// <summary>
        /// The receiver of this message
        /// </summary>
        [JsonProperty("receiver", Order = -993)]
        [Required]
        public EdiMessageRouting Receiver { get; set; }

        /// <summary>
        /// The sender of this message
        /// </summary>
        [JsonProperty("sender", Required = Required.DisallowNull, Order = -991)]
        public EdiMessageRouting Sender { get; set; }

        //[JsonProperty("receiver", Required = Required.DisallowNull, Order = -998)]
        //public EdiPartnerIdentification Receiver { get; set; }

        //[JsonProperty("sender", Required = Required.DisallowNull, Order = -997)]
        //public EdiPartnerIdentification Sender { get; set; }

        /// <summary>
        /// The used network for this message
        /// </summary>
        [JsonProperty("network", Required = Required.DisallowNull, Order = -990)]
        public EdiNetwork Network { get; set; }

        /// <summary>
        /// Metadata for conizi routing etc. (Not be shown in Model definition)
        /// </summary>
        [JsonProperty("$metadata", Required = Required.DisallowNull)]
        public EdiMetadata Metadata { get; set; }
    }
}