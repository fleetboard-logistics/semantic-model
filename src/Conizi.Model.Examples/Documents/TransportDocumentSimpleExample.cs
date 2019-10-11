using System;
using System.Collections.Generic;
using Conizi.Model.Documents;
using Conizi.Model.Examples.Interfaces;
using Conizi.Model.Examples.Shared.Attributes;
using Conizi.Model.Shared.Definitions;
using Conizi.Model.Shared.Entities;

namespace Conizi.Model.Examples.Documents
{
    /// <summary>
    /// Simple example for a <see cref="TransportDocument"/>
    /// </summary>
    [ExampleFor(typeof(TransportDocument))]
    public class TransportDocumentSimpleExample : IModelCreateFactory<TransportDocument>
    {
        public TransportDocument Create()
        {
            var m = new TransportDocument
            {
                References = new EdiDocumentReferencesExtended {Id = "12345678"},
                Archive = new EdiDocumentArchive(),
                DocumentCreationDateTime = DateTime.Now.AddHours(-2),
                ShippingDate = DateTime.Now,
                Receiver = new EdiMessageRouting {ConiziId = "4545454545454545454"}
            };

            // The receiver of data and m message
            m.References.ReferenceNumber = "12312313";
            // Shipping partner of the goods, Sender
            m.Archive.ShippingPartner = new EdiPartnerIdentification
            {
                PartnerId = "MAINP",
                Name = "My Shipping Partner"
            };
            // Receiver of the goods for further delivery
            m.Archive.ReceivingPartner = new EdiPartnerIdentification
            {
                Name = "Max Mustermann",
                Street = "Musterstraße 1",
                ZipCode = "97082",
                City = "Würzburg",
                CountryCode = "DE"
            };
            // The client, sender of the goods
            m.Archive.Shipper = new EdiAddress
            {
                Name = "Zombie Inc.",
                Street = "Am düsteren Weg",
                HouseNumber = "3a",
                ZipCode = "97424",
                City = "Würzburg",
                CountryCode = "DE",
                AdditionalAddressLines = new List<string>
                {
                    "Gate 2"
                },
                TownArea = "Hafen West",
            };
            // Receiver of the goods
            m.Archive.Consignee = new EdiAddress
            {
                Name = "Umbrella Corp.",
                City = "Racoon City",
                Street = "Umbrella Str.",
                HouseNumber = "1-20"
            };
            m.Documents = new List<EdiDocumentItem>
            {
                new EdiDocumentItem
                {
                    DocumentType = EdiDocumentType.ProofOfDelivery,
                    DocumentCreator ="Hans Z.",
                    DocumentDateTime  = DateTime.Now.AddHours(-2).AddMinutes(-2),
                    DocumentContent = new EdiFileContent
                    {
                        ContentType = "application/pdf",
                        FileName = "hans_waybill_doc.pdf",
                        BinaryData = new EdiBinaryData
                        {
                            Data = new byte[]
                            {
                                1, 0, 0, 1
                            }
                        }
                    },
                    Signatures = new List<EdiSignature>
                    {
                        new EdiSignature
                        {
                            SigneeName = "Hans Z.",
                            SignatureDateTime = DateTime.Now.AddHours(-2).AddMinutes(-4),
                            SignatureContent =  new EdiFileContent
                            {
                                ContentType = "image/png",
                                FileName = "hans_signature.png",
                                BinaryData = new EdiBinaryData
                                {
                                    Data = new byte[]
                                    {
                                        1, 1, 1, 1
                                    }
                                }
                            }
                        }
                     
                    }
                }
            };

            return m;
        }
    }
}