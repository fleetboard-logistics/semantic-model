using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Empty class holds additional properties
    /// </summary>
    [DisplayName("Empty class holds additional properties")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiEmptyClassWAdditionalProps : EdiPatternPropertiesBase
    {
    }
}
