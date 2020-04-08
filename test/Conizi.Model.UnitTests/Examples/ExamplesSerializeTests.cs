using System;
using System.Collections.Generic;
using System.Text;
using Conizi.Model.Core.Tools;
using Conizi.Model.Examples.Documents;
using Conizi.Model.Examples.Telematics;
using Conizi.Model.Examples.Transport.Truck.Groupage.Forwarding;
using Conizi.Model.Examples.Transport.Truck.Groupage.Forwarding.Tour;
using Conizi.Model.Telematics;
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
        public void SerializeTransportDocumentSimpleExample_AssertSerializationValid()
        {
            var m = new TransportDocumentSimpleExample().Create();

            var result = Converter.Serialize(m);
            Assert.False(result.HasValidationErrors);
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void SerializeStatusImageSimpleExample_AssertSerializationValid()
        {
            var m = new StatusImageSimpleExample().Create();

            var result = Converter.Serialize(m);
            Assert.False(result.HasValidationErrors);
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void SerializeTourEventLoadingEquipment_AssertSerializationValid()
        {
            var m = new TourLoadingEquipmentExchangeExample().Create();

            var result = Converter.Serialize(m, true);
            Assert.False(result.HasValidationErrors);
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void SerializeSimpleTruckNotificationMessage_ReturnValid()
        {
            var m = new TruckNotificationMessageSimpleExample().Create();

            var result = Converter.Serialize(m);
            Assert.False(result.HasValidationErrors);
        }


        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void SerializeTruckNotificationMessageState_ReturnValid()
        {
            var m = new TruckNotificationMessageStateExample().Create();

            var result = Converter.Serialize(m);
            Assert.False(result.HasValidationErrors);
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void SerializeSimpleGroundTelematicsEvent_AssertSerializationValid()
        {
            var m = new GroundTelematicsEventExample().Create();

            var result = Converter.Serialize(m);
            Assert.False(result.HasValidationErrors);
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void SerializeSimpleGroundTelematicsEvent_AssertGpsValid()
        {
            var m = new GroundTelematicsEventExample().Create();

            var result = Converter.Serialize(m);
            Assert.False(result.HasValidationErrors);
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void SerializeTruckTelematicsGroundTelematicsEvent_AssertSerializationValid()
        {
            var m = new GroundTelematicsEventTruckTelematicsExample().Create();

            var result = Converter.Serialize(m);
            Assert.False(result.HasValidationErrors);
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void SerializeTrailerTelematicsGroundTelematicsEvent_AssertSerializationValid()
        {
            var m = new GroundTelematicsEventTrailerTelematicsExample().Create();

            var result = Converter.Serialize(m);
            Assert.False(result.HasValidationErrors);
        }


        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void SerializeTourEventWithReferencedFiles_AssertSerializationValid()
        {
            var m = new SimpleTourEventForPodTourCompleted().Create();

            var result = Converter.Serialize(m);
            Assert.False(result.HasValidationErrors);
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void SimpleTourEventForChecklistImageTourStarted_AssertSerializationValid()
        {
            var m = new SimpleTourEventForChecklistTourStarted().Create();

            var result = Converter.Serialize(m);
            Assert.False(result.HasValidationErrors);
        }

    }
}
