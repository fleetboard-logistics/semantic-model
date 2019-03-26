using System;
using System.Collections.Generic;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json;

namespace Conizi.Model.Test.Library.Entities
{
    [ConiziSchema("https://model.conizi.io/v1.0/test/test.json", "test.json")]
    [DisplayName("Test Model")]
    [Description("This is the conizi test model")]
    public class TestModel : EdiDocument
    {

        [JsonRequired]
        public EdiPartnerIdentification TestReceivingPartner { get; set; }

        [JsonRequired]
        public EdiPartner TestShippingPartner { get; set; }

        [ConiziDateOnly]
        public DateTime TestDateOnly { get; set; }

        [ConiziTimeOnly]
        public string TestTimeOnly { get; set; }

        [ConiziTimeOnly]
        public DateTime TestDateTime { get; set; }

        [JsonProperty("testFileContent", IsReference = false, ItemIsReference = false)]
        public EdiFileContent TestFileContentContent { get; set; }

    }
}
