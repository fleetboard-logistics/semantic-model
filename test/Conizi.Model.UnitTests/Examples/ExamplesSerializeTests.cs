using System;
using System.Collections.Generic;
using System.Text;
using Conizi.Model.Core.Tools;
using Conizi.Model.Examples.Archiving;
using Conizi.Model.Examples.Transport.Truck.Groupage.Forwarding;
using Conizi.Model.Examples.Transport.Truck.Groupage.Forwarding.Tour;
using Xunit;

namespace Conizi.Model.UnitTests.Examples
{
    public class ExamplesSerializeTests
    {
        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void SerializeSimpleTourForEtaExample_AssertSerializationValid()
        {
            var m = new SimpleTourForEtaExample().Create();

            var result = Converter.Serialize(m);
            Assert.False(result.HasValidationErrors);
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void SerializeConsignmentSimpleExample_AssertSerializationValid()
        {
            var m = new ConsignmentSimpleExample().Create();

            var result = Converter.Serialize(m);
            Assert.False(result.HasValidationErrors);

            var me = new ConsignmentEventSimpleExample().Create();

            var eventResult = Converter.Serialize(me);
            Assert.False(eventResult.HasValidationErrors);
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void SerializeProofOfDeliverySimpleExample_AssertSerializationValid()
        {
            var m = new ProofOfDeliverySimpleExample().Create();

            var result = Converter.Serialize(m);
            Assert.False(result.HasValidationErrors);
        }
    }
}
