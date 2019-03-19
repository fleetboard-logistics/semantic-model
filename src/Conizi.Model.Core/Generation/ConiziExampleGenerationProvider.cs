using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;

namespace Conizi.Model.Core.Generation
{
    /// <summary>
    /// The example conizi schema generation provider
    /// </summary>
    internal class ConiziExampleGenerationProvider : JSchemaGenerationProvider
    {
        public override JSchema GetSchema(JSchemaTypeGenerationContext context)
        {
            throw new NotImplementedException();
        }
    }
}
