using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Conizi.Model.Examples.Interfaces;
using Conizi.Model.Examples.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;

namespace Conizi.Model.Examples.Transport.Truck.Groupage.Forwarding
{
    /// <summary>
    /// Simple example for a <see cref="Consignment"/>
    /// </summary>
    [ExampleFor(typeof(Consignment))]
    public class ConsignmentSimpleExample : IModelCreateFactory<Consignment>
    {

        public Consignment Create()
        {

            var m = new Consignment
            {
                ConsignmentNoShippingPartner = "12345678",
                ConsignmentObjectId = "12345678",
                ShippingDate = DateTime.Parse("2020-03-31", new CultureInfo("us-US")),
                Receiver = new EdiMessageRouting { ConiziId = "4545454545454545454" },
                ShippingPartner = new EdiPartnerIdentification { PartnerId = "MAINP", Name = "My Shipping Partner" },
                ReceivingPartner =
                    new EdiPartnerIdentification
                    {
                        Name = "Max Mustermann",
                        Street = "Musterstraße 1",
                        ZipCode = "97082",
                        City = "Würzburg",
                        CountryCode = "DE"
                    },
                Routing = new EdiRouting
                {
                    Shipper = new EdiAddress
                    {
                        Name = "Zombie Inc.",
                        Street = "Am düsteren Weg",
                        HouseNumber = "3a",
                        ZipCode = "97424",
                        City = "Würzburg",
                        CountryCode = "DE",
                        AdditionalAddressLines = new List<string> { "Gate 2" },
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
                },
                Content = new EdiContent
                {
                    AdditionalLoadingEquipment = new EdiAdditionalLoadingEquipment { EurBoxes = 1, EurPallets = 3 },
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
                                new EdiBarcode {Code = "00341827336742371821"},
                                new EdiBarcode {Code = "00340018273648712201"}
                            }
                        }
                    }
                }
            };

            return m;
        }
    }


    /// <summary>
    /// Simple example for a <see cref="ConsignmentEvent"/>
    /// </summary>
    [ExampleFor(typeof(ConsignmentEvent))]
    public class ConsignmentEventSimpleExample : IModelCreateFactory<ConsignmentEvent>
    {
        public ConsignmentEvent Create()
        {
            var m = new ConsignmentEvent
            {
                Receiver = new EdiMessageRouting { ConiziId = "4545454545454545454" },
                ConsignmentNoShippingPartner = "12345678",
                DeliveryAttemptFailed = new EdiEventDeliveryAttemptFailed
                {
                    EventDateTime = DateTime.Now.AddHours(-2),
                    Remarks = "We have problems! To much traffic!!",
                    Exceptions = new EdiDeliveryAttemptFailedExceptions
                    {
                       TimeIssue = new EdiEmptyExtendableObject()
                    }
                }
            };

            return m;
        }

    }
}