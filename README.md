# conizi Semantic models

The conizi semantic model describes the logistic entities used to exchange information between the parties working together in logistic processes. Unklike the
formats used for file exchange these models are driven by business cases and not by technical requirements such as segment types. The models are very explicit about
additional information required to fulfill a service and explicitly do not try to generalize away properties into generalized fields. 

# Conventions

The key words "MUST", "MUST NOT", "REQUIRED", "SHALL", "SHALL NOT",
"SHOULD", "SHOULD NOT", "RECOMMENDED", "MAY", and "OPTIONAL" in this
document are to be interpreted as described in [RFC2119].

# Normative References

   [RFC2119]  Bradner, S., "Key words for use in RFCs to Indicate
              Requirement Levels", BCP 14, RFC 2119, March 1997.
              
conizi semantic models - Fleetboard Logistics GmbH 2018-2020.

# Usage

In order to create a valid message that can be processed on the conizi platform, it is necessary to work with the definition of the messages as JSON schema.

These schema definitions can be found here in the repostitory:
[Schema definitions](model/).

Please remember that conizi has several environments. It is important to note that some of the schema definitions found on the development systems are not yet available in the production system. Therefore we recommend to always develop against the "preproduction" branch.

Please check for a productive operation whether the required features are also included in the "production" branch.

Furthermore it is important that the conizi platform always treats dates that do not contain a time component as UTC date. See "shippingDate" in this example.

For development purposes it is still possible to adapt the $schema as follows:
[https://model.conizi.io/v1/transport/truck/groupage/forwarding/consignment.json?branch=preproduction](https://model.conizi.io/v1/transport/truck/groupage/forwarding/consignment.json?branch=preproduction), here the schema definitions for the pre-production environment are used. Possible values are "master", "preproduction", "production".

```JSON
{
    "$schema": "https://model.conizi.io/v1/transport/truck/groupage/forwarding/consignment.json",
    "sender": {
        "ediId": "VER4999"
    },
    "receiver": {
        "ediId": "EMP4888"
    },
    "shippingPartner": {
        "partnerId": "4999",
        "name": "Versandparter GmbH"
    },
    "receivingPartner": {
        "partnerId": "4888",
        "name": "Empfangpartner AG"
    },
    "shippingDate": "2019-01-02",
    "consignmentNoShippingPartner": "4711",
    "routing": {
        "shipper": {
            "name": "Meyer GmbH",
            "street": "Meyerstraße 10",
            "zipCode": "97424",
            "city": "Schweinfurt",
            "countryCode": "DE"
        },
        "consignee": {
            "name": "Max Mustermann",
            "street": "Musterstraße 1",
            "zipCode": "97332",
            "city": "Würzburg",
            "countryCode": "DE"
        }
    }
}
```
