using System;
using System.Collections.Generic;
using Conizi.Model.Examples.Interfaces;
using Conizi.Model.Examples.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;
using Newtonsoft.Json.Linq;

namespace Conizi.Model.Examples.Transport.Truck.Groupage.Forwarding.Tour
{
    /// <summary>
    /// Simple example for a <see cref="Tour"/> to demonstrate ETA and GPS usage in <see cref="TourEvent"/> 
    /// </summary>
    [ExampleFor(typeof(Model.Transport.Truck.Groupage.Forwarding.Tour))]
    public class SimpleTourForEtaExample : IModelCreateFactory<Model.Transport.Truck.Groupage.Forwarding.Tour>
    {
        public Model.Transport.Truck.Groupage.Forwarding.Tour Create()
        {
            var m = new Model.Transport.Truck.Groupage.Forwarding.Tour
            {
                Sender = new EdiMessageRouting { EdiId = "FBLVK" },
                Receiver = new EdiMessageRouting { EdiId = "C2P0" },
                Network = new EdiNetwork
                {
                    NetworkId = "FBNET"
                },
                ShippingDate = DateTime.Now.AddDays(1),
                TourId = "20191234567",
                Carrier = new EdiAddress
                {
                    Reference = "C2PO",
                    Name = "Cargo Partner",
                    Street = "Franeknstraße",
                    HouseNumber = "7",
                    ZipCode = "97078",
                    City = "Würzburg",
                    EmailAddress = "c2po@cargo-partner.net",
                    CountryCode = "DE"
                },
                Consignments = new List<Consignment>
                {
                    new Consignment
                    {
                        ConsignmentNoReceivingPartner = "201914444",
                        ConsignmentObjectId = "20194444",
                        ShippingDate = DateTime.Now.AddDays(1),
                        Receiver = new EdiMessageRouting
                        {
                            EdiId = "C2PO"
                        },
                        ShippingPartner = new EdiPartnerIdentification
                        {
                            EdiId = "C2P0",
                            Name = "Cargo Partner",
                            City = "Würzburg"
                        },
                        ReceivingPartner = new EdiPartnerIdentification
                        {
                            EdiId = "C3P0",
                            Name = "Cargo Partner",
                            Street = "Gaustadter Hauptstraße",
                            HouseNumber = "55",
                            ZipCode = "96049",
                            City = "Bamberg",
                            EmailAddress = "c3po@cargo-partner.net",
                            CountryCode = "DE"
                        },
                        Routing = new EdiRouting
                        {
                            Shipper = new EdiAddress
                            {
                                Name = "Fleetboard Logistics GmbH",
                                Reference = "FBLVK01",
                                Street = "Am Alten Bahnhof",
                                HouseNumber = "8",
                                ZipCode = "97332",
                                City = "Volkach",
                                CountryCode = "DE",
                                ContactPerson = "Frau Holle",
                                EmailAddress = "f.holle@fleetboard-logistics.com"
                            },
                            Consignee = new EdiAddress
                            {
                                Name = "Bamberger RZ",
                                Street = "Mainstraße",
                                ZipCode = "96052",
                                City = "Bamberg",
                                ContactPerson = "Herr Rezi"
                            }
                        },
                        References = new EdiReferences
                        {
                            CustomerOrderDate = DateTime.Now.AddDays(-1)
                        },
                        Content = new EdiContent
                        {
                            AdditionalLoadingEquipment = new EdiAdditionalLoadingEquipment
                            {
                                EurPallets = 2
                            },
                            LoadingMeter = 1.3m,
                            GrossWeightKilogram = 2432.5m,
                            Lines = new List<EdiLine>
                            {
                                new EdiLine
                                {
                                    LineNo = 1,
                                    HandlingUnitCount = 2,
                                    LoadingMeter = 1.2m,
                                    Content = "cable ducts",
                                    GrossWeightKilogram = 1419,
                                    Barcodes = new List<EdiBarcode>
                                    {
                                        new EdiBarcode
                                        {
                                            Code = "003999999990000000034"
                                        },
                                        new EdiBarcode
                                        {
                                            Code = "003999999990000000036",
                                        }
                                    }
                                },
                                new EdiLine
                                {
                                    LineNo = 2,
                                    HandlingUnitCount = 16,
                                    LoadingMeter = 1.1m,
                                    Content = "magic cubes",
                                    GrossWeightKilogram = 1013.54m
                                }
                            }
                        }
                    }
                },
                Vehicles = new List<EdiVehicle>
                {
                    new EdiVehicle
                    {
                        VehicleId = "LKW10005424",
                        Registration = "WÜ CP 4711",
                        TruckType = "Truck"
                    },
                    new EdiVehicle
                    {
                        VehicleId = "TRA10007454",
                        Registration = "WÜ CT 1511",
                        TruckType = "Semi-Trailer"
                    }
                },
                Stops = new List<EdiTourStop>
                {
                    new EdiTourStop
                    {
                        StopNo = 1000,
                        StopId = "d8a37e5e-e008-4959-b1c3-13f3c7de90b6",
                        LoadingInformation = new TourLoadingInformation
                        {
                            ConsignmentObjectIds = new List<string>
                            {
                                "201914444"
                            }
                        },
                        Address = new EdiAddress
                        {
                            Name = "Fleetboard Logistics GmbH",
                            Reference = "FBLVK01",
                            Street = "Am Alten Bahnhof",
                            HouseNumber = "8",
                            ZipCode = "97332",
                            City = "Volkach",
                            CountryCode = "DE"
                        }
                    },
                    new EdiTourStop
                    {
                        StopNo = 2000,
                        StopId = "693e4c46-527a-44a2-b41a-cab42634e3bd",
                    },
                    new EdiTourStop
                    {
                        StopNo = 3000,
                        StopId = "f58da879-7bc0-442d-9625-cc3daff33bed",
                    }
                }
            };

            return m;
        }
    }
}