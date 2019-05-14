using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Conizi.Model.Archiving;
using Conizi.Model.Examples.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;

namespace Conizi.Model.Examples.Transport.Truck.Groupage.Forwarding
{
    /// <summary>
    /// Simple example for a <see cref="Consignment"/>
    /// </summary>
    [ExampleFor(typeof(Consignment))]
    public class ConsignmentSimpleExample : Consignment
    {
        public ConsignmentSimpleExample()
        {
            // Unique consignment number from shipping partner
            this.ConsignmentNoShippingPartner = "12345678";
            this.ShippingDate = DateTime.Now;
            // The receiver of data and this message
            this.Receiver = new EdiMessageRouting
            {
                ConiziId = "4545454545454545454"
            };
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
            this.Routing = new EdiRouting
            {
                Shipper = new EdiAddress
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
                },
                // Receiver of the goods
                Consignee = new EdiAddress
                {
                    Name = "Umbrella Corp.",
                    City = "Racoon City",
                    Street = "Umbrella Str.",
                    HouseNumber = "1-20"
                }
            };
            this.Content = new EdiContent
            {
                AdditionalLoadingEquipment = new EdiAdditionalLoadingEquipment
                {
                    EurBoxes = 1,
                    EurPallets = 3
                },
                GrossWeightKilogram = 4215,
                HighValueGoods = true,
                LoadingMeter = 8.5m,
                Lines = new List<EdiLine>
                {
                    new EdiLine
                    {
                        LineNo = 1,
                        RefNo = "L34234",
                        Content = "Mag. Goods",
                        Barcodes = new List<EdiBarcode>
                        {
                            new EdiBarcode
                            {
                                Code = "00341827336742371821"
                            },
                            new EdiBarcode
                            {
                                Code = "00340018273648712201"
                            }
                        }
                    }
                }
                
            };
        }
    }
}