<Query Kind="Statements">
  <Reference Relative="..\Conizi.Model.Core\bin\Debug\netstandard2.0\Conizi.Model.Core.dll">C:\src\semanticmodel-master\src\Conizi.Model.Core\bin\Debug\netstandard2.0\Conizi.Model.Core.dll</Reference>
  <Reference Relative="..\Conizi.Model.Core\bin\Debug\netstandard2.0\Conizi.Model.dll">C:\src\semanticmodel-master\src\Conizi.Model.Core\bin\Debug\netstandard2.0\Conizi.Model.dll</Reference>
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <NuGetReference>Newtonsoft.Json.Schema</NuGetReference>
  <NuGetReference>Serilog.Sinks.LINQPad</NuGetReference>
  <NuGetReference>System.Security.Cryptography.Algorithms</NuGetReference>
  <Namespace>Conizi.Model.Accounting.Material</Namespace>
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
var assembly = typeof(Conizi.Model.Core.Tools.Generator).Assembly.GetName();
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
	 typeof(PickupOrderBulk),
	 typeof(ProofOfDelivery),
	 typeof(MaterialTransaction)
};

foreach (var model in models)
{
	try
	{
		bool isNewModel = true;
		
		//(Generated: {DateTime.Now} - {assembly.Name} v:{assembly.Version})
		var result = Generator.Generate(model);
		//result.Dump();

		var outFile = Path.Combine(modelSrcPath, result.Id.Replace("https://model.conizi.io/v1/", string.Empty));
		var fileInfo = new FileInfo(outFile);
		var currentModelJson = string.Empty;
		JObject curModel = null;

		if (File.Exists(outFile))
		{
			isNewModel = false;
			currentModelJson = File.ReadAllText(outFile, Encoding.UTF8);
			curModel = JObject.Parse(currentModelJson);
			curModel.Remove("$comment");
		}
		
		if (isNewModel || ModelHashChanged(result.ToString(), curModel.ToString()))
		{
			var message = $"Generated: {DateTime.Now.ToString("o")} - {assembly.Name} v:{assembly.Version}"
			var newModel = JObject.Parse(result.ToString());
			
			if(newModel.SelectToken("$comment") == null)
				newModel.First.AddAfterSelf(new JProperty("$comment", message));
			else 
				newModel.SelectToken("$comment").Replace(message);
				
			File.WriteAllBytes(fileInfo.FullName, Encoding.UTF8.GetBytes(newModel.ToString()));
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

bool ModelHashChanged(string newModelJson, string currentModelJson)
{
	if (string.IsNullOrEmpty(newModelJson))
		throw new ArgumentNullException(nameof(newModelJson));

	using (var hashCalc = SHA256.Create())
	{		
		var currentModelContent = Encoding.UTF8.GetBytes(currentModelJson);
		var currentModelHash = hashCalc.ComputeHash(currentModelContent);

		var newModelContent = Encoding.UTF8.GetBytes(newModelJson);
		var newModelHash = hashCalc.ComputeHash(newModelContent);

		return Encoding.UTF8.GetString(newModelHash) != Encoding.UTF8.GetString(currentModelHash);
	}
}