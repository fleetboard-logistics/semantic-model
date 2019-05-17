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
        public EdiMetadataEntity Sender { get; set; }

        /// <summary>
        /// The main receiver
        /// </summary>
        public EdiMetadataEntity Receiver { get; set; }

        /// <summary>
        /// The forwarder (Customer of App or Service)
        /// </summary>
        public EdiMetadataEntity TechnicalSender { get; set; }

        /// <summary>
        /// The message was created at date
        /// </summary>
        [JsonProperty("$createdAt", Required = Required.DisallowNull, Order = -997)]
        [DisplayName("Created at date")]
        [Description("The message was created at date")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The message was created by
        /// </summary>
        [JsonProperty("$createdBy", Required = Required.DisallowNull, Order = -995)]
        [DisplayName("Created by generator")]
        [Description("The message was created by")]
        public string CreatedBy { get; internal set; }
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
