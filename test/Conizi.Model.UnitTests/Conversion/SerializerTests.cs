using System;
using System.Text.RegularExpressions;
using Conizi.Model.Core.Tools;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Test.Library.Entities;
using Xunit;

namespace Conizi.Model.UnitTests.Conversion
{
    public class SerializerTests
    {
        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void SerializerInvalidModel_AssertJsonSerializationException()
        {
            var m = new InvalidModel();

            var result = Converter.Serialize(m);

            Assert.True(result.HasValidationErrors);
            Assert.Equal("Invalid URI: The format of the URI could not be determined.", result.ValidationErrors[1]);
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void SerializerBasicModel_AssertValidSerialization()
        {
            // Simple test model
            var m = new TestModel
            {
                Receiver = new EdiPartnerIdentification()
                {
                        EdiId = "CONIZIVK"
                },
                Sender = new EdiPartnerIdentification
                {
                    EdiId = "FLELOVK"
                },
                TestReceivingPartner = new EdiPartnerIdentification
                {
                    Name = "Fleetboard Logistics",
                    Street = "Am Alten Bahnhof",
                    HouseNumber = "8",
                    City = "Volkach",
                        EdiId = "FLELOVK"
                },
                TestShippingPartner = new EdiPartnerIdentification
                {
                    PartnerId = "1234"
                },
                Network = new EdiNetwork
                {
                    NetworkId = "CL"
                },
                TestFileContent = new EdiFileContent
                {
                    FileName = "MyFuzzyFile.jpeg",
                    ContentType = "image/jpeg",
                    FileReference = new EdiFileReference
                    {
                        AbsoluteUri = "http://imnotexistend.org",
                        UriValidFrom = DateTime.Today,
                        UriValidTo = DateTime.Now.AddDays(5)
                    }
                }

            };

            m.TestFileContent.AddPatternProperty("x-cloud-storage", "minio");

            var result = Converter.Serialize(m);
            Assert.False(result.HasValidationErrors);

        }

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
                Receiver = new EdiPartnerIdentification
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
                Receiver = new EdiPartnerIdentification
                {
                    EdiId = "FRANZKF"
                },
                Sender = new EdiPartnerIdentification
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
                        GeneralNotificationAddress = new EdiAddress
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
                Receiver = new EdiPartnerIdentification
                {
                    EdiId = "KLMN01",
                },
                Sender = new EdiPartnerIdentification
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

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void SerializeTestModel_AssertDateTime()
        {
            var m = new TestModel
            {
                Receiver = new EdiPartnerIdentification
                {
                    EdiId = "KLMN01",
                },
                Sender = new EdiPartnerIdentification
                {
                    PartnerId = "4711"
                },
                TestReceivingPartner = new EdiPartnerIdentification
                {
                    EdiId = "KLMN01",
                    Name = "Franz Kafka",
                    City = "Kafka City"
                },
                TestShippingPartner = new EdiPartnerIdentification
                {
                    EdiId = "OIJE234",
                    City = "Mary Town"
                },
                TestDateTime = DateTime.Now,
                TestDateOnly = DateTime.Now,
                TestTimeOnly = "14:12:23"
            };

            var result = Converter.Serialize(m);

            var content = result.Content;

            Assert.False(result.HasValidationErrors, "Validation errors detected: " + Environment.NewLine + string.Join(Environment.NewLine, result.ValidationErrors));

            Assert.NotNull(content);

            var validTestDateTime = Regex.IsMatch(content,
                "\"testDateTime\": \"\\d\\d\\d\\d-\\d\\d-\\d\\dT\\d\\d:\\d\\d:\\d\\d.*\"");
            Assert.True(validTestDateTime, "Invalid DateTime format!");

            var validTestDateOnly = Regex.IsMatch(content,
                "\"testDateOnly\": \"\\d\\d\\d\\d-\\d\\d-\\d\\d\"");
            Assert.True(validTestDateOnly, "Invalid Date format!");


        }
    }
}

