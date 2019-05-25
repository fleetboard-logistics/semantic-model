using System;
using System.Collections.Generic;
using System.ComponentModel;
using Conizi.Model.Converters;
using Conizi.Model.Core.Converters;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json;

namespace Conizi.Model.Test.Library.Entities
{
    [ConiziSchema("https://model.conizi.io/v1.0/test/test.json", "test.json")]
    [DisplayName("Test Model")]
    [Description("This is the conizi test model")]
    [ConiziAllowXProperties]
    public class TestModel : EdiModel
    {

        [JsonRequired]
        public EdiPartnerIdentification TestReceivingPartner { get; set; }

        [JsonRequired]
        public EdiPartnerIdentification TestShippingPartner { get; set; }

        /// <summary>
        /// Should only be serialized as yyyy-MM-dd
        /// </summary>
        [ConiziDateOnly]
        [JsonConverter(typeof(ConiziDateConverter))]
        public DateTime TestDateOnly { get; set; }

        /// <summary>
        /// Should only be serialized as yyyy-MM-ddTHH:mm:ss
        /// </summary>
        public DateTime TestDateTime { get; set; }

        /// <summary>
        /// Should only be serialized as yyyy-MM-ddTHH:mm:ss
        /// </summary>
        [ConiziTimeOnly]
        public string TestTimeOnly { get; set; }

        [JsonProperty("testFileContent")]
        public EdiFileContent TestFileContent { get; set; }

        public EdiServices Services { get; set; }

        /// <summary>
        /// Sub Models
        /// </summary>
        public List<TestSubModel> SubModels { get; set; }

    }
}
