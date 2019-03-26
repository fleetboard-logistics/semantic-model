using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.XPath;
using Conizi.Model.Core.Entities;
using Conizi.Model.Core.Generation;
using Conizi.Model.Test.Library.Entities;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;
using Newtonsoft.Json.Schema;
using Xunit;

namespace Conizi.Model.UnitTests.Generation
{
    public class GeneratorTests
    {

        public GeneratorTests()
        {

            var license = TestHelper.GetJsonSchemaLicense();

            if (!string.IsNullOrEmpty(license))
                Generator.RegisterJsonSchemaLicense(license);
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void GenerateInvalidModel_AssertInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => Generator.Generate<System.DateTime>());
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void GenerateValidModel_AssertValidSchema()
        {
            var result = Generator.Generate<Consignment>();

            Assert.IsType<GenerationResult>(result);

            // Get schema version 6 as default
            Assert.NotEmpty(result.JSchema.ToString(SchemaVersion.Draft6));
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void GenerateModel_AssertValidModel()
        {
            var result = Generator.Generate<Consignment>();

            Assert.IsType<GenerationResult>(result);

            // Get schema version 6 as default
            Assert.Equal("transport/truck/groupage/forwarding/consignment", result.Model);
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void GenerateModel_AssertModelUriFormatException()
        {
            Assert.Throws<UriFormatException>(() => Generator.Generate<InvalidModel>());
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void GenerateValidModel_AssertValidVersion()
        {
            var result = Generator.Generate<Consignment>();

            Assert.IsType<GenerationResult>(result);

            var valid = Regex.IsMatch(result.Version, "^(v([0-9]|[0-9]\\.)+)$");

            //Valid version
            Assert.True(valid);
        }



        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void GenerateTestModel_AssertUnionTypesCount()
        {

            var result = Generator.Generate<TestModel>();

            Assert.IsType<GenerationResult>(result);

            var schema = result.JSchema;

            Assert.NotNull(schema);

            var content =  schema.Properties["testFileContent"];

            Assert.Equal(2, content.OneOf.Count);

            Assert.Equal(4, schema.Properties["testReceivingPartner"].AnyOf.Count);
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void GenerateTestModel_AssertValidDateFormats()
        {
         
            var result = Generator.Generate<TestModel>();

            Assert.IsType<GenerationResult>(result);
            
            var schema = result.JSchema;
            
            Assert.Equal("date-time", schema.Properties["testDateTime"].Format);
            Assert.Equal("date", schema.Properties["testDateOnly"].Format);
            Assert.Equal("time", schema.Properties["testTimeOnly"].Format);
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void GenerateCominedTestModel_AssertCombinedTypes()
        {
            var result = Generator.Generate<TestCombinedModel>();

            Assert.IsType<GenerationResult>(result);

            var schema = result.JSchema;

            Assert.NotNull(schema);

            var prop = schema.Properties["testFileContent"];

            Assert.DoesNotContain(prop.Properties, x => x.Key == "fileData");

            Assert.True(prop.OneOf.Count == 2);


        }

    }
}

