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
</Query>

public class PartnerIdentitifcation
{
	public string Name { get; set; }
	public string Test { get; set; }
}

public class ExampleAttribute : Attribute
{
	public Type ExampleType { get; set; }
	public bool HasExampleValue { get; set; }
	public object ExampleValue { get; set; }

	public ExampleAttribute(Type exampleType)
	{
		this.ExampleType = exampleType;
	}


	public ExampleAttribute(object exampleType)
	{
		this.ExampleType = exampleType.GetType();
		this.HasExampleValue = true;
		this.ExampleValue = ExampleValue;
	}
}

public class PartnerIdentificationExample : PartnerIdentitifcation
{
	public PartnerIdentificationExample()
	{
		this.Name = "ExampleName";
		this.Test = "exampleTest";
	}
}


class ExampleGenerationProvider : JSchemaGenerationProvider
{
	private readonly List<string> oneOfItems = new List<string>();
	
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
			
			foreach(var prop in context.ObjectType.GetProperties().Where(p=>p.CustomAttributes.Any()))
			{
			    foreach(var customAttr in prop.GetCustomAttributes()) {
					switch(customAttr)
					{
						case ConiziOneOfAttribute oneOf:
							this.oneOfItems.Add(prop.Name);
						break;

						case ConiziAnyOfAttribute anyOf:
							break;
					}
				}
			}
			
		}

		

//		//if (context.ObjectType.IsGenericType && context.ObjectType.GetGenericTypeDefinition() == typeof(ConiziOneOf<,>))
//		if (context.ObjectType.GetProperties().Any(p => p.ReflectedType == typeof(EdiFileBase)))
//		{
//			var generator = context.Generator;
//			var schema = generator.Generate(context.ObjectType);
//			
//
//			foreach (var attr in context.ObjectType.GetCustomAttributes().Where(a => a.GetType() == typeof(KnownTypeAttribute)).Cast<KnownTypeAttribute>())
//			{
//				var schemaOneOf = generator.Generate(attr.Type);
//				schema.OneOf.Add(schemaOneOf);
//			}
//			return schema;
//		}
		
		return null;
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

	JSchema schema = generator.Generate(typeof(Conizi.Model.Test));

	schema.ToString().Dump();
}

// Define other methods and classes here