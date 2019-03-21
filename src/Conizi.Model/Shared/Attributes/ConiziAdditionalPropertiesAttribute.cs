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
        /// <summary>
        /// Indicates if additional properties should be allowed
        /// </summary>
        public bool AllowAdditionalProperties { get; set; }

        /// <summary>
        /// Set value, if additional properties should be allowed
        /// </summary>
        /// <param name="allowAdditionalProperties"></param>
        public ConiziAdditionalPropertiesAttribute(bool allowAdditionalProperties = false)
        {
            this.AllowAdditionalProperties = allowAdditionalProperties;
        }

    }
}