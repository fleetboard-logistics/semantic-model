using System;
using System.Collections.Generic;
using Conizi.Model.Archiving;
using Conizi.Model.Examples.Interfaces;
using Conizi.Model.Examples.Shared.Attributes;
using Conizi.Model.Shared.Entities;

namespace Conizi.Model.Examples.Archiving
{
    /// <summary>
    /// Simple example for Proof of Delivery <see cref="ProofOfDelivery"/>
    /// </summary>
    [ExampleFor(typeof(ProofOfDelivery))]
    public class ProofOfDeliverySimpleExample : IModelCreateFactory<ProofOfDelivery>
    {

        public ProofOfDelivery Create()
        {
           var m = new ProofOfDelivery();

            m.Id = "12345678";
            m.DocumentCreationDate = DateTime.Now.AddHours(-2);
            m.ArrivalDate = DateTime.Now.AddDays(-1);
            m.PlannedShippingDate = DateTime.Now.AddDays(-1);
            m.ShippingDate = DateTime.Now;
            // The receiver of data and m message
            m.Receiver = new EdiMessageRouting
            {
                ConiziId = "4545454545454545454"
            };
            m.RefNo = "12312313";
            // Shipping partner of the goods, Sender
            m.ShippingPartner = new EdiPartnerIdentification
            {
                PartnerId = "MAINP",
                Name = "My Shipping Partner"
            };
            // Receiver of the goods for further delivery
            m.ReceivingPartner = new EdiPartnerIdentification
            {
                Name = "Max Mustermann",
                Street = "Musterstraße 1",
                ZipCode = "97082",
                City = "Würzburg",
                CountryCode = "DE"
            };
            // The client, sender of the goods
            m.Shipper = new EdiAddress
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
            m.Consignee = new EdiAddress
            {
                Name = "Umbrella Corp.",
                City = "Racoon City",
                Street = "Umbrella Str.",
                HouseNumber = "1-20"
            };
            m.Content = new EdiFileContent
            {
                ContentType = "image/png",
                FileName = "test-pod.png",
                BinaryData = new EdiBinaryData
                {
                    Data = new byte[]
                    {
                        1, 0, 0, 1
                    }
                }
            };

            return m;
        }
    }
}