using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Conizi.Model.Archiving;
using Conizi.Model.Examples.Shared.Attributes;
using Conizi.Model.Shared.Entities;

namespace Conizi.Model.Examples.Archiving
{
    /// <summary>
    /// Simple example for Proof of Delivery
    /// </summary>
    [ExampleFor(typeof(ProofOfDelivery))]
    public class ProofOfDeliverySimpleExample : ProofOfDelivery
    {
        public ProofOfDeliverySimpleExample()
        {
            this.Id = "12345678";
            this.DocumentCreationDate = DateTime.Now.AddHours(-2);
            this.ArrivalDate = DateTime.Now.AddDays(-1);
            this.PlannedShippingDate = DateTime.Now.AddDays(-1);
            this.ShippingDate = DateTime.Now;
            // The receiver of data and this message
            this.Receiver = new EdiMessageRouting
            {
                ConiziId = "4545454545454545454"
            };
            this.RefNo = "12312313";
            // Shipping partner of the goods, Sender
            this.ShippingPartner = new EdiPartnerIdentification
            {
                PartnerId = "MAINP",
                Name = "My Shipping Partner"
            };
            // Receiver of the goods for further delivery
            this.ReceivingPartner = new EdiPartnerIdentification
            {
                Name = "Max Mustermann",
                Street = "Musterstraße 1",
                ZipCode = "97082",
                City = "Würzburg",
                CountryCode = "DE"
            };
            // The client, sender of the goods
            this.Shipper = new EdiAddress
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
            this.Consignee = new EdiAddress
            {
                Name = "Umbrella Corp.",
                City = "Racoon City",
                Street = "Umbrella Str.",
                HouseNumber = "1-20"
            };
            this.Content = new EdiFileContent
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
        }
    }
}