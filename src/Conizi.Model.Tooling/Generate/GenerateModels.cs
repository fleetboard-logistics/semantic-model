using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using Conizi.Model.Accounting.Material;
using Conizi.Model.Documents;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Telematics;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Serilog;

namespace Conizi.Model.Tooling.Generate
{
    public  static class GenerateModels
    {
        static GenerateModels()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console()
                .CreateLogger();
        }

        public static bool Generate(string modelPath)
        {
            var models = new List<Type>
            {
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
                typeof(TransportDocument),
                typeof(StatusImage),
                typeof(MaterialTransaction),
                typeof(GroundTelematicsEvent)
            };


            foreach (var model in models)
            {
                try
                {
                    bool isNewModel = true;

                    //(Generated: {DateTime.Now} - {assembly.Name} v:{assembly.Version})
                    Core.Tools.Generator.RegisterJsonSchemaLicense(
                        Environment.GetEnvironmentVariable("GENERATOR_JSONSCHEMALICENSE"));
                    var pipeline = Environment.GetEnvironmentVariable("PIPELINE") ?? "0";
                    var branch = Environment.GetEnvironmentVariable("BRANCH") ?? "n/a";
                    var result = Core.Tools.Generator.Generate(model);

                    var outFile = Path.Combine(modelPath, result.Id.Replace("https://model.conizi.io/v1/", string.Empty));
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
                        var message = $"Generated: {DateTime.Now.ToString("o")} - {Assembly.GetExecutingAssembly().GetName().Name} v:{Assembly.GetExecutingAssembly().GetName().Version} p:{pipeline} - {branch}";
                        var newModel = JObject.Parse(result.ToString());

                        if (newModel.SelectToken("$comment") == null)
                            newModel.First.AddAfterSelf(new JProperty("$comment", message));
                        else
                            newModel.SelectToken("$comment").Replace(message);

                        File.WriteAllBytes(fileInfo.FullName, Encoding.UTF8.GetBytes(newModel.ToString()));
                        Log.Information("Model {model} was successfully generated to {file}", result.Model, fileInfo.FullName);
                        continue;
                    }

                    Log.Debug("Model {model} is equal to the new generated content, skip writting to file {file}", result.Model, fileInfo.FullName);
                }
                catch (Exception ex)
                {
                    Log.Error(ex, "Error while generating model {model}", model);
                    throw;
                }
            }

            return true;
        }

        private static bool ModelHashChanged(string newModelJson, string currentModelJson)
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
    }
}
