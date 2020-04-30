using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Attributes
{
    public class ConiziKeyFieldAttribute : Attribute
    {
        [JsonIgnore]
        public string Description { get; set; }

        public ConiziKeyFieldAttribute(string description = null)
        {
            this.Description = description;
        }


    }
}
