using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Attributes
{
    public class ConiziHandleExternal : Attribute
    {

        public string externalRef { get; set; }

        public ConiziHandleExternal(string externalRef)
        {
            this.externalRef = externalRef;
        }


    }
}
