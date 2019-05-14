---
uid: articles.index
---

## Getting Started with conizi semantic models

The conizi semantic models describe all business objects that can be used on the conizi platform. 

The original definition of these objects (models) was implemented with [JSON Schema](https://json-schema.org/) (Draft 6) and is still valid. You can get the JSON schema definition via [Github](https://github.com/fleetboard-logistics/semantic-model/tree/production/model).

### The C# Models

In the course of the further development of conizi and the takeover of habbl and conizi by [Daimler Fleetboard](https://www.fleetboard.de) and the transfer to [Fleetboard Logistics GmbH](https://fleetboard-logistics.com), it was decided to implement the semantic models in C# as well. 

This enables TMS providers and customers, who rely on Microsoft's .NET Framework in their software, to easily integrate the models into their environment.

The library is divided into two parts:
 * The conizi semantic models in C# => [Conizi.Model](xref:Conizi.Model.Transport.Truck.Groupage.Forwarding)
 * A set of tools to deal with the models (generate, serialize, de-serialize...) => [Conizi.Model.Core]()

You can get the library from two different Nuget packages:
 * [Conizi.Model](https://www.nuget.org/packages/Conizi.Model) (nuget prerelease)
  * [Conizi.Model.Core](https://www.nuget.org/packages/Conizi.Model.Core) (nuget prerelease)

New models and further developments are carried out exclusively in C#. The C# models can then be converted into JSON schemas or other possible formats.

It is also possible to generate a message from a C# model, which is then sent directly to conizi. The C# models are not only used to define the structure of the message (schema/model), but also to be the message itself.

### Example for a simple [tour-event](xref:Conizi.Model.Transport.Truck.Groupage.Forwarding.TourEvent)

```cs
var m = new TourEvent
{
    TourId = "MyTourId",
    Receiver = new EdiMessageRouting
    {
        EdiId = "DAIMLER"
    },
    Network = new EdiNetwork
    {
        NetworkId = "FBL"
    },
    Tour = new EdiTourSpecificEvent
    {
        EventDateTime = DateTime.Now,
        TourAccepted = true
    }
}
 ```
### Serialize the [tour-event](xref:Conizi.Model.Transport.Truck.Groupage.Forwarding.TourEvent) to JSON

With the help of the [Conizi.Model.Core](xref:Conizi.Model.Core.Tools.Converter) library, the C# models can be serialized to JSON.

```cs
var result =  Converter.Serialize(m);
 ```

 ### Serialization result of the  [tour-event](xref:Conizi.Model.Transport.Truck.Groupage.Forwarding.TourEvent)

 ```json
 {
    "$schema": "https://model.conizi.io/v1/transport/truck/groupage/forwarding/tour-event.json",
    "receiver": {
        "ediId": "DAIMLER"
    },
    "network": {
        "networkId": "FBL"
    },
    "tourId": "MyTourId",
    "tour": {
        "eventDateTime": "2019-04-24T18:07:05.5784106+02:00",
        "tourAccepted": true
    }
}
 ```

This serialized tour-event JSON message is ready to send to conizi Input HTTP API. Please have a look [here](https://fleetboard-logistics.github.io/docs/conizi/howto/howto-conizi-http-input-api.pdf), to get further information how the API works.

### Further information

In the following some scenarios are listed, which should help in working with conizi.

* Working with a [consignment](consignment.md)
* Working with a [tour](tour.md)
* Working with [events](events.md)

More examples can be found [here](xref:examples.index)