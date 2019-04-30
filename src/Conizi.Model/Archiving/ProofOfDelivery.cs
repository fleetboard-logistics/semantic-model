using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;
using Newtonsoft.Json;

namespace Conizi.Model.Archiving
{

    /// <summary>
    /// Proof of delivery (POD) is a method/document to establish the fact that the recipient received the contents sent by the sender.
    /// The POD is usually generated after the delivery of an <see cref="Consignment"/>
    /// </summary>
    [DisplayName("Proof of Delivery")]
    [Description("Proof of delivery (POD) is a method/document to establish the fact that the recipient received the contents sent by the sender")]
    [ConiziSchema("https://model.conizi.io/v1/archiving/proof-of-delivery.json", "proof-of-delivery.json")]
    public class ProofOfDelivery : EdiModel 
    {
        /// <summary>
        ///  The unique id of the POD
        /// </summary>
        [Required]
        [DisplayName("Id")]
        [Description("The unique id of the POD")]
        [JsonProperty(Order = -11)]
        public string Id { get; set; }

        /// <summary>
        /// A reference of the ordering party relating to the goods
        /// </summary>
        [Required]
        [DisplayName("Reference Number")]
        [Description("A reference of the ordering party relating to the goods")]
        [JsonProperty(Order = -10)]
        public string RefNo { get; set; }

        /// <summary>
        /// The address of the party which is sending the goods. This is usually the place where the pickup originated
        /// </summary>
        [Required]
        [JsonProperty(Order = -8)]
        public EdiAddress Shipper { get; set; }

        /// <summary>
        /// The address of the good's recipient
        /// </summary>
        [Required]
        [JsonProperty(Order = -6)]
        public EdiAddress Consignee { get; set; }

        /// <summary>
        /// Company responsible for the actual transport of the goods from the shipping partner to the recipient
        /// </summary>
        [JsonProperty(Order = -5)]
        public EdiAddress Carrier { get; set; }
        
        /// <summary>
        /// The partner which is sending the consignment to the receiving partner for further delivery
        /// </summary>
        [Required]
        public EdiPartnerIdentification ShippingPartner { get; set; }

        /// <summary>
        /// The partner which is receiving the goods declared on the manifest from the shipping partner for further delivery
        /// </summary>
        [Required]
        public EdiPartnerIdentification ReceivingPartner { get; set; }

        /// <summary>
        /// The content as file
        /// </summary>
        [JsonProperty("content")]
        public EdiFileContent Content { get; set; }
        
        /// <summary>
        /// The date on which the consignment was forwarded to the receiving partner. If the consignment was part of a cargo manifest, this is the date on which the manifest was issued
        /// </summary>
        [DisplayName("Shipping date")]
        [Description("The date on which the consignment was forwarded to the receiving partner. If the consignment was part of a cargo manifest, this is the date on which the manifest was issued")]
        [JsonProperty(Order = -4)]
        [ConiziDateOnly]
        [Required]
        public DateTime ShippingDate { get; set; }

        /// <summary>
        /// Date this document was created
        /// </summary>
        [DisplayName("Document creation date")]
        [Description("Date this document was created")]
        [Required]
        public DateTime DocumentCreationDate { get; set; }

        /// <summary>
        /// The date and time goods arrived
        /// </summary>
        [DisplayName("Arrival date")]
        [Description("The date and time goods arrived")]
        public DateTime ArrivalDate { get; set; }

        /// <summary>
        /// The planned date and time of shipping/transport
        /// </summary>
        [ConiziDateOnly]
        [DisplayName("Planned shipping date")]
        [Description("The planned date and time of shipping/transport")]
        public DateTime PlannedShippingDate { get; set; }

        /// <summary>
        /// The signature of the recipient
        /// </summary>
        public EdiSignature Signature { get; set; }
    }
}
