using System;
using System.Text.RegularExpressions;
using System.Xml.XPath;
using Conizi.Model.Core.Entities;
using Conizi.Model.Core.Generation;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;
using Conizi.Model.UnitTests.Resources;
using Newtonsoft.Json.Schema;
using Xunit;

namespace Conizi.Model.UnitTests.Generation
{
    public class GeneratorTests
    {
        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void GenerateInvalidModel_AssertInvalidOperationException()
        {
            var generator = new Generator();
            Assert.Throws<InvalidOperationException>(() => generator.Generate<System.DateTime>());
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void GenerateValidModel_AssertValidSchema()
        {
            var generator = new Generator();
            var result = generator.Generate<Consignment>();

            Assert.IsType<GenerationResult>(result);

            // Get schema version 6 as default
            Assert.NotEmpty(result.JSchema.ToString(SchemaVersion.Draft6));
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void GenerateModel_AssertValidModel()
        {
            var generator = new Generator();
            var result = generator.Generate<Consignment>();

            Assert.IsType<GenerationResult>(result);

            // Get schema version 6 as default
            Assert.Equal("transport/truck/groupage/forwarding/consignment", result.Model);
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void GenerateModel_AssertModelUriFormatException()
        {
            var generator = new Generator();
            Assert.Throws<UriFormatException>(() => generator.Generate<InvalidModel>());
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void GenerateValidModel_AssertValidVersion()
        {
            var generator = new Generator();
            var result = generator.Generate<Consignment>();

            Assert.IsType<GenerationResult>(result);

            var valid = Regex.IsMatch(result.Version, "^(v([0-9]|[0-9]\\.)+)$");

            //Valid version
            Assert.True(valid);
        }



        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void GenerateTestModel_AssertUnionTypesCount()
        {

            var generator = new Generator();
            var result = generator.Generate<TestModel>();

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
         
            var generator = new Generator();
            var result = generator.Generate<TestModel>();

            Assert.IsType<GenerationResult>(result);
            
            var schema = result.JSchema;
            
            Assert.Equal("date-time", schema.Properties["testDateTime"].Format);
            Assert.Equal("date", schema.Properties["testDateOnly"].Format);
            Assert.Equal("time", schema.Properties["testTimeOnly"].Format);
        }

    }
}

