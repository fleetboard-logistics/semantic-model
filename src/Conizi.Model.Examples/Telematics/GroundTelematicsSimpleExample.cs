using System;
using System.Collections.Generic;
using Conizi.Model.Examples.Interfaces;
using Conizi.Model.Examples.Shared.Attributes;
using Conizi.Model.Shared.Definitions;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Telematics;

namespace Conizi.Model.Examples.Telematics
{
    /// <summary>
    /// Simple example for a <see cref="GroundTelematicsEvent"/>
    /// </summary>
    [ExampleFor(typeof(GroundTelematicsEvent))]
    public class GroundTelematicsEventExample : IModelCreateFactory<GroundTelematicsEvent>
    {
        public GroundTelematicsEvent Create()
        {
            var m = new GroundTelematicsEvent
            {
                EventDateTime = DateTime.Now.AddMinutes(-2),
                Sender = new EdiMessageRouting
                {
                    ConiziId = "2856454"
                },
                Receiver = new EdiMessageRouting {ConiziId = "4545454545454545454"},
                Vehicle = new EdiVehicle
                {
                    VehicleIdentificationNumber = "AS1254856454545451",
                    Registration = "KT FL 1111",
                    SendTelematics = true,
                    TruckType = "Box Truck",
                    VehicleId = "4711"
                },
                Driver = new EdiDriver
                {
                    DriverId = "D12345678999977",
                    Name = "Mister T.",
                    PhoneNumber = "0152887545454"
                },
                GeoLocationEvent = new EdiGeoLocationEvent
                {
                    EventDateTime = DateTime.Now.AddMinutes(-20),
                    GeoPosition = new EdiGeoPosition
                    {
                        Latitude = 49.8639895m,
                        Longitude = 10.2309327m,
                        PlaceName = "Volkach",
                        Speed = new EdiGeoSpeed
                        {
                            Speed = 53,
                            SpeedMeasurementUnitCode = MeasurementUnitCode.Kilometer
                        }
                    }
                }
            };


            return m;
        }
    }

    /// <summary>
    /// Simple example for a <see cref="GroundTelematicsEvent"/>
    /// </summary>
    [ExampleFor(typeof(GroundTelematicsEvent))]
    public class GroundTelematicsEventErrorExample : IModelCreateFactory<GroundTelematicsEvent>
    {
        public GroundTelematicsEvent Create()
        {
            var m = new GroundTelematicsEvent
            {
                Sender = new EdiMessageRouting
                {
                    ConiziId = "2856454"
                },
                Receiver = new EdiMessageRouting { ConiziId = "4545454545454545454" },
                Vehicle = new EdiVehicle
                {
                    VehicleIdentificationNumber = "AS1254856454545451",
                    Registration = "KT FL 1111",
                    SendTelematics = true,
                    TruckType = "Box Truck",
                    VehicleId = "4711"
                },
                Driver = new EdiDriver
                {
                    DriverId = "D12345678999977",
                    Name = "Mister T.",
                    PhoneNumber = "0152887545454"
                },
                GeoLocationEvent = new EdiGeoLocationEvent
                {
                    EventDateTime = DateTime.Now.AddMinutes(-20),
                    GeoPosition = new EdiGeoPosition
                    {
                        Latitude = 49.8639895m,
                        Longitude = 10.2309327m,
                        PlaceName = "Volkach",
                        Speed = new EdiGeoSpeed
                        {
                            Speed = 53,
                            SpeedMeasurementUnitCode = MeasurementUnitCode.Kilometer
                        }
                    }
                }
            };

            return m;
        }
    }


    /// <summary>
    /// Extended example for a <see cref="GroundTelematicsEvent"/>
    /// </summary>
    [ExampleFor(typeof(GroundTelematicsEvent))]
    public class GroundTelematicsEventTruckTelematicsExample : IModelCreateFactory<GroundTelematicsEvent>
    {
        public GroundTelematicsEvent Create()
        {
            var m = new GroundTelematicsEvent
            {
                EventDateTime = DateTime.Now.AddMinutes(-5),
                Sender = new EdiMessageRouting
                {
                    ConiziId = "2856454"
                },
                Receiver = new EdiMessageRouting {ConiziId = "4545454545454545454"},
                Vehicle = new EdiVehicle
                {
                    VehicleIdentificationNumber = "AS1254856454545451",
                    Registration = "KT FL 1111",
                    SendTelematics = true,
                    TruckType = "Box Truck",
                    VehicleId = "4711"
                },
                Driver = new EdiDriver
                {
                    DriverId = "D12345678999977",
                    Name = "Mister T.",
                    PhoneNumber = "0152887545454"
                },
                CoDriver = new EdiDriver()
                {
                    DriverId = "D52347548973939",
                    Name = "Franz K.",
                    PhoneNumber = "0162877535352"
                },
                GeoLocationEvent = new EdiGeoLocationEvent
                {
                    EventDateTime = DateTime.Now.AddMinutes(-5),
                    GeoPosition = new EdiGeoPosition
                    {
                        Latitude = 49.8639895m,
                        Longitude = 10.2309327m,
                        PlaceName = "Volkach",
                        Angle = 12,
                        RecordTime = DateTimeOffset.Now.AddMinutes(-7),
                        Speed = new EdiGeoSpeed
                        {
                            Speed = 0
                        }
                    },
                    Remarks = "Parking in Volkach..."
                },
                TruckTelematicsEvent = new EdiTruckTelematicsEvent
                {
                    EventDateTime = DateTime.Now.AddMinutes(-5),
                    TruckTelematics = new EdiTruckTelematics
                    {
                        RecordTime = DateTimeOffset.Now.AddMinutes(-6).ToUnixTimeMilliseconds(),
                        TotalDrivenDistance = 25000000,
                        Weight = 18600,
                        TotalFuelConsumption = 12548000,
                        AdBlueLevel = 82,
                        FuelLevel = 53
                    },
                    Remarks = "Truck telematics information"
                }
            };
            return m;
        }
    }

    

    /// <summary>
    /// Trailer example for a <see cref="GroundTelematicsEvent"/>
    /// </summary>
    [ExampleFor(typeof(GroundTelematicsEvent))]
    public class GroundTelematicsEventTrailerTelematicsExample : IModelCreateFactory<GroundTelematicsEvent>
    {
        public GroundTelematicsEvent Create()
        {
            var m = new GroundTelematicsEvent
            {
                EventDateTime = DateTime.Now.AddMinutes(-5),
                Sender = new EdiMessageRouting
                {
                    ConiziId = "2856454"
                },
                Receiver = new EdiMessageRouting { ConiziId = "4545454545454545454" },
                Vehicle = new EdiVehicle
                {
                    VehicleIdentificationNumber = "TS1254856454545451",
                    Registration = "KT FL 234",
                    SendTelematics = true,
                    IsTrailer = true,
                    TruckType = "Flatbed Trailer",
                    VehicleId = "4711",
                    Dimensions = new EdiMeasures
                    {
                        WidthMeter = 2.8m,
                        LengthMeter = 12.1m
                    }
                },
                GeoLocationEvent = new EdiGeoLocationEvent
                {
                    EventDateTime = DateTime.Now.AddMinutes(-5),
                    GeoPosition = new EdiGeoPosition
                    {
                        Latitude = 49.8639895m,
                        Longitude = 10.2309327m,
                        PlaceName = "Volkach",
                        Angle = 12,
                        RecordTime = DateTimeOffset.Now.AddMinutes(-7),
                        Speed = new EdiGeoSpeed
                        {
                            Speed = 53.8m
                        }
                    },
                    Remarks = "On the Road..."
                },
                TrailerTelematicsEvent = new EdiTrailerTelematicsEvent
                {
                    EventDateTime = DateTime.Now.AddMinutes(-5),
                    TrailerTelematics = new EdiTrailerTelematics
                    {
                        RecordTime = DateTimeOffset.Now.AddMinutes(-6).ToUnixTimeMilliseconds(),
                        Temperatures = new List<EdiTemperature>
                        {
                            new EdiTemperature
                            {
                                Name = "Front",
                                SignalId = "1454578454",
                                Value = 5.5m
                            },
                            new EdiTemperature
                            {
                                Name = "Back",
                                SignalId = "145557878",
                                Value = 4.9m
                            }
                        },
                        DoorStates = new List<EdiDoorState>
                        {
                            new EdiDoorState
                            {
                                Name = "Door Left",
                                SignalId = "755",
                                Value = 1
                            },
                            new EdiDoorState
                            {
                                Name = "Door Right",
                                SignalId = "756",
                                Value = 0
                            }
                        },
                        BrakeSystemStates = new List<EdiBrakeSystemState>
                        {
                            new EdiBrakeSystemState()
                            {
                                Name = "pressure",
                                SignalId = "121",
                                Value = 225
                            }
                        }
                    },
                    Remarks = "Truck telematics information"
                }

            };
            return m;
        }
    }
}