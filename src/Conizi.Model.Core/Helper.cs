using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Conizi.Model.Shared.Attributes;

namespace Conizi.Model.Core
{
    public class Helper
    {
        public static IEnumerable<Type> GetConiziModels()
        {
            var assembly = Assembly.LoadFrom(Path.Combine(AssemblyDirectory, "Conizi.Model.dll"));

            var schemas = assembly.GetTypes().Where(t =>
                t.CustomAttributes.Any(a => a.AttributeType == typeof(ConiziSchemaAttribute)));

            return schemas;
        }

        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = typeof(Helper).GetTypeInfo().Assembly.CodeBase;
                var uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

    }
}
