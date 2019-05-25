using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Attributes
{
    public class ConiziSchemaAttribute : Attribute
    {
        [JsonProperty("@id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonIgnore]
        public string FileName { get; set; }

        public ConiziSchemaAttribute(string id, string fileName)
        {
            this.Id = id;
            this.FileName = fileName;
        }


    }
}
