using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{
    /// <summary>
    /// An event which occured during the processing of the referenced package, which is included in a <see cref="Consignment"/>
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/transport/truck/groupage/forwarding/package-event.json",
        "package-event.json")]
    [DisplayName("Package event")]
    [Description("An event which occured during the processing of the referenced package.")]
    [ConiziAdditionalProperties(true)]
    [ConiziAllowXProperties]
    public class PackageEvent : EdiModel
    {

    }

}
