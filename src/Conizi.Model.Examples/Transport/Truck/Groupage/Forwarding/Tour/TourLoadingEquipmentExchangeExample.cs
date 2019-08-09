using System;
using System.Collections.Generic;
using System.Text;
using Conizi.Model.Examples.Interfaces;
using Conizi.Model.Examples.Shared.Attributes;
using Conizi.Model.Shared.Definitions;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;

namespace Conizi.Model.Examples.Transport.Truck.Groupage.Forwarding.Tour
{
    /// <summary>
    /// Simple example for a <see cref="TourEvent"/> to demonstrate Loading Equipment
    /// </summary>
    [ExampleFor(typeof(TourEvent))]
    public class TourLoadingEquipmentExchangeExample : IModelCreateFactory<TourEvent>
    {
        public TourEvent Create()
        {
            var me = new TourEvent()
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
                    EventDateTime = DateTime.Now.AddHours(-1),
                    UnloadingCompleted = true,
                    LoadingEquipmentExchange = new EdiLoadingEquipmentExchange
                    {
                        Exchanged = true,
                        LoadingEquipment = new List<EdiLoadingEquipment>
                        {
                            new EdiLoadingEquipment
                            {
                                EquipmentType = LoadingEquipmentType.EurPallets,
                                AmountLoaded = 4,
                                AmountUnloaded = 3,
                                Remarks = "One was lost..."
                            },
                            new EdiLoadingEquipment
                            {
                                EquipmentType = LoadingEquipmentType.OneWayPallets,
                                AmountLoaded = 6,
                                AmountUnloaded = 2
                            }
                        },
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