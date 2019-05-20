using System;
using System.Collections.Generic;
using Conizi.Model.Examples.Interfaces;
using Conizi.Model.Examples.Shared.Attributes;
using Conizi.Model.Shared.Definitions;
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
                Sender = new EdiMessageRouting {EdiId = "FBLVK"},
                Receiver = new EdiMessageRouting {EdiId = "C2P0"},
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
                        ConsignmentObjectId = "201914444",
                        ShippingDate = DateTime.Now.AddDays(1),
                        Receiver = new EdiMessageRouting
                        {
                            EdiId = "C2PO"
                        },
                        ShippingPartner = new EdiPartnerIdentification
                        {
                            EdiId = "C2PO"
                        },
                        ReceivingPartner = new EdiPartnerIdentification
                        {
                            EdiId = "C3PO"
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
                            LoadingMeter = 2.3m,
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
                    },
                    new Consignment
                    {
                        ConsignmentNoReceivingPartner = "201925878",
                        ConsignmentObjectId = "201925878",
                        ShippingDate = DateTime.Now.AddDays(1),
                        Receiver = new EdiMessageRouting
                        {
                            EdiId = "C2PO"
                        },
                        ShippingPartner = new EdiPartnerIdentification
                        {
                            EdiId = "C2PO"
                        },
                        ReceivingPartner = new EdiPartnerIdentification
                        {
                            EdiId = "C3PO"
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
                                Name = "Freetime Schweinfurt",
                                Street = "Industriestraße 24",
                                ZipCode = "97469",
                                City = "Gochsheim",
                                ContactPerson = "Herr Franze"
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
                                EurPallets = 3
                            },
                            LoadingMeter = 3.8m,
                            GrossWeightKilogram = 3250.5m,
                            Lines = new List<EdiLine>
                            {
                                new EdiLine
                                {
                                    LineNo = 1,
                                    HandlingUnitCount = 6,
                                    LoadingMeter = 1.2m,
                                    Content = "cable ducts",
                                    GrossWeightKilogram = 2215,
                                },
                                new EdiLine
                                {
                                    LineNo = 2,
                                    HandlingUnitCount = 64,
                                    LoadingMeter = 2.6m,
                                    Content = "Truck Hardware Controller",
                                    GrossWeightKilogram = 1035.5m,
                                    Barcodes = new List<EdiBarcode>
                                    {
                                        new EdiBarcode
                                        {
                                            Code = "003999999990000000620",
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new Consignment
                    {
                        ConsignmentNoReceivingPartner = "201935866",
                        ConsignmentObjectId = "201935866",
                        ShippingDate = DateTime.Now.AddDays(1),
                        Receiver = new EdiMessageRouting
                        {
                            EdiId = "C2PO"
                        },
                        ShippingPartner = new EdiPartnerIdentification
                        {
                            EdiId = "C2PO"
                        },
                        ReceivingPartner = new EdiPartnerIdentification
                        {
                            EdiId = "C3PO"
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
                                Name = "Truck & Co Würzburg",
                                Street = "Gustav-Heinemann-Allee",
                                ZipCode = "97204",
                                City = "Höchberg",
                                ContactPerson = "Frau Roth",
                                EmailAddress = "f.roth@truckco.de"
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
                                EurPallets = 3
                            },
                            LoadingMeter = 2.8m,
                            GrossWeightKilogram = 3250.5m,
                            Lines = new List<EdiLine>
                            {
                                new EdiLine
                                {
                                    LineNo = 2,
                                    HandlingUnitCount = 12,
                                    LoadingMeter = 2.6m,
                                    Content = "Truck Hardware Controller",
                                    GrossWeightKilogram = 1013.54m,
                                    Barcodes = new List<EdiBarcode>
                                    {
                                        new EdiBarcode
                                        {
                                            Code = "003999999990000000620",
                                        }
                                    }
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
                        TruckType = "Truck",
                        SendTelematics = true
                    },
                    new EdiVehicle
                    {
                        VehicleId = "TRA10007454",
                        Registration = "WÜ CT 1511",
                        TruckType = "Semi-Trailer",
                        IsTrailer = true
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
                                "201914444",
                                "201925878",
                                "201935866"
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
                            CountryCode = "DE",
                            GeoPosition = new EdiGeoPosition
                            {
                                W3WCoordinate = "angreifenden.zögert.auslöser"
                            }
                        }
                    },
                    new EdiTourStop
                    {
                        StopNo = 2000,
                        StopId = "693e4c46-527a-44a2-b41a-cab42634e3bd",
                        UnloadingInformation = new TourUnloadingInformation
                        {
                            ConsignmentObjectIds = new List<string>
                            {
                                "201914444"
                            }
                        },
                        Address = new EdiAddress
                        {
                            Name = "Bamberger RZ",
                            Street = "Mainstraße",
                            ZipCode = "96052",
                            City = "Bamberg",
                            ContactPerson = "Herr Rezi",
                            EmailAddress = "rezi@rzb.com",
                            CountryCode = "DE",
                            GeoPosition = new EdiGeoPosition
                            {
                                Latitude = 49.910659m,
                                Longitude = 10.8682589m
                            }
                        }
                    },
                    new EdiTourStop
                    {
                        StopNo = 3000,
                        StopId = "f58da879-7bc0-442d-9625-cc3daff33bed",
                        UnloadingInformation = new TourUnloadingInformation
                        {
                            ConsignmentObjectIds = new List<string>
                            {
                                "201925878"
                            }
                        },
                        Address = new EdiAddress
                        {
                            Name = "Freetime Schweinfurt",
                            Street = "Industriestraße 24",
                            ZipCode = "97469",
                            City = "Gochsheim",
                            ContactPerson = "Herr Franze",
                            EmailAddress = "h.franze@freetime.net",
                            CountryCode = "DE",
                            AdditionalAddressLines = new List<string>
                            {
                                "Please use side entrance."
                            }
                        }
                    },
                    new EdiTourStop
                    {
                        StopNo = 4000,
                        StopId = "4a4c3e88-5fd5-4174-a890-5ffc8e5c107f",
                        UnloadingInformation = new TourUnloadingInformation
                        {
                            ConsignmentObjectIds = new List<string>
                            {
                                "201935866"
                            }
                        },
                        Address = new EdiAddress
                        {
                            Name = "Truck & Co Würzburg",
                            Street = "Gustav-Heinemann-Allee",
                            ZipCode = "97204",
                            City = "Höchberg",
                            ContactPerson = "Frau Roth",
                            EmailAddress = "f.roth@truckco.de",
                            CountryCode = "DE",
                            PhoneNumber = "+499314458454",
                            GeoPosition = new EdiGeoPosition
                            {
                                W3WCoordinate = "haupt.handschuhe.haube"
                            }
                        }
                    }
                }
            };

            return m;
        }
    }

    /// <summary>
    /// Simple example for a <see cref="TourEvent"/> to demonstrate ETA and GPS usage
    /// </summary>
    [ExampleFor(typeof(Model.Transport.Truck.Groupage.Forwarding.Tour))]
    public class
        SimpleTourEventForEtaExampleAccepted : IModelCreateFactory<Model.Transport.Truck.Groupage.Forwarding.TourEvent>
    {
        public TourEvent Create()
        {
            var me = new TourEvent()
            {
                Receiver = new EdiMessageRouting
                {
                    EdiId = "C2PO"
                },
                TourId = "20191234567",
                Vehicle = new EdiVehicleSpecificEvent
                {
                    EventDateTime = DateTime.Now.AddHours(-1),
                    DriverName = "Alexander Kruger",
                    TruckRegistrationNumber = "WÜ CP 4711",
                    TrailerRegistrationNumber = "WÜ CT 1511",
                    MileageStart = 83654
                },
                Tour = new EdiTourSpecificEvent
                {
                    EventDateTime = DateTime.Now.AddHours(-1),
                    TourAccepted = true,
                    GeoPosition = new EdiGeoPosition
                    {
                        Latitude = 49.8629167m,
                        Longitude = 10.2259302702594m,
                        PlaceName = "Fleetboard Logistics GmbH"
                    }
                },
            };

            return me;
        }
    }

    /// <summary>
    /// Simple example for a <see cref="TourEvent"/> to demonstrate GPS usage
    /// </summary>
    [ExampleFor(typeof(Model.Transport.Truck.Groupage.Forwarding.Tour))]
    public class
        SimpleTourEventForEtaExampleStarted : IModelCreateFactory<Model.Transport.Truck.Groupage.Forwarding.TourEvent>
    {
        public TourEvent Create()
        {
            var me = new TourEvent()
            {
                Receiver = new EdiMessageRouting
                {
                    EdiId = "C2PO"
                },
                TourId = "20191234567",
                Tour = new EdiTourSpecificEvent
                {
                    EventDateTime = DateTime.Now.AddHours(-1),
                    TourStarted = true,
                    GeoPosition = new EdiGeoPosition
                    {
                        Latitude = 49.8629167m,
                        Longitude = 10.2259302702594m,
                        PlaceName = "Fleetboard Logistics GmbH"
                    }
                }
            };

            return me;
        }
    }

    /// <summary>
    /// Simple example for a <see cref="TourEvent"/> to demonstrate GPS usage and ETA times
    /// </summary>
    [ExampleFor(typeof(Model.Transport.Truck.Groupage.Forwarding.Tour))]
    public class SimpleTourEventForEtaExampleTourStop : IModelCreateFactory<TourEvent>
    {
        public TourEvent Create()
        {
            var eventDateTime = DateTime.Now.AddMinutes(-56);

            var me = new TourEvent()
            {
                Receiver = new EdiMessageRouting
                {
                    EdiId = "C2PO"
                },
                TourId = "20191234567",
                Stop = new EdiStopSpecificEvent
                {
                    EventDateTime = eventDateTime,
                    OnWayLoadingPoint = true,
                    GeoPosition = new EdiGeoPosition
                    {
                        Latitude = 49.924783m,
                        Longitude = 10.816709m,
                        PlaceName = "Oberhaid"
                    },
                    StopId = "693e4c46-527a-44a2-b41a-cab42634e3bd",
                    Eta = new EdiGeoEta
                    {
                        DistanceToDestination = 42.5m,
                        DistanceMeasurementUnitCode = MeasurementUnitCode.Kilometer,
                        EtaTimeAbsolute = DateTime.Now.AddMinutes(-2).ToString("HH:mm:ss"),
                        Ete = (int)(DateTime.Now.AddMinutes(-2) - eventDateTime).TotalSeconds,
                        StopsToDestination = 0
                    }
                }
            };

            return me;
        }
    }

    /// <summary>
    /// Simple example for a <see cref="TourEvent"/> to demonstrate GPS usage and ETA times
    /// </summary>
    [ExampleFor(typeof(Model.Transport.Truck.Groupage.Forwarding.Tour))]
    public class SimpleTourEventForEtaExampleStopArrived : IModelCreateFactory<TourEvent>
    {
        public TourEvent Create()
        {
            var eventDateTime = DateTime.Now.AddMinutes(-56);

            var me = new TourEvent()
            {
                Receiver = new EdiMessageRouting
                {
                    EdiId = "C2PO"
                },
                TourId = "20191234567",
                Stop = new EdiStopSpecificEvent
                {
                    EventDateTime = eventDateTime,
                    ArrivedAtUnloadingPoint = true,
                    GeoPosition = new EdiGeoPosition
                    {
                        Latitude = 49.910659m,
                        Longitude = 10.8682589m,
                        PlaceName = "Bamberger Rechenzentrum"
                    },
                    StopId = "693e4c46-527a-44a2-b41a-cab42634e3bd",
                }
            };

            return me;
        }
    }
}