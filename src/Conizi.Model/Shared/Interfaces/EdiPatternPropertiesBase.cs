using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Interfaces
{
    /// <summary>
    /// Enables the models to add additional pattern (x-) properties
    /// Attention: Pattern properties will not be processed in all services and apps, so please use carefully!
    /// </summary>
    public abstract class EdiPatternPropertiesBase
    {
        [JsonIgnore]
        private List<EdiPatternProperty> PatternProperties { get; }

        public EdiPatternPropertiesBase()
        {
            this.PatternProperties = new List<EdiPatternProperty>();
        }

        /// <summary>
        /// Add a pattern property to this object (e.g. x-name2)
        /// </summary>
        /// <param name="name">The name of the property as string</param>
        /// <param name="value">The value of the property as string</param>
        public void AddPatternProperty(string name, string value)
        {
            if (string.IsNullOrEmpty(name) || !name.StartsWith("x-"))
                throw new ArgumentException("Property name must start with 'x-'");
            
            if (this.PatternProperties.Any(x=>x.Name == name))
            {
                this.PatternProperties.FirstOrDefault(x=>x.Name == name).Value = value;
                return;
            }

            this.PatternProperties.Add(new EdiPatternProperty(name, value));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetPatternPropertyValue(string name)
        {

            return this.PatternProperties.FirstOrDefault(x => x.Name == name)?.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<EdiPatternProperty> GetInstancePatternProperies()
        {
            return this.PatternProperties;
        }

    }

    /// <summary>
    /// Pattern property to handle additional properties (e.g. x-name2)
    /// </summary>
    public class EdiPatternProperty
    {
        public EdiPatternProperty(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// Name of the property as string
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Value of the property as string
        /// </summary>
        public string Value  { get; set; }
    }
}
