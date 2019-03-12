using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Attributes
{
    /// <summary>
    /// Indicates if X- Properties should allowed. Default true
    /// </summary>
    public class ConiziAllowXPropertiesAttribute : Attribute
    {
        public bool AllowXProperties { get; set; }

        public ConiziAllowXPropertiesAttribute(bool allowXProperties = true)
        {
            this.AllowXProperties = allowXProperties;
        }



    }
}