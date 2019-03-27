using System;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;

namespace Conizi.Model.Core.Generation.Provider
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
