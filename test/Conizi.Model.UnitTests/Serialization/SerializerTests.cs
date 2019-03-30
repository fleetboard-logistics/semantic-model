using System;
using System.Collections.Generic;
using System.Text;
using Conizi.Model.Core.Conversion;
using Conizi.Model.Core.Generation;
using Conizi.Model.Core.Validate;
using Conizi.Model.Shared.Definitions;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Test.Library.Entities;
using Xunit;

namespace Conizi.Model.UnitTests.Serialization
{
    public class SerializerTests
    {
        public SerializerTests()
        {
            var license = TestHelper.GetJsonSchemaLicense();

            if (!string.IsNullOrEmpty(license))
                Generator.RegisterJsonSchemaLicense(license);
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void SerializeTestModel_AssertSuccess()
        {
            var m = new TestModel
            {
                Receiver = new EdiMessageRouting()
                {
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
        public void SerializeTestModel_AssertAddPatternProperties()
        {
            var m = new TestModel
            {
                Receiver = new EdiMessageRouting
                {
                    EdiId = "FRANZKF"
                },
                Sender = new EdiMessageRouting
                {
                    PartnerId = "4711"
                },
                TestReceivingPartner = new EdiPartnerIdentification()
                {
                    Name = "Franz Kafka",
                    City = "Kafka City"
                },
                TestShippingPartner = new EdiPartnerIdentification
                {
                    PartnerId = "FRANZKF"
                },
                Services = new EdiServices
                {
                    SpecialRun = "yes",
                    TimeOptions = new EdiTimeOptions
                    {
                        Evening = new EdiEvening
                        {
                            TimeFrom = "17:00:00",
                            TimeUntil = "18:30:00"
                        }
                    },
                    TimeSlotBooking = new EdiTimeSlotBooking
                    {
                        ByDeliveryPartner = new EdiPartnerIdentification()
                        {
                            PartnerId = "4711"
                        }
                    },
                    Notifications = new EdiNotifications
                    {
                        GeneralNotificationAddress = new EdiPartnerIdentification
                        {
                            ContactPerson = "Mice Mouse"
                        }
                    }
                }
            };

            m.Receiver.AddPatternProperty("x-name3", "Mister T.");
            m.Sender.AddPatternProperty("x-my-id", "frogger");
            m.TestReceivingPartner.AddPatternProperty("x-my-personal-partner", "frank the tank");
            m.Services.AddPatternProperty("x-my-little-service", "go faster than all");
            m.Services.TimeOptions.Evening.AddPatternProperty("x-before-dawn", "huhu");
            m.Services.TimeOptions.AddPatternProperty("x-my-time-option", "ffg");
            m.Services.Notifications.GeneralNotificationAddress.AddPatternProperty("x-notify-me", "hello");

            var result = Converter.Serialize(m);
            Assert.False(result.HasValidationErrors);
            Assert.Contains("x-name3", result.Content);
            Assert.Contains("x-my-id", result.Content);
            Assert.Contains("x-my-personal-partner", result.Content);
            Assert.Contains("x-my-little-service", result.Content);
            Assert.Contains("x-before-dawn", result.Content);
        }


        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void SerializeTestModel_AssertValidationErrors()
        {
            var m = new TestModel
            {
                Receiver = new EdiMessageRouting
                {
                    EdiId = "KLMN01",
                },
                Sender = new EdiMessageRouting
                {
                    PartnerId = "4711"
                },
                TestReceivingPartner = new EdiPartnerIdentification
                {
                    EdiId = "KLMN01",
                    Name = "Franz Kafka",
                    City = "Kafka City"
                },
            };

            var result = Converter.Serialize(m);
            Assert.True(result.HasValidationErrors);
            Assert.Contains("Required properties are missing", result.ValidationErrors[0]);
        }
    }
}