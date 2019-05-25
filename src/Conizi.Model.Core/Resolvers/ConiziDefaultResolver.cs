using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Conizi.Model.Core.Resolvers
{
    internal class ConiziDefaultResolver : DefaultContractResolver
    {
        public ConiziDefaultResolver() : base()
        {
            NamingStrategy = new CamelCaseNamingStrategy
            {
                ProcessDictionaryKeys = true,
                OverrideSpecifiedNames = true
            };
        }

        public new static readonly ConiziDefaultResolver Instance = new ConiziDefaultResolver();

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);

            if (property.PropertyType == typeof(EdiMetadata))
            {

                property.Ignored = true;
            }

            return property;
        }
    }
}