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

public enum Ti {
	AnyOf,
	AllOf,
	OneOf
};

class TiItem {
	public string Name { get; set; }
	public PropertyInfo Info { get; set; }
	public Ti Kind {get; set; }
}

class ExampleGenerationProvider : JSchemaGenerationProvider
{
	private readonly List<TiItem> ofItems = new List<TiItem>();

	public override JSchema GetSchema(JSchemaTypeGenerationContext context)
	{
		// Handle Schema Definition Attribute
		if (context.ObjectType.CustomAttributes.Any(a => a.AttributeType == typeof(ConiziSchemaAttribute)))
		{

			foreach (var prop in context.ObjectType.GetProperties().Where(p => p.CustomAttributes.Any()))
			{
				foreach (var customAttr in prop.GetCustomAttributes())
				{
					switch (customAttr)
					{
						case ConiziOneOfAttribute oneOf:
							this.ofItems.Add(new TiItem {
								Name = prop.Name,
								Info = prop,
								Kind =Ti.OneOf
							});
							break;

						case ConiziAnyOfAttribute anyOf:
							this.ofItems.Add(new TiItem
							{
								Name = prop.Name,
								Info = prop,
								Kind = Ti.AnyOf
							});
							break;

						case ConiziAllOfAttribute allOf:
							this.ofItems.Add(new TiItem
							{
								Name = prop.Name,
								Info = prop,
								Kind = Ti.AllOf
							});
							break;
					}
				}
			}

			var generator = context.Generator;
			var schema = generator.Generate(context.ObjectType);
			var attr = context.ObjectType.GetCustomAttribute<ConiziSchemaAttribute>();
			schema.Id = new Uri(attr.Id);
			schema.SchemaVersion = new Uri("http://json-schema.org/draft-06/schema#");
			
			return schema;
		}

	
		if (context.ObjectType.CustomAttributes.Any(a => a.AttributeType == typeof(KnownTypeAttribute)))
		{
			var generator = context.Generator;
			var schema = generator.Generate(context.ObjectType);
			
			foreach (var attr in context.ObjectType.GetCustomAttributes().Where(a => a.GetType() == typeof(KnownTypeAttribute)).Cast<KnownTypeAttribute>())
			{
				var prop = context.MemberProperty.PropertyName.ToLower();
				var schemaOf = generator.Generate(attr.Type);
				
				var item =this.ofItems.FirstOrDefault(a=>string.Equals(a.Name, prop, StringComparison.OrdinalIgnoreCase));
				
				if(item == null)
				continue;
				
				switch(item.Kind) {
					case Ti.OneOf:
						schema.OneOf.Add(schemaOf);
						break;

					case Ti.AnyOf:
						schema.AnyOf.Add(schemaOf);
						break;

					case Ti.AllOf:
						schema.AllOf.Add(schemaOf);
						break;
				}
					
				
			
			}
			return schema;
		}
		
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

	JSchema schema = generator.Generate(typeof(Consignment));

	schema.ToString().Dump();
}