using System;
using System.Collections.Generic;
using System.Text;
using Conizi.Model.Core.Tools;
using Conizi.Model.Examples.Transport.Truck.Groupage.Forwarding;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;
using DeepEqual.Syntax;
using Xunit;

namespace Conizi.Model.UnitTests.Examples
{
    public class ExamplesDeserializeTests
    {
        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void DeserializeConsignmentSimpleExample_AssertSerializationValid()
        {
            var m = new ConsignmentSimpleExample().Create();

            var result = Converter.Serialize(m);
            Assert.False(result.HasValidationErrors);

            var deserialized = Converter.Deserialize<Consignment>(result.Content);

            m.ShouldDeepEqual(deserialized);
        }
    }
}
