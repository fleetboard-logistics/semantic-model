using System;
using System.Collections.Generic;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json;

namespace Conizi.Model.Test.Library.Entities
{
    [ConiziSchema("https://model.conizi.io/v1.0/test/combinetest.json", "combinetest.json")]
    [DisplayName("Test Combined Schema Model")]
    [Description("This is the conizi combined schema test model")]
    public class TestCombinedModel
    {

        public string Label { get; set; }

        [ConiziTimeOnly]
        public DateTime TestDateTime { get; set; }

        [JsonProperty("testFileContent", IsReference = false, ItemIsReference = false)]
        public EdiFileContent TestFileContentContent { get; set; }

    }
}
