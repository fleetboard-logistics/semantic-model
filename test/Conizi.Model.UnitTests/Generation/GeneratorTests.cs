using System;
using System.Text.RegularExpressions;
using System.Xml.XPath;
using Conizi.Model.Core.Entities;
using Conizi.Model.Core.Generation;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;
using Newtonsoft.Json.Schema;
using Xunit;

namespace Conizi.Model.UnitTests.Generation
{
    public class GeneratorTests
    {
        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void GenerateInvalidModel_ReturnInvalidOperationException()
        {
            var generator = new Generator();
            Assert.Throws<InvalidOperationException>(() => generator.Generate<System.DateTime>());
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void GenerateValidModel_ReturnValidSchema()
        {
            var generator = new Generator();
            var result = generator.Generate<Consignment>();

            Assert.IsType<SchemaResult>(result);

            // Get schema version 6 as default
            Assert.NotEmpty(result.JSchema.ToString(SchemaVersion.Draft6));
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void GenerateValidModel_ReturnValidModel()
        {
            var generator = new Generator();
            var result = generator.Generate<Consignment>();

            Assert.IsType<SchemaResult>(result);

            // Get schema version 6 as default
            Assert.Equal("transport/truck/groupage/forwarding/consignment", result.Model);
        }

        [Fact]
        [Trait("Category", TraitCategory.UNIT_TEST)]
        public void GenerateValidModel_ReturnValidVersion()
        {
            var generator = new Generator();
            var result = generator.Generate<Consignment>();

            Assert.IsType<SchemaResult>(result);

            var valid = Regex.IsMatch("^(v([0-9]|[0-9]\\.)+)$", result.Version);

            //Valid version
            Assert.True(valid);
        }

    }
}
