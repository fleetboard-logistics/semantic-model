using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Definitions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{

    [ConiziSchema("http://conizi.io/model/transport/truck/groupage/forwarding/tour.json", "tour.json")]
    [DisplayName("Consignment")]
    [Description("A tour describes a amount of stops given an explicit stop order, containing all information about activities to be done, e.g.loading and unloading information about consignments or maintenance stops")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class Tour
    {
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("messageFunctionCode")]
        [DisplayName("Message function code")]
        public EdiMessageFunctionCode MessageFunctionCode { get; set; }

    }
}
