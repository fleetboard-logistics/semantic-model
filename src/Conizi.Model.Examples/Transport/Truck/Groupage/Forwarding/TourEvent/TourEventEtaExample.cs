using System;
using System.Collections.Generic;
using System.Text;
using Conizi.Model.Examples.Interfaces;
using Conizi.Model.Examples.Shared.Attributes;
using Conizi.Model.Shared.Definitions;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;

namespace Conizi.Model.Examples.Transport.Truck.Groupage.Forwarding.TourEvent
{
    /// <summary>
    /// Simple example for a <see cref="TourEvent"/> to demonstrate Eta
    /// </summary>
    [ExampleFor(typeof(Model.Transport.Truck.Groupage.Forwarding.TourEvent))]
    public class TourEventEtaExample : IModelCreateFactory<Model.Transport.Truck.Groupage.Forwarding.TourEvent>
    {
        public Model.Transport.Truck.Groupage.Forwarding.TourEvent Create()
        {
            var me = new Model.Transport.Truck.Groupage.Forwarding.TourEvent()
            {
                Receiver = new EdiMessageRouting
                {
                    EdiId = "DAIMLER"
                },
                Network = new EdiNetwork
                {
                    NetworkId = "MBT"
                },
                TourId = "123123123",
                Stop = new EdiStopSpecificEvent()
                {
                    StopId = "45745378753079860978",
                    StopType = StopType.Loading,
                    EventDateTime = DateTime.Now.AddHours(-1),
                    OnWayLoadingPoint = true,
                    Eta = new EdiGeoEta
                    {
                        EtaDateTimeAbsolute = DateTime.Now.AddMinutes(-8),

                    },
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
}
