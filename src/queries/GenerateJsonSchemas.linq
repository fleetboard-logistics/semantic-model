<Query Kind="Statements">
  <Reference Relative="..\Conizi.Model.Core\bin\Debug\netstandard2.0\Conizi.Model.Core.dll">C:\src\sematicmodel\src\Conizi.Model.Core\bin\Debug\netstandard2.0\Conizi.Model.Core.dll</Reference>
  <Reference Relative="..\Conizi.Model.Core\bin\Debug\netstandard2.0\Conizi.Model.dll">C:\src\sematicmodel\src\Conizi.Model.Core\bin\Debug\netstandard2.0\Conizi.Model.dll</Reference>
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <NuGetReference>Newtonsoft.Json.Schema</NuGetReference>
  <NuGetReference>Serilog.Sinks.LINQPad</NuGetReference>
  <Namespace>Conizi.Model.Archiving</Namespace>
  <Namespace>Conizi.Model.Converters</Namespace>
  <Namespace>Conizi.Model.Core</Namespace>
  <Namespace>Conizi.Model.Core.Entities</Namespace>
  <Namespace>Conizi.Model.Core.Extensions</Namespace>
  <Namespace>Conizi.Model.Core.Tools</Namespace>
  <Namespace>Conizi.Model.Extensions</Namespace>
  <Namespace>Conizi.Model.Shared.Attributes</Namespace>
  <Namespace>Conizi.Model.Shared.Definitions</Namespace>
  <Namespace>Conizi.Model.Shared.Entities</Namespace>
  <Namespace>Conizi.Model.Shared.Helper</Namespace>
  <Namespace>Conizi.Model.Shared.Interfaces</Namespace>
  <Namespace>Conizi.Model.Transport.Truck.Groupage.Forwarding</Namespace>
  <Namespace>Conizi.Model.Transport.Truck.Groupage.Forwarding.Helper.Manifest</Namespace>
  <Namespace>Conizi.Model.Transport.Truck.Groupage.Forwarding.Helper.Tour</Namespace>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>Newtonsoft.Json.Bson</Namespace>
  <Namespace>Newtonsoft.Json.Converters</Namespace>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
  <Namespace>Newtonsoft.Json.Schema</Namespace>
  <Namespace>Newtonsoft.Json.Schema.Generation</Namespace>
  <Namespace>Newtonsoft.Json.Serialization</Namespace>
  <Namespace>Serilog</Namespace>
  <Namespace>Serilog.Configuration</Namespace>
</Query>

Generator.RegisterJsonSchemaLicense(Environment.GetEnvironmentVariable("Generator:JsonSchemaLicense"));
Log.Logger = new LoggerConfiguration()
	.WriteTo.LINQPad()
	.CreateLogger();

var modelSrcPath = Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), @"..\..\model").Replace('\\', '/');

var models = new List<Type> {
	 typeof(Tour),
	 typeof(TourEvent),
	 typeof(Consignment),
	 typeof(ConsignmentEvent),
	 typeof(PackageEvent),
	 typeof(Manifest),
	 typeof(EventBulk),

};

foreach (var model in models)
{
	try
	{
		var result = Generator.Generate(model);

		var outFile = Path.Combine(modelSrcPath, result.Id.Replace("https://model.conizi.io/v1/", string.Empty));

		var fileInfo = new FileInfo(outFile);

		File.WriteAllText(fileInfo.FullName, result.ToString(), Encoding.UTF8);

		Log.Information("Model {model} was successfully generated to {file}", result.Model, fileInfo.FullName);
	}
	catch(Exception ex)
	{
		Log.Error(ex,"Error while generating model {model}", model); 
	}
}