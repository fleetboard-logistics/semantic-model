using System;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("unloadingOptions")]
    [DisplayName("Unloading Options")]
    [Description("Information regarding unloading of the main haul")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiUnloadingOptions
    {
        [DisplayName("Direct delivery")]
        [Description("The goods are to be deliverd without unloading them at the receiving partners warehouse")]
        public bool DirectDelivery { get; set; }

        public EdiAlreadyReceived AlreadyReceived { get; set; }

        public EdiMissingFromPreviousManifest MissingFromPreviousManifest { get; set; }
    }

    [JsonObject("alreadyReceived")]
    [DisplayName("Already received as surplus consignment")]
    [Description(
        "The goods are already at the receiving partners warehouse, because they have been reported as surplus earlier on")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiAlreadyReceived
    {
        [DisplayName("Surplus consignment no")]
        [Description(
            "The reference number under which the surplus consignment had been reported by the receiving partner")]
        public string SurplusConsignmentNo { get; set; }

        [DisplayName("Shipping date")]
        [Description("The date of the manifest which contained the surplus goods")]
        public DateTime ShippingDate { get; set; }
    }

    [JsonObject("missingFromPreviousManifest")]
    [DisplayName("Missing from previous manifest")]
    [Description(
        "The goods for a consigment which already was part of another manifest and had been reported missing on that manifest")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiMissingFromPreviousManifest
    {
        [DisplayName("Manifest id")]
        [Description("The manifest which first included the consignment")]
        public string ManifestId { get; set; }

        [DisplayName("Shipping date")]
        [Description("The date of the manifest which included the consignment")]
        public DateTime ShippingDate { get; set; }
    }
}