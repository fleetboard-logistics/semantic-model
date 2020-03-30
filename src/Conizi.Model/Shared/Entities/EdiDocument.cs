using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Conizi.Model.Converters;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Definitions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Conizi.Model.Shared.Entities
{
    public class EdiDocument : EdiModel
    {
        /// <summary>
        /// The date and time this document was created
        /// </summary>
        [DisplayName("Document creation date and time")]
        [Description("The date and time this document was created")]
        [Required]
        public DateTime DocumentCreationDateTime { get; set; }

        /// <summary>
        /// The date on which the consignment was forwarded to the receiving partner. If the consignment was part of a cargo manifest, this is the date on which the manifest was issued
        /// </summary>
        [DisplayName("Shipping date")]
        [Description(
            "The date on which the consignment was forwarded to the receiving partner. If the consignment was part of a cargo manifest, this is the date on which the manifest was issued")]
        [ConiziDateOnly]
        [JsonConverter(typeof(ConiziDateConverter))]
        public DateTime? ShippingDate { get; set; }

        /// <summary>
        /// All references to the linked documents, systems and devices
        /// </summary>
        [Required]
        public EdiDocumentReferencesExtended References { get; set; }

        /// <summary>
        ///  All object to archive the document
        /// </summary>
        public EdiDocumentArchive Archive { get; set; }

        /// <summary>
        /// Additional remarks (free form)
        /// </summary>
        [DisplayName("Remarks (free form)")]
        [Description("Additional remarks")]
        public string Remarks { get; set; }
    }


    /// <summary>
    ///  All references to the linked documents, systems and devices
    /// </summary>
    [DisplayName("References")]
    [Description("All references to the linked documents, systems and devices")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiDocumentReferences
    {
        /// <summary>
        ///  The unique id of the document
        /// </summary>
        [DisplayName("Id")]
        [Description("The unique id of the document")]
        public string Id { get; set; }

        /// <summary>
        /// The reference number (e.g. delivery note")
        /// </summary>
        [DisplayName("Reference number")]
        [Description("The reference number (e.g. delivery note)")]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Unique identification for the consignment in a central system
        /// </summary>
        [DisplayName("Unique central consignment number")]
        [Description("Unique identification for the consignment in a central system")]
        public string ConsignmentObjectId { get; set; }

        /// <summary>
        /// Unique identification for the consignment within the transport management system of the shipping partner
        /// </summary>
        [DisplayName("Consignment number of the shipping partner")]
        [Description(
            "Unique identification for the consignment within the transport management system of the shipping partner")]
        public string ConsignmentNoShippingPartner { get; set; }

        /// <summary>
        /// Unique identification for the consignment within the transport management system of the receiving partner
        /// </summary>
        [DisplayName("Consignment number of the receiving partner")]
        [Description(
            "Unique identification for the consignment within the transport management system of the receiving partner")]
        public string ConsignmentNoReceivingPartner { get; set; }

        /// <summary>
        /// The Tour Id. A unique identifier assigned to the tour by the devlivering company
        /// </summary>
        [DisplayName("Tour Id")]
        [Description("A unique identifier assigned to the tour by the devlivering company")]
        public string TourId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Tour Reference")]
        [Description("")]
        public string TourReference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DisplayName("Workflow Id")]
        [Description("")]
        public string WorkflowId { get; set; }

        /// <summary>
        /// Transport Order Id
        /// </summary>
        [DisplayName("Transport Order Id")]
        [Description("Transport Order Id")]
        public string TransportOrderId { get; set; }

        /// <summary>
        /// Transport Order No
        /// </summary>
        [DisplayName("Transport Order No")]
        [Description("Transport Order No")]
        public string TransportOrderNo { get; set; }

        /// <summary>
        /// Stop Id. Unique identifier for the stop within the tour
        /// </summary>
        [DisplayName("Stop Id")]
        [Description("Unique identifier for the stop within the tour")]
        public string StopId { get; set; }

        /// <summary>
        /// The id of the driver
        /// </summary>
        [DisplayName("Diver Id")]
        [Description("The id of the driver")]
        public string DriverId { get; set; }

        /// <summary>
        /// The unique Id of the vehicle (Truck/Trailer/Train)
        /// </summary>
        [DisplayName("The vehicle id")]
        [Description("The unique Id of the vehicle (Truck/Trailer/Train)")]
        public string VehicleId { get; set; }

        /// <summary>
        /// The id of the used device
        /// </summary>
        [DisplayName("Device Id")]
        [Description(" The id of the used device")]
        public string DeviceId { get; set; }

        /// <summary>
        /// A reference to an IT system
        /// </summary>
        [DisplayName("A reference to an IT system")]
        [Description("A reference to an IT system like TMS, etc.")]
        public string SystemReferences { get; set; }

        /// <summary>
        /// Unique identification for the package. This is often an SSCC / NVE barcode number
        /// </summary>
        [DisplayName("Package number / Barcode of the package")]
        [Description(
            "Unique identification for the package. This is often an SSCC / NVE barcode number")]
        public string PackageNo { get; set; }

        /// <summary>
        /// Commission number under which the commission is managed in the master data
        /// </summary>
        [DisplayName("Commission Number")]
        [Description(
            "Commission number under which the commission is managed in the master data")]
        public string CommissionNo { get; set; }
    }

    /// <summary>
    ///  All object to archive the document
    /// </summary>
    [DisplayName("Archive")]
    [Description("All object to archive the document")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiDocumentArchive
    {
        /// <summary>
        /// The address of the party which is sending the goods. This is usually the place where the pickup originated
        /// </summary>
        [Required]
        public EdiAddress Shipper { get; set; }

        /// <summary>
        /// The address of the good's recipient
        /// </summary>
        [Required]
        public EdiAddress Consignee { get; set; }

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
    }

    /// <summary>
    ///  All kind of documents used for transports
    /// </summary>
    [DisplayName("Document")]
    [Description("All kind of documents used for transports")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiDocumentItem
    {
        /// <summary>
        ///  The document type
        /// </summary>
        [DisplayName("Document type")]
        [Description("The document type")]
        [Required]
        [JsonConverter(typeof(StringEnumConverter))]
        public EdiDocumentType DocumentType { get; set; }

        /// <summary>
        ///  The creator of the document
        /// </summary>
        [DisplayName("Document creator")]
        [Description("The creator of the document")]
        public string DocumentCreator { get; set; }

        /// <summary>
        /// The date and time this document item was created
        /// </summary>
        [DisplayName("Document item creation date and time")]
        [Description("The date and time this document item was created")]
        [Required]
        public DateTime DocumentDateTime { get; set; }

        /// <summary>
        /// The document as a file (image, pdf, reference)
        /// </summary>
        [Required]
        public EdiFileContent DocumentContent { get; set; }

        /// <summary>
        /// Signatures of the recipients
        /// </summary>
        public List<EdiSignature> Signatures { get; set; }

        /// <summary>
        /// Additional remarks (free form)
        /// </summary>
        [DisplayName("Remarks (free form)")]
        [Description("Additional remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// The geo position, document was created
        /// </summary>
        public EdiGeoPosition GeoPosition { get; set; }
    }

    /// <summary>
    ///  All kind of status images, used for documentation
    /// </summary>
    [DisplayName("Status image")]
    [Description("All kind of status images, used for documentation")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiStatusImage
    {
        /// <summary>
        ///  The image type
        /// </summary>
        [DisplayName("Image type")]
        [Description("The image type")]
        [JsonConverter(typeof(StringEnumConverter))]
        [Required]
        public EdiImageType ImageType { get; set; }

        /// <summary>
        ///  The creator of the image ((photographer) 
        /// </summary>
        [DisplayName("Image creator")]
        [Description("The creator of the image (photographer)")]
        public string ImageCreator { get; set; }

        /// <summary>
        /// The date and time this status image was created
        /// </summary>
        [DisplayName("Document item creation date and time")]
        [Description("The date and time this status image was created")]
        [Required]
        public DateTime ImageDateTime { get; set; }

        /// <summary>
        /// The document as a file (image, pdf, reference)
        /// </summary>
        [Required]
        public EdiFileContent ImageContent { get; set; }

        /// <summary>
        /// Signatures of the recipients
        /// </summary>
        public List<EdiSignature> Signatures { get; set; }

        /// <summary>
        /// Additional remarks (free form)
        /// </summary>
        [DisplayName("Remarks (free form)")]
        [Description("Additional remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// The geo position, image was taken
        /// </summary>
        public EdiGeoPosition GeoPosition { get; set; }
    }

    /// <summary>
    /// Extended Reference properties for document types
    /// </summary>
    public class EdiDocumentReferencesExtended : EdiDocumentReferences
    {
        /// <summary>
        /// Company responsible for the actual transport of the goods from the shipping partner to the recipient
        /// </summary>
        [JsonProperty("carrier", Order = -2)]
        public EdiAddress Carrier { get; set; }
    }
}