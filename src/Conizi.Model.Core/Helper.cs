using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Conizi.Model.Shared.Attributes;

namespace Conizi.Model.Core
{
    internal class Helper
    {
        internal static IEnumerable<Type> GetConiziModels()
        {
            var assembly = Assembly.LoadFrom(Path.Combine(AssemblyDirectory, "Conizi.Model.dll"));

            var schemas = assembly.GetTypes().Where(t =>
                t.CustomAttributes.Any(a => a.AttributeType == typeof(ConiziSchemaAttribute)));

            return schemas;
        }

        internal static Type GetConiziModel(string modelId)
        {
            var assembly = Assembly.LoadFrom(Path.Combine(AssemblyDirectory, "Conizi.Model.dll"));

            var schemas = assembly.GetTypes().Where(t =>
                t.CustomAttributes.Any(a => a.AttributeType == typeof(ConiziSchemaAttribute)));


            var model = schemas.FirstOrDefault(t =>
                string.Equals(t.CustomAttributes.First(a => a.AttributeType == typeof(ConiziSchemaAttribute)).ConstructorArguments[0].Value.ToString(), modelId, StringComparison.InvariantCultureIgnoreCase));

            return model == null ? null : model;
        }


        internal static string AssemblyDirectory
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
