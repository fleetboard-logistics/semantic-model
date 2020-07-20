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
    /// Simple example for a <see cref="PositionEvent"/>
    /// </summary>
    [ExampleFor(typeof(PositionEvent))]
    public class PoistionEventExample : IModelCreateFactory<PositionEvent>
    {
        public PositionEvent Create()
        {
            var m = new PositionEvent
            {
                EventDateTime = DateTime.Now.AddMinutes(-2),
                Sender = new EdiMessageRouting
                {
                    ConiziId = "2856454"
                },
                Receiver = new EdiMessageRouting {ConiziId = "4545454545454545454"},
                References = new EdiDocumentReferences
                {
                    Id = "123456789-unique",
                    VehicleId = "1235450",
                    DeviceId = "H5e3"

                },
                GpsTracking = new List<EdiGpsTracking>
                {
                    new EdiGpsTracking
                    {
                        TourIds = new List<string> { "T1", "T2", "T3" },
                        Latitude = 49.8639895m,
                        Longitude = 10.2309327m,
                        PlaceName = "Volkach",
                        RecordTime =  DateTimeOffset.Now.AddMinutes(-3).UtcDateTime,
                        Speed = new EdiGeoSpeed
                        {
                            Speed = 53,
                            SpeedMeasurementUnitCode = MeasurementUnitCode.Kilometer
                        }
                    },
                    new EdiGpsTracking
                    {
                        TourIds = new List<string> { "T1", "T2", "T3" },
                        Latitude = 49.8022738m,
                        Longitude = 10.1612858m,
                        PlaceName = "Dettelbach",
                        RecordTime =  DateTimeOffset.Now.AddMinutes(-19).UtcDateTime,
                        Speed = new EdiGeoSpeed
                        {
                            Speed = 62,
                            SpeedMeasurementUnitCode = MeasurementUnitCode.Kilometer
                        }
                    }

                }
            };


            return m;
        }
    }
}