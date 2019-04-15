using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{
    /// <summary>
    /// An event which occured during the processing of the referenced tour <see cref="Tour"/>
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/transport/truck/groupage/forwarding/tour-event.json",
        "tour-event.json")]
    [DisplayName("Tour event")]
    [Description("An event which occured during the processing of the referenced tour")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class TourEvent : EdiModel
    {
    }
}
