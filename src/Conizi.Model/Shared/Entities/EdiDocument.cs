using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    public class EdiDocument
    {
        [JsonProperty("$schema")]
        public string Schema { get; set; }
        public virtual EdiReceiver Receiver { get; set; }
        public virtual EdiSender Sender { get; set; }
        public EdiNetwork Network { get; set; }
    }

    [JsonObject("receiver", IsReference = true, ItemIsReference = true)]
    public class EdiReceiver
    {
        public string PartnerId { get; set; }
        public string EdiId { get; set; }
        public string ConiziId { get; set; }

        public EdiAddress Address { get; set; }
    }

    [JsonObject("sender", IsReference = true, ItemIsReference = true)]
    public class EdiSender
    {
        public string PartnerId { get; set; }
        public string EdiId { get; set; }
        public string ConiziId { get; set; }
    }

    [JsonObject("network")]
    public class EdiNetwork
    {
        public string NetworkId { get; set; }
        public string Codelist { get; set; }
        public string Product { get; set; }
    }

    public class Manifest : EdiDocument
    {
        public Line[] Lines { get; set; }
    }

    public class Line
    {
        public int LineNo { get; set; }
        public EdiDocument Consignment { get; set; }
    }

    public class PickupOrderBulk : EdiDocument
    {
        public EdiDocument[] Pickuporders { get; set; }
    }

    public class EdiPartnerIdentification
    {
        public string EdiId { get; set; }

        public string PartnerId { get; set; }

        public EdiAddress Address { get; set; }

        public string ConiziId { get; set; }
    }
}