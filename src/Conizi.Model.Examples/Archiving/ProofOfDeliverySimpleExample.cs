using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Conizi.Model.Archiving;
using Conizi.Model.Examples.Shared.Attributes;
using Conizi.Model.Shared.Entities;

namespace Conizi.Model.Examples.Archiving
{
    //[ExampleFor(typeof(ProofOfDelivery))]
    //public class ProofOfDeliverySimpleExample : ProofOfDelivery
    //{
    //    public ProofOfDeliverySimpleExample()
    //    {
    //        this.Id = "12345678";
    //        this.DocumentCreationDate = DateTime.Now.AddHours(-2);
    //        this.ArrivalDate = DateTime.Now.AddDays(-1);
    //        this.PlannedShippingDate = DateTime.Now.AddDays(-1);
    //        this.ShippingDate = DateTime.Now;
    //        this.Carrier = new EdiAddress
    //        {
    //            Name = "Freight Driver GmbH",
    //            City = "Freiburg"
    //        };
    //        this.Receiver = new EdiPartnerIdentification
    //        {
    //            EdiConiziIdentification = new EdiConiziIdentification()
    //            {
    //                ConiziId = "4545454545454545454"
    //            }
    //        };
    //        this.Consignee = new EdiAddress
    //        {
    //            Name = "Max Mustermann",
    //            Street = "Musterstraße 1",
    //            ZipCode = "97082",
    //            City = "Würzburg",
    //            CountryCode = "DE"
    //        };
    //        this.Shipper = new EdiAddress
    //        {
    //            Name = "Meyer GmbH",
    //            Street = "Meyerstraße 10",
    //            ZipCode = "97424",
    //            City = "Würzburg",
    //            CountryCode = "DE",
    //            AdditionalAddressLines = new List<string>
    //            {
    //                "z.H. Herr Meyer",
    //                "Tor 2a"
    //            },
    //            TownArea = "Hafen West",
    //        };
    //        //this.Content = new EdiFileContent()
    //        //{
    //        //    FileData = new EdiFileData
    //        //    {
    //        //        ContentType = "image/png",
    //        //        FileName = "test-pod.png",
    //        //        Data = new byte[]
    //        //        {
    //        //            1, 0, 0, 1
    //        //        }
    //        //    }
    //        //};
    //    }
    //}
}