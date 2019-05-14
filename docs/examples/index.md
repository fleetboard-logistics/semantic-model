---
uid: examples.index
---

## Examples of C# models

To assist you in integrating your software into the conizi Fleetboard world, we have created some examples for you. Furthermore, [JSON examples]() are available if you do not want to use C# directly.

The example project is structured in the same way as the models. It is therefore structured according to traffic type land, sea, air or application area, such as archiving or accounting.

An example for archiving would be the PoD ([Proof of Delivery](xref:Conizi.Model.Archiving.ProofOfDelivery))

We create a proof of delivery by inheriting from the ProofOfDelivery model and overwriting the public properties of the base class in the constructor with our desired values.

```cs
    public class ProofOfDeliverySimpleExample : ProofOfDelivery
    {
        public ProofOfDeliverySimpleExample()
        {
            this.Id = "12345678";
            this.DocumentCreationDate = DateTime.Now.AddHours(-2);
            this.ArrivalDate = DateTime.Now.AddDays(-1);
            this.PlannedShippingDate = DateTime.Now.AddDays(-1);
            this.ShippingDate = DateTime.Now;
            // The receiver of data and this message
            this.Receiver = new EdiMessageRouting
            {
                ConiziId = "4545454545454545454"
            };
            this.RefNo = "12312313";
            // Shipping partner of the goods, Sender
            this.ShippingPartner = new EdiPartnerIdentification
            {
                PartnerId = "MAINP",
                Name = "My Shipping Partner"
            };
            // Receiver of the goods for further delivery
            this.ReceivingPartner = new EdiPartnerIdentification
            {
                Name = "Max Mustermann",
                Street = "Musterstraße 1",
                ZipCode = "97082",
                City = "Würzburg",
                CountryCode = "DE"
            };
            // The client, sender of the goods
            this.Shipper = new EdiAddress
            {
                Name = "Zombie Inc.",
                Street = "Am düsteren Weg",
                HouseNumber = "3a",
                ZipCode = "97424",
                City = "Würzburg",
                CountryCode = "DE",
                AdditionalAddressLines = new List<string>
                {
                    "Gate 2"
                },
                TownArea = "Hafen West",
            };
            // Receiver of the goods
            this.Consignee = new EdiAddress
            {
                Name = "Umbrella Corp.",
                City = "Racoon City",
                Street = "Umbrella Str.",
                HouseNumber = "1-20"
            };
            this.Content = new EdiFileContent
            {
                ContentType = "image/png",
                FileName = "test-pod.png",
                BinaryData = new EdiBinaryData
                {
                    Data = new byte[]
                    {
                        1, 0, 0, 1
                    }
                }
            };
        }
    }
}
```

After the class has been created and filled with values, it can be serialized.

```cs
var m = new ProofOfDeliverySimpleExample();
var result =  Converter.Serialize(m);
 ```

