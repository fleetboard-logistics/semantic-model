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
        [JsonProperty(Required = Required.Always)]
        [ConiziOneOf]
        public EdiFileBase Content { get; set; }


    }
}
