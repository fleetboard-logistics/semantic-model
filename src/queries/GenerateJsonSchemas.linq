<Query Kind="Statements">
  <Reference Relative="..\Conizi.Model.Core\bin\Debug\netstandard2.0\Conizi.Model.Core.dll">C:\src\sematicmodel\src\Conizi.Model.Core\bin\Debug\netstandard2.0\Conizi.Model.Core.dll</Reference>
  <Reference Relative="..\Conizi.Model.Core\bin\Debug\netstandard2.0\Conizi.Model.dll">C:\src\sematicmodel\src\Conizi.Model.Core\bin\Debug\netstandard2.0\Conizi.Model.dll</Reference>
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <NuGetReference>Newtonsoft.Json.Schema</NuGetReference>
  <NuGetReference>Serilog.Sinks.LINQPad</NuGetReference>
  <NuGetReference>System.Security.Cryptography.Algorithms</NuGetReference>
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
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>Newtonsoft.Json.Bson</Namespace>
  <Namespace>Newtonsoft.Json.Converters</Namespace>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
  <Namespace>Newtonsoft.Json.Schema</Namespace>
  <Namespace>Newtonsoft.Json.Schema.Generation</Namespace>
  <Namespace>Newtonsoft.Json.Serialization</Namespace>
  <Namespace>Serilog</Namespace>
  <Namespace>Serilog.Configuration</Namespace>
  <Namespace>System.Security.Cryptography</Namespace>
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
	 typeof(PickupOrderEvent),
	 typeof(PickupOrder),
	 typeof(ProofOfDelivery)
};

foreach (var model in models)
{
	try
	{
		
		//(Generated: {DateTime.Now} - {assembly.Name} v:{assembly.Version})
		var result = Generator.Generate(model);

		var outFile = Path.Combine(modelSrcPath, result.Id.Replace("https://model.conizi.io/v1/", string.Empty));

		var fileInfo = new FileInfo(outFile);

		if (ModelHashChanged(result.ToString(), outFile))
		{
			File.WriteAllBytes(fileInfo.FullName, Encoding.UTF8.GetBytes(result.ToString()));
			Log.Information("Model {model} was successfully generated to {file}", result.Model, fileInfo.FullName);
			continue;
		}

		Log.Warning("Model {model} is equal to the new generated content, skip writting to file {file}", result.Model, fileInfo.FullName);
	}
	catch (Exception ex)
	{
		Log.Error(ex, "Error while generating model {model}", model);
	}
}

bool ModelHashChanged(string newModelJson, string currentModelPath)
{

	if (string.IsNullOrEmpty(newModelJson))
		throw new ArgumentNullException(nameof(newModelJson));

	//Maybe a new model?!
	if (!File.Exists(currentModelPath))
		return true;

	using (var hashCalc = SHA256.Create())
	{
		newModelJson.Dump();
		var currentModelContent = File.ReadAllBytes(currentModelPath);
		var currentModelHash = hashCalc.ComputeHash(currentModelContent);

		var newModelContent = Encoding.UTF8.GetBytes(newModelJson);
		var newModelHash = hashCalc.ComputeHash(newModelContent);

		return newModelHash != currentModelHash;
	}
}
