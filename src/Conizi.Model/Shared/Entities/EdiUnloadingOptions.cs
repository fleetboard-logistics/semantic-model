using System;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Information regarding unloading of the main haul
    /// </summary>
    [JsonObject("unloadingOptions")]
    [DisplayName("Unloading Options")]
    [Description("Information regarding unloading of the main haul")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiUnloadingOptions : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The goods are to be delivered without unloading them at the receiving partners warehouse
        /// </summary>
        [DisplayName("Direct delivery")]
        [Description("The goods are to be delivered without unloading them at the receiving partners warehouse")]
        public bool? DirectDelivery { get; set; }

        /// <summary>
        /// The goods are already at the receiving partners warehouse, because they have been reported as surplus earlier on
        /// </summary>
        public EdiAlreadyReceived AlreadyReceived { get; set; }

        /// <summary>
        /// The goods for a consignment which already was part of another manifest and had been reported missing on that manifest
        /// </summary>
        public EdiMissingFromPreviousManifest MissingFromPreviousManifest { get; set; }
    }

    /// <summary>
    /// The goods are already at the receiving partners warehouse, because they have been reported as surplus earlier on
    /// </summary>
    [JsonObject("alreadyReceived")]
    [DisplayName("Already received as surplus consignment")]
    [Description(
        "The goods are already at the receiving partners warehouse, because they have been reported as surplus earlier on")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiAlreadyReceived : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The reference number under which the surplus consignment had been reported by the receiving partner
        /// </summary>
        [DisplayName("Surplus consignment no")]
        [Description(
            "The reference number under which the surplus consignment had been reported by the receiving partner")]
        public string SurplusConsignmentNo { get; set; }

        /// <summary>
        /// The date of the manifest which contained the surplus goods
        /// </summary>
        [DisplayName("Shipping date")]
        [Description("The date of the manifest which contained the surplus goods")]
        [ConiziDateOnly]
        public DateTime ShippingDate { get; set; }
    }

    /// <summary>
    /// The goods for a consignment which already was part of another manifest and had been reported missing on that manifest
    /// </summary>
    [JsonObject("missingFromPreviousManifest")]
    [DisplayName("Missing from previous manifest")]
    [Description(
        "The goods for a consignment which already was part of another manifest and had been reported missing on that manifest")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiMissingFromPreviousManifest : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The manifest which first included the consignment
        /// </summary>
        [DisplayName("Manifest id")]
        [Description("The manifest which first included the consignment")]
        public string ManifestId { get; set; }

        /// <summary>
        /// The date of the manifest which included the consignment
        /// </summary>
        [DisplayName("Shipping date")]
        [Description("The date of the manifest which included the consignment")]
        [ConiziDateOnly]
        public DateTime ShippingDate { get; set; }
    }
}