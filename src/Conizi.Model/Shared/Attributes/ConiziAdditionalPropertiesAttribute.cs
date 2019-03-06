using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Attributes
{
    public class ConiziAdditionalPropertiesAttribute : Attribute
    {
        public bool AllowAdditionalProperties { get; set; }

        public ConiziAdditionalPropertiesAttribute(bool allowAdditionalProperties = false)
        {
            this.AllowAdditionalProperties = allowAdditionalProperties;
        }

    }
}