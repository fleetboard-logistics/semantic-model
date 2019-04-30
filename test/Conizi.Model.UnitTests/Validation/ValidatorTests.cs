using System;
using Conizi.Model.Core.Tools;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Test.Library.Entities;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;
using Xunit;

namespace Conizi.Model.UnitTests.Validation
{
    public class ValidatorTests
    {
        public ValidatorTests()
        {
            var license = TestHelper.GetJsonSchemaLicense();

            if (!string.IsNullOrEmpty(license))
                Generator.RegisterJsonSchemaLicense(license);
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void ValidateTestModel_AssertSuccess()
        {
            var m = new TestModel
            {
                Receiver = new EdiPartnerIdentification { 
                    EdiId = "CONIZVK"
                },
                Sender = new EdiPartnerIdentification
                {
                    PartnerId = "4711"
                },
                TestReceivingPartner = new EdiPartnerIdentification
                {
                    Name = "Franz Kafka",
                    City = "Kafka City"
                },
                TestShippingPartner = new EdiPartnerIdentification
                {
                    PartnerId = "FRANZKF"
                }
            };

            var result = Converter.Serialize(m);
            Assert.False(result.HasValidationErrors);
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void ValidateParseModel_AssertSuccess()
        {
            var m = new Consignment
            {
                Receiver = new EdiPartnerIdentification
                {
                    EdiId = "CONIZVK"
                },
                Sender = new EdiPartnerIdentification
                {
                    PartnerId = "4711"
                },
                ShippingDate = DateTime.Now,
                ReceivingPartner = new EdiPartnerIdentification
                {
                    Name = "Hans Marks"
                },
                ShippingPartner = new EdiPartnerIdentification
                {
                    Name = "Franz Kafka",
                    Street = "Kafka Straße"
                }
            };

            var result = Converter.Serialize(m, false);
            Assert.NotNull(result);


            var test =  Validator.ValidateSchema(result.Content, out var errors);
        }
    }
}