using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;

namespace Conizi.Model.Telematics
{
    /// <summary>
    /// A single telematics message for ground vehicles which is transferred between two partners.
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/telematics/ground-telematics.json", "ground-telematics.json")]
    [DisplayName("Ground telematics")]
    [Description("A single telematics message for ground vehicles which is transferred between two partners.")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class GroundTelematics : GeoLocation
    {
    }
}
