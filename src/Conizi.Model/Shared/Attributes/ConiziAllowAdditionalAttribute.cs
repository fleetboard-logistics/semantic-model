using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Attributes
{
    public class ConiziAllowAdditionalAttribute : Attribute
    {
        public bool AllowAdditionalProperties { get; set; }

        public ConiziAllowAdditionalAttribute(bool allowAdditionalProperties = true)
        {
            this.AllowAdditionalProperties = allowAdditionalProperties;
        }

    }
}