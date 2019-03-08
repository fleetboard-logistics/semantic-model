<Query Kind="Program">
  <Reference Relative="..\Conizi.Model\bin\Debug\net452\Conizi.Model.dll">C:\src\sematicmodel\src\Conizi.Model\bin\Debug\net452\Conizi.Model.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Reflection.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.ServiceModel.Internals.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\SMDiagnostics.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Configuration.dll</Reference>
  <NuGetReference>Newtonsoft.Json.Schema</NuGetReference>
  <Namespace>Conizi.Model.Archiving</Namespace>
  <Namespace>Conizi.Model.Shared.Attributes</Namespace>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
  <Namespace>Newtonsoft.Json.Schema</Namespace>
  <Namespace>Newtonsoft.Json.Schema.Generation</Namespace>
  <Namespace>Newtonsoft.Json.Serialization</Namespace>
  <Namespace>System.ComponentModel</Namespace>
  <Namespace>Conizi.Model.Shared.Entities</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>Conizi.Model.Transport.Truck.Groupage.Forwarding</Namespace>
</Query>

class ExampleGenerationProvider : JSchemaGenerationProvider
{
	private void HandleAdditionalPropeties(Type typeObject, JSchema schema)
	{
		if (!typeObject.CustomAttributes.Any(a => a.AttributeType == typeof(ConiziAdditionalPropertiesAttribute)))
			return;

		var attr = typeObject.CustomAttributes.FirstOrDefault(a => a.AttributeType == typeof(ConiziAdditionalPropertiesAttribute));

		schema.AllowAdditionalProperties = Convert.ToBoolean(attr.ConstructorArguments[0].Value);
	}

	public override JSchema GetSchema(JSchemaTypeGenerationContext context)
	{
		// Handle Schema Definition Attribute
		if (context.ObjectType.CustomAttributes.Any(a => a.AttributeType == typeof(ConiziSchemaAttribute)))
		{
			var generator = context.Generator;
			var schema = generator.Generate(context.ObjectType);
			var attr = context.ObjectType.GetCustomAttribute<ConiziSchemaAttribute>();
			schema.Id = new Uri(attr.Id);
			schema.SchemaVersion = new Uri("http://json-schema.org/draft-06/schema#");
			return schema;
		}

		//Check if anyOf etc. is used
		if (context.ObjectType.CustomAttributes.Any(a => a.AttributeType == typeof(KnownTypeAttribute)))
		{
			var generator = context.Generator;
			var schema = generator.Generate(context.ObjectType);

			foreach (var attr in context.ObjectType.GetCustomAttributes().Where(a => a.GetType() == typeof(KnownTypeAttribute)).Cast<KnownTypeAttribute>())
			{
				var schemaOf = generator.Generate(attr.Type);
				HandleAdditionalPropeties(attr.Type, schemaOf);
				schemaOf.Title = context.SchemaTitle;
				schemaOf.Description = context.SchemaDescription;

				foreach (var custAttr in context.ObjectType.GetCustomAttributes())
				{

					switch (custAttr)
					{
						case ConiziOneOfAttribute oneOf:
							schema.OneOf.Add(schemaOf);
							break;

						case ConiziAnyOfAttribute oneOf:
							schema.AnyOf.Add(schemaOf);
							break;

						case ConiziAllOfAttribute allOf:
							schema.AllOf.Add(schemaOf);
							break;
					}
				}
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
		HandleAdditionalPropeties(context.ObjectType, defaultSchema);
		defaultSchema.Title = context.SchemaTitle;
		defaultSchema.Description = context.SchemaDescription;
		return defaultSchema;
	}
}

void Main()
{
	string _newtonsoftLicense = "3668-KKyc+tNSwrYP/ng0Hlp5pLP791C3DC2FVPw6UIvvtFYEqxyDd8DewJFeFAldSUbmXZOVOvs9ndks4YQTe2cwimy3Rh09Rts6W1smXc47y8as4/lGWmvg+zJO+nLFulygN1aRKdTToZESMLCsjuuKTc8+AOuFnOQWaJ41ybOBMrF7IklkIjozNjY4LCJFeHBpcnlEYXRlIjoiMjAxOS0wNS0zMFQxMToxNzoxMy4zMTg2NTFaIiwiVHlwZSI6Ikpzb25TY2hlbWFTaXRlIn0=";

	Newtonsoft.Json.Schema.License.RegisterLicense(_newtonsoftLicense);

	var generator = new JSchemaGenerator();

	generator.DefaultRequired = Newtonsoft.Json.Required.DisallowNull;
	generator.SchemaIdGenerationHandling = SchemaIdGenerationHandling.None;
	generator.SchemaPropertyOrderHandling = SchemaPropertyOrderHandling.Default;
	generator.SchemaLocationHandling = SchemaLocationHandling.Definitions;
	generator.ContractResolver = new CamelCasePropertyNamesContractResolver();
	generator.GenerationProviders.Add(new ExampleGenerationProvider());

	JSchema schema = generator.Generate(typeof(Consignment));

	schema.ToString().Dump();
}