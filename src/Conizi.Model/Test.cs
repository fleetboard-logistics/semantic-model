using System;
using System.Collections.Generic;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json;

namespace Conizi.Model
{
    [ConiziSchema("http://conizi.io/model/test.json", "test.json")]
    public class Test
    {
        public EdiPartnerIdentification ReceivingPartner { get; set; }
        public EdiPartnerIdentification ShippingPartner { get; set; }

        [JsonProperty("content", IsReference = false, ItemIsReference = false)]
        [ConiziOneOf]
        public EdiFileBase Content { get; set; }

        public EdiSignature Signature { get; set; }


    }
}
