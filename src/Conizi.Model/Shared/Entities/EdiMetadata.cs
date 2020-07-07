using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Addition conizi metadata for Routing purposes
    /// </summary>
    public class EdiMetadata
    {
        /// <summary>
        /// The main sender
        /// </summary>
        [JsonProperty("sender", Required = Required.DisallowNull)]
        [DisplayName("sender")]
        [Description("The main sender")]
        public EdiMetadataEntity Sender { get; set; }

        /// <summary>
        /// The main receiver
        /// </summary>
        [JsonProperty("receiver", Required = Required.DisallowNull)]
        [DisplayName("Receiver")]
        [Description("The main receiver")]
        public EdiMetadataEntity Receiver { get; set; }

        /// <summary>
        /// The forwarder (Customer of App or Service)
        /// </summary>
        [JsonProperty("technicalSender", Required = Required.DisallowNull)]
        [DisplayName("Technical Sender")]
        [Description("The forwarder (Customer of App or Service)")]
        public EdiMetadataEntity TechnicalSender { get; set; }
        
        /// <summary>
        /// The message was created at date
        /// </summary>
        [JsonProperty("createdAt", Required = Required.DisallowNull)]
        [DisplayName("Created at date")]
        [Description("The message was created at date")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The message was created by
        /// </summary>
        [JsonProperty("createdBy", Required = Required.DisallowNull)]
        [DisplayName("Created by generator")]
        [Description("The message was created by")]
        public string CreatedBy { get; internal set; }
        
        /// <summary>
        /// The message was created on environment
        /// </summary>
        [JsonProperty("environment", Required = Required.DisallowNull)]
        [DisplayName("Created on environment")]
        [Description("The message was created on environment")]
        public string Environment { get; internal set; }
    }

    /// <summary>
    /// Entity to use with conizi <see cref="EdiMetadata"/> 
    /// </summary>
    public class EdiMetadataEntity
    {
        /// <summary>
        /// The conizi id of the tenant
        /// </summary>
        public string Tenant { get; set; }

        /// <summary>
        /// The conizi id of the party
        /// </summary>
        public string Party { get; set; }
    }
}
