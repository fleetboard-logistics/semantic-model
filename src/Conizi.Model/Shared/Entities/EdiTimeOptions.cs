using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("timeOptions")]
    [DisplayName("Time options")]
    [Description("Requirements for the delivery or pickup time")]
    [ConiziAdditionalProperties(false)]
    public class EdiTimeOptions
    {
        public NotAfter NotAfter { get; set; }

        public NotBefore NotBefore { get; set; }



    }

    [JsonObject("notAfter")]
    [DisplayName("Not after")]
    [Description("The consignment must be deliverd until the given date")]
    [ConiziAdditionalProperties(false)]
    public class NotAfter
    {
       public DateTime Date { get; set; }
    }

    [JsonObject("notBefore")]
    [DisplayName("notBefore")]
    [Description("The consignment must not be deliverd before the given date")]
    [ConiziAdditionalProperties(false)]
    public class NotBefore {
        public DateTime Date { get; set; }
    }
}
