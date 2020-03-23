using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Transport Services
    /// </summary>
    [DisplayName("Transport Services")]
    [Description("")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiTransportServices : EdiPatternPropertiesBase
    {
      
    }
}