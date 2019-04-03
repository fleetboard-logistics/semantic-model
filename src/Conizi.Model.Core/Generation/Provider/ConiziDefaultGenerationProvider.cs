using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using Conizi.Model.Core.Extensions;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;

namespace Conizi.Model.Core.Generation.Provider
{
    /// <summary>
    /// The default conizi schema generation provider
    /// </summary>
    internal class ConiziDefaultGenerationProvider : JSchemaGenerationProvider
    {
        private void HandleXProperties(Type typeObject, JSchema schema)
        {
            if (typeObject.CustomAttributes.All(a => a.AttributeType != typeof(ConiziAllowXPropertiesAttribute)))
                return;

            schema.PatternProperties.Add("x-.*", JSchema.Parse("{}"));
            schema.PatternProperties.Add("\\$.*", JSchema.Parse("{}"));
        }

        private void HandleAdditionalProperties(MemberInfo typeObject, JSchema schema)
        {
            if (typeObject.CustomAttributes.All(a => a.AttributeType != typeof(ConiziAdditionalPropertiesAttribute)))
                return;

            var attr = typeObject.CustomAttributes.FirstOrDefault(a =>
                a.AttributeType == typeof(ConiziAdditionalPropertiesAttribute));

            schema.AllowAdditionalProperties = Convert.ToBoolean(attr.ConstructorArguments[0].Value);
        }

        public override JSchema GetSchema(JSchemaTypeGenerationContext context)
        {
            // Handle Schema Definition Attribute
            if (context.ObjectType.CustomAttributes.Any(a => a.AttributeType == typeof(ConiziSchemaAttribute)))
            {
                var generator = context.Generator;
                var schema = generator.Generate(context.ObjectType);
                HandleAdditionalProperties(context.ObjectType, schema);
                HandleXProperties(context.ObjectType, schema);
                var attr = context.ObjectType.GetCustomAttribute<ConiziSchemaAttribute>();
                schema.Id = new Uri(attr.Id);
                schema.SchemaVersion = new Uri("http://json-schema.org/draft-06/schema#");
                return schema;
            }

            var processedProps = new List<string>();

            //Check if anyOf etc. is used
            if (context.ObjectType.CustomAttributes.Any(a => a.AttributeType == typeof(KnownTypeAttribute)))
            {
                var generator = context.Generator;
                var schema = generator.Generate(context.ObjectType);

                foreach (var attr in context.ObjectType.GetCustomAttributes().Where(a => a is KnownTypeAttribute)
                    .Cast<KnownTypeAttribute>())
                {
                    var schemaOf = generator.Generate(attr.Type);
                    HandleAdditionalProperties(attr.Type, schemaOf);
                    HandleXProperties(attr.Type, schemaOf);
                    schemaOf.Title = context.SchemaTitle;
                    schemaOf.Description = context.SchemaDescription;

                    foreach (var custAttr in context.ObjectType.GetCustomAttributes())
                    {
                        switch (custAttr)
                        {
                            case ConiziOneOfAttribute oneOf:
                                schema.OneOf.Add(schemaOf);
                                processedProps.Add(attr.Type.Name);
                                break;

                            case ConiziAnyOfAttribute oneOf:
                                schema.AnyOf.Add(schemaOf);
                                processedProps.Add(attr.Type.Name);
                                break;

                            case ConiziAllOfAttribute allOf:
                                schema.AllOf.Add(schemaOf);
                                processedProps.Add(attr.Type.Name);
                                break;
                        }
                    }
                }

                foreach (var prop in context.ObjectType.GetProperties())
                {
                    if (!processedProps.Contains(prop.PropertyType.Name))
                        continue;

                    var ccProp = prop.Name.ToCamelCase();

                    schema.Properties.Remove(ccProp);
                }

                return schema;
            }

            if (context.ObjectType == typeof(DateTime))
            {
                if (context.MemberProperty.AttributeProvider.GetAttributes(typeof(ConiziDateOnlyAttribute), true).Any())
                {
                    var generator = context.Generator;
                    var schema = generator.Generate(context.ObjectType);
                    schema.Format = "date";
                    schema.Title = context.SchemaTitle;
                    schema.Description = context.SchemaDescription;
                    return schema;
                }
            }

            if (context.ObjectType == typeof(string) && context.MemberProperty?.AttributeProvider != null)
            {
                if (context.MemberProperty.AttributeProvider.GetAttributes(typeof(ConiziTimeOnlyAttribute), true).Any())
                {
                    var generator = context.Generator;
                    var schema = generator.Generate(context.ObjectType);
                    schema.Format = "time";
                    schema.Title = context.SchemaTitle;
                    schema.Description = context.SchemaDescription;
                    return schema;
                }
            }

            var defaultGenerator = context.Generator;
            var defaultSchema = defaultGenerator.Generate(context.ObjectType);
            HandleAdditionalProperties(context.ObjectType, defaultSchema);
            HandleXProperties(context.ObjectType, defaultSchema);
            defaultSchema.Title = context.SchemaTitle;
            defaultSchema.Description = context.SchemaDescription;
            return defaultSchema;
        }
    }
}