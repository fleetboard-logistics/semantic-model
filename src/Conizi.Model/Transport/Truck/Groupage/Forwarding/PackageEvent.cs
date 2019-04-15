using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{
    /// <summary>
    /// An event which occured during the processing of the referenced package <see cref="PackageEvent"/>
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/transport/truck/groupage/forwarding/package-event.json",
        "package-event.json")]
    [DisplayName("Package event")]
    [Description("An event which occured during the processing of the referenced package")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class PackageEvent : EdiModel
    {


    }
}
