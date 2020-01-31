using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{
    /// <summary>
    /// An event which occurred during the processing of the referenced package, which is included in a <see cref="Consignment"/>
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/transport/truck/groupage/forwarding/package-event.json",
        "package-event.json")]
    [DisplayName("Package event")]
    [Description("An event which occurred during the processing of the referenced package.")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class PackageEvent : EdiModel
    {
        /// <summary>
        /// The partner which is sending the consignment to the receiving partner for further delivery
        /// </summary>
        public EdiPartnerIdentification ShippingPartner { get; set; }

        /// <summary>
        /// The partner which is receiving the goods declared on the manifest from the shipping partner for further delivery
        /// </summary>
        public EdiPartnerIdentification ReceivingPartner { get; set; }

        /// <summary>
        /// The partner which is reporting the event
        /// </summary>
        public EdiPartnerIdentification ReportingPartner { get; set; }

        /// <summary>
        /// Consignment number of the shipping partner
        /// </summary>
        [JsonRequired]
        [DisplayName("Consignment number of the shipping partner")]
        [Description(
            "Unique identification for the consignment within the transport management system of the shipping partner")]
        public string ConsignmentNoShippingPartner { get; set; }

        /// <summary>
        /// Unique identification for the package. This is often an SSCC / NVE barcode number.
        /// </summary>
        [JsonRequired]
        [DisplayName("Package number / Barcode of the package")]
        [Description(
            "Unique identification for the package. This is often an SSCC / NVE barcode number")]
        public string PackageNo { get; set; }

        /// <summary>
        /// Events occurred while pickup the package
        /// </summary>
        //[DisplayName("Pickup by the sender")]
        //[Description("Events occurred while pickup the package")]
        public EdiPackageEvent PickupSender { get; set; }

        /// <summary>
        /// Unique identification for the consignment in a central system
        /// </summary>
        [DisplayName("Unique central consignment number")]
        [Description("Unique identification for the consignment in a central system")]
        public string ConsignmentObjectId { get; set; }

        /// <summary>
        /// Events occurred while unloading the package by the shipping partner
        /// </summary>
        //[DisplayName("Unloading by the shipping partner")]
        //[Description("Events occurred while unloading the package by the shipping partner")]
        public EdiPackageEvent UnloadingShippingPartner { get; set; }

        /// <summary>
        /// Events occurred while loading the package by the shipping partner
        /// </summary>
        //[DisplayName("Loading by the shipping partner")]
        //[Description("Events occurred while loading the package by the shipping partner")]
        public EdiPackageEvent LoadingShippingPartner { get; set; }

        /// <summary>
        /// Events occurred while the package enters the security area of the shipping partner
        /// </summary>
        //[DisplayName("Entrance to the security area of the shipping partner")]
        //[Description("Events occurred while the package enters the security area of the shipping partner")]
        public EdiPackageEvent EntrySecurityAreaShippingPartner { get; set; }

        /// <summary>
        /// Events occurred while the package leaves the security area of the shipping partner
        /// </summary>
        //[DisplayName("Exit of the security area of the shipping partner")]
        //[Description("Events occurred while the package leaves the security area of the shipping partner")]
        public EdiPackageEvent ExitSecurityAreaShippingPartner { get; set; }

        /// <summary>
        /// Events occurred while stocktaking the package by the shipping partner
        /// </summary>
        //[DisplayName("Stocktaking by the shipping partner")]
        //[Description("Events occurred while stocktaking the package by the shipping partner")]
        public EdiPackageEvent StocktakingShippingPartner { get; set; }

        /// <summary>
        /// Events occurred while unloading the package by the gateway
        /// </summary>
        //[DisplayName("Unloading by the gateway")]
        //[Description("Events occurred while unloading the package by the gateway")]
        public EdiPackageEvent UnloadingGateway { get; set; }

        /// <summary>
        /// Events occurred while loading the package by the gateway
        /// </summary>
        //[DisplayName("Loading by the gateway")]
        //[Description("Events occurred while loading the package by the gateway")]
        public EdiPackageEvent LoadingGateway { get; set; }

        /// <summary>
        /// Events occurred while loading the package by the gateway
        /// </summary>
        //[DisplayName("Loading by the gateway")]
        //[Description("Events occurred while loading the package by the gateway")]
        public EdiPackageEvent EntrySecurityAreaGateway { get; set; }

        /// <summary>
        /// Events occurred while the package leaves the security area of the gateway
        /// </summary>
        //[DisplayName("Exit of the security area of the gateway")]
        //[Description("Events occurred while the package leaves the security area of the gateway")]
        public EdiPackageEvent ExitSecurityAreaGateway { get; set; }

        /// <summary>
        /// Events occurred while stocktaking the package by the gateway
        /// </summary>
        //[DisplayName("Stocktaking by the gateway")]
        //[Description("Events occurred while stocktaking the package by the gateway")]
        public EdiPackageEvent StocktakingGateway { get; set; }

        /// <summary>
        /// Events occurred while unloading the package by the HUB
        /// </summary>
        //[DisplayName("Unloading by the HUB")]
        //[Description("Events occurred while unloading the package by the HUB")]
        [JsonProperty("unloadingHUB")]
        public EdiPackageEvent UnloadingHub { get; set; }

        /// <summary>
        /// Events occurred while loading the package by the HUB
        /// </summary>
        //[DisplayName("Loading by the HUB")]
        //[Description("Events occurred while loading the package by the HUB")]
        [JsonProperty("loadingHUB")]
        public EdiPackageEvent LoadingHub{ get; set; }

        /// <summary>
        /// Events occured while the package enters the security area of the HUB
        /// </summary>
        //[DisplayName("Entrance to the security area of the HUB")]
        //[Description("Events occured while the package enters the security area of the HUB")]
        [JsonProperty("entrySecurityAreaHUB")]
        public EdiPackageEvent EntrySecurityAreaHub { get; set; }

        /// <summary>
        /// Events occured while the package leaves the security area of the HUB
        /// </summary>
        //[DisplayName("Exit of the security area of the HUB")]
        //[Description("Events occured while the package leaves the security area of the HUB")]
        [JsonProperty("exitSecurityAreaHUB")]
        public EdiPackageEvent ExitSecurityAreaHub { get; set; }

        /// <summary>
        /// Events occurred while stocktaking the package by the HUB
        /// </summary>
        //[DisplayName("Stocktaking by the HUB)]
        //[Description("Events occurred while stocktaking the package by the HUB")]
        [JsonProperty("stocktakingHUB")]
        public EdiPackageEvent StocktakingHub { get; set; }

        /// <summary>
        /// Events occurred while unloading the package by the receiving partner
        /// </summary>
        //[DisplayName("Unloading by the receiving partner")]
        //[Description("Events occurred while unloading the package by the receiving partner")]
        public EdiPackageEvent UnloadingReceivingPartner { get; set; }

        /// <summary>
        /// Events occured while loading the package by the receiving partner
        /// </summary>
        //[DisplayName("Loading by the receiving partner")]
        //[Description("Events occured while loading the package by the receiving partner")]
        public EdiPackageEvent LoadingReceivingPartner { get; set; }

        /// <summary>
        /// Events occurred while the package enters the security area of the receiving partner
        /// </summary>
        //[DisplayName("Entrance to the security area of the receiving partner"")]
        //[Description("Events occurred while the package enters the security area of the receiving partner")]
        public EdiPackageEvent EntrySecurityAreaReceivingPartner { get; set; }

        /// <summary>
        /// Events occured while the package leaves the security area of the receiving partner
        /// </summary>
        //[DisplayName("Exit of the security area of the receiving partner")]
        //[Description("Events occured while the package leaves the security area of the receiving partner")]
        public EdiPackageEvent ExitSecurityAreaReceivingPartner { get; set; }

        /// <summary>
        /// Events occurred while stocktaking the package by the receiving partner
        /// </summary>
        //[DisplayName("Stocktaking by the receiving partner")]
        //[Description("Events occurred while stocktaking the package by the receiving partner")]
        public EdiPackageEvent StocktakingReceivingPartner { get; set; }

        /// <summary>
        /// Events occurred while delivery the package
        /// </summary>
        //[DisplayName("Events occured while delivery the package")]
        //[Description("Events occurred while delivery the package")]
        public EdiPackageEvent DeliveryReceiver { get; set; }

        /// <summary>
        /// Events occured while unloading the package by the receiving partner after an unsuccessfully delivery attempt
        /// </summary>
        //[DisplayName("Unloading by the receiving partner after a delivery attempt")]
        //[Description("Events occured while unloading the package by the receiving partner after an unsuccessfully delivery attempt")]
        public EdiPackageEvent UnloadingAfterDeliveryAttempt { get; set; }


        /// <summary>
        /// Events occurred while unloading the package by an external deliverer
        /// </summary>
        //[DisplayName("Unloading by an external delivery party / service provider")]
        //[Description("Events occurred while unloading the package by an external deliverer")]
        public EdiPackageEvent UnloadingExternalDeliverer { get; set; }

        /// <summary>
        /// The geo position
        /// </summary>
        [JsonProperty("geoPosition", Order = -15, Required = Required.DisallowNull)]
        public EdiGeoPosition GeoPosition { get; set; }

        /// <summary>
        /// A list of document items
        /// </summary>
        public List<EdiDocumentItem> Documents { get; set; }

        /// <summary>
        /// A list of status images
        /// </summary>
        public List<EdiStatusImage> Images { get; set; }
    }

}
