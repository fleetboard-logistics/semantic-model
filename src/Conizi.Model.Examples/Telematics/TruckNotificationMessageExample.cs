using System;
using System.Collections.Generic;
using Conizi.Model.Examples.Interfaces;
using Conizi.Model.Examples.Shared.Attributes;
using Conizi.Model.Shared.Definitions;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Telematics;
using Conizi.Model.Telematics.Truck;

namespace Conizi.Model.Examples.Telematics
{
    /// <summary>
    /// Simple example for a <see cref="TruckNotificationMessage"/>
    /// </summary>
    [ExampleFor(typeof(TruckNotificationMessage))]
    public class TruckNotificationMessageSimpleExample : IModelCreateFactory<TruckNotificationMessage>
    {
        public TruckNotificationMessage Create()
        {
            var m = new TruckNotificationMessage()
            {
                MessageId = "72b7f2ba3873488f8a54ef0bc54c9950",
                SendDateTime = DateTime.Now.AddMinutes(-5), 
                MessageType =  "text",
                Sender = new EdiMessageRouting
                {
                    ConiziId = "habblConiziId"
                },
                Receiver = new EdiMessageRouting {ConiziId = "carrierConiziId" },
                SenderGeoPosition = new EdiGeoPosition
                {
                    Latitude = 49.864159m,
                    Longitude = 10.226990m,
                    PlaceName = "Volkach",
                    Speed = new EdiGeoSpeed
                    {
                        Speed = 5.9m,
                        SpeedMeasurementUnitCode = MeasurementUnitCode.Kilometer
                    }
                },
                References = new EdiDocumentReferences
                {
                    VehicleId = "WAXXXXX1232422244",
                    DriverId = "DR124545454",
                    DeviceId = "ASEEREREREWREWR"
                },
                Message = "This a message from habbl for you"
            };
            
            return m;
        }
    }

    /// <summary>
    /// Example for a <see cref="TruckNotificationMessageState"/>
    /// </summary>
    [ExampleFor(typeof(TruckNotificationMessageState))]
    public class TruckNotificationMessageStateExample : IModelCreateFactory<TruckNotificationMessageState>
    {
        public TruckNotificationMessageState Create()
        {
            var m = new TruckNotificationMessageState()
            {
             
                Sender = new EdiMessageRouting
                {
                    ConiziId = "carrierConiziId"
                },
                Receiver = new EdiMessageRouting { ConiziId = "habblConiziId" },
                MessageIdRef = "72b7f2ba3873488f8a54ef0bc54c9950",
                SendDateTime = DateTime.Now.AddMinutes(-2),
                SenderGeoPosition = new EdiGeoPosition
                {
                    Latitude = 49.864155m,
                    Longitude = 10.226992m,
                    PlaceName = "Volkach",
                    Speed = new EdiGeoSpeed
                    {
                        Speed = 38.4m,
                        SpeedMeasurementUnitCode = MeasurementUnitCode.Kilometer
                    }
                },
                States = new TruckNotificationMessageResponseStates
                {
                    Delivered = true,
                    MessageWasRead = true
                }
            };

            return m;
        }
    }
}