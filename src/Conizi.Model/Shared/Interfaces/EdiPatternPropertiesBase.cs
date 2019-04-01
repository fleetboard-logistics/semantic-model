using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Conizi.Model.Shared.Interfaces
{
    /// <summary>
    /// Enables the models to add additional pattern (x-) properties
    /// Attention: Pattern properties will not be processed in all services and apps, so please use carefully!
    /// </summary>
    [JsonObject()]
    public abstract class EdiPatternPropertiesBase
    {

        [JsonExtensionData(WriteData = true, ReadData = true)]
        private Dictionary<string, JToken> patternProperties;
        
        public EdiPatternPropertiesBase()
        {
            this.patternProperties = new Dictionary<string, JToken>();
        }

        /// <summary>
        /// Add a pattern property to this object (e.g. x-name2)
        /// </summary>
        /// <param name="name">The name of the property as string</param>
        /// <param name="value">The value of the property as string</param>
        public void AddPatternProperty(string name, object value)
        {
            if (string.IsNullOrEmpty(name) || !name.StartsWith("x-"))
                throw new ArgumentException("Property name must start with 'x-'");

            if (this.patternProperties.Any(x => x.Key == name))
            {
                //this.patternProperties.FirstOrDefault(x => x.Key == name).Value = JToken.FromObject(value);
                return;
            }

            //this.PatternProperties.Add(new EdiPatternProperty(name, value));
            this.patternProperties.Add(name, JToken.FromObject(value));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public JToken GetPatternPropertyValue(string name)
        {

            return this.patternProperties.FirstOrDefault(x => x.Key == name).Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //public List<> GetInstancePatternProperies()
        //{
        //    return this.PatternProperties;
        //}

    }
}
