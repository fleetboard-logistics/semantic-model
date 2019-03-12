using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Attributes
{
    /// <summary>
    /// Indicates if Additional Properties should allowed. Default is false
    /// </summary>
    public class ConiziAdditionalPropertiesAttribute : Attribute
    {
        public bool AllowAdditionalProperties { get; set; }

        public ConiziAdditionalPropertiesAttribute(bool allowAdditionalProperties = false)
        {
            this.AllowAdditionalProperties = allowAdditionalProperties;
        }

    }
}