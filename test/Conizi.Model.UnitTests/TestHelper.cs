using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Conizi.Model.Core;
using Microsoft.Extensions.Configuration;

namespace Conizi.Model.UnitTests
{
    public static class TestHelper
    {
        public static IConfigurationRoot GetIConfigurationRoot(string outputPath=null)
        {
            if (string.IsNullOrEmpty(outputPath))
                outputPath = AssemblyDirectory;

            return new ConfigurationBuilder()
                .SetBasePath(outputPath)
                .AddJsonFile("appsettings.json", optional: true)
                .AddEnvironmentVariables()
                .Build();
        }

        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = typeof(TestHelper).GetTypeInfo().Assembly.CodeBase;
                var uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        public static string GetJsonSchemaLicense()
        {

            var config = TestHelper.GetIConfigurationRoot();
            var key = config.GetSection("Generator:JsonSchemaLicense");

            return key?.Value;
        }

    }
}
